using System;
using System.Collections.Generic;
using System.Data;
using HHMES.Interfaces;
using HHMES.Bridge;


namespace HHMES.Business
{
    /*
     数据字典缓存数据
     */
    public class DataDictCache
    {

        private DataDictCache() { } /*私有构造器,不允许外部创建实例*/

        #region 缓存数据唯一实例

        private static DataDictCache _Cache = null;

        /// <summary>
        /// 缓存数据唯一实例
        /// </summary>
        public static DataDictCache Cache
        {
            get
            {
                if (_Cache == null)
                {
                    _Cache = new DataDictCache();
                    _Cache.DownloadBaseCacheData();//下载基本数据                    
                }
                return _Cache;
            }
        }
        #endregion

        #region 外部使用的静态方法

        /// <summary>
        /// 刷新缓存数据
        /// </summary>
        public static void RefreshCache()
        {
            Cache.DownloadBaseCacheData();
        }

        ///// <summary>
        ///// 刷新单个数据字典
        ///// </summary>
        ///// <param name="tableName">字典表名</param>
        //public static void RefreshCache(string tableName)
        //{
        //    DataTable cache = GetCacheTableData(tableName);

        //    if (cache != null) //有客户窗体引用缓存数据时才更新
        //    {
        //        IBridge_DataDict bridge = BridgeFactory.CreateDataDictBridge(tableName, "");
        //        DataTable data = bridge.GetDataDictByTableName(tableName);
        //        cache.Rows.Clear();
        //        foreach (DataRow row in data.Rows) cache.ImportRow(row);
        //        cache.AcceptChanges();
        //    }
        //}

        #endregion

        #region 2.数据表缓存数据. 局域变易及属性定义

        public static DataSet _AllDataDicts = null;
        public static DataTable _DataDictType = null;
        

        #endregion

        // 获取所有字典数据
        public void DownloadBaseCacheData()
        {
            IBridge_DataDict bridge = BridgeFactory.CreateDataDictBridge("");

            //下载小字典表数据
            _AllDataDicts = bridge.DownloadDicts();
            _DataDictType = _AllDataDicts.Tables[1];
            string[] TableNames = new string[] { "CONFIG_DETAIL","CONFIG_HEADER","WAREHOUSE","COMPANY"};
            for (int i = 0; i < _AllDataDicts.Tables.Count; i++)
            {
                _AllDataDicts.Tables[i].TableName = TableNames[i];
            }
           
        }

        /// <summary>
        /// 跟据表名取数据表实例
        /// </summary>
        /// <param name="tableName">字典表名</param>
        /// <returns></returns>
        public static DataTable GetCacheTableData(string tableName)
        {
            //if(_AllDataDicts.Tables.Contains(tableName))
                
            return _AllDataDicts.Tables[tableName];
        }
        /// <summary>
        /// 跟据CODE名取数据表实例
        /// </summary>
        /// <param name="HeaderCode">字典表名</param>
        /// <returns></returns>
        public static DataTable GetCacheConfigData(string headerCode)
        {
            DataTable dt = _AllDataDicts.Tables[1].Clone();
            foreach (DataRow dr in _AllDataDicts.Tables[0].Rows)
            {
                if (dr["HEADERCODE"].ToString() == headerCode)
                {
                    DataRow r = dt.NewRow();
                    r["ID"] = dr["ID"].ToString();
                    r["CODE"] = dr["CODE"].ToString();
                    r["NAME"] = dr["NAME"].ToString();
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count > 0)
                return dt;
            else return null;
        }


        /// <summary>
        ///删除字典数据某一行数据
        /// </summary>
        /// <param name="tableName">字典表名</param>
        /// <param name="keyField">主键</param>
        /// <param name="key">主键值</param>
        public static void DeleteCacheRow(string tableName, string keyField, string key)
        {
            DataTable cach = GetCacheTableData(tableName);
            if (cach != null)
            {
                DataRow[] rows = cach.Select(keyField + "='" + key + "'");
                if (rows.Length > 0)
                    cach.Rows.Remove(rows[0]);
                cach.AcceptChanges();
            }
        }
    }
}

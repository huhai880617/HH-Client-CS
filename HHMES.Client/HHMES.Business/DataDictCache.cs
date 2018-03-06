using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
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
            DataDictCache.Cache.DownloadBaseCacheData();
        }

        /// <summary>
        /// 刷新单个数据字典
        /// </summary>
        /// <param name="tableName">字典表名</param>
        public static void RefreshCache(string tableName)
        {
            DataTable cache = DataDictCache.Cache.GetCacheTableData(tableName);

            if (cache != null) //有客户窗体引用缓存数据时才更新
            {
                IBridge_DataDict bridge = BridgeFactory.CreateDataDictBridge(tableName, "");
                DataTable data = bridge.GetDataDictByTableName(tableName);
                cache.Rows.Clear();
                foreach (DataRow row in data.Rows) cache.ImportRow(row);
                cache.AcceptChanges();
            }
        }

        #endregion

        #region 2.数据表缓存数据. 局域变易及属性定义

        private DataSet _AllDataDicts = null;

        private DataTable _BusinessTables = null;
        public DataTable BusinessTables { get { return _BusinessTables; } }

        private DataTable _StockType = null;
        public DataTable StockType { get { return _StockType; } }

        private DataTable _StockStatus = null;
        public DataTable StockStatus { get { return _StockStatus; } }

        private DataTable _Currency = null;
        public DataTable Currency { get { return _Currency; } }

        private DataTable _PayType = null;
        public DataTable PayType { get { return _PayType; } }

        private DataTable _User = null; //用户表
        public DataTable User { get { return _User; } }

        private DataTable _Person = null; //营销员
        public DataTable Person { get { return _Person; } }

        private DataTable _Storage = null; //仓库
        public DataTable Storage { get { return _Storage; } }

        private DataTable _Unit = null;
        public DataTable Unit { get { return _Unit; } }

        private DataTable _DepartmentData = null;
        public DataTable DepartmentData { get { return _DepartmentData; } }

        private DataTable _CustomerAttributes = null;
        public DataTable CustomerAttributes { get { return _CustomerAttributes; } }

        private DataTable _Bank = null;
        public DataTable Bank { get { return _Bank; } }

        private DataTable _CommonDataDictType = null;
        public DataTable CommonDataDictType { get { return _CommonDataDictType; } }

        private DataTable _Location = null;
        public DataTable Location { get { return _Location; } }

        private DataTable _DocType_IN = null;
        public DataTable DocType_IN { get { return _DocType_IN; } }

        private DataTable _DocType_Out = null;
        public DataTable DocType_Out { get { return _DocType_Out; } }

        private DataTable _DocStatus_IN = null;
        public DataTable DocStatus_IN { get { return _DocStatus_IN; } }

        private DataTable _DocStatus_OUT = null;
        public DataTable DocStatus_OUT { get { return _DocStatus_OUT; } }

        private DataTable _TaskStatus = null;
        public DataTable TaskStatus { get { return _TaskStatus; } }

        private DataTable _TaskType = null;
        public DataTable TaskType { get { return _TaskType; } }

        private DataTable _DocCheck = null;
        public DataTable DocCheck { get { return _DocCheck; } }

        private DataTable _DocAccount = null;
        public DataTable DocAccount { get { return _DocAccount; } }

        private DataTable _DocAdjust = null;
        public DataTable DocAdjust { get { return _DocAdjust; } }

        private DataTable _DocMove = null;
        public DataTable DocMove { get { return _DocMove; } }

        private DataTable _MaterialType = null;
        public DataTable MaterialType { get { return _MaterialType; } }


        private DataTable _MaterialUnit = null;
        public DataTable MaterialUnit { get { return _MaterialUnit; } }

        private DataTable _MaterialAttribute = null;
        public DataTable MaterialAttribute { get { return _MaterialAttribute; } }

        private DataTable _PalletSpec = null;
        public DataTable PalletSpec{ get { return _PalletSpec; } }

        private DataTable _PalletStatus = null;
        public DataTable PalletStatus { get { return _PalletStatus; } }

        private DataTable _WareCellSpec = null;
        public DataTable WareCellSpec { get { return _WareCellSpec; } }

        private DataTable _WareCellStatus = null;
        public DataTable WareCellStatus { get { return _WareCellStatus; } }
        #endregion


        public void DownloadBaseCacheData()
        {
            IBridge_DataDict bridge = BridgeFactory.CreateDataDictBridge("");

            //下载小字典表数据
            _AllDataDicts = bridge.DownloadDicts();

            //跟据存储过程返回数据表的顺序取
            _BusinessTables = _AllDataDicts.Tables[1];
            _User = _AllDataDicts.Tables[2];
            _Person = _AllDataDicts.Tables[3];
            _CustomerAttributes = _AllDataDicts.Tables[4];
            _Bank = _AllDataDicts.Tables[5];
            _CommonDataDictType = _AllDataDicts.Tables[6];
            _PayType = _AllDataDicts.Tables[7];
            _Currency = _AllDataDicts.Tables[8];
            _Location = _AllDataDicts.Tables[9];
            _DepartmentData = _AllDataDicts.Tables[10];
            _DocType_IN = _AllDataDicts.Tables[11];
            _DocStatus_IN = _AllDataDicts.Tables[12];
            _TaskStatus = _AllDataDicts.Tables[13];
            _TaskType = _AllDataDicts.Tables[14];
            _DocType_Out = _AllDataDicts.Tables[15];
            _DocStatus_OUT = _AllDataDicts.Tables[16];
            _DocCheck = _AllDataDicts.Tables[17];
            _DocAccount = _AllDataDicts.Tables[18];
            _DocAdjust = _AllDataDicts.Tables[19];
            _DocMove = _AllDataDicts.Tables[20];
            _MaterialType = _AllDataDicts.Tables[21];
            _MaterialAttribute = _AllDataDicts.Tables[22];
            _MaterialUnit = _AllDataDicts.Tables[23];
            _PalletSpec = _AllDataDicts.Tables[24];
            _WareCellSpec = _AllDataDicts.Tables[25];
            _StockType = _AllDataDicts.Tables[26];
            _WareCellStatus = _AllDataDicts.Tables[27];
            _PalletStatus = _AllDataDicts.Tables[28];
            _StockStatus = _AllDataDicts.Tables[29];

            //调用数据表名
            _AllDataDicts.Tables[1].TableName = sys_BusinessTables.__TableName;
            _AllDataDicts.Tables[2].TableName = TUser.__TableName;
            _AllDataDicts.Tables[3].TableName = tb_Person.__TableName;
            _AllDataDicts.Tables[4].TableName = tb_CustomerAttribute.__TableName;
            _AllDataDicts.Tables[5].TableName = "#Bank"; //tb_CommDataDictType表的银行类别的记录
            _AllDataDicts.Tables[6].TableName = tb_CommDataDictType.__TableName;
            _AllDataDicts.Tables[7].TableName = tb_PayType.__TableName;
            _AllDataDicts.Tables[8].TableName = tb_Currency.__TableName;
            _AllDataDicts.Tables[9].TableName = tb_Location.__TableName;
            _AllDataDicts.Tables[10].TableName = "#Dept"; //tb_CommDataDictType表的部门类别的记录
            _AllDataDicts.Tables[11].TableName = "DocType_IN";
            _AllDataDicts.Tables[12].TableName = "DocStatus_IN";
            _AllDataDicts.Tables[13].TableName = "TaskStatus";
            _AllDataDicts.Tables[14].TableName = "TaskType";
            _AllDataDicts.Tables[15].TableName = "DocType_OUT";
            _AllDataDicts.Tables[16].TableName = "DocStatus_OUT";
            _AllDataDicts.Tables[17].TableName = "DocCheck";
            _AllDataDicts.Tables[18].TableName = "DocAccount";
            _AllDataDicts.Tables[19].TableName = "DocAdjust";
            _AllDataDicts.Tables[20].TableName = "DocMove";
            _AllDataDicts.Tables[21].TableName = "MaterialType";
            _AllDataDicts.Tables[22].TableName = "MaterialAttribute";
            _AllDataDicts.Tables[23].TableName = "MaterialUnit";
            _AllDataDicts.Tables[24].TableName = "PalletSpec";
            _AllDataDicts.Tables[25].TableName = "WareCellSpec";
            _AllDataDicts.Tables[26].TableName = "StockType";
            _AllDataDicts.Tables[27].TableName = "WareCellStatus";
            _AllDataDicts.Tables[27].TableName = "PalletStatus";
            _AllDataDicts.Tables[28].TableName = "StockStatus";
        }

        /// <summary>
        /// 跟据表名取数据表实例
        /// </summary>
        /// <param name="tableName">字典表名</param>
        /// <returns></returns>
        private DataTable GetCacheTableData(string tableName)
        {
            foreach (DataTable dt in _AllDataDicts.Tables)
            {
                if (dt.TableName.ToUpper() == tableName.ToUpper()) return dt;
            }

            DataTable cache = null;
            //if (tableName == tb_CommDataDictType.__TableName) cache = _CommonDataDictType;            
            return cache;
        }

        /// <summary>
        ///删除字典数据某一行数据
        /// </summary>
        /// <param name="tableName">字典表名</param>
        /// <param name="keyField">主键</param>
        /// <param name="key">主键值</param>
        public void DeleteCacheRow(string tableName, string keyField, string key)
        {
            DataTable cach = this.GetCacheTableData(tableName);
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

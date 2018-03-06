using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
using HHMES.ORM;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Interfaces;
using HHMES.Server.DataAccess.DAL_Base;

/*==========================================
 *   程序说明: WMS_Customer的数据访问层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-05 09:18:39
 *   最后修改: 2016-10-05 09:18:39
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Server.DataAccess
{
    /// <summary>
    /// dalWMS_Customer
    /// </summary>
    public class dalWMS_Customer : dalBaseDataDict
    {
         /// <summary>
         /// 构造器
         /// </summary>
         /// <param name="loginer">当前登录用户</param>
         public dalWMS_Customer(Loginer loginer): base(loginer)
         {
             _KeyName = tb_WMS_Customer.__KeyName; //主键字段
             _TableName = tb_WMS_Customer.__TableName;//表名
             _ModelType = typeof(tb_WMS_Customer);
         }

         /// <summary>
         /// 根据表名获取该表的SQL命令生成器
         /// </summary>
         /// <param name="tableName">表名</param>
         /// <returns></returns>
         protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
         {
           Type ORM = null;
           if (tableName == tb_WMS_Customer.__TableName) ORM = typeof(tb_WMS_Customer);
           if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");
           return new GenerateSqlCmdByTableFields(ORM);
         }

     }
}

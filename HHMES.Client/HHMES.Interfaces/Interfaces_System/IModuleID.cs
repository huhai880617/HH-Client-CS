using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 模块编号. 用来排序
    /// </summary>
    public enum ModuleID
    {
        None = 0,
        DataDictionary = 1,//数据字典
        InterfaceModule = 2,//接口模块
        DocumentModule = 3,//单据模块
        InventoryModule = 4,//库存模块
        TaskModule = 5,//任务模块
        MonitorModule = 6,//监控模块
        SystemManage = 7,//系统模块
        ConfigModule = 8, //配置模块
        ReportModule=9  //报表模块
        // None = 0,
        //DataDictionary = 1,//数据字典
        //PurchaseModule = 2,//采购模块
        //SalesModule = 3,//销售模块
        //InventoryModule = 4,//仓库模块
        //ProductionModule = 5,
        //AccountModule = 6,
        //SystemManage = 7,
        //ProductionManage = 8, //用于排序
        //WarehouseManage=9
    }

    /// <summary>
    /// 模块名称.
    /// </summary>
    public class ModuleNames
    {
        public const string DataDictionary = "数据字典";//
        public const string InterfaceModule = "接口管理";
        public const string DocumentModule = "单据管理";
        public const string InventoryModule = "库存管理";
        public const string ConfigModule = "配置管理";
        public const string TaskModule = "任务管理";
        public const string SystemManage = "系统管理";
        public const string MonitorModule = "监控管理";
        public const string ReportModule = "报表管理";
    }
}

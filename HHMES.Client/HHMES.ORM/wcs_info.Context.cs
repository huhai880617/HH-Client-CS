﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.ORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class wcs_infoEntities : DbContext
    {
        public wcs_infoEntities()
            : base("name=wcs_infoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ADJUSTBILL_DETAIL> ADJUSTBILL_DETAIL { get; set; }
        public virtual DbSet<ADJUSTBILL_HEADER> ADJUSTBILL_HEADER { get; set; }
        public virtual DbSet<B_Module> B_Module { get; set; }
        public virtual DbSet<B_ModulePermission> B_ModulePermission { get; set; }
        public virtual DbSet<B_OperateLog> B_OperateLog { get; set; }
        public virtual DbSet<B_Permission> B_Permission { get; set; }
        public virtual DbSet<B_Role> B_Role { get; set; }
        public virtual DbSet<B_RoleModulePermission> B_RoleModulePermission { get; set; }
        public virtual DbSet<B_User> B_User { get; set; }
        public virtual DbSet<B_UserRole> B_UserRole { get; set; }
        public virtual DbSet<BILL_DETAIL> BILL_DETAIL { get; set; }
        public virtual DbSet<BILL_HEADER> BILL_HEADER { get; set; }
        public virtual DbSet<C_AuthorityItem> C_AuthorityItem { get; set; }
        public virtual DbSet<C_BusinessTables> C_BusinessTables { get; set; }
        public virtual DbSet<C_CompanyInfo> C_CompanyInfo { get; set; }
        public virtual DbSet<C_FieldNameDefs> C_FieldNameDefs { get; set; }
        public virtual DbSet<C_FormTagName> C_FormTagName { get; set; }
        public virtual DbSet<C_Log> C_Log { get; set; }
        public virtual DbSet<C_LogDtl> C_LogDtl { get; set; }
        public virtual DbSet<C_LogFields> C_LogFields { get; set; }
        public virtual DbSet<C_LoginLog> C_LoginLog { get; set; }
        public virtual DbSet<C_Menu> C_Menu { get; set; }
        public virtual DbSet<C_Modules> C_Modules { get; set; }
        public virtual DbSet<C_Product> C_Product { get; set; }
        public virtual DbSet<C_ProductBOM> C_ProductBOM { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<C_UserGroup> C_UserGroup { get; set; }
        public virtual DbSet<C_UserGroupRe> C_UserGroupRe { get; set; }
        public virtual DbSet<C_UserRole> C_UserRole { get; set; }
        public virtual DbSet<CHECKBILL_DETAIL> CHECKBILL_DETAIL { get; set; }
        public virtual DbSet<CHECKBILL_HEADER> CHECKBILL_HEADER { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<CONFIG_DETAIL> CONFIG_DETAIL { get; set; }
        public virtual DbSet<CONFIG_HEADER> CONFIG_HEADER { get; set; }
        public virtual DbSet<EQUIPMENT> EQUIPMENT { get; set; }
        public virtual DbSet<EQUIPMENT_ADDRESS> EQUIPMENT_ADDRESS { get; set; }
        public virtual DbSet<EQUIPMENT_ALARMRECORD> EQUIPMENT_ALARMRECORD { get; set; }
        public virtual DbSet<EQUIPMENT_ALARMTEXT> EQUIPMENT_ALARMTEXT { get; set; }
        public virtual DbSet<INF_BILLIN> INF_BILLIN { get; set; }
        public virtual DbSet<INF_BILLSTOCKTAKING> INF_BILLSTOCKTAKING { get; set; }
        public virtual DbSet<INF_ITEM> INF_ITEM { get; set; }
        public virtual DbSet<INVENTORY> INVENTORY { get; set; }
        public virtual DbSet<INVENTORY_HISTORY> INVENTORY_HISTORY { get; set; }
        public virtual DbSet<ITEM> ITEM { get; set; }
        public virtual DbSet<ITEM_PALLET_CAPACITY> ITEM_PALLET_CAPACITY { get; set; }
        public virtual DbSet<ITEM_ZONE_CAPACITY> ITEM_ZONE_CAPACITY { get; set; }
        public virtual DbSet<LOG_EXCEPTION> LOG_EXCEPTION { get; set; }
        public virtual DbSet<LOG_OPERATOR> LOG_OPERATOR { get; set; }
        public virtual DbSet<PALLET> PALLET { get; set; }
        public virtual DbSet<PALLETSPEC> PALLETSPEC { get; set; }
        public virtual DbSet<PORT> PORT { get; set; }
        public virtual DbSet<POSITION> POSITION { get; set; }
        public virtual DbSet<ROADWAY> ROADWAY { get; set; }
        public virtual DbSet<ROUTE_HEADER> ROUTE_HEADER { get; set; }
        public virtual DbSet<SERIAL_NUMBER> SERIAL_NUMBER { get; set; }
        public virtual DbSet<STACKER> STACKER { get; set; }
        public virtual DbSet<STOCKTAKINGBILL_DETAIL> STOCKTAKINGBILL_DETAIL { get; set; }
        public virtual DbSet<STOCKTAKINGBILL_HEADER> STOCKTAKINGBILL_HEADER { get; set; }
        public virtual DbSet<STRATEGY_DETAIL> STRATEGY_DETAIL { get; set; }
        public virtual DbSet<STRATEGY_HEADER> STRATEGY_HEADER { get; set; }
        public virtual DbSet<STRATEGY_RELATION> STRATEGY_RELATION { get; set; }
        public virtual DbSet<SUPPLIERCUSTOMER> SUPPLIERCUSTOMER { get; set; }
        public virtual DbSet<TASK_DETAIL> TASK_DETAIL { get; set; }
        public virtual DbSet<TASK_HEADER> TASK_HEADER { get; set; }
        public virtual DbSet<WARECELL> WARECELL { get; set; }
        public virtual DbSet<WARECELLSPEC> WARECELLSPEC { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSE { get; set; }
        public virtual DbSet<WAVE> WAVE { get; set; }
        public virtual DbSet<WAVE_DETAIL> WAVE_DETAIL { get; set; }
        public virtual DbSet<WAVE_HEADER> WAVE_HEADER { get; set; }
        public virtual DbSet<ZONE> ZONE { get; set; }
        public virtual DbSet<INF_BILLMOVE> INF_BILLMOVE { get; set; }
        public virtual DbSet<INF_BILLOUT> INF_BILLOUT { get; set; }
        public virtual DbSet<INF_BILLREPLENISHIMENT> INF_BILLREPLENISHIMENT { get; set; }
        public virtual DbSet<ITEM_CLASS> ITEM_CLASS { get; set; }
    }
}

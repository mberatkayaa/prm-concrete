﻿using Promax.Entities;
using System;
using System.Collections.Generic;

namespace Promax.DataAccess
{
    public static class Infrastructure
    {
        private static Dictionary<Type, DatabaseTableInfo> DatabaseTableInfos = new Dictionary<Type, DatabaseTableInfo>();
        static Infrastructure()
        {
            InitDatabaseTableInfos();
        }
        private static void InitDatabaseTableInfos()
        {
            DatabaseTableInfos.Add(typeof(ProductWayBillViewDTO), new DatabaseTableInfo("VIEW_RTM_WAYBILL",
                nameof(ProductWayBillViewDTO.ProductId).ToColumnInfo("PRODUCT_ID"),
                nameof(ProductWayBillViewDTO.ProductDate).ToColumnInfo("TARIH"),
                nameof(ProductWayBillViewDTO.ProductTime).ToColumnInfo("SAAT"),
                nameof(ProductWayBillViewDTO.DepTime).ToColumnInfo("CIKIS_SAATI"),
                nameof(ProductWayBillViewDTO.RtmNumber).ToColumnInfo("URETIM_NO"),
                nameof(ProductWayBillViewDTO.BillNumber).ToColumnInfo("BELGE_NO"),
                nameof(ProductWayBillViewDTO.Shipped).ToColumnInfo("SEVK_MIKTAR"),
                nameof(ProductWayBillViewDTO.Delivered).ToColumnInfo("TESLIM_MIKTAR"),
                nameof(ProductWayBillViewDTO.TotalMaterial).ToColumnInfo("TOPLAM_MALZEME"),
                nameof(ProductWayBillViewDTO.ClientName).ToColumnInfo("MUSTERI_ADI"),
                nameof(ProductWayBillViewDTO.ClientAddress).ToColumnInfo("MUSTERI_ADRES"),
                nameof(ProductWayBillViewDTO.ClientPhone).ToColumnInfo("MUSTERI_TELEFON"),
                nameof(ProductWayBillViewDTO.ClientTaxLocation).ToColumnInfo("VERGI_DAIRESI"),
                nameof(ProductWayBillViewDTO.ClientTaxNumber).ToColumnInfo("VERGI_NUMARASI"),
                nameof(ProductWayBillViewDTO.SiteName).ToColumnInfo("SANTIYE_ADI"),
                nameof(ProductWayBillViewDTO.SiteAddress).ToColumnInfo("SANTIYE_ADRESI"),
                nameof(ProductWayBillViewDTO.SitePhone).ToColumnInfo("SANTIYE_TELEFON"),
                nameof(ProductWayBillViewDTO.SiteContact).ToColumnInfo("SANTIYE_YETKILI"),
                nameof(ProductWayBillViewDTO.RecipeName).ToColumnInfo("RECETE_ADI"),
                nameof(ProductWayBillViewDTO.Consistency).ToColumnInfo("KIVAM"),
                nameof(ProductWayBillViewDTO.Endurance).ToColumnInfo("DAYANIM"),
                nameof(ProductWayBillViewDTO.Dmax).ToColumnInfo("DMAX"),
                nameof(ProductWayBillViewDTO.CementType).ToColumnInfo("CIMENTO_TIPI"),
                nameof(ProductWayBillViewDTO.MineralType).ToColumnInfo("MINERAL_TIPI"),
                nameof(ProductWayBillViewDTO.AdditiveType).ToColumnInfo("KATKI_TIPI"),
                nameof(ProductWayBillViewDTO.Slump).ToColumnInfo("SLUMP"),
                nameof(ProductWayBillViewDTO.UnitVolume).ToColumnInfo("BIRIM_HACIM"),
                nameof(ProductWayBillViewDTO.Environmental).ToColumnInfo("CEVRESEL_ETKI"),
                nameof(ProductWayBillViewDTO.ChlorideContent).ToColumnInfo("KLORUR_ICERIGI"),
                nameof(ProductWayBillViewDTO.CemRate).ToColumnInfo("SU_CIMENTO_ORANI"),
                nameof(ProductWayBillViewDTO.MixerServiceId).ToColumnInfo("MIKSER_NO"),
                nameof(ProductWayBillViewDTO.MixerLicencePlate).ToColumnInfo("MIKSER_PLAKA"),
                nameof(ProductWayBillViewDTO.MixerDriver).ToColumnInfo("MIKSER_SURUCU"),
                nameof(ProductWayBillViewDTO.PumpServiceId).ToColumnInfo("POMPA_NO"),
                nameof(ProductWayBillViewDTO.PumpLicencePlate).ToColumnInfo("POMPA_PLAKA"),
                nameof(ProductWayBillViewDTO.PumpDriver).ToColumnInfo("POMPA_SURUCU"),
                nameof(ProductWayBillViewDTO.ServiceCategoryName).ToColumnInfo("SERVIS_ADI"),
                nameof(ProductWayBillViewDTO.UserName).ToColumnInfo("OPERATOR_ADI"),
                nameof(ProductWayBillViewDTO.AdditiveName).ToColumnInfo("KATKI_ADI")));
            DatabaseTableInfos.Add(typeof(ClientDTO), new DatabaseTableInfo("CRM_CLIENTS",
                nameof(ClientDTO.ClientId).ToColumnInfo("CLIENT_ID"),
                nameof(ClientDTO.ClientCode).ToColumnInfo("CLIENT_CODE"),
                nameof(ClientDTO.ClientName).ToColumnInfo("CLIENT_NAME"),
                nameof(ClientDTO.Address).ToColumnInfo("ADDRESS"),
                nameof(ClientDTO.State).ToColumnInfo("STATE"),
                nameof(ClientDTO.City).ToColumnInfo("CITY"),
                nameof(ClientDTO.AddressLine).ToColumnInfo("ADDRESS_LINE"),
                nameof(ClientDTO.Contact).ToColumnInfo("CONTACT"),
                nameof(ClientDTO.Phone).ToColumnInfo("PHONE"),
                nameof(ClientDTO.TaxLocation).ToColumnInfo("TAX_LOCATION"),
                nameof(ClientDTO.TaxNumber).ToColumnInfo("TAX_NUMBER"),
                nameof(ClientDTO.Gravity).ToColumnInfo("GRAVITY"),
                nameof(ClientDTO.IsHidden).ToColumnInfo("IS_HIDDEN"),
                nameof(ClientDTO.ClientType).ToColumnInfo("CLIENT_TYPE"),
                nameof(ClientDTO.FirstName).ToColumnInfo("FIRST_NAME"),
                nameof(ClientDTO.LastName).ToColumnInfo("LAST_NAME"),
                nameof(ClientDTO.ClientTitle).ToColumnInfo("CLIENT_TITLE"),
            nameof(ClientDTO.Email).ToColumnInfo("EMAIL"),
            nameof(ClientDTO.EnableNotification).ToColumnInfo("ENABLE_NOTIFICATION"),
            nameof(ClientDTO.MailAttachInfo).ToColumnInfo("MAIL_ATTACH_INFO")));
            DatabaseTableInfos.Add(typeof(RecipeContentDTO), new DatabaseTableInfo("REC_CONTENTS",
                nameof(RecipeContentDTO.ContentId).ToColumnInfo("CONTENT_ID"),
                nameof(RecipeContentDTO.RecipeId).ToColumnInfo("RECIPE_ID"),
                nameof(RecipeContentDTO.StockId).ToColumnInfo("STOCK_ID"),
                nameof(RecipeContentDTO.Quantity).ToColumnInfo("QUANTITY")));
            DatabaseTableInfos.Add(typeof(DriverDTO), new DatabaseTableInfo("DEF_DRIVERS",
                nameof(DriverDTO.DriverId).ToColumnInfo("DRIVER_ID"),
                nameof(DriverDTO.DriverCode).ToColumnInfo("DRIVER_CODE"),
                nameof(DriverDTO.DriverName).ToColumnInfo("DRIVER_NAME"),
                nameof(DriverDTO.Identity).ToColumnInfo("IDENTITY"),
                nameof(DriverDTO.BloodGroup).ToColumnInfo("BLOOD_GROUP"),
                nameof(DriverDTO.Address).ToColumnInfo("ADDRESS"),
                nameof(DriverDTO.State).ToColumnInfo("STATE"),
                nameof(DriverDTO.City).ToColumnInfo("CITY"),
                nameof(DriverDTO.Phone).ToColumnInfo("PHONE"),
                nameof(DriverDTO.Gravity).ToColumnInfo("GRAVITY"),
                nameof(DriverDTO.IsHidden).ToColumnInfo("IS_HIDDEN")));
            DatabaseTableInfos.Add(typeof(BatchedStockDTO), new DatabaseTableInfo("INV_BATCHED",
               nameof(BatchedStockDTO.BatchedId).ToColumnInfo("BATCHED_ID"),
               nameof(BatchedStockDTO.ProductId).ToColumnInfo("PRODUCT_ID"),
               nameof(BatchedStockDTO.BatchNo).ToColumnInfo("BATCH_NO"),
               nameof(BatchedStockDTO.StockId).ToColumnInfo("STOCK_ID"),
               nameof(BatchedStockDTO.SiloId).ToColumnInfo("SILO_ID"),
               nameof(BatchedStockDTO.UserId).ToColumnInfo("USER_ID"),
               nameof(BatchedStockDTO.BatchedDate).ToColumnInfo("BATCHED_DATE"),
               nameof(BatchedStockDTO.BatchedTime).ToColumnInfo("BATCHED_TIME"),
               nameof(BatchedStockDTO.AddVal).ToColumnInfo("ADD_VAL"),
               nameof(BatchedStockDTO.Design).ToColumnInfo("DESIGN"),
               nameof(BatchedStockDTO.Batched).ToColumnInfo("BATCHED")));
            DatabaseTableInfos.Add(typeof(ConsumedStockDTO), new DatabaseTableInfo("INV_CONSUMED",
               nameof(ConsumedStockDTO.ConsumedId).ToColumnInfo("CONSUMED_ID"),
               nameof(ConsumedStockDTO.StockId).ToColumnInfo("STOCK_ID"),
               nameof(ConsumedStockDTO.SiloId).ToColumnInfo("SILO_ID"),
               nameof(ConsumedStockDTO.UserId).ToColumnInfo("USER_ID"),
               nameof(ConsumedStockDTO.ConsumedDate).ToColumnInfo("CONSUMED_DATE"),
               nameof(ConsumedStockDTO.ConsumedTime).ToColumnInfo("CONSUMED_TIME"),
               nameof(ConsumedStockDTO.Consumed).ToColumnInfo("CONSUMED")));
            DatabaseTableInfos.Add(typeof(StockEntryDTO), new DatabaseTableInfo("INV_ENTRIES",
               nameof(StockEntryDTO.EntryId).ToColumnInfo("ENTRY_ID"),
               nameof(StockEntryDTO.StockId).ToColumnInfo("STOCK_ID"),
               nameof(StockEntryDTO.SiloId).ToColumnInfo("SILO_ID"),
               nameof(StockEntryDTO.UserId).ToColumnInfo("USER_ID"),
               nameof(StockEntryDTO.EntryDate).ToColumnInfo("ENTRY_DATE"),
               nameof(StockEntryDTO.EntryTime).ToColumnInfo("ENTRY_TIME"),
               nameof(StockEntryDTO.DocumentNo).ToColumnInfo("DOCUMENT_NO"),
               nameof(StockEntryDTO.Description).ToColumnInfo("DESCRIPTION"),
               nameof(StockEntryDTO.Entry).ToColumnInfo("ENTRY"),
               nameof(StockEntryDTO.Minus).ToColumnInfo("MINUS")));
            DatabaseTableInfos.Add(typeof(OrderDTO), new DatabaseTableInfo("RTM_ORDERS",
               nameof(OrderDTO.OrderId).ToColumnInfo("ORDER_ID"),
               nameof(OrderDTO.OrderDate).ToColumnInfo("ORDER_DATE"),
               nameof(OrderDTO.OrderTime).ToColumnInfo("ORDER_TIME"),
               nameof(OrderDTO.OrderStatus).ToColumnInfo("ORDER_STATUS"),
               nameof(OrderDTO.ServiceCatNum).ToColumnInfo("SERVICE_CAT_NUM"),
               nameof(OrderDTO.ClientId).ToColumnInfo("CLIENT_ID"),
               nameof(OrderDTO.SiteId).ToColumnInfo("SITE_ID"),
               nameof(OrderDTO.RecipeId).ToColumnInfo("RECIPE_ID"),
               nameof(OrderDTO.AddWater).ToColumnInfo("ADD_WATER"),
               nameof(OrderDTO.PumpServiceId).ToColumnInfo("PUMP_SERVICE_ID"),
               nameof(OrderDTO.Quantity).ToColumnInfo("QUANTITY"),
               nameof(OrderDTO.Produced).ToColumnInfo("PRODUCED"),
               nameof(OrderDTO.Remaining).ToColumnInfo("REMAINING"),
               nameof(OrderDTO.OrderNumber).ToColumnInfo("ORDER_NUMBER")));
            DatabaseTableInfos.Add(typeof(SiloDTO), new DatabaseTableInfo("PRM_SILOS",
                nameof(SiloDTO.SiloId).ToColumnInfo("SILO_ID"),
                nameof(SiloDTO.WegId).ToColumnInfo("WEG_ID"),
                nameof(SiloDTO.SiloName).ToColumnInfo("SILO_NAME"),
                nameof(SiloDTO.SiloNo).ToColumnInfo("SILO_NO"),
                nameof(SiloDTO.IsStock).ToColumnInfo("IS_STOCK"),
                nameof(SiloDTO.IsActive).ToColumnInfo("IS_ACTIVE"),
                nameof(SiloDTO.StockId).ToColumnInfo("STOCK_ID"),
                nameof(SiloDTO.Capacity).ToColumnInfo("CAPACITY"),
                nameof(SiloDTO.Scale).ToColumnInfo("SCALE"),
                nameof(SiloDTO.FastVal).ToColumnInfo("FAST_VAL"),
                nameof(SiloDTO.VibOn).ToColumnInfo("VIB_ON"),
                nameof(SiloDTO.VibOff).ToColumnInfo("VIB_OFF"),
                nameof(SiloDTO.VibFl).ToColumnInfo("VIB_FL"),
                nameof(SiloDTO.SwingOn).ToColumnInfo("SWING_ON"),
                nameof(SiloDTO.SwingOff).ToColumnInfo("SWING_OFF"),
                nameof(SiloDTO.SwingVal).ToColumnInfo("SWING_VAL"),
                nameof(SiloDTO.TolVal).ToColumnInfo("TOL_VAL"),
                nameof(SiloDTO.ShotVal).ToColumnInfo("SHOT_VAL"),
                nameof(SiloDTO.ManNem).ToColumnInfo("MAN_NEM"),
                nameof(SiloDTO.NemId).ToColumnInfo("NEM_ID"),
                nameof(SiloDTO.MinDebi).ToColumnInfo("MIN_DEBI"),
                nameof(SiloDTO.Enabled).ToColumnInfo("ENABLED"),
                nameof(SiloDTO.Temp).ToColumnInfo("TEMP"),
                nameof(SiloDTO.Balance).ToColumnInfo("BALANCE")));
            DatabaseTableInfos.Add(typeof(ProductDTO), new DatabaseTableInfo("RTM_PRODUCTS",
                nameof(ProductDTO.ProductId).ToColumnInfo("PRODUCT_ID"),
                nameof(ProductDTO.ProductDate).ToColumnInfo("PRODUCT_DATE"),
                nameof(ProductDTO.ProductTime).ToColumnInfo("PRODUCT_TIME"),
                nameof(ProductDTO.RtmNumber).ToColumnInfo("RTM_NUMBER"),
                nameof(ProductDTO.BillNumber).ToColumnInfo("BILL_NUMBER"),
                nameof(ProductDTO.OrderId).ToColumnInfo("ORDER_ID"),
                nameof(ProductDTO.ClientId).ToColumnInfo("CLIENT_ID"),
                nameof(ProductDTO.SiteId).ToColumnInfo("SITE_ID"),
                nameof(ProductDTO.RecipeId).ToColumnInfo("RECIPE_ID"),
                nameof(ProductDTO.ServiceCatNum).ToColumnInfo("SERVICE_CAT_NUM"),
                nameof(ProductDTO.MixerServiceId).ToColumnInfo("MIXER_SERVICE_ID"),
                nameof(ProductDTO.PumpServiceId).ToColumnInfo("PUMP_SERVICE_ID"),
                nameof(ProductDTO.SelfServiceId).ToColumnInfo("SELF_SERVICE_ID"),
                nameof(ProductDTO.MixerDriverId).ToColumnInfo("MIXER_DRIVER_ID"),
                nameof(ProductDTO.PumpDriverId).ToColumnInfo("PUMP_DRIVER_ID"),
                nameof(ProductDTO.SelfDriverId).ToColumnInfo("SELF_DRIVER_ID"),
                nameof(ProductDTO.UserId).ToColumnInfo("USER_ID"),
                nameof(ProductDTO.Target).ToColumnInfo("TARGET"),
                nameof(ProductDTO.Addon).ToColumnInfo("ADDON"),
                nameof(ProductDTO.RealTarget).ToColumnInfo("REAL_TARGET"),
                nameof(ProductDTO.Produced).ToColumnInfo("PRODUCED"),
                nameof(ProductDTO.Shipped).ToColumnInfo("SHIPPED"),
                nameof(ProductDTO.Returned).ToColumnInfo("RETURNED"),
                nameof(ProductDTO.Transfer).ToColumnInfo("TRANSFER"),
                nameof(ProductDTO.Recycled).ToColumnInfo("RECYCLED"),
                nameof(ProductDTO.Delivered).ToColumnInfo("DELIVERED"),
                nameof(ProductDTO.Capacity).ToColumnInfo("CAPACITY"),
                nameof(ProductDTO.Ubm).ToColumnInfo("UBM"),
                nameof(ProductDTO.AimBatch).ToColumnInfo("AIM_BATCH"),
                nameof(ProductDTO.AimFactor).ToColumnInfo("AIM_FACTOR"),
                nameof(ProductDTO.RtmBatch).ToColumnInfo("RTM_BATCH"),
                nameof(ProductDTO.RtmFactor).ToColumnInfo("RTM_FACTOR"),
                nameof(ProductDTO.GateNum).ToColumnInfo("GATE_NUM"),
                nameof(ProductDTO.AddWater).ToColumnInfo("ADD_WATER"),
                nameof(ProductDTO.IsBill).ToColumnInfo("IS_BILL"),
                nameof(ProductDTO.Desk).ToColumnInfo("DESK"),
                nameof(ProductDTO.Dep).ToColumnInfo("DEP"),
                nameof(ProductDTO.DepTime).ToColumnInfo("DEP_TIME"),
                nameof(ProductDTO.Pos).ToColumnInfo("POS"),
                nameof(ProductDTO.DespatchNumber).ToColumnInfo("DESPATCH_NUMBER"),
                nameof(ProductDTO.DespatchGuid).ToColumnInfo("DESPATCH_GUID"),
                nameof(ProductDTO.EbisNumber).ToColumnInfo("EBIS_NUMBER"),
                nameof(ProductDTO.DespatchTag).ToColumnInfo("DESPATCH_TAG"),
                nameof(ProductDTO.DespatchStatus).ToColumnInfo("DESPATCH_STATUS"),
                nameof(ProductDTO.OrderQuantity).ToColumnInfo("ORDER_QUANTITY"),
                nameof(ProductDTO.OrderNumber).ToColumnInfo("ORDER_NUMBER"),
                nameof(ProductDTO.OrderDate).ToColumnInfo("ORDER_DATE")));
            DatabaseTableInfos.Add(typeof(RecipeDTO), new DatabaseTableInfo("REC_RECIPES",
                nameof(RecipeDTO.RecipeId).ToColumnInfo("RECIPE_ID"),
                nameof(RecipeDTO.RecipeCode).ToColumnInfo("RECIPE_CODE"),
                nameof(RecipeDTO.RecipeCatNum).ToColumnInfo("RECIPE_CAT_NUM"),
                nameof(RecipeDTO.RecipeName).ToColumnInfo("RECIPE_NAME"),
                nameof(RecipeDTO.Cweg1OrderTime).ToColumnInfo("CWEG1_ORDER_TIME"),
                nameof(RecipeDTO.Cweg2OrderTime).ToColumnInfo("CWEG2_ORDER_TIME"),
                nameof(RecipeDTO.Sweg1OrderTime).ToColumnInfo("SWEG1_ORDER_TIME"),
                nameof(RecipeDTO.Sweg2OrderTime).ToColumnInfo("SWEG2_ORDER_TIME"),
                nameof(RecipeDTO.Kweg1OrderTime).ToColumnInfo("KWEG1_ORDER_TIME"),
                nameof(RecipeDTO.Kweg2OrderTime).ToColumnInfo("KWEG2_ORDER_TIME"),
                nameof(RecipeDTO.MixingTime).ToColumnInfo("MIXING_TIME"),
                nameof(RecipeDTO.FullopenTime).ToColumnInfo("FULLOPEN_TIME"),
                nameof(RecipeDTO.LastopenTime).ToColumnInfo("LASTOPEN_TIME"),
                nameof(RecipeDTO.UnitPrice).ToColumnInfo("UNIT_PRICE"),
                nameof(RecipeDTO.CementType).ToColumnInfo("CEMENT_TYPE"),
                nameof(RecipeDTO.MineralType).ToColumnInfo("MINERAL_TYPE"),
                nameof(RecipeDTO.AdditiveType).ToColumnInfo("ADDITIVE_TYPE"),
                nameof(RecipeDTO.Consistency).ToColumnInfo("CONSISTENCY"),
                nameof(RecipeDTO.Endurance).ToColumnInfo("ENDURANCE"),
                nameof(RecipeDTO.Dmax).ToColumnInfo("DMAX"),
                nameof(RecipeDTO.Slump).ToColumnInfo("SLUMP"),
                nameof(RecipeDTO.UnitVolume).ToColumnInfo("UNIT_VOLUME"),
                nameof(RecipeDTO.Environmental).ToColumnInfo("ENVIRONMENTAL"),
                nameof(RecipeDTO.ChlorideContent).ToColumnInfo("CHLORIDE_CONTENT"),
                nameof(RecipeDTO.Gravity).ToColumnInfo("GRAVITY"),
                nameof(RecipeDTO.IsHidden).ToColumnInfo("IS_HIDDEN"),
                nameof(RecipeDTO.EnduranceRate).ToColumnInfo("ENDURANCE_RATE"),
                nameof(RecipeDTO.Fibers).ToColumnInfo("FIBERS"),
                nameof(RecipeDTO.EnduranceDay).ToColumnInfo("ENDURANCE_DAY")));
            DatabaseTableInfos.Add(typeof(ServiceDTO), new DatabaseTableInfo("DEF_SERVICES",
                nameof(ServiceDTO.ServiceId).ToColumnInfo("SERVICE_ID"),
                nameof(ServiceDTO.ServiceCode).ToColumnInfo("SERVICE_CODE"),
                nameof(ServiceDTO.ServiceName).ToColumnInfo("SERVICE_NAME"),
                nameof(ServiceDTO.ServiceCatNum).ToColumnInfo("SERVICE_CAT_NUM"),
                nameof(ServiceDTO.LicencePlate).ToColumnInfo("LICENCE_PLATE"),
                nameof(ServiceDTO.DriverId).ToColumnInfo("DRIVER_ID"),
                nameof(ServiceDTO.Capacity).ToColumnInfo("CAPACITY"),
                nameof(ServiceDTO.Gravity).ToColumnInfo("GRAVITY"),
                nameof(ServiceDTO.IsHidden).ToColumnInfo("IS_HIDDEN")));
            DatabaseTableInfos.Add(typeof(SiteDTO), new DatabaseTableInfo("CRM_SITES",
                nameof(SiteDTO.SiteId).ToColumnInfo("SITE_ID"),
                nameof(SiteDTO.ClientId).ToColumnInfo("CLIENT_ID"),
                nameof(SiteDTO.SiteCode).ToColumnInfo("SITE_CODE"),
                nameof(SiteDTO.SiteName).ToColumnInfo("SITE_NAME"),
                nameof(SiteDTO.Address).ToColumnInfo("ADDRESS"),
                nameof(SiteDTO.State).ToColumnInfo("STATE"),
                nameof(SiteDTO.City).ToColumnInfo("CITY"),
                nameof(SiteDTO.AddressLine).ToColumnInfo("ADDRESS_LINE"),
                nameof(SiteDTO.Contact).ToColumnInfo("CONTACT"),
                nameof(SiteDTO.Phone).ToColumnInfo("PHONE"),
                nameof(SiteDTO.Distance).ToColumnInfo("DISTANCE"),
                nameof(SiteDTO.IsHidden).ToColumnInfo("IS_HIDDEN")));
            DatabaseTableInfos.Add(typeof(StockDTO), new DatabaseTableInfo("INV_STOCKS",
                nameof(StockDTO.StockId).ToColumnInfo("STOCK_ID"),
                nameof(StockDTO.StockCode).ToColumnInfo("STOCK_CODE"),
                nameof(StockDTO.StockName).ToColumnInfo("STOCK_NAME"),
                nameof(StockDTO.StockCatNum).ToColumnInfo("STOCK_CAT_NUM"),
                nameof(StockDTO.Temp).ToColumnInfo("TEMP"),
                nameof(StockDTO.Balance).ToColumnInfo("BALANCE")));
            DatabaseTableInfos.Add(typeof(ServiceCategoryDTO), new DatabaseTableInfo("SYS_CATS",
                nameof(ServiceCategoryDTO.CatId).ToColumnInfo("CAT_ID"),
                nameof(ServiceCategoryDTO.CatClass).ToColumnInfo("CAT_CLASS"),
                nameof(ServiceCategoryDTO.CatNum).ToColumnInfo("CAT_NUM"),
                nameof(ServiceCategoryDTO.CatName).ToColumnInfo("CAT_NAME")));
            DatabaseTableInfos.Add(typeof(UserDTO), new DatabaseTableInfo("SYS_USERS",
                 nameof(UserDTO.UserId).ToColumnInfo("USER_ID"),
                 nameof(UserDTO.UserCatNum).ToColumnInfo("USER_CAT_NUM"),
                 nameof(UserDTO.UserName).ToColumnInfo("USER_NAME"),
                 nameof(UserDTO.UserPassword).ToColumnInfo("USER_PASSWORD"),
                 nameof(UserDTO.FullName).ToColumnInfo("FULL_NAME"),
                 nameof(UserDTO.LastLogin).ToColumnInfo("LAST_LOGIN"),
                 nameof(UserDTO.AuOrders).ToColumnInfo("AU_ORDERS"),
                 nameof(UserDTO.AuProducts).ToColumnInfo("AU_PRODUCTS"),
                 nameof(UserDTO.AuClients).ToColumnInfo("AU_CLIENTS"),
                 nameof(UserDTO.AuRecipes).ToColumnInfo("AU_RECIPES"),
                 nameof(UserDTO.AuStocks).ToColumnInfo("AU_STOCKS"),
                 nameof(UserDTO.AuServices).ToColumnInfo("AU_SERVICES"),
                 nameof(UserDTO.AuManAgg).ToColumnInfo("AU_MAN_AGG"),
                 nameof(UserDTO.AuManCem).ToColumnInfo("AU_MAN_CEM"),
                 nameof(UserDTO.AuManAdv).ToColumnInfo("AU_MAN_ADV"),
                 nameof(UserDTO.IsHidden).ToColumnInfo("IS_HIDDEN")));
        }

        public static string FirebirdEmbedded { get => "FirebirdEmbedded"; }
        public static string SQLite { get => "SQLite"; }
        public static string Firebird { get => "Firebird"; }

        internal static DatabaseTableInfo GetTableInfo<T>()
        {
            return DatabaseTableInfos[typeof(T)];
        }

    }
}
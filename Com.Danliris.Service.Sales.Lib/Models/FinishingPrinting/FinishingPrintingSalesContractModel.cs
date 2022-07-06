using Com.Danliris.Service.Sales.Lib.Utilities.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Danliris.Service.Sales.Lib.Models.FinishingPrinting
{
    public class FinishingPrintingSalesContractModel : BaseModel
    {
        #region newSC
        public DateTimeOffset Date { get; set; }

        public long PreSalesContractId { get; set; }

        //[MaxLength(64)]
        //public string ProductionOrderNo { get; set; }
        [MaxLength(64)]
        public string PreSalesContractNo { get; set; }

        [MaxLength(512)]
        public string UnitName { get; set; }


        public long SalesId { get; set; }

        [MaxLength(1024)]
        public string SalesUserName { get; set; }

        [MaxLength(1024)]
        public string SalesFirstName { get; set; }

        [MaxLength(1024)]
        public string SalesLastName { get; set; }

        #endregion

        #region Account Bank
        public string AccountBankAccountName { get; set; }
        public int AccountBankID { get; set; }
        [MaxLength(25)]
        public string AccountBankCode { get; set; }
        [MaxLength(255)]
        public string AccountBankName { get; set; }
        [MaxLength(255)]
        public string AccountBankNumber { get; set; }
        [MaxLength(255)]
        #region Account Bank Currency
        public int AccountBankCurrencyID { get; set; }
        [MaxLength(25)]
        public string AccountBankCurrencyCode { get; set; }
        [MaxLength(25)]
        public string AccountBankCurrencySymbol { get; set; }
        public double AccountBankCurrencyRate { get; set; }
        #endregion
        #endregion
        public double Amount { get; set; }
        #region Agent
        public int AgentID { get; set; }
        [MaxLength(25)]
        public string AgentCode { get; set; }
        [MaxLength(255)]
        public string AgentName { get; set; }
        #endregion
        public int AutoIncrementNumber { get; set; }
        #region Buyer
        public int BuyerID { get; set; }
        [MaxLength(25)]
        public string BuyerCode { get; set; }
        [MaxLength(1000)]
        public string BuyerName { get; set; }
        [MaxLength(255)]
        public string BuyerType { get; set; }
        public string BuyerJob { get; set; }
        #endregion
        [MaxLength(25)]
        public string Code { get; set; }
        [MaxLength(255)]
        public string Commission { get; set; }
        #region Commodity
        public int CommodityID { get; set; }
        [MaxLength(25)]
        public string CommodityCode { get; set; }
        [MaxLength(255)]
        public string CommodityName { get; set; }
        #endregion
        [MaxLength(1000)]
        public string CommodityDescription { get; set; }
        [MaxLength(1000)]
        public string Condition { get; set; }
        [MaxLength(1000)]
        public string DeliveredTo { get; set; }
        public DateTimeOffset DeliverySchedule { get; set; }
        #region Design Motive
        public int DesignMotiveID { get; set; }
        [MaxLength(25)]
        public string DesignMotiveCode { get; set; }
        [MaxLength(255)]
        public string DesignMotiveName { get; set; }
        #endregion
        [MaxLength(255)]
        public string DispositionNumber { get; set; }
        public bool FromStock { get; set; }
        #region Material
        public int MaterialID { get; set; }
        [MaxLength(25)]
        public string MaterialCode { get; set; }
        [MaxLength(255)]
        public string MaterialName { get; set; }
        public double MaterialPrice { get; set; }

        [MaxLength(255)]
        public string MaterialTags { get; set; }
        #endregion
        #region Material Construction
        public int MaterialConstructionId { get; set; }
        [MaxLength(25)]
        public string MaterialConstructionCode { get; set; }
        [MaxLength(255)]
        public string MaterialConstructionName { get; set; }
        #endregion
        [MaxLength(255)]
        public string MaterialWidth { get; set; }
        public double OrderQuantity { get; set; }
        #region Order Type
        public int OrderTypeID { get; set; }
        [MaxLength(25)]
        public string OrderTypeCode { get; set; }
        [MaxLength(255)]
        public string OrderTypeName { get; set; }
        #endregion
        [MaxLength(1000)]
        public string Packing { get; set; }
        [MaxLength(255)]
        public string PieceLength { get; set; }
        public double PointLimit { get; set; }
        public int PointSystem { get; set; }
        #region Quality
        public int QualityID { get; set; }
        [MaxLength(25)]
        public string QualityCode { get; set; }
        [MaxLength(255)]
        public string QualityName { get; set; }
        #endregion
        [MaxLength(25)]
        public string SalesContractNo { get; set; }
        [MaxLength(1000)]
        public string ShipmentDescription { get; set; }
        [MaxLength(1000)]
        public double ShippingQuantityTolerance { get; set; }
        #region Term Of Payment
        public int TermOfPaymentID { get; set; }
        [MaxLength(25)]
        public string TermOfPaymentCode { get; set; }
        [MaxLength(255)]
        public string TermOfPaymentName { get; set; }
        public bool TermOfPaymentIsExport { get; set; }
        #endregion
        [MaxLength(1000)]
        public string TermOfShipment { get; set; }
        [MaxLength(1000)]
        public string TransportFee { get; set; }
        public bool UseIncomeTax { get; set; }
        public string VatId { get; set; }
        public double VatRate { get; set; }
        public double RemainingQuantity { get; set; }
        #region UOM
        public int UOMID { get; set; }
        [MaxLength(255)]
        public string UOMUnit { get; set; }
        #endregion
        #region Yarn Material
        public int YarnMaterialID { get; set; }
        [MaxLength(25)]
        public string YarnMaterialCode { get; set; }
        [MaxLength(255)]
        public string YarnMaterialName { get; set; }
        #endregion

        #region Product Type
        public int ProductTypeId { get; set; }
        [MaxLength(25)]
        public string ProductTypeCode { get; set; }
        [MaxLength(255)]
        public string ProductTypeName { get; set; }
        #endregion

        public string DownPayments { get; set; }
        public double PriceDP { get; set; }
        public double precentageDP { get; set; }
        public string PaymentMethods { get; set; }
        public int Day { get; set; }
        public int LatePayment { get; set; }
        public int LateReturn { get; set; }
        public double? Claim { get; set; }

        public virtual ICollection<FinishingPrintingSalesContractDetailModel> Details { get; set; }
    }
}

using Com.Danliris.Service.Sales.Lib.Utilities;
using Com.Danliris.Service.Sales.Lib.ViewModels.IntegrationViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.ViewModels.Weaving
{
    public class WeavingSalesContractViewModel : BaseViewModel, IValidatableObject
    {
        [MaxLength(255)]
        public string Code { get; set; }
        [MaxLength(255)]
        public string SalesContractNo { get; set; }
        [MaxLength(255)]
        public string DispositionNumber { get; set; }
        public bool FromStock { get; set; }
        [MaxLength(255)]
        public string MaterialWidth { get; set; }
        public double OrderQuantity { get; set; }
        public double ShippingQuantityTolerance { get; set; }
        public string ComodityDescription { get; set; }
        [MaxLength(255)]
        public string IncomeTax { get; set; }
        [MaxLength(1000)]
        public string TermOfShipment { get; set; }
        [MaxLength(1000)]
        public string TransportFee { get; set; }
        [MaxLength(1000)]
        public string Packing { get; set; }
        [MaxLength(1000)]
        public string DeliveredTo { get; set; }
        public double Price { get; set; }
        [MaxLength(1000)]
        public string Comission { get; set; }
        public DateTimeOffset? DeliverySchedule { get; set; }
        public string ShipmentDescription { get; set; }
        [MaxLength(1000)]
        public string Condition { get; set; }
        public string Remark { get; set; }
        [MaxLength(1000)]
        public string PieceLength { get; set; }
        public int? AutoIncrementNumber { get; set; }


        /* integration vm*/
        public BuyerViewModel Buyer { get; set; }
        public ProductViewModel Product { get; set; }
        public UomViewModel Uom { get; set; }
        public MaterialConstructionViewModel MaterialConstruction { get; set; }
        public YarnMaterialViewModel YarnMaterial { get; set; }
        public CommodityViewModel Comodity { get; set; }
        public QualityViewModel Quality { get; set; }
        public TermOfPaymentViewModel TermOfPayment { get; set; }
        public AccountBankViewModel AccountBank { get; set; }
        public AgentViewModel Agent { get; set; }
        public VatTaxViewModel VatTax { get; set; }
        public ProductTypeViewModel ProductType { get; set;}
        public MaterialViewModel Material { get; set; }
        public string DownPayments { get; set; }
        public double? PriceDP { get; set; }
        public double? precentageDP { get; set; }
        public string PaymentMethods { get; set; }
        public int? Day { get; set; }
        public int? LatePayment { get; set; }
        public int? LateReturn { get; set; }
        public double? Claim { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Buyer == null || this.Buyer.Id.Equals(0))
            {
                yield return new ValidationResult("Buyer harus di isi", new List<string> { "Buyer" });
            }
            else if (this.Buyer != null && !this.Buyer.Id.Equals(0))
            {
                if (this.Buyer.Type.ToLower() == "ekspor")
                {
                    if (this.Agent == null || this.Agent.Id.Equals(0))
                        yield return new ValidationResult("Agent harus di isi", new List<string> { "Agent" });
                    if (string.IsNullOrWhiteSpace(this.TermOfShipment))
                        yield return new ValidationResult("harus di isi", new List<string> { "TermOfShipment" });
                }
                if (this.Agent != null && !this.Agent.Id.Equals(0))
                {
                    if (string.IsNullOrWhiteSpace(this.Comission))
                        yield return new ValidationResult("harus di isi", new List<string> { "Comission" });
                }
            }

            if (this.Product == null || this.Product.Id.Equals(0))
                yield return new ValidationResult("Product harus di isi", new List<string> { "Product" });
            if (this.Uom == null || this.Uom.Id.Equals(0))
                yield return new ValidationResult("Uom harus di isi", new List<string> { "Uom" });
            if (this.MaterialConstruction == null || this.MaterialConstruction.Id.Equals(0))
                yield return new ValidationResult("MaterialConstruction harus di isi", new List<string> { "MaterialConstruction" });
            if (this.YarnMaterial == null || this.YarnMaterial.Id.Equals(0))
                yield return new ValidationResult("YarnMaterial harus di isi", new List<string> { "YarnMaterial" });
            if (this.Comodity == null || this.Comodity.Id.Equals(0))
                yield return new ValidationResult("Comodity harus di isi", new List<string> { "Comodity" });
            if (this.Quality == null || this.Quality.Id.Equals(0))
                yield return new ValidationResult("Quality harus di isi", new List<string> { "Quality" });
            if (this.TermOfPayment == null || this.TermOfPayment.Id.Equals(0))
                yield return new ValidationResult("TermPayment harus di isi", new List<string> { "TermPayment" });
            if (this.AccountBank == null || this.AccountBank.Id.Equals(0))
                yield return new ValidationResult("AccountBank harus di isi", new List<string> { "AccountBank" });
            if (string.IsNullOrWhiteSpace(this.MaterialWidth))
                yield return new ValidationResult("MaterialWidth harus di isi", new List<string> { "MaterialWidth" });
            if (this.OrderQuantity.Equals(0))
                yield return new ValidationResult("OrderQuantity harus lebih dari 0", new List<string> { "OrderQuantity" });
            if (string.IsNullOrWhiteSpace(this.DeliveredTo))
                yield return new ValidationResult("harus di isi", new List<string> { "DeliveredTo" });
            if (this.Price <= 0)
                yield return new ValidationResult("harus lebih dari 0", new List<string> { "Price" });
            if (this.DeliverySchedule == null)
                yield return new ValidationResult("harus di isi", new List<string> { "DeliverySchedule" });
            //if (ProductType == null || ProductType.Id.Equals(0))
            //    yield return new ValidationResult("Jenis Produk harus diisi", new List<string> { "ProductTypeId" });

            //if (this.Day.Equals(null))
            //{
            //    yield return new ValidationResult("Hari harus diisi", new List<string> { "Day" });
            //}

            if (this.LatePayment.Equals(null))
            {
                yield return new ValidationResult("Besar Denda harus diisi", new List<string> { "LatePayment" });
            }

            if (this.LateReturn.Equals(null))
            {
                yield return new ValidationResult("Hari Pengembalian harus diisi", new List<string> { "LateReturn" });
            }

            //if (Claim.Equals(null))
            //{
            //    yield return new ValidationResult("Claim Hari harus diisi", new List<string> { "Claim" });
            //}
        }
    }
}

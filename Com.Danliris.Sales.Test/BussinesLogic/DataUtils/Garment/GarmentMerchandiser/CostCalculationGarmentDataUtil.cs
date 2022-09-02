using Com.Danliris.Sales.Test.BussinesLogic.DataUtils.GarmentPreSalesContractDataUtils;
using Com.Danliris.Sales.Test.BussinesLogic.Utils;
using Com.Danliris.Service.Sales.Lib.BusinessLogic.Facades.CostCalculationGarments;
using Com.Danliris.Service.Sales.Lib.Models.CostCalculationGarments;
using Com.Danliris.Service.Sales.Lib.Models.GarmentPreSalesContractModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Sales.Test.BussinesLogic.DataUtils.Garment.GarmentMerchandiser
{
    public class CostCalculationGarmentDataUtil : BaseDataUtil<CostCalculationGarmentFacade, CostCalculationGarment>
    {
        private readonly GarmentPreSalesContractDataUtil garmentPreSalesContractDataUtil;

        public CostCalculationGarmentDataUtil(CostCalculationGarmentFacade facade, GarmentPreSalesContractDataUtil garmentPreSalesContractDataUtil) : base(facade)
        {
            this.garmentPreSalesContractDataUtil = garmentPreSalesContractDataUtil;
        }

        public override async Task<CostCalculationGarment> GetNewData()
        {
            var garmentPreSalesContractData = await garmentPreSalesContractDataUtil.GetTestData();

            return await GetNewData(garmentPreSalesContractData);
        }

        public async Task<CostCalculationGarment> GetNewData(GarmentPreSalesContract garmentPreSalesContractData)
        {
            var data = await base.GetNewData();
            data.Section = "A";
            data.Article = "test";
            data.ConfirmDate = DateTimeOffset.Now;
            data.DeliveryDate = DateTimeOffset.Now;
            data.CreatedUtc = DateTime.Now;
            data.LeadTime = 25;
            data.BuyerId = "1";
            data.BuyerCode = "Test";
            data.BuyerName = "Text";
            data.BuyerBrandId = 1;
            data.BuyerBrandCode = "Test";
            data.BuyerBrandName = "Test";
            data.RO_Number = "Test";
            data.Description = "Test";
            data.ComodityCode = "Test";
            data.CommodityDescription = "Test";
            data.RateValue = 1;
            data.NETFOBP = 10;
            data.Quantity = 1;
            data.ConfirmPrice = 1;
            data.UOMUnit = "Test";
            data.SectionName = "FRANSISKA YULIANI";
            data.ApprovalCC = "FRANSISKA YULIANI";
            data.ApprovalRO = "FRANSISKA YULIANI";
            data.ApprovalKadiv = "AMUMPUNI";
            data.PreSCId = garmentPreSalesContractData.Id;
            data.PreSCNo = garmentPreSalesContractData.SCNo;
            data.UnitCode = "C2A";
            data.UnitName = "test";
            data.IsROAccepted = false;
            data.ROAcceptedBy = "test";
            data.ROAcceptedDate = DateTimeOffset.Now;
            data.IsROAvailable = false;
            data.ROAvailableBy = "test";
            data.ROAvailableDate = DateTimeOffset.Now;
            data.IsRODistributed = false;
            data.RODistributionBy = "test";
            data.RODistributionDate = DateTimeOffset.Now;
            data.SMV_Cutting = 1.25;
            data.SMV_Sewing = 7.54;
            data.SMV_Finishing = 3.32;
            data.SMV_Total = 12.11;
            data.FabricAllowance = 0;
            data.AccessoriesAllowance = 3;
            data.IsApprovedMD = false;
            data.CreatedBy = "test";
            data.IsApprovedMD = false;
            data.IsApprovedIE = false;
            data.IsApprovedPurchasing = false;
            data.IsApprovedKadivMD = true;
            data.IsValidatedROSample = true;
            data.IsValidatedROMD = true;
            data.ApprovedKadivMDBy = "Test";
            data.ValidationMDDate = DateTimeOffset.Now;
            data.ApprovedMDDate = DateTimeOffset.Now;
            data.ApprovedIEDate = DateTimeOffset.Now;
            data.ApprovedPurchasingDate = DateTimeOffset.Now;
            data.ApprovedKadivMDDate = DateTimeOffset.Now;
            data.ValidationSampleDate = DateTimeOffset.Now;
            data.CostCalculationGarment_Materials = new List<CostCalculationGarment_Material>()
            {
                new CostCalculationGarment_Material
                {
                    ProductId = "1",
                    CategoryCode = "EMB",
                    CategoryName = "FABRIC",
                    Total = 109375,
                    CM_Price = 172450,
                    ProductCode = "Test001",
                    Description = "Test Description",
                    ProductRemark = "Test ProoductRemark",
                    BudgetQuantity = 1000,
                    UOMPriceName = "Test Sat",
                    Price = 10000,
                    PO_SerialNumber = "Test PO",
                }
            };

            return data;
        }
    }
}

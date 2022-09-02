using AutoMapper;
using Com.Danliris.Service.Sales.Lib.Models.Weaving;
using Com.Danliris.Service.Sales.Lib.ViewModels.Weaving;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.AutoMapperProfiles.WeavingProfiles
{
    public class WeavingSalesContract : Profile
    {
        public WeavingSalesContract()
        {
            CreateMap<WeavingSalesContractModel, WeavingSalesContractViewModel>()
                .ForPath(d => d.Buyer.Id, opt => opt.MapFrom(s => s.BuyerId))
                .ForPath(d => d.Buyer.Code, opt => opt.MapFrom(s => s.BuyerCode))
                .ForPath(d => d.Buyer.Name, opt => opt.MapFrom(s => s.BuyerName))
                .ForPath(d => d.Buyer.Type, opt => opt.MapFrom(s => s.BuyerType))

                .ForPath(d => d.Product.Id, opt => opt.MapFrom(s => s.ProductId))
                .ForPath(d => d.Product.Code, opt => opt.MapFrom(s => s.ProductCode))
                .ForPath(d => d.Product.Name, opt => opt.MapFrom(s => s.ProductName))
                .ForPath(d => d.Product.Price, opt => opt.MapFrom(s => s.ProductPrice))
                .ForPath(d => d.Product.Tags, opt => opt.MapFrom(s => s.ProductTags))

                .ForPath(d => d.ProductType.Id, opt => opt.MapFrom(s => s.ProductTypeId))
                .ForPath(d => d.ProductType.Code, opt => opt.MapFrom(s => s.ProductTypeCode))
                .ForPath(d => d.ProductType.Name, opt => opt.MapFrom(s => s.ProductTypeName))
                //.ForPath(d => d.ProductType.Remark, opt => opt.MapFrom(s => s.ProductTypeRemark))

                .ForPath(d => d.Uom.Id, opt => opt.MapFrom(s => s.UomId))
                .ForPath(d => d.Uom.Unit, opt => opt.MapFrom(s => s.UomUnit))

                .ForPath(d => d.MaterialConstruction.Id, opt => opt.MapFrom(s => s.MaterialConstructionId))
                .ForPath(d => d.MaterialConstruction.Code, opt => opt.MapFrom(s => s.MaterialConstructionCode))
                .ForPath(d => d.MaterialConstruction.Name, opt => opt.MapFrom(s => s.MaterialConstructionName))
                .ForPath(d => d.MaterialConstruction.Remark, opt => opt.MapFrom(s => s.MaterialConstructionRemark))

                .ForPath(d => d.YarnMaterial.Id, opt => opt.MapFrom(s => s.YarnMaterialId))
                .ForPath(d => d.YarnMaterial.Code, opt => opt.MapFrom(s => s.YarnMaterialCode))
                .ForPath(d => d.YarnMaterial.Name, opt => opt.MapFrom(s => s.YarnMaterialName))
                .ForPath(d => d.YarnMaterial.Remark, opt => opt.MapFrom(s => s.YarnMaterialRemark))

                .ForPath(d => d.YarnMaterial.Id, opt => opt.MapFrom(s => s.YarnMaterialId))
                .ForPath(d => d.YarnMaterial.Code, opt => opt.MapFrom(s => s.YarnMaterialCode))
                .ForPath(d => d.YarnMaterial.Name, opt => opt.MapFrom(s => s.YarnMaterialName))
                .ForPath(d => d.YarnMaterial.Remark, opt => opt.MapFrom(s => s.YarnMaterialRemark))

                .ForPath(d => d.Comodity.Id, opt => opt.MapFrom(s => s.ComodityId))
                .ForPath(d => d.Comodity.Code, opt => opt.MapFrom(s => s.ComodityCode))
                .ForPath(d => d.Comodity.Name, opt => opt.MapFrom(s => s.ComodityName))
                .ForPath(d => d.Comodity.Type, opt => opt.MapFrom(s => s.ComodityType))

                .ForPath(d => d.Quality.Id, opt => opt.MapFrom(s => s.QualityId))
                .ForPath(d => d.Quality.Code, opt => opt.MapFrom(s => s.QualityCode))
                .ForPath(d => d.Quality.Name, opt => opt.MapFrom(s => s.QualityName))

                .ForPath(d => d.TermOfPayment.Id, opt => opt.MapFrom(s => s.TermOfPaymentId))
                .ForPath(d => d.TermOfPayment.Code, opt => opt.MapFrom(s => s.TermOfPaymentCode))
                .ForPath(d => d.TermOfPayment.Name, opt => opt.MapFrom(s => s.TermOfPaymentName))
                .ForPath(d => d.TermOfPayment.IsExport, opt => opt.MapFrom(s => s.TermOfPaymentIsExport))

                .ForPath(d => d.AccountBank.Id, opt => opt.MapFrom(s => s.AccountBankId))
                .ForPath(d => d.AccountBank.Code, opt => opt.MapFrom(s => s.AccountBankCode))
                .ForPath(d => d.AccountBank.AccountName, opt => opt.MapFrom(s => s.AccountBankName))
                .ForPath(d => d.AccountBank.AccountNumber, opt => opt.MapFrom(s => s.AccountBankNumber))
                .ForPath(d => d.AccountBank.BankName, opt => opt.MapFrom(s => s.BankName))
                .ForPath(d => d.AccountBank.AccountCurrencyId, opt => opt.MapFrom(s => s.AccountCurrencyId))
                .ForPath(d => d.AccountBank.AccountCurrencyCode, opt => opt.MapFrom(s => s.AccountCurrencyCode))

                .ForPath(d => d.Agent.Id, opt => opt.MapFrom(s => s.AgentId))
                .ForPath(d => d.Agent.Code, opt => opt.MapFrom(s => s.AgentCode))
                .ForPath(d => d.Agent.Name, opt => opt.MapFrom(s => s.AgentName))

                .ForPath(d => d.VatTax.Id, opt => opt.MapFrom(s => s.VatId))
                .ForPath(d => d.VatTax.Rate, opt => opt.MapFrom(s => s.VatRate))

                .ForPath(d => d.PriceDP, opt => opt.MapFrom(s => s.PriceDP))
                .ForPath(d => d.precentageDP, opt => opt.MapFrom(s => s.precentageDP))

                .ReverseMap();
        }
    }
}

using AutoMapper;
using Com.Danliris.Service.Sales.Lib.BusinessLogic.Facades.Spinning;
using Com.Danliris.Service.Sales.Lib.BusinessLogic.Interface.Spinning;
using Com.Danliris.Service.Sales.Lib.Models.Spinning;
using Com.Danliris.Service.Sales.Lib.PDFTemplates;
using Com.Danliris.Service.Sales.Lib.Services;
using Com.Danliris.Service.Sales.Lib.ViewModels.IntegrationViewModel;
using Com.Danliris.Service.Sales.Lib.ViewModels.Spinning;
using Com.Danliris.Service.Sales.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Com.Danliris.Service.Sales.WebApi.Controllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/sales/spinning-sales-contracts")]
    [Authorize]
    public class SpinningSalesContractController : BaseController<SpinningSalesContractModel, SpinningSalesContractViewModel, ISpinningSalesContract>
    {
        private readonly static string apiVersion = "1.0";
        private readonly IHttpClientService HttpClientService;
        private readonly IServiceProvider _serviceProvider;
        public SpinningSalesContractController(IIdentityService identityService, IValidateService validateService, ISpinningSalesContract spinningSalesContractFacade,IMapper mapper, IServiceProvider serviceProvider) : base(identityService, validateService, spinningSalesContractFacade, mapper, apiVersion)
        {
            HttpClientService = serviceProvider.GetService<IHttpClientService>();
            _serviceProvider = serviceProvider;
        }

        [HttpGet("pdf/{Id}")]
        public async Task<IActionResult> GetPDF([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var indexAcceptPdf = Request.Headers["Accept"].ToList().IndexOf("application/pdf");
                int timeoffsset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
                SpinningSalesContractModel model = await Facade.ReadByIdAsync(Id);

                if (model == null)
                {
                    Dictionary<string, object> Result =
                        new ResultFormatter(ApiVersion, Common.NOT_FOUND_STATUS_CODE, Common.NOT_FOUND_MESSAGE)
                        .Fail();
                    return NotFound(Result);
                }
                else
                {
                    string BuyerUri = "master/buyers";
                    string BankUri = "master/account-banks";
                    string ProductTypeUri = "master/product-types";
                    //string CurrenciesUri = "master/currencies";
                    string Token = Request.Headers["Authorization"].First().Replace("Bearer ", "");

                    
                    SpinningSalesContractViewModel viewModel = Mapper.Map<SpinningSalesContractViewModel>(model);

                    /* Get Buyer */
                    var response = HttpClientService.GetAsync($@"{APIEndpoint.Core}{BuyerUri}/" + viewModel.Buyer.Id).Result.Content.ReadAsStringAsync();
                    Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Result);
                    object json;
                    if (result.TryGetValue("data", out json))
                    {
                        Dictionary<string, object> buyer = JsonConvert.DeserializeObject<Dictionary<string, object>>(json.ToString());
                        viewModel.Buyer.City = buyer.TryGetValue("City", out json) ? (json != null ? json.ToString() : "") : "";
                        viewModel.Buyer.Address = buyer.TryGetValue("Address", out json) ? (json != null ? json.ToString() : "") : "";
                        viewModel.Buyer.Contact = buyer.TryGetValue("Contact", out json) ? (json != null ? json.ToString() : "") : "";
                        viewModel.Buyer.Country = buyer.TryGetValue("Country", out json) ? (json != null ? json.ToString() : "") : "";
                        viewModel.Buyer.NIK = buyer.TryGetValue("NIK", out json) ? (json != null ? json.ToString() : "") : "";
                        viewModel.Buyer.Job = buyer.TryGetValue("Job", out json) ? (json != null ? json.ToString() : "") : "";
                    }

                    /* Get Agent */
                    var responseAgent = HttpClientService.GetAsync($@"{APIEndpoint.Core}{BuyerUri}/" + viewModel.Agent.Id).Result.Content.ReadAsStringAsync();
                    Dictionary<string, object> resultAgent = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseAgent.Result);
                    object jsonAgent;
                    if (resultAgent.TryGetValue("data", out jsonAgent))
                    {
                        Dictionary<string, object> agent = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonAgent.ToString());
                        viewModel.Agent.City = agent.TryGetValue("City", out jsonAgent) ? (jsonAgent != null ? jsonAgent.ToString() : "") : "";
                        viewModel.Agent.Address = agent.TryGetValue("Address", out jsonAgent) ? (jsonAgent != null ? jsonAgent.ToString() : "") : "";
                        viewModel.Agent.Contact = agent.TryGetValue("Contact", out jsonAgent) ? (jsonAgent != null ? jsonAgent.ToString() : "") : "";
                        viewModel.Agent.Country = agent.TryGetValue("Country", out jsonAgent) ? (jsonAgent != null ? jsonAgent.ToString() : "") : "";
                    }

                    /* Get AccountBank */
                    var responseBank = HttpClientService.GetAsync($@"{APIEndpoint.Core}{BankUri}/" + viewModel.AccountBank.Id).Result.Content.ReadAsStringAsync();
                    Dictionary<string, object> resultBank = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBank.Result);
                    object jsonBank;
                    if (resultBank.TryGetValue("data", out jsonBank))
                    {
                        Dictionary<string, object> bank = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonBank.ToString());
                        var currencyBankObj = new CurrencyViewModel();
                        object objResult = new object();
                        if (bank.TryGetValue("Currency", out objResult))
                        {
                            currencyBankObj = JsonConvert.DeserializeObject<CurrencyViewModel>(objResult.ToString());
                        }
                        viewModel.AccountBank.BankAddress = bank.TryGetValue("BankAddress", out objResult) ? (objResult != null ? objResult.ToString() : "") : "";
                        viewModel.AccountBank.SwiftCode = bank.TryGetValue("SwiftCode", out objResult) ? (objResult != null ? objResult.ToString() : "") : "";

                        viewModel.AccountBank.Currency = new CurrencyViewModel();
                        viewModel.AccountBank.Currency.Description = currencyBankObj.Description;
                        viewModel.AccountBank.Currency.Symbol = currencyBankObj.Symbol;
                        viewModel.AccountBank.Currency.Rate = currencyBankObj.Rate;
                        viewModel.AccountBank.Currency.Code = currencyBankObj.Code;

                    }

                    /* Get Product Type */
                    var responseProductType = HttpClientService.GetAsync($@"{APIEndpoint.Core}{ProductTypeUri}/" + viewModel.ProductType.Id).Result.Content.ReadAsStringAsync();
                    Dictionary<string, object> resultProductType = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Result);
                    object jsonProductType;
                    if (resultProductType.TryGetValue("data", out jsonProductType))
                    {
                        Dictionary<string, object> productType = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonProductType.ToString());
                        viewModel.ProductType.Name = productType.TryGetValue("Name", out jsonProductType) ? (jsonProductType != null ? jsonProductType.ToString() : "") : "";
                    }

                    /* Get Currencies */
                    //var responseCurrencies = httpClient.GetAsync($@"{APIEndpoint.Core}{CurrenciesUri}/" + viewModel.AccountBank.Currency.Id).Result.Content.ReadAsStringAsync();
                    //Dictionary<string, object> resultCurrencies = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseCurrencies.Result);
                    //var jsonCurrencies = resultCurrencies.Single(p => p.Key.Equals("data")).Value;
                    //Dictionary<string, object> currencies = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonCurrencies.ToString());

                    if (viewModel.Buyer.Type != "Ekspor")
                    {
                        NewSpinningSalesContractPdftemplate PdfTemplate = new NewSpinningSalesContractPdftemplate();
                        MemoryStream stream = PdfTemplate.GeneratePdfTemplate(viewModel, timeoffsset);
                        return new FileStreamResult(stream, "application/pdf")
                        {
                            FileDownloadName = "spinning sales contract (id)" + viewModel.SalesContractNo + ".pdf"
                        };
                    }
                    else
                    {
                        SpinningSalesContractModelExportPDFTemplate PdfTemplate = new SpinningSalesContractModelExportPDFTemplate();
                        MemoryStream stream = PdfTemplate.GeneratePdfTemplate(viewModel, timeoffsset);
                        return new FileStreamResult(stream, "application/pdf")
                        {
                            FileDownloadName = "spinning sales contract (en) " + viewModel.SalesContractNo + ".pdf"
                        };
                    }
                }
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, Common.INTERNAL_ERROR_STATUS_CODE, e.Message + " \n " + APIEndpoint.Core + " \n " + e.StackTrace)
                    .Fail();
                return StatusCode(Common.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }
    }
}

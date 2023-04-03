using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using DrilldownFunctions.Common;
using DrilldownFunctions.Common.Error;
using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace DrilldownFunctions.Functions.AzureCosmosDB
{
    public class AzureCosmosDBDrillDownFunction
    {
        private readonly ILogger<AzureCosmosDBDrillDownFunction> _logger;
        private readonly IOptionsMonitor<AppSettings> _appSetting;
        private readonly AzureCosmosDBFactory _AzureCosmosDBFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly DrilldownDbContext _dbContext;

        public AzureCosmosDBDrillDownFunction(ILogger<AzureCosmosDBDrillDownFunction> log, 
            IResponseFactory responseFactory, AzureCosmosDBFactory azureCosmosDBFactory, DrilldownDbContext dbContext)
        {
            _logger = log;
            _responseFactory = responseFactory;
            _AzureCosmosDBFactory = azureCosmosDBFactory;
            _dbContext = dbContext;
        }

        [FunctionName("AzureCosmosDB_DrillDownDimensions")]
        public IActionResult AzureCosmosDB_DrillDownDimensions(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("AzureCosmosDB_DrillDownDimensions");

            try
            {
                var drillDownService = new DrillDownService(_AzureCosmosDBFactory);
                var queryResult = drillDownService.ExecuteDimensionsQuery();

                return _responseFactory.CreateOKResponse(queryResult);
            }
            catch (Exception e)
            {
                _logger.LogError(e, JsonConvert.SerializeObject(req));
                return _responseFactory.CreateOKResponse(ErrorCodes.InternalServerError);
            }
        }
        [FunctionName("AzureCosmosDB_DrillDownSummarize")]
        public async Task<IActionResult> AzureCosmosDB_DrillDownSummarize(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("AzureCosmosDB_DrillDownSummarize");

            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                var requestPayload = JsonConvert.DeserializeObject<DrillDownSummarizeRequest>(requestBody);
                var drillDownService = new DrillDownService(_AzureCosmosDBFactory);
                var queryResult = drillDownService.ExecuteSummarizeQuery(requestPayload);

                return _responseFactory.CreateOKResponse(queryResult);
            }
            catch (Exception e)
            {
                _logger.LogError(e, JsonConvert.SerializeObject(req));
                return _responseFactory.CreateOKResponse(ErrorCodes.InternalServerError);
            }
        }
        [FunctionName("AzureCosmosDB_DrillDownDetails")]
        public async Task<IActionResult> AzureCosmosDB_DrillDownDetails(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("AzureCosmosDB_DrillDownDetails");

            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                var requestPayload = JsonConvert.DeserializeObject<DrillDownDetailsRequest>(requestBody);
                var drillDownService = new DrillDownService(_AzureCosmosDBFactory);
                var queryResult = drillDownService.ExecuteDetailsQuery(requestPayload);

                return _responseFactory.CreateOKResponse(queryResult);
            }
            catch (Exception e)
            {
                _logger.LogError(e, JsonConvert.SerializeObject(req));
                return _responseFactory.CreateOKResponse(ErrorCodes.InternalServerError);
            }
        }
    }
}


using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using DrilldownFunctions.Common;
using DrilldownFunctions.Common.Error;
using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Common.Query.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
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

        public AzureCosmosDBDrillDownFunction(ILogger<AzureCosmosDBDrillDownFunction> log, IResponseFactory responseFactory, AzureCosmosDBFactory azureCosmosDBFactory)
        {
            _logger = log;
            _responseFactory = responseFactory;
            _AzureCosmosDBFactory = azureCosmosDBFactory;
        }

        //[OpenApiOperation(operationId: "Run", tags: new[] { "name" })]
        //[OpenApiSecurity("AzureCosmosDB_DrillDownData", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        //[OpenApiParameter(name: "name", In = ParameterLocation.Query, Required = true, Type = typeof(string), Description = "The **Name** parameter")]
        //[OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(string), Description = "The OK response")]
        [FunctionName("AzureCosmosDB_DrillDownDimensions")]
        public async Task<IActionResult> AzureCosmosDB_DrillDownDimensions(
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
        [FunctionName("AzureCosmosDB_DrillDownData")]
        public async Task<IActionResult> AzureCosmosDB_DrillDownData(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("AzureCosmosDB_DrillDownData");

            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                var requestPayload = JsonConvert.DeserializeObject<DrillDownDataRequest>(requestBody);
                var drillDownService = new DrillDownService(_AzureCosmosDBFactory);
                var queryResult = drillDownService.ExecuteDataQuery(requestPayload);

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


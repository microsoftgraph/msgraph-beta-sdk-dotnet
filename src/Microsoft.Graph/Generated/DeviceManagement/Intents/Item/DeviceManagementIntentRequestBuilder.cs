using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.DeviceManagement.Intents.Item.Assign;
using MicrosoftGraph.DeviceManagement.Intents.Item.Assignments;
using MicrosoftGraph.DeviceManagement.Intents.Item.Categories;
using MicrosoftGraph.DeviceManagement.Intents.Item.CompareWithTemplateId;
using MicrosoftGraph.DeviceManagement.Intents.Item.CreateCopy;
using MicrosoftGraph.DeviceManagement.Intents.Item.DeviceSettingStateSummaries;
using MicrosoftGraph.DeviceManagement.Intents.Item.DeviceStates;
using MicrosoftGraph.DeviceManagement.Intents.Item.DeviceStateSummary;
using MicrosoftGraph.DeviceManagement.Intents.Item.MigrateToTemplate;
using MicrosoftGraph.DeviceManagement.Intents.Item.Settings;
using MicrosoftGraph.DeviceManagement.Intents.Item.UpdateSettings;
using MicrosoftGraph.DeviceManagement.Intents.Item.UserStates;
using MicrosoftGraph.DeviceManagement.Intents.Item.UserStateSummary;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.DeviceManagement.Intents.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\intents\{deviceManagementIntent-id}</summary>
    public class DeviceManagementIntentRequestBuilder {
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateCopyRequestBuilder CreateCopy { get =>
            new CreateCopyRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceSettingStateSummariesRequestBuilder DeviceSettingStateSummaries { get =>
            new DeviceSettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceStatesRequestBuilder DeviceStates { get =>
            new DeviceStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceStateSummaryRequestBuilder DeviceStateSummary { get =>
            new DeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public MigrateToTemplateRequestBuilder MigrateToTemplate { get =>
            new MigrateToTemplateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UpdateSettingsRequestBuilder UpdateSettings { get =>
            new UpdateSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UserStatesRequestBuilder UserStates { get =>
            new UserStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserStateSummaryRequestBuilder UserStateSummary { get =>
            new UserStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\intents\{deviceManagementIntent-id}\microsoft.graph.compare(templateId='{templateId}')
        /// <param name="templateId">Usage: templateId={templateId}</param>
        /// </summary>
        public CompareWithTemplateIdRequestBuilder CompareWithTemplateId(string templateId) {
            if(string.IsNullOrEmpty(templateId)) throw new ArgumentNullException(nameof(templateId));
            return new CompareWithTemplateIdRequestBuilder(PathParameters, RequestAdapter, templateId);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementIntentRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementIntentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/intents/{deviceManagementIntent_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementIntentRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementIntentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/intents/{deviceManagementIntent_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The device management intents
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device management intents
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device management intents
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementIntent body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device management intents
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The device management intents
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceManagementIntent> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DeviceManagementIntent>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The device management intents
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceManagementIntent body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The device management intents</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

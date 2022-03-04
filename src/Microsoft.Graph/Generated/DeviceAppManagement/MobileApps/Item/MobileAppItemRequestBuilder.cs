using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.Assign;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.Assignments;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.Categories;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.DeviceStatuses;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.GetRelatedAppStatesWithUserPrincipalNameWithDeviceId;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.InstallSummary;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.IosVppApp;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.Relationships;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UpdateRelationships;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\mobileApps\{mobileApp-id}</summary>
    public class MobileAppItemRequestBuilder {
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceStatusesRequestBuilder DeviceStatuses { get =>
            new DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public InstallSummaryRequestBuilder InstallSummary { get =>
            new InstallSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosVppAppRequestBuilder IosVppApp { get =>
            new IosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RelationshipsRequestBuilder Relationships { get =>
            new RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public UpdateRelationshipsRequestBuilder UpdateRelationships { get =>
            new UpdateRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UserStatusesRequestBuilder UserStatuses { get =>
            new UserStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MobileAppItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MobileAppItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The mobile apps.
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
        /// The mobile apps.
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
        /// The mobile apps.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MobileApp body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The mobile apps.
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
        /// The mobile apps.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MobileApp> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceAppManagement\mobileApps\{mobileApp-id}\microsoft.graph.getRelatedAppStates(userPrincipalName='{userPrincipalName}',deviceId='{deviceId}')
        /// <param name="deviceId">Usage: deviceId={deviceId}</param>
        /// <param name="userPrincipalName">Usage: userPrincipalName={userPrincipalName}</param>
        /// </summary>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder GetRelatedAppStatesWithUserPrincipalNameWithDeviceId(string userPrincipalName, string deviceId) {
            if(string.IsNullOrEmpty(deviceId)) throw new ArgumentNullException(nameof(deviceId));
            if(string.IsNullOrEmpty(userPrincipalName)) throw new ArgumentNullException(nameof(userPrincipalName));
            return new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder(PathParameters, RequestAdapter, userPrincipalName, deviceId);
        }
        /// <summary>
        /// The mobile apps.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MobileApp body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The mobile apps.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

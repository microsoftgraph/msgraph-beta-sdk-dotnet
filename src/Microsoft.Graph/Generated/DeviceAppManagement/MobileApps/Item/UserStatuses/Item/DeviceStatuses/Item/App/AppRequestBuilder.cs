using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App.Assign;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App.GetRelatedAppStatesWithUserPrincipalNameWithDeviceId;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App.IosVppApp;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App.Ref;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App.UpdateRelationships;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.DeviceStatuses.Item.App {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\mobileApps\{mobileApp-id}\userStatuses\{userAppInstallStatus-id}\deviceStatuses\{mobileAppInstallStatus-id}\app</summary>
    public class AppRequestBuilder {
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosVppAppRequestBuilder IosVppApp { get =>
            new IosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public UpdateRelationshipsRequestBuilder UpdateRelationships { get =>
            new UpdateRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new AppRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AppRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp_id}/userStatuses/{userAppInstallStatus_id}/deviceStatuses/{mobileAppInstallStatus_id}/app{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AppRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AppRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp_id}/userStatuses/{userAppInstallStatus_id}/deviceStatuses/{mobileAppInstallStatus_id}/app{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The navigation link to the mobile app.
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
        /// The navigation link to the mobile app.
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
        /// Builds and executes requests for operations under \deviceAppManagement\mobileApps\{mobileApp-id}\userStatuses\{userAppInstallStatus-id}\deviceStatuses\{mobileAppInstallStatus-id}\app\microsoft.graph.getRelatedAppStates(userPrincipalName='{userPrincipalName}',deviceId='{deviceId}')
        /// <param name="deviceId">Usage: deviceId={deviceId}</param>
        /// <param name="userPrincipalName">Usage: userPrincipalName={userPrincipalName}</param>
        /// </summary>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder GetRelatedAppStatesWithUserPrincipalNameWithDeviceId(string userPrincipalName, string deviceId) {
            if(string.IsNullOrEmpty(deviceId)) throw new ArgumentNullException(nameof(deviceId));
            if(string.IsNullOrEmpty(userPrincipalName)) throw new ArgumentNullException(nameof(userPrincipalName));
            return new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder(PathParameters, RequestAdapter, userPrincipalName, deviceId);
        }
        /// <summary>The navigation link to the mobile app.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

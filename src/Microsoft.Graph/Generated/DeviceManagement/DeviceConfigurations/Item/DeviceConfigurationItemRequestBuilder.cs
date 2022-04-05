using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.Assign;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.AssignedAccessMultiModeProfiles;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.Assignments;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.DeviceSettingStateSummaries;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.DeviceStatuses;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.DeviceStatusOverview;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.GroupAssignments;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.UserStatuses;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.UserStatusOverview;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.WindowsPrivacyAccessControls;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.WindowsUpdateForBusinessConfiguration;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item {
    /// <summary>Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
    public class DeviceConfigurationItemRequestBuilder {
        /// <summary>The assign property</summary>
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignedAccessMultiModeProfiles property</summary>
        public AssignedAccessMultiModeProfilesRequestBuilder AssignedAccessMultiModeProfiles { get =>
            new AssignedAccessMultiModeProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignments property</summary>
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceSettingStateSummaries property</summary>
        public DeviceSettingStateSummariesRequestBuilder DeviceSettingStateSummaries { get =>
            new DeviceSettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceStatuses property</summary>
        public DeviceStatusesRequestBuilder DeviceStatuses { get =>
            new DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceStatusOverview property</summary>
        public DeviceStatusOverviewRequestBuilder DeviceStatusOverview { get =>
            new DeviceStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupAssignments property</summary>
        public GroupAssignmentsRequestBuilder GroupAssignments { get =>
            new GroupAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userStatuses property</summary>
        public UserStatusesRequestBuilder UserStatuses { get =>
            new UserStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userStatusOverview property</summary>
        public UserStatusOverviewRequestBuilder UserStatusOverview { get =>
            new UserStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsPrivacyAccessControls property</summary>
        public WindowsPrivacyAccessControlsRequestBuilder WindowsPrivacyAccessControls { get =>
            new WindowsPrivacyAccessControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsUpdateForBusinessConfiguration property</summary>
        public WindowsUpdateForBusinessConfigurationRequestBuilder WindowsUpdateForBusinessConfiguration { get =>
            new WindowsUpdateForBusinessConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property deviceConfigurations for deviceManagement
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device configurations.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property deviceConfigurations in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceConfiguration body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property deviceConfigurations for deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The device configurations.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.DeviceConfiguration> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceConfiguration>(requestInfo, Microsoft.Graph.Beta.Models.DeviceConfiguration.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getOmaSettingPlainTextValue method.
        /// <param name="secretReferenceValueId">Usage: secretReferenceValueId=&apos;{secretReferenceValueId}&apos;</param>
        /// </summary>
        public GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder GetOmaSettingPlainTextValueWithSecretReferenceValueId(string secretReferenceValueId) {
            if(string.IsNullOrEmpty(secretReferenceValueId)) throw new ArgumentNullException(nameof(secretReferenceValueId));
            return new GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(PathParameters, RequestAdapter, secretReferenceValueId);
        }
        /// <summary>
        /// Update the navigation property deviceConfigurations in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.DeviceConfiguration body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>The device configurations.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.Assign;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.AssignedAccessMultiModeProfiles;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.GetOmaSettingPlainTextValueWithSecretReferenceValueId;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.Ref;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.WindowsPrivacyAccessControls;
using MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.WindowsUpdateForBusinessConfiguration;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceConfigurations\{deviceConfiguration-id}\groupAssignments\{deviceConfigurationGroupAssignment-id}\deviceConfiguration</summary>
    public class DeviceConfigurationRequestBuilder {
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignedAccessMultiModeProfilesRequestBuilder AssignedAccessMultiModeProfiles { get =>
            new AssignedAccessMultiModeProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WindowsPrivacyAccessControlsRequestBuilder WindowsPrivacyAccessControls { get =>
            new WindowsPrivacyAccessControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsUpdateForBusinessConfigurationRequestBuilder WindowsUpdateForBusinessConfiguration { get =>
            new WindowsUpdateForBusinessConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}/groupAssignments/{deviceConfigurationGroupAssignment_id}/deviceConfiguration{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}/groupAssignments/{deviceConfigurationGroupAssignment_id}/deviceConfiguration{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The navigation link to the Device Configuration being targeted.
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
        /// The navigation link to the Device Configuration being targeted.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraph.Models.Microsoft.Graph.DeviceConfiguration> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraph.Models.Microsoft.Graph.DeviceConfiguration>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceConfigurations\{deviceConfiguration-id}\groupAssignments\{deviceConfigurationGroupAssignment-id}\deviceConfiguration\microsoft.graph.getOmaSettingPlainTextValue(secretReferenceValueId='{secretReferenceValueId}')
        /// <param name="secretReferenceValueId">Usage: secretReferenceValueId={secretReferenceValueId}</param>
        /// </summary>
        public GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder GetOmaSettingPlainTextValueWithSecretReferenceValueId(string secretReferenceValueId) {
            if(string.IsNullOrEmpty(secretReferenceValueId)) throw new ArgumentNullException(nameof(secretReferenceValueId));
            return new GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(PathParameters, RequestAdapter, secretReferenceValueId);
        }
        /// <summary>The navigation link to the Device Configuration being targeted.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

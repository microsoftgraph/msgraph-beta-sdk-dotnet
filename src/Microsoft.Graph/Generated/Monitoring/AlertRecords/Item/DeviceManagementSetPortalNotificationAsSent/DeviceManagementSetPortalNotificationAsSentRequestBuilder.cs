using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Monitoring.AlertRecords.Item.DeviceManagementSetPortalNotificationAsSent {
    /// <summary>
    /// Provides operations to call the setPortalNotificationAsSent method.
    /// </summary>
    public class DeviceManagementSetPortalNotificationAsSentRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DeviceManagementSetPortalNotificationAsSentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementSetPortalNotificationAsSentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/monitoring/alertRecords/{alertRecord%2Did}/deviceManagement.setPortalNotificationAsSent", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeviceManagementSetPortalNotificationAsSentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementSetPortalNotificationAsSentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/monitoring/alertRecords/{alertRecord%2Did}/deviceManagement.setPortalNotificationAsSent", rawUrl) {
        }
        /// <summary>
        /// Set the status of the notification associated with the specified alertRecord on the Microsoft EndPoint Manager admin center as sent, by setting the **isPortalNotificationSent** property of the portal notification to `true`.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/devicemanagement-alertrecord-setportalnotificationassent?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(Action<DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Set the status of the notification associated with the specified alertRecord on the Microsoft EndPoint Manager admin center as sent, by setting the **isPortalNotificationSent** property of the portal notification to `true`.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementSetPortalNotificationAsSentRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

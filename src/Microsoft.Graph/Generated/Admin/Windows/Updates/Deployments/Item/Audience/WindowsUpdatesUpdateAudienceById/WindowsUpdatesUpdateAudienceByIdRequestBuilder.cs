using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.WindowsUpdatesUpdateAudienceById {
    /// <summary>
    /// Provides operations to call the updateAudienceById method.
    /// </summary>
    public class WindowsUpdatesUpdateAudienceByIdRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WindowsUpdatesUpdateAudienceByIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsUpdatesUpdateAudienceByIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/deployments/{deployment%2Did}/audience/windowsUpdates.updateAudienceById", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WindowsUpdatesUpdateAudienceByIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsUpdatesUpdateAudienceByIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/deployments/{deployment%2Did}/audience/windowsUpdates.updateAudienceById", rawUrl) {
        }
        /// <summary>
        /// Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type. Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object if it does not already exist. If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset. You can also use the method updateAudience to update the **deploymentAudience**.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/windowsupdates-deploymentaudience-updateaudiencebyid?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(UpdateAudienceByIdPostRequestBody body, Action<WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(UpdateAudienceByIdPostRequestBody body, Action<WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type. Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object if it does not already exist. If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset. You can also use the method updateAudience to update the **deploymentAudience**.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UpdateAudienceByIdPostRequestBody body, Action<WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UpdateAudienceByIdPostRequestBody body, Action<WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new windowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public WindowsUpdatesUpdateAudienceByIdRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

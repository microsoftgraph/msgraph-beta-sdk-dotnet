// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.ChangeUserAccountType;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.CreateSnapshot;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.EndGracePeriod;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetCloudPcConnectivityHistory;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetCloudPcLaunchInfo;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetShiftWorkCloudPcAccessState;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetSupportedCloudPcRemoteActions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.PowerOff;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.PowerOn;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Reboot;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Rename;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Reprovision;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Resize;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Restore;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.RetryPartnerAgentInstallation;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Start;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Stop;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Troubleshoot;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item {
    /// <summary>
    /// Provides operations to manage the cloudPCs property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    public class CloudPCItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to call the changeUserAccountType method.</summary>
        public ChangeUserAccountTypeRequestBuilder ChangeUserAccountType
        {
            get => new ChangeUserAccountTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createSnapshot method.</summary>
        public CreateSnapshotRequestBuilder CreateSnapshot
        {
            get => new CreateSnapshotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the endGracePeriod method.</summary>
        public EndGracePeriodRequestBuilder EndGracePeriod
        {
            get => new EndGracePeriodRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcConnectivityHistory method.</summary>
        public GetCloudPcConnectivityHistoryRequestBuilder GetCloudPcConnectivityHistory
        {
            get => new GetCloudPcConnectivityHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcLaunchInfo method.</summary>
        public GetCloudPcLaunchInfoRequestBuilder GetCloudPcLaunchInfo
        {
            get => new GetCloudPcLaunchInfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFrontlineCloudPcAccessState method.</summary>
        public GetFrontlineCloudPcAccessStateRequestBuilder GetFrontlineCloudPcAccessState
        {
            get => new GetFrontlineCloudPcAccessStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getShiftWorkCloudPcAccessState method.</summary>
        public GetShiftWorkCloudPcAccessStateRequestBuilder GetShiftWorkCloudPcAccessState
        {
            get => new GetShiftWorkCloudPcAccessStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSupportedCloudPcRemoteActions method.</summary>
        public GetSupportedCloudPcRemoteActionsRequestBuilder GetSupportedCloudPcRemoteActions
        {
            get => new GetSupportedCloudPcRemoteActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the powerOff method.</summary>
        public PowerOffRequestBuilder PowerOff
        {
            get => new PowerOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the powerOn method.</summary>
        public PowerOnRequestBuilder PowerOn
        {
            get => new PowerOnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reboot method.</summary>
        public RebootRequestBuilder Reboot
        {
            get => new RebootRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rename method.</summary>
        public RenameRequestBuilder Rename
        {
            get => new RenameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reprovision method.</summary>
        public ReprovisionRequestBuilder Reprovision
        {
            get => new ReprovisionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resize method.</summary>
        public ResizeRequestBuilder Resize
        {
            get => new ResizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore
        {
            get => new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retryPartnerAgentInstallation method.</summary>
        public RetryPartnerAgentInstallationRequestBuilder RetryPartnerAgentInstallation
        {
            get => new RetryPartnerAgentInstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the start method.</summary>
        public StartRequestBuilder Start
        {
            get => new StartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public StopRequestBuilder Stop
        {
            get => new StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the troubleshoot method.</summary>
        public TroubleshootRequestBuilder Troubleshoot
        {
            get => new TroubleshootRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="CloudPCItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPCItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CloudPCItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPCItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property cloudPCs for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPC"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.CloudPC?> GetAsync(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.CloudPC> GetAsync(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.CloudPC>(requestInfo, Microsoft.Graph.Beta.Models.CloudPC.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property cloudPCs in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPC"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.CloudPC?> PatchAsync(Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.CloudPC> PatchAsync(Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.CloudPC>(requestInfo, Microsoft.Graph.Beta.Models.CloudPC.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property cloudPCs for deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property cloudPCs in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="CloudPCItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CloudPCItemRequestBuilder WithUrl(string rawUrl)
        {
            return new CloudPCItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CloudPCItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// </summary>
        public class CloudPCItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CloudPCItemRequestBuilderGetRequestConfiguration : RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CloudPCItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}

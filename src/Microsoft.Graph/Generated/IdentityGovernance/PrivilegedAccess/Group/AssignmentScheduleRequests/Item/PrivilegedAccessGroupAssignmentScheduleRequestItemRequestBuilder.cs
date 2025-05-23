// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.ActivatedUsing;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Cancel;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Group;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Principal;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.TargetSchedule;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item
{
    /// <summary>
    /// Provides operations to manage the assignmentScheduleRequests property of the microsoft.graph.privilegedAccessGroup entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the activatedUsing property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.ActivatedUsing.ActivatedUsingRequestBuilder ActivatedUsing
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.ActivatedUsing.ActivatedUsingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancel method.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Cancel.CancelRequestBuilder Cancel
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the group property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Group.GroupRequestBuilder Group
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Group.GroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the principal property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Principal.PrincipalRequestBuilder Principal
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Principal.PrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the targetSchedule property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.TargetSchedule.TargetScheduleRequestBuilder TargetSchedule
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.TargetSchedule.TargetScheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleRequests/{privilegedAccessGroupAssignmentScheduleRequest%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleRequests/{privilegedAccessGroupAssignmentScheduleRequest%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property assignmentScheduleRequests for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
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
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read the properties and relationships of a privilegedAccessGroupAssignmentScheduleRequest object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/privilegedaccessgroupassignmentschedulerequest-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest>(requestInfo, global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property assignmentScheduleRequests in identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest?> PatchAsync(global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest> PatchAsync(global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest>(requestInfo, global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property assignmentScheduleRequests for identityGovernance
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
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a privilegedAccessGroupAssignmentScheduleRequest object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property assignmentScheduleRequests in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of a privilegedAccessGroupAssignmentScheduleRequest object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilder.PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrivilegedAccessGroupAssignmentScheduleRequestItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

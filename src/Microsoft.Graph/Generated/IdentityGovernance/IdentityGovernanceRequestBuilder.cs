// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews;
using Microsoft.Graph.Beta.IdentityGovernance.AppConsent;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows;
using Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics;
using Microsoft.Graph.Beta.IdentityGovernance.PermissionsManagement;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess;
using Microsoft.Graph.Beta.IdentityGovernance.RoleManagementAlerts;
using Microsoft.Graph.Beta.IdentityGovernance.TermsOfUse;
using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance
{
    /// <summary>
    /// Provides operations to manage the identityGovernance singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IdentityGovernanceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the accessReviews property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.AccessReviewsRequestBuilder AccessReviews
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.AccessReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appConsent property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.AppConsent.AppConsentRequestBuilder AppConsent
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.AppConsent.AppConsentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the entitlementManagement property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder EntitlementManagement
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lifecycleWorkflows property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.LifecycleWorkflowsRequestBuilder LifecycleWorkflows
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.LifecycleWorkflowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionsAnalytics property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.PermissionsAnalyticsRequestBuilder PermissionsAnalytics
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.PermissionsAnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionsManagement property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PermissionsManagement.PermissionsManagementRequestBuilder PermissionsManagement
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PermissionsManagement.PermissionsManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the privilegedAccess property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.PrivilegedAccessRequestBuilder PrivilegedAccess
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.PrivilegedAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleManagementAlerts property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.RoleManagementAlerts.RoleManagementAlertsRequestBuilder RoleManagementAlerts
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.RoleManagementAlerts.RoleManagementAlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termsOfUse property of the microsoft.graph.identityGovernance entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.TermsOfUse.TermsOfUseRequestBuilder TermsOfUse
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.TermsOfUse.TermsOfUseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityGovernanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityGovernanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder.IdentityGovernanceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder.IdentityGovernanceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance>(requestInfo, global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance?> PatchAsync(global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance> PatchAsync(global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance>(requestInfo, global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder.IdentityGovernanceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder.IdentityGovernanceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityGovernanceRequestBuilderGetQueryParameters 
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
        public partial class IdentityGovernanceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.IdentityGovernanceRequestBuilder.IdentityGovernanceRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityGovernanceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

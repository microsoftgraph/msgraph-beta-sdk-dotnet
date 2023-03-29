using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.Tenants.Item.ManagedTenantsResetTenantOnboardingStatus {
    /// <summary>
    /// Provides operations to call the resetTenantOnboardingStatus method.
    /// </summary>
    public class ManagedTenantsResetTenantOnboardingStatusRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ManagedTenantsResetTenantOnboardingStatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantsResetTenantOnboardingStatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/tenants/{tenant%2Did}/managedTenants.resetTenantOnboardingStatus", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ManagedTenantsResetTenantOnboardingStatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantsResetTenantOnboardingStatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/tenants/{tenant%2Did}/managedTenants.resetTenantOnboardingStatus", rawUrl) {
        }
        /// <summary>
        /// Carries out the appropriate procedures to reset the onboarding status for the managed tenant that was removed from the multi-tenant management platform using the offboardTenant action. By invoking this action the platform will attempt to onboard the managed tenant for management.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/managedtenants-tenant-resettenantonboardingstatus?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Tenant?> PostAsync(Action<ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Tenant> PostAsync(Action<ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Tenant>(requestInfo, Tenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Carries out the appropriate procedures to reset the onboarding status for the managed tenant that was removed from the multi-tenant management platform using the offboardTenant action. By invoking this action the platform will attempt to onboard the managed tenant for management.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsResetTenantOnboardingStatusRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

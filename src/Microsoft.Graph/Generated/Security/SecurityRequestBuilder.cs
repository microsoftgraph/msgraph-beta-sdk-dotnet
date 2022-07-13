using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.Alerts_v2;
using Microsoft.Graph.Beta.Security.Alerts;
using Microsoft.Graph.Beta.Security.AttackSimulation;
using Microsoft.Graph.Beta.Security.Cases;
using Microsoft.Graph.Beta.Security.CloudAppSecurityProfiles;
using Microsoft.Graph.Beta.Security.DomainSecurityProfiles;
using Microsoft.Graph.Beta.Security.FileSecurityProfiles;
using Microsoft.Graph.Beta.Security.HostSecurityProfiles;
using Microsoft.Graph.Beta.Security.Incidents;
using Microsoft.Graph.Beta.Security.InformationProtection;
using Microsoft.Graph.Beta.Security.IpSecurityProfiles;
using Microsoft.Graph.Beta.Security.Labels;
using Microsoft.Graph.Beta.Security.ProviderTenantSettings;
using Microsoft.Graph.Beta.Security.RunHuntingQuery;
using Microsoft.Graph.Beta.Security.SecureScoreControlProfiles;
using Microsoft.Graph.Beta.Security.SecureScores;
using Microsoft.Graph.Beta.Security.SecurityActions;
using Microsoft.Graph.Beta.Security.SubjectRightsRequests;
using Microsoft.Graph.Beta.Security.TiIndicators;
using Microsoft.Graph.Beta.Security.Triggers;
using Microsoft.Graph.Beta.Security.TriggerTypes;
using Microsoft.Graph.Beta.Security.UserSecurityProfiles;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class SecurityRequestBuilder {
        /// <summary>The alerts property</summary>
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The alerts_v2 property</summary>
        public Alerts_v2RequestBuilder Alerts_v2 { get =>
            new Alerts_v2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attackSimulation property</summary>
        public AttackSimulationRequestBuilder AttackSimulation { get =>
            new AttackSimulationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cases property</summary>
        public CasesRequestBuilder Cases { get =>
            new CasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudAppSecurityProfiles property</summary>
        public CloudAppSecurityProfilesRequestBuilder CloudAppSecurityProfiles { get =>
            new CloudAppSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domainSecurityProfiles property</summary>
        public DomainSecurityProfilesRequestBuilder DomainSecurityProfiles { get =>
            new DomainSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fileSecurityProfiles property</summary>
        public FileSecurityProfilesRequestBuilder FileSecurityProfiles { get =>
            new FileSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hostSecurityProfiles property</summary>
        public HostSecurityProfilesRequestBuilder HostSecurityProfiles { get =>
            new HostSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The incidents property</summary>
        public IncidentsRequestBuilder Incidents { get =>
            new IncidentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The informationProtection property</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ipSecurityProfiles property</summary>
        public IpSecurityProfilesRequestBuilder IpSecurityProfiles { get =>
            new IpSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public LabelsRequestBuilder Labels { get =>
            new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The providerTenantSettings property</summary>
        public ProviderTenantSettingsRequestBuilder ProviderTenantSettings { get =>
            new ProviderTenantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The runHuntingQuery property</summary>
        public RunHuntingQueryRequestBuilder RunHuntingQuery { get =>
            new RunHuntingQueryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secureScoreControlProfiles property</summary>
        public SecureScoreControlProfilesRequestBuilder SecureScoreControlProfiles { get =>
            new SecureScoreControlProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secureScores property</summary>
        public SecureScoresRequestBuilder SecureScores { get =>
            new SecureScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityActions property</summary>
        public SecurityActionsRequestBuilder SecurityActions { get =>
            new SecurityActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subjectRightsRequests property</summary>
        public SubjectRightsRequestsRequestBuilder SubjectRightsRequests { get =>
            new SubjectRightsRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tiIndicators property</summary>
        public TiIndicatorsRequestBuilder TiIndicators { get =>
            new TiIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The triggers property</summary>
        public TriggersRequestBuilder Triggers { get =>
            new TriggersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The triggerTypes property</summary>
        public TriggerTypesRequestBuilder TriggerTypes { get =>
            new TriggerTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userSecurityProfiles property</summary>
        public UserSecurityProfilesRequestBuilder UserSecurityProfiles { get =>
            new UserSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SecurityRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SecurityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/security{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new SecurityRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SecurityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/security{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get security
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<SecurityRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SecurityRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update security
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SecurityRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get security
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.Security.Security> GetAsync(Action<SecurityRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.Security>(requestInfo, Microsoft.Graph.Beta.Models.Security.Security.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update security
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get security</summary>
        public class SecurityRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class SecurityRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SecurityRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SecurityRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new securityRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SecurityRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class SecurityRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new securityRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SecurityRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}

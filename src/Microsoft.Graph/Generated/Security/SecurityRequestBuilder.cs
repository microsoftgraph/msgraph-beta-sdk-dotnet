using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using MicrosoftGraphSdk.Security.Alerts;
using MicrosoftGraphSdk.Security.AttackSimulation;
using MicrosoftGraphSdk.Security.CloudAppSecurityProfiles;
using MicrosoftGraphSdk.Security.DomainSecurityProfiles;
using MicrosoftGraphSdk.Security.FileSecurityProfiles;
using MicrosoftGraphSdk.Security.HostSecurityProfiles;
using MicrosoftGraphSdk.Security.InformationProtection;
using MicrosoftGraphSdk.Security.IpSecurityProfiles;
using MicrosoftGraphSdk.Security.ProviderTenantSettings;
using MicrosoftGraphSdk.Security.SecureScoreControlProfiles;
using MicrosoftGraphSdk.Security.SecureScores;
using MicrosoftGraphSdk.Security.SecurityActions;
using MicrosoftGraphSdk.Security.TiIndicators;
using MicrosoftGraphSdk.Security.UserSecurityProfiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class SecurityRequestBuilder {
        /// <summary>The alerts property</summary>
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attackSimulation property</summary>
        public AttackSimulationRequestBuilder AttackSimulation { get =>
            new AttackSimulationRequestBuilder(PathParameters, RequestAdapter);
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
        /// <summary>The informationProtection property</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ipSecurityProfiles property</summary>
        public IpSecurityProfilesRequestBuilder IpSecurityProfiles { get =>
            new IpSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The providerTenantSettings property</summary>
        public ProviderTenantSettingsRequestBuilder ProviderTenantSettings { get =>
            new ProviderTenantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
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
        /// <summary>The tiIndicators property</summary>
        public TiIndicatorsRequestBuilder TiIndicators { get =>
            new TiIndicatorsRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/security{?select,expand}";
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
            UrlTemplate = "{+baseurl}/security{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get security
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
        /// Update security
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// Get security
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update security
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get security</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

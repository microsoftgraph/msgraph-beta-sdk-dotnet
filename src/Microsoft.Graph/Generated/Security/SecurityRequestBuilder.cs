using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using MicrosoftGraphSdk.Security.Alerts_v2;
using MicrosoftGraphSdk.Security.Alerts;
using MicrosoftGraphSdk.Security.AttackSimulation;
using MicrosoftGraphSdk.Security.CloudAppSecurityProfiles;
using MicrosoftGraphSdk.Security.DomainSecurityProfiles;
using MicrosoftGraphSdk.Security.FileSecurityProfiles;
using MicrosoftGraphSdk.Security.HostSecurityProfiles;
using MicrosoftGraphSdk.Security.Incidents;
using MicrosoftGraphSdk.Security.IpSecurityProfiles;
using MicrosoftGraphSdk.Security.ProviderTenantSettings;
using MicrosoftGraphSdk.Security.RunHuntingQuery;
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
    /// <summary>Builds and executes requests for operations under \security</summary>
    public class SecurityRequestBuilder {
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        public Alerts_v2RequestBuilder Alerts_v2 { get =>
            new Alerts_v2RequestBuilder(PathParameters, RequestAdapter);
        }
        public AttackSimulationRequestBuilder AttackSimulation { get =>
            new AttackSimulationRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudAppSecurityProfilesRequestBuilder CloudAppSecurityProfiles { get =>
            new CloudAppSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DomainSecurityProfilesRequestBuilder DomainSecurityProfiles { get =>
            new DomainSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public FileSecurityProfilesRequestBuilder FileSecurityProfiles { get =>
            new FileSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public HostSecurityProfilesRequestBuilder HostSecurityProfiles { get =>
            new HostSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public IncidentsRequestBuilder Incidents { get =>
            new IncidentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public IpSecurityProfilesRequestBuilder IpSecurityProfiles { get =>
            new IpSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public ProviderTenantSettingsRequestBuilder ProviderTenantSettings { get =>
            new ProviderTenantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RunHuntingQueryRequestBuilder RunHuntingQuery { get =>
            new RunHuntingQueryRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecureScoreControlProfilesRequestBuilder SecureScoreControlProfiles { get =>
            new SecureScoreControlProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecureScoresRequestBuilder SecureScores { get =>
            new SecureScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecurityActionsRequestBuilder SecurityActions { get =>
            new SecurityActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TiIndicatorsRequestBuilder TiIndicators { get =>
            new TiIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
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
        /// Update security
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get security
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update security
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Security.Security body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
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

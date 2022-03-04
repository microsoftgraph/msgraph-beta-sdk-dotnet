using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Directory.AdministrativeUnits;
using MicrosoftGraphSdk.Directory.AttributeSets;
using MicrosoftGraphSdk.Directory.CustomSecurityAttributeDefinitions;
using MicrosoftGraphSdk.Directory.DeletedItems;
using MicrosoftGraphSdk.Directory.FeatureRolloutPolicies;
using MicrosoftGraphSdk.Directory.FederationConfigurations;
using MicrosoftGraphSdk.Directory.ImpactedResources;
using MicrosoftGraphSdk.Directory.InboundSharedUserProfiles;
using MicrosoftGraphSdk.Directory.OutboundSharedUserProfiles;
using MicrosoftGraphSdk.Directory.Recommendations;
using MicrosoftGraphSdk.Directory.SharedEmailDomains;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Directory {
    /// <summary>Builds and executes requests for operations under \directory</summary>
    public class DirectoryRequestBuilder {
        public AdministrativeUnitsRequestBuilder AdministrativeUnits { get =>
            new AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AttributeSetsRequestBuilder AttributeSets { get =>
            new AttributeSetsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CustomSecurityAttributeDefinitionsRequestBuilder CustomSecurityAttributeDefinitions { get =>
            new CustomSecurityAttributeDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeletedItemsRequestBuilder DeletedItems { get =>
            new DeletedItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies { get =>
            new FeatureRolloutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public FederationConfigurationsRequestBuilder FederationConfigurations { get =>
            new FederationConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImpactedResourcesRequestBuilder ImpactedResources { get =>
            new ImpactedResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        public InboundSharedUserProfilesRequestBuilder InboundSharedUserProfiles { get =>
            new InboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OutboundSharedUserProfilesRequestBuilder OutboundSharedUserProfiles { get =>
            new OutboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RecommendationsRequestBuilder Recommendations { get =>
            new RecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SharedEmailDomainsRequestBuilder SharedEmailDomains { get =>
            new SharedEmailDomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/directory{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/directory{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get directory
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
        /// Update directory
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Directory body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Get directory
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Directory> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Directory>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.Directory.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update directory
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Directory body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get directory</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

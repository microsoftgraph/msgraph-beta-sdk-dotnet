using Microsoft.Graph.Beta.Me.Profile.Account;
using Microsoft.Graph.Beta.Me.Profile.Addresses;
using Microsoft.Graph.Beta.Me.Profile.Anniversaries;
using Microsoft.Graph.Beta.Me.Profile.Awards;
using Microsoft.Graph.Beta.Me.Profile.Certifications;
using Microsoft.Graph.Beta.Me.Profile.EducationalActivities;
using Microsoft.Graph.Beta.Me.Profile.Emails;
using Microsoft.Graph.Beta.Me.Profile.Interests;
using Microsoft.Graph.Beta.Me.Profile.Languages;
using Microsoft.Graph.Beta.Me.Profile.Names;
using Microsoft.Graph.Beta.Me.Profile.Notes;
using Microsoft.Graph.Beta.Me.Profile.Patents;
using Microsoft.Graph.Beta.Me.Profile.Phones;
using Microsoft.Graph.Beta.Me.Profile.Positions;
using Microsoft.Graph.Beta.Me.Profile.Projects;
using Microsoft.Graph.Beta.Me.Profile.Publications;
using Microsoft.Graph.Beta.Me.Profile.Skills;
using Microsoft.Graph.Beta.Me.Profile.WebAccounts;
using Microsoft.Graph.Beta.Me.Profile.Websites;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Me.Profile {
    /// <summary>Provides operations to manage the profile property of the microsoft.graph.user entity.</summary>
    public class ProfileRequestBuilder {
        /// <summary>The account property</summary>
        public AccountRequestBuilder Account { get =>
            new AccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The addresses property</summary>
        public AddressesRequestBuilder Addresses { get =>
            new AddressesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The anniversaries property</summary>
        public AnniversariesRequestBuilder Anniversaries { get =>
            new AnniversariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The awards property</summary>
        public AwardsRequestBuilder Awards { get =>
            new AwardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The certifications property</summary>
        public CertificationsRequestBuilder Certifications { get =>
            new CertificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The educationalActivities property</summary>
        public EducationalActivitiesRequestBuilder EducationalActivities { get =>
            new EducationalActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emails property</summary>
        public EmailsRequestBuilder Emails { get =>
            new EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The interests property</summary>
        public InterestsRequestBuilder Interests { get =>
            new InterestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The languages property</summary>
        public LanguagesRequestBuilder Languages { get =>
            new LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The names property</summary>
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notes property</summary>
        public NotesRequestBuilder Notes { get =>
            new NotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The patents property</summary>
        public PatentsRequestBuilder Patents { get =>
            new PatentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The phones property</summary>
        public PhonesRequestBuilder Phones { get =>
            new PhonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The positions property</summary>
        public PositionsRequestBuilder Positions { get =>
            new PositionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects { get =>
            new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The publications property</summary>
        public PublicationsRequestBuilder Publications { get =>
            new PublicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The skills property</summary>
        public SkillsRequestBuilder Skills { get =>
            new SkillsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The webAccounts property</summary>
        public WebAccountsRequestBuilder WebAccounts { get =>
            new WebAccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The websites property</summary>
        public WebsitesRequestBuilder Websites { get =>
            new WebsitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ProfileRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ProfileRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/profile{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ProfileRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ProfileRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/profile{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property profile for me
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
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
        /// Update the navigation property profile in me
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.Profile body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// Delete navigation property profile for me
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.Profile> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Profile>(requestInfo, Microsoft.Graph.Beta.Models.Profile.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property profile in me
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.Profile body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Represents properties that are descriptive of a user in a tenant.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
    }
}

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using MicrosoftGraphSdk.Users.Item.Profile.Account;
using MicrosoftGraphSdk.Users.Item.Profile.Addresses;
using MicrosoftGraphSdk.Users.Item.Profile.Anniversaries;
using MicrosoftGraphSdk.Users.Item.Profile.Awards;
using MicrosoftGraphSdk.Users.Item.Profile.Certifications;
using MicrosoftGraphSdk.Users.Item.Profile.EducationalActivities;
using MicrosoftGraphSdk.Users.Item.Profile.Emails;
using MicrosoftGraphSdk.Users.Item.Profile.Interests;
using MicrosoftGraphSdk.Users.Item.Profile.Languages;
using MicrosoftGraphSdk.Users.Item.Profile.Names;
using MicrosoftGraphSdk.Users.Item.Profile.Notes;
using MicrosoftGraphSdk.Users.Item.Profile.Patents;
using MicrosoftGraphSdk.Users.Item.Profile.Phones;
using MicrosoftGraphSdk.Users.Item.Profile.Positions;
using MicrosoftGraphSdk.Users.Item.Profile.Projects;
using MicrosoftGraphSdk.Users.Item.Profile.Publications;
using MicrosoftGraphSdk.Users.Item.Profile.Skills;
using MicrosoftGraphSdk.Users.Item.Profile.WebAccounts;
using MicrosoftGraphSdk.Users.Item.Profile.Websites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Users.Item.Profile {
    /// <summary>Provides operations to manage the profile property of the microsoft.graph.user entity.</summary>
    public class ProfileRequestBuilder {
        public AccountRequestBuilder Account { get =>
            new AccountRequestBuilder(PathParameters, RequestAdapter);
        }
        public AddressesRequestBuilder Addresses { get =>
            new AddressesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AnniversariesRequestBuilder Anniversaries { get =>
            new AnniversariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AwardsRequestBuilder Awards { get =>
            new AwardsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CertificationsRequestBuilder Certifications { get =>
            new CertificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EducationalActivitiesRequestBuilder EducationalActivities { get =>
            new EducationalActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public EmailsRequestBuilder Emails { get =>
            new EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public InterestsRequestBuilder Interests { get =>
            new InterestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public LanguagesRequestBuilder Languages { get =>
            new LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(PathParameters, RequestAdapter);
        }
        public NotesRequestBuilder Notes { get =>
            new NotesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PatentsRequestBuilder Patents { get =>
            new PatentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PhonesRequestBuilder Phones { get =>
            new PhonesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PositionsRequestBuilder Positions { get =>
            new PositionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProjectsRequestBuilder Projects { get =>
            new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PublicationsRequestBuilder Publications { get =>
            new PublicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SkillsRequestBuilder Skills { get =>
            new SkillsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WebAccountsRequestBuilder WebAccounts { get =>
            new WebAccountsRequestBuilder(PathParameters, RequestAdapter);
        }
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
            UrlTemplate = "{+baseurl}/users/{user_id}/profile{?select,expand}";
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
            UrlTemplate = "{+baseurl}/users/{user_id}/profile{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property profile for users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
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
        /// Update the navigation property profile in users
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Profile body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete navigation property profile for users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Profile> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Profile>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.Profile.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property profile in users
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Profile body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Represents properties that are descriptive of a user in a tenant.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

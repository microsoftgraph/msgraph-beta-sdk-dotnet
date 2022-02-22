using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using MicrosoftGraph.Users.Item.Profile.Account;
using MicrosoftGraph.Users.Item.Profile.Addresses;
using MicrosoftGraph.Users.Item.Profile.Anniversaries;
using MicrosoftGraph.Users.Item.Profile.Awards;
using MicrosoftGraph.Users.Item.Profile.Certifications;
using MicrosoftGraph.Users.Item.Profile.EducationalActivities;
using MicrosoftGraph.Users.Item.Profile.Emails;
using MicrosoftGraph.Users.Item.Profile.Interests;
using MicrosoftGraph.Users.Item.Profile.Languages;
using MicrosoftGraph.Users.Item.Profile.Names;
using MicrosoftGraph.Users.Item.Profile.Notes;
using MicrosoftGraph.Users.Item.Profile.Patents;
using MicrosoftGraph.Users.Item.Profile.Phones;
using MicrosoftGraph.Users.Item.Profile.Positions;
using MicrosoftGraph.Users.Item.Profile.Projects;
using MicrosoftGraph.Users.Item.Profile.Publications;
using MicrosoftGraph.Users.Item.Profile.Skills;
using MicrosoftGraph.Users.Item.Profile.WebAccounts;
using MicrosoftGraph.Users.Item.Profile.Websites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.Users.Item.Profile {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\profile</summary>
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
        /// Represents properties that are descriptive of a user in a tenant.
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
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraph.Models.Microsoft.Graph.Profile body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraph.Models.Microsoft.Graph.Profile> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraph.Models.Microsoft.Graph.Profile>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraph.Models.Microsoft.Graph.Profile body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
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

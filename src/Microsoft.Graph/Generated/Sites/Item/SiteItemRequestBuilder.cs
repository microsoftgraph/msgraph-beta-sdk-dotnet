using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Sites.Item.Analytics;
using Microsoft.Graph.Beta.Sites.Item.Columns;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes;
using Microsoft.Graph.Beta.Sites.Item.Drive;
using Microsoft.Graph.Beta.Sites.Item.Drives;
using Microsoft.Graph.Beta.Sites.Item.ExternalColumns;
using Microsoft.Graph.Beta.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Beta.Sites.Item.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Beta.Sites.Item.GetByPathWithPath;
using Microsoft.Graph.Beta.Sites.Item.Items;
using Microsoft.Graph.Beta.Sites.Item.Lists;
using Microsoft.Graph.Beta.Sites.Item.Onenote;
using Microsoft.Graph.Beta.Sites.Item.Operations;
using Microsoft.Graph.Beta.Sites.Item.Pages;
using Microsoft.Graph.Beta.Sites.Item.Permissions;
using Microsoft.Graph.Beta.Sites.Item.Sites;
using Microsoft.Graph.Beta.Sites.Item.TermStore;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Sites.Item {
    /// <summary>Provides operations to manage the collection of site entities.</summary>
    public class SiteItemRequestBuilder {
        /// <summary>The analytics property</summary>
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The columns property</summary>
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contentTypes property</summary>
        public ContentTypesRequestBuilder ContentTypes { get =>
            new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drive property</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drives property</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalColumns property</summary>
        public ExternalColumnsRequestBuilder ExternalColumns { get =>
            new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The items property</summary>
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lists property</summary>
        public ListsRequestBuilder Lists { get =>
            new ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onenote property</summary>
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The operations property</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pages property</summary>
        public PagesRequestBuilder Pages { get =>
            new PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The permissions property</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The sites property</summary>
        public Microsoft.Graph.Beta.Sites.Item.Sites.SitesRequestBuilder Sites { get =>
            new Microsoft.Graph.Beta.Sites.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The termStore property</summary>
        public TermStoreRequestBuilder TermStore { get =>
            new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new SiteItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new SiteItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SiteItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get entity from sites by key
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<SiteItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new SiteItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update entity in sites
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SiteItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        /// </summary>
        public GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId) {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// Get entity from sites by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.Site> GetAsync(Action<SiteItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Site>(requestInfo, Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        /// </summary>
        public GetByPathWithPathRequestBuilder GetByPathWithPath(string path) {
            if(string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            return new GetByPathWithPathRequestBuilder(PathParameters, RequestAdapter, path);
        }
        /// <summary>
        /// Update entity in sites
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get entity from sites by key</summary>
        public class SiteItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class SiteItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SiteItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SiteItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new siteItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class SiteItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new siteItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}

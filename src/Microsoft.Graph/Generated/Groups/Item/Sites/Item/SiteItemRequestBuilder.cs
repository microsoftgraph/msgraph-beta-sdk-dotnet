using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Analytics;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Columns;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.ContentTypes;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Drive;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Drives;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.ExternalColumns;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Items;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Lists;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Onenote;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Operations;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Pages;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Permissions;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.Sites;
using MicrosoftGraphSdk.Groups.Item.Sites.Item.TermStore;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Groups.Item.Sites.Item {
    /// <summary>Provides operations to manage the sites property of the microsoft.graph.group entity.</summary>
    public class SiteItemRequestBuilder {
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContentTypesRequestBuilder ContentTypes { get =>
            new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExternalColumnsRequestBuilder ExternalColumns { get =>
            new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ListsRequestBuilder Lists { get =>
            new ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PagesRequestBuilder Pages { get =>
            new PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
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
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}{?select,expand}";
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
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property sites for groups
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
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
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
        /// Update the navigation property sites in groups
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Site body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete navigation property sites for groups
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
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Site> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Site>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.Site.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property sites in groups
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Site body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>The list of SharePoint sites in this group. Access the default site with /sites/root.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

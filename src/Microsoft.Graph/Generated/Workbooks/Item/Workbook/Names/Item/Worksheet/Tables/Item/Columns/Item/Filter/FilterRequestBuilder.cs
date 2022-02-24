using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Apply;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCustomFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyIconFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyValuesFilter;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Clear;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\columns\{workbookTableColumn-id}\filter</summary>
    public class FilterRequestBuilder {
        public ApplyRequestBuilder Apply { get =>
            new ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyBottomItemsFilterRequestBuilder ApplyBottomItemsFilter { get =>
            new ApplyBottomItemsFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyBottomPercentFilterRequestBuilder ApplyBottomPercentFilter { get =>
            new ApplyBottomPercentFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyCellColorFilterRequestBuilder ApplyCellColorFilter { get =>
            new ApplyCellColorFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyCustomFilterRequestBuilder ApplyCustomFilter { get =>
            new ApplyCustomFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyDynamicFilterRequestBuilder ApplyDynamicFilter { get =>
            new ApplyDynamicFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyFontColorFilterRequestBuilder ApplyFontColorFilter { get =>
            new ApplyFontColorFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyIconFilterRequestBuilder ApplyIconFilter { get =>
            new ApplyIconFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyTopItemsFilterRequestBuilder ApplyTopItemsFilter { get =>
            new ApplyTopItemsFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyTopPercentFilterRequestBuilder ApplyTopPercentFilter { get =>
            new ApplyTopPercentFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplyValuesFilterRequestBuilder ApplyValuesFilter { get =>
            new ApplyValuesFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClearRequestBuilder Clear { get =>
            new ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FilterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/tables/{workbookTable_id}/columns/{workbookTableColumn_id}/filter{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FilterRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/tables/{workbookTable_id}/columns/{workbookTableColumn_id}/filter{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFilter> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFilter>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

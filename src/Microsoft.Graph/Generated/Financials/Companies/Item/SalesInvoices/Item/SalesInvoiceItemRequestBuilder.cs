using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.Cancel;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.CancelAndSend;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.Currency;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.Customer;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.PaymentTerm;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.Post;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.PostAndSend;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.SalesInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.Send;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item.ShipmentMethod;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices.Item {
    /// <summary>
    /// Provides operations to manage the salesInvoices property of the microsoft.graph.company entity.
    /// </summary>
    public class SalesInvoiceItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the cancel method.</summary>
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancelAndSend method.</summary>
        public CancelAndSendRequestBuilder CancelAndSend { get =>
            new CancelAndSendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the currency property of the microsoft.graph.salesInvoice entity.</summary>
        public CurrencyRequestBuilder Currency { get =>
            new CurrencyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customer property of the microsoft.graph.salesInvoice entity.</summary>
        public CustomerRequestBuilder Customer { get =>
            new CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the paymentTerm property of the microsoft.graph.salesInvoice entity.</summary>
        public PaymentTermRequestBuilder PaymentTerm { get =>
            new PaymentTermRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the postAndSend method.</summary>
        public PostAndSendRequestBuilder PostAndSend { get =>
            new PostAndSendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the post method.</summary>
        public PostRequestBuilder PostPath { get =>
            new PostRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesInvoiceLines property of the microsoft.graph.salesInvoice entity.</summary>
        public SalesInvoiceLinesRequestBuilder SalesInvoiceLines { get =>
            new SalesInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the send method.</summary>
        public SendRequestBuilder Send { get =>
            new SendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the shipmentMethod property of the microsoft.graph.salesInvoice entity.</summary>
        public ShipmentMethodRequestBuilder ShipmentMethod { get =>
            new ShipmentMethodRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SalesInvoiceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesInvoiceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/salesInvoices/{salesInvoice%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SalesInvoiceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesInvoiceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/salesInvoices/{salesInvoice%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get salesInvoices from financials
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SalesInvoice?> GetAsync(Action<SalesInvoiceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SalesInvoice> GetAsync(Action<SalesInvoiceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SalesInvoice>(requestInfo, SalesInvoice.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property salesInvoices in financials
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SalesInvoice?> PatchAsync(SalesInvoice body, Action<SalesInvoiceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SalesInvoice> PatchAsync(SalesInvoice body, Action<SalesInvoiceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SalesInvoice>(requestInfo, SalesInvoice.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get salesInvoices from financials
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SalesInvoiceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SalesInvoiceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SalesInvoiceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property salesInvoices in financials
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(SalesInvoice body, Action<SalesInvoiceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(SalesInvoice body, Action<SalesInvoiceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SalesInvoiceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get salesInvoices from financials
        /// </summary>
        public class SalesInvoiceItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SalesInvoiceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SalesInvoiceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SalesInvoiceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new SalesInvoiceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SalesInvoiceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SalesInvoiceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new SalesInvoiceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SalesInvoiceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

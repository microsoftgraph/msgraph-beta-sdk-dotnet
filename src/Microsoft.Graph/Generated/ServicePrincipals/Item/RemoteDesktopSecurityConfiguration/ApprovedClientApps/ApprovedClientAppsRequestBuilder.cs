// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Count;
using Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps
{
    /// <summary>
    /// Provides operations to manage the approvedClientApps property of the microsoft.graph.remoteDesktopSecurityConfiguration entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApprovedClientAppsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the approvedClientApps property of the microsoft.graph.remoteDesktopSecurityConfiguration entity.</summary>
        /// <param name="position">The unique identifier of approvedClientApp</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Item.ApprovedClientAppItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Item.ApprovedClientAppItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("approvedClientApp%2Did", position);
                return new global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.Item.ApprovedClientAppItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApprovedClientAppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/remoteDesktopSecurityConfiguration/approvedClientApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApprovedClientAppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/remoteDesktopSecurityConfiguration/approvedClientApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get approvedClientApps from servicePrincipals
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApprovedClientAppCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.ApprovedClientAppCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder.ApprovedClientAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.ApprovedClientAppCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder.ApprovedClientAppsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.ApprovedClientAppCollectionResponse>(requestInfo, global::Microsoft.Graph.Beta.Models.ApprovedClientAppCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to approvedClientApps for servicePrincipals
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApprovedClientApp"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.ApprovedClientApp?> PostAsync(global::Microsoft.Graph.Beta.Models.ApprovedClientApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.ApprovedClientApp> PostAsync(global::Microsoft.Graph.Beta.Models.ApprovedClientApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.ApprovedClientApp>(requestInfo, global::Microsoft.Graph.Beta.Models.ApprovedClientApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get approvedClientApps from servicePrincipals
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder.ApprovedClientAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder.ApprovedClientAppsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to approvedClientApps for servicePrincipals
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.ApprovedClientApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.ApprovedClientApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get approvedClientApps from servicePrincipals
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ApprovedClientAppsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ApprovedClientAppsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.ApprovedClientApps.ApprovedClientAppsRequestBuilder.ApprovedClientAppsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ApprovedClientAppsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

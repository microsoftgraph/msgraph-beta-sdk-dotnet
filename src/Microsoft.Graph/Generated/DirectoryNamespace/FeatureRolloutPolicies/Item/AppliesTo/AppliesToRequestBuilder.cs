// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Count;
using Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Item;
using Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Ref;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo
{
    /// <summary>
    /// Provides operations to manage the appliesTo property of the microsoft.graph.featureRolloutPolicy entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AppliesToRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directory entities.</summary>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Microsoft.Graph.Beta.directory.featureRolloutPolicies.item.appliesTo.item collection</summary>
        /// <param name="position">The unique identifier of directoryObject</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Item.DirectoryObjectItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Item.DirectoryObjectItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("directoryObject%2Did", position);
                return new global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.Item.DirectoryObjectItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppliesToRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory/featureRolloutPolicies/{featureRolloutPolicy%2Did}/appliesTo{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppliesToRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory/featureRolloutPolicies/{featureRolloutPolicy%2Did}/appliesTo{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Nullable. Specifies a list of directoryObject resources that feature is enabled for.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder.AppliesToRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder.AppliesToRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse>(requestInfo, global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to appliesTo for directory
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObject"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject?> PostAsync(global::Microsoft.Graph.Beta.Models.DirectoryObject body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject> PostAsync(global::Microsoft.Graph.Beta.Models.DirectoryObject body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DirectoryObject>(requestInfo, global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Nullable. Specifies a list of directoryObject resources that feature is enabled for.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder.AppliesToRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder.AppliesToRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to appliesTo for directory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.DirectoryObject body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.DirectoryObject body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies. as of 2021-01/DirectoryFeatureRolloutPolicies on 2021-03-05 and will be removed 2021-06-30")]
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Nullable. Specifies a list of directoryObject resources that feature is enabled for.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AppliesToRequestBuilderGetQueryParameters 
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
        public partial class AppliesToRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.Item.AppliesTo.AppliesToRequestBuilder.AppliesToRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AppliesToRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

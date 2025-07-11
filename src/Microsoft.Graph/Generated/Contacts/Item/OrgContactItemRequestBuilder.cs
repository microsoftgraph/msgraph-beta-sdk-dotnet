// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Contacts.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.Contacts.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.Contacts.Item.DirectReports;
using Microsoft.Graph.Beta.Contacts.Item.GetMemberGroups;
using Microsoft.Graph.Beta.Contacts.Item.GetMemberObjects;
using Microsoft.Graph.Beta.Contacts.Item.Manager;
using Microsoft.Graph.Beta.Contacts.Item.MemberOf;
using Microsoft.Graph.Beta.Contacts.Item.Restore;
using Microsoft.Graph.Beta.Contacts.Item.RetryServiceProvisioning;
using Microsoft.Graph.Beta.Contacts.Item.ServiceProvisioningErrors;
using Microsoft.Graph.Beta.Contacts.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.Contacts.Item.TransitiveReports;
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
namespace Microsoft.Graph.Beta.Contacts.Item
{
    /// <summary>
    /// Provides operations to manage the collection of orgContact entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OrgContactItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder CheckMemberGroups
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder CheckMemberObjects
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directReports property of the microsoft.graph.orgContact entity.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.DirectReports.DirectReportsRequestBuilder DirectReports
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.DirectReports.DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.GetMemberGroups.GetMemberGroupsRequestBuilder GetMemberGroups
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.GetMemberObjects.GetMemberObjectsRequestBuilder GetMemberObjects
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the manager property of the microsoft.graph.orgContact entity.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.Manager.ManagerRequestBuilder Manager
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.Manager.ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.orgContact entity.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.MemberOf.MemberOfRequestBuilder MemberOf
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retryServiceProvisioning method.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.RetryServiceProvisioning.RetryServiceProvisioningRequestBuilder RetryServiceProvisioning
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.RetryServiceProvisioning.RetryServiceProvisioningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceProvisioningErrors property</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder ServiceProvisioningErrors
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.orgContact entity.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder TransitiveMemberOf
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveReports property of the microsoft.graph.orgContact entity.</summary>
        public global::Microsoft.Graph.Beta.Contacts.Item.TransitiveReports.TransitiveReportsRequestBuilder TransitiveReports
        {
            get => new global::Microsoft.Graph.Beta.Contacts.Item.TransitiveReports.TransitiveReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgContactItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contacts/{orgContact%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgContactItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contacts/{orgContact%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/orgcontact-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OrgContact"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.OrgContact?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder.OrgContactItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.OrgContact> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder.OrgContactItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.OrgContact>(requestInfo, global::Microsoft.Graph.Beta.Models.OrgContact.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder.OrgContactItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder.OrgContactItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrgContactItemRequestBuilderGetQueryParameters 
        {
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
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrgContactItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Contacts.Item.OrgContactItemRequestBuilder.OrgContactItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Organization.Item.Branding;
using Microsoft.Graph.Beta.Organization.Item.CertificateBasedAuthConfiguration;
using Microsoft.Graph.Beta.Organization.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.Organization.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.Organization.Item.Extensions;
using Microsoft.Graph.Beta.Organization.Item.GetMemberGroups;
using Microsoft.Graph.Beta.Organization.Item.GetMemberObjects;
using Microsoft.Graph.Beta.Organization.Item.PartnerInformation;
using Microsoft.Graph.Beta.Organization.Item.Restore;
using Microsoft.Graph.Beta.Organization.Item.SetMobileDeviceManagementAuthority;
using Microsoft.Graph.Beta.Organization.Item.Settings;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Organization.Item
{
    /// <summary>
    /// Provides operations to manage the collection of organization entities.
    /// </summary>
    public class OrganizationItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the branding property of the microsoft.graph.organization entity.</summary>
        public Microsoft.Graph.Beta.Organization.Item.Branding.BrandingRequestBuilder Branding
        {
            get => new Microsoft.Graph.Beta.Organization.Item.Branding.BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the certificateBasedAuthConfiguration property of the microsoft.graph.organization entity.</summary>
        public Microsoft.Graph.Beta.Organization.Item.CertificateBasedAuthConfiguration.CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration
        {
            get => new Microsoft.Graph.Beta.Organization.Item.CertificateBasedAuthConfiguration.CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder CheckMemberGroups
        {
            get => new Microsoft.Graph.Beta.Organization.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder CheckMemberObjects
        {
            get => new Microsoft.Graph.Beta.Organization.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.organization entity.</summary>
        public Microsoft.Graph.Beta.Organization.Item.Extensions.ExtensionsRequestBuilder Extensions
        {
            get => new Microsoft.Graph.Beta.Organization.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.GetMemberGroups.GetMemberGroupsRequestBuilder GetMemberGroups
        {
            get => new Microsoft.Graph.Beta.Organization.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.GetMemberObjects.GetMemberObjectsRequestBuilder GetMemberObjects
        {
            get => new Microsoft.Graph.Beta.Organization.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the partnerInformation property of the microsoft.graph.organization entity.</summary>
        public Microsoft.Graph.Beta.Organization.Item.PartnerInformation.PartnerInformationRequestBuilder PartnerInformation
        {
            get => new Microsoft.Graph.Beta.Organization.Item.PartnerInformation.PartnerInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new Microsoft.Graph.Beta.Organization.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setMobileDeviceManagementAuthority method.</summary>
        public Microsoft.Graph.Beta.Organization.Item.SetMobileDeviceManagementAuthority.SetMobileDeviceManagementAuthorityRequestBuilder SetMobileDeviceManagementAuthority
        {
            get => new Microsoft.Graph.Beta.Organization.Item.SetMobileDeviceManagementAuthority.SetMobileDeviceManagementAuthorityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.organization entity.</summary>
        public Microsoft.Graph.Beta.Organization.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new Microsoft.Graph.Beta.Organization.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organization/{organization%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organization/{organization%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete entity from organization
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the properties and relationships of the currently authenticated organization. Since the organization resource supports extensions, you can also use the GET operation to get custom properties and extension data in an organization instance.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organization-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Organization"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Organization?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder.OrganizationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Organization> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder.OrganizationItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Organization>(requestInfo, Microsoft.Graph.Beta.Models.Organization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of the currently authenticated organization. In this case, organization is defined as a collection of exactly one record, and so its ID must be specified in the request.  The ID is also known as the tenantId of the organization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organization-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Organization"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Organization?> PatchAsync(Microsoft.Graph.Beta.Models.Organization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Organization> PatchAsync(Microsoft.Graph.Beta.Models.Organization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Organization>(requestInfo, Microsoft.Graph.Beta.Models.Organization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete entity from organization
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of the currently authenticated organization. Since the organization resource supports extensions, you can also use the GET operation to get custom properties and extension data in an organization instance.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder.OrganizationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder.OrganizationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of the currently authenticated organization. In this case, organization is defined as a collection of exactly one record, and so its ID must be specified in the request.  The ID is also known as the tenantId of the organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Organization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Organization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OrganizationItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get the properties and relationships of the currently authenticated organization. Since the organization resource supports extensions, you can also use the GET operation to get custom properties and extension data in an organization instance.
        /// </summary>
        public class OrganizationItemRequestBuilderGetQueryParameters 
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
        public class OrganizationItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Organization.Item.OrganizationItemRequestBuilder.OrganizationItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OrganizationItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}

// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Activate;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Columns;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Lock;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.MigrationJobs;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.PermanentDelete;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Permissions;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.ProvisionMigrationContainers;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.RecycleBin;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Restore;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.SharePointGroups;
using Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Unlock;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item
{
    /// <summary>
    /// Provides operations to manage the deletedContainers property of the microsoft.graph.fileStorage entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FileStorageContainerItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the activate method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Activate.ActivateRequestBuilder Activate
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Activate.ActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Columns.ColumnsRequestBuilder Columns
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.DriveRequestBuilder Drive
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lock method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Lock.LockRequestBuilder Lock
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Lock.LockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the migrationJobs property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.MigrationJobs.MigrationJobsRequestBuilder MigrationJobs
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.MigrationJobs.MigrationJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the permanentDelete method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.PermanentDelete.PermanentDeleteRequestBuilder PermanentDelete
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.PermanentDelete.PermanentDeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the provisionMigrationContainers method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.ProvisionMigrationContainers.ProvisionMigrationContainersRequestBuilder ProvisionMigrationContainers
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.ProvisionMigrationContainers.ProvisionMigrationContainersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recycleBin property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.RecycleBin.RecycleBinRequestBuilder RecycleBin
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.RecycleBin.RecycleBinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharePointGroups property of the microsoft.graph.fileStorageContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.SharePointGroups.SharePointGroupsRequestBuilder SharePointGroups
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.SharePointGroups.SharePointGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unlock method.</summary>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Unlock.UnlockRequestBuilder Unlock
        {
            get => new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Unlock.UnlockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FileStorageContainerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/deletedContainers/{fileStorageContainer%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FileStorageContainerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/deletedContainers/{fileStorageContainer%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property deletedContainers for storage
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
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
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get deletedContainers from storage
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.FileStorageContainer"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.FileStorageContainer?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder.FileStorageContainerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.FileStorageContainer> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder.FileStorageContainerItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.FileStorageContainer>(requestInfo, global::Microsoft.Graph.Beta.Models.FileStorageContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property deletedContainers in storage
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.FileStorageContainer"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.FileStorageContainer?> PatchAsync(global::Microsoft.Graph.Beta.Models.FileStorageContainer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.FileStorageContainer> PatchAsync(global::Microsoft.Graph.Beta.Models.FileStorageContainer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.FileStorageContainer>(requestInfo, global::Microsoft.Graph.Beta.Models.FileStorageContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property deletedContainers for storage
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
        /// Get deletedContainers from storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder.FileStorageContainerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder.FileStorageContainerItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property deletedContainers in storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.FileStorageContainer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.FileStorageContainer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FileStorageContainerItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get deletedContainers from storage
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FileStorageContainerItemRequestBuilderGetQueryParameters 
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
        public partial class FileStorageContainerItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.FileStorageContainerItemRequestBuilder.FileStorageContainerItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FileStorageContainerItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

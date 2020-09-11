// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedEBookCategoriesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedEBookCategoriesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementManagedEBookCategoriesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedEBookCategoryRequestBuilder"/> for the specified DeviceAppManagementManagedEBookCategory.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementManagedEBookCategory.</param>
        /// <returns>The <see cref="IManagedEBookCategoryRequestBuilder"/>.</returns>
        public IManagedEBookCategoryRequestBuilder this[string id]
        {
            get
            {
                return new ManagedEBookCategoryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
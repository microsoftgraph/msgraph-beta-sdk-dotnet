// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupSettingsCollectionRequestBuilder.
    /// </summary>
    public partial class GroupSettingsCollectionRequestBuilder : BaseRequestBuilder, IGroupSettingsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupSettingsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupSettingsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupSettingsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupSettingsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupSettingsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectorySettingRequestBuilder"/> for the specified GroupDirectorySetting.
        /// </summary>
        /// <param name="id">The ID for the GroupDirectorySetting.</param>
        /// <returns>The <see cref="IDirectorySettingRequestBuilder"/>.</returns>
        public IDirectorySettingRequestBuilder this[string id]
        {
            get
            {
                return new DirectorySettingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

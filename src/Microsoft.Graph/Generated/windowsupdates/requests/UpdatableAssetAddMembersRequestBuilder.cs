// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UpdatableAssetAddMembersRequestBuilder.
    /// </summary>
    public partial class UpdatableAssetAddMembersRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<IUpdatableAssetAddMembersRequest>, IUpdatableAssetAddMembersRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UpdatableAssetAddMembersRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="assets">A assets parameter for the OData method call.</param>
        public UpdatableAssetAddMembersRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<UpdatableAsset> assets)
            : base(requestUrl, client)
        {
            this.SetParameter("assets", assets, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUpdatableAssetAddMembersRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new UpdatableAssetAddMembersRequest(functionUrl, this.Client, options);

            if (this.HasParameter("assets"))
            {
                request.RequestBody.Assets = this.GetParameter<IEnumerable<UpdatableAsset>>("assets");
            }

            return request;
        }
    }
}

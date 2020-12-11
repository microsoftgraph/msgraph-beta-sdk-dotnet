// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Threading;

namespace Microsoft.Graph
{
    public partial interface IExternalItemRequest
    {
        /// <summary>
        /// Creates the specified ExternalItem using PUT. Use this instead of CreateAsync().
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <returns>The created ExternalItem.</returns>
        System.Threading.Tasks.Task<ExternalItem> PutAsync(ExternalItem externalItemToCreate);

        /// <summary>
        /// Creates the specified ExternalItem using PUT. Use this instead of CreateAsync().
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalItem.</returns>
        System.Threading.Tasks.Task<ExternalItem> PutAsync(ExternalItem externalItemToCreate, CancellationToken cancellationToken);
    }

    public partial class ExternalItemRequest : IExternalItemRequest
    {
        /// <summary>
        /// Creates the specified ExternalItem using PUT. Use this instead of CreateAsync().
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <returns>The created ExternalItem.</returns>
        public System.Threading.Tasks.Task<ExternalItem> PutAsync(ExternalItem externalItemToCreate)
        {
            return this.PutAsync(externalItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ExternalItem using PUT. Use this instead of CreateAsync().
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalItem.</returns>
        public async System.Threading.Tasks.Task<ExternalItem> PutAsync(ExternalItem externalItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<ExternalItem>(externalItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }
    }
}
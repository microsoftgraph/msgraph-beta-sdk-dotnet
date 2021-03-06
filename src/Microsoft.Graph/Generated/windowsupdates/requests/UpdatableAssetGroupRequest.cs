// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UpdatableAssetGroupRequest.
    /// </summary>
    public partial class UpdatableAssetGroupRequest : Microsoft.Graph.BaseRequest, IUpdatableAssetGroupRequest
    {
        /// <summary>
        /// Constructs a new UpdatableAssetGroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UpdatableAssetGroupRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UpdatableAssetGroup using POST.
        /// </summary>
        /// <param name="updatableAssetGroupToCreate">The UpdatableAssetGroup to create.</param>
        /// <returns>The created UpdatableAssetGroup.</returns>
        public System.Threading.Tasks.Task<UpdatableAssetGroup> CreateAsync(UpdatableAssetGroup updatableAssetGroupToCreate)
        {
            return this.CreateAsync(updatableAssetGroupToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UpdatableAssetGroup using POST.
        /// </summary>
        /// <param name="updatableAssetGroupToCreate">The UpdatableAssetGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UpdatableAssetGroup.</returns>
        public async System.Threading.Tasks.Task<UpdatableAssetGroup> CreateAsync(UpdatableAssetGroup updatableAssetGroupToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UpdatableAssetGroup>(updatableAssetGroupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified UpdatableAssetGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UpdatableAssetGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UpdatableAssetGroup>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UpdatableAssetGroup.
        /// </summary>
        /// <returns>The UpdatableAssetGroup.</returns>
        public System.Threading.Tasks.Task<UpdatableAssetGroup> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UpdatableAssetGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UpdatableAssetGroup.</returns>
        public async System.Threading.Tasks.Task<UpdatableAssetGroup> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UpdatableAssetGroup>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UpdatableAssetGroup using PATCH.
        /// </summary>
        /// <param name="updatableAssetGroupToUpdate">The UpdatableAssetGroup to update.</param>
        /// <returns>The updated UpdatableAssetGroup.</returns>
        public System.Threading.Tasks.Task<UpdatableAssetGroup> UpdateAsync(UpdatableAssetGroup updatableAssetGroupToUpdate)
        {
            return this.UpdateAsync(updatableAssetGroupToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UpdatableAssetGroup using PATCH.
        /// </summary>
        /// <param name="updatableAssetGroupToUpdate">The UpdatableAssetGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UpdatableAssetGroup.</returns>
        public async System.Threading.Tasks.Task<UpdatableAssetGroup> UpdateAsync(UpdatableAssetGroup updatableAssetGroupToUpdate, CancellationToken cancellationToken)
        {
			if (updatableAssetGroupToUpdate.AdditionalData != null)
			{
				if (updatableAssetGroupToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					updatableAssetGroupToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, updatableAssetGroupToUpdate.GetType().Name)
						});
				}
			}
            if (updatableAssetGroupToUpdate.AdditionalData != null)
            {
                if (updatableAssetGroupToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    updatableAssetGroupToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, updatableAssetGroupToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UpdatableAssetGroup>(updatableAssetGroupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatableAssetGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatableAssetGroupRequest Expand(Expression<Func<UpdatableAssetGroup, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatableAssetGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatableAssetGroupRequest Select(Expression<Func<UpdatableAssetGroup, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="updatableAssetGroupToInitialize">The <see cref="UpdatableAssetGroup"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UpdatableAssetGroup updatableAssetGroupToInitialize)
        {

            if (updatableAssetGroupToInitialize != null && updatableAssetGroupToInitialize.AdditionalData != null)
            {

                if (updatableAssetGroupToInitialize.Members != null && updatableAssetGroupToInitialize.Members.CurrentPage != null)
                {
                    updatableAssetGroupToInitialize.Members.AdditionalData = updatableAssetGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    updatableAssetGroupToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        updatableAssetGroupToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

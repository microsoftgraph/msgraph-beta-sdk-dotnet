// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryrootRequest.
    /// </summary>
    public partial class EdiscoveryrootRequest : Microsoft.Graph.BaseRequest, IEdiscoveryrootRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryrootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryrootRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Ediscoveryroot using POST.
        /// </summary>
        /// <param name="ediscoveryrootToCreate">The Ediscoveryroot to create.</param>
        /// <returns>The created Ediscoveryroot.</returns>
        public System.Threading.Tasks.Task<Ediscoveryroot> CreateAsync(Ediscoveryroot ediscoveryrootToCreate)
        {
            return this.CreateAsync(ediscoveryrootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Ediscoveryroot using POST.
        /// </summary>
        /// <param name="ediscoveryrootToCreate">The Ediscoveryroot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> CreateAsync(Ediscoveryroot ediscoveryrootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Ediscoveryroot>(ediscoveryrootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Ediscoveryroot.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Ediscoveryroot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Ediscoveryroot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Ediscoveryroot.
        /// </summary>
        /// <returns>The Ediscoveryroot.</returns>
        public System.Threading.Tasks.Task<Ediscoveryroot> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Ediscoveryroot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Ediscoveryroot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PATCH.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot to update.</param>
        /// <returns>The updated Ediscoveryroot.</returns>
        public System.Threading.Tasks.Task<Ediscoveryroot> UpdateAsync(Ediscoveryroot ediscoveryrootToUpdate)
        {
            return this.UpdateAsync(ediscoveryrootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PATCH.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> UpdateAsync(Ediscoveryroot ediscoveryrootToUpdate, CancellationToken cancellationToken)
        {
			if (ediscoveryrootToUpdate.AdditionalData != null)
			{
				if (ediscoveryrootToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					ediscoveryrootToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, ediscoveryrootToUpdate.GetType().Name)
						});
				}
			}
            if (ediscoveryrootToUpdate.AdditionalData != null)
            {
                if (ediscoveryrootToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    ediscoveryrootToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, ediscoveryrootToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Ediscoveryroot>(ediscoveryrootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Expand(Expression<Func<Ediscoveryroot, object>> expandExpression)
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
        public IEdiscoveryrootRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Select(Expression<Func<Ediscoveryroot, object>> selectExpression)
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
        /// <param name="ediscoveryrootToInitialize">The <see cref="Ediscoveryroot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Ediscoveryroot ediscoveryrootToInitialize)
        {

            if (ediscoveryrootToInitialize != null && ediscoveryrootToInitialize.AdditionalData != null)
            {

                if (ediscoveryrootToInitialize.Cases != null && ediscoveryrootToInitialize.Cases.CurrentPage != null)
                {
                    ediscoveryrootToInitialize.Cases.AdditionalData = ediscoveryrootToInitialize.AdditionalData;

                    object nextPageLink;
                    ediscoveryrootToInitialize.AdditionalData.TryGetValue("cases@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        ediscoveryrootToInitialize.Cases.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

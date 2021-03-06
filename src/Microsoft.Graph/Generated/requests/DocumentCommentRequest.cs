// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DocumentCommentRequest.
    /// </summary>
    public partial class DocumentCommentRequest : BaseRequest, IDocumentCommentRequest
    {
        /// <summary>
        /// Constructs a new DocumentCommentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DocumentCommentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DocumentComment using POST.
        /// </summary>
        /// <param name="documentCommentToCreate">The DocumentComment to create.</param>
        /// <returns>The created DocumentComment.</returns>
        public System.Threading.Tasks.Task<DocumentComment> CreateAsync(DocumentComment documentCommentToCreate)
        {
            return this.CreateAsync(documentCommentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DocumentComment using POST.
        /// </summary>
        /// <param name="documentCommentToCreate">The DocumentComment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DocumentComment.</returns>
        public async System.Threading.Tasks.Task<DocumentComment> CreateAsync(DocumentComment documentCommentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DocumentComment>(documentCommentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DocumentComment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DocumentComment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DocumentComment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DocumentComment.
        /// </summary>
        /// <returns>The DocumentComment.</returns>
        public System.Threading.Tasks.Task<DocumentComment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DocumentComment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DocumentComment.</returns>
        public async System.Threading.Tasks.Task<DocumentComment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DocumentComment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DocumentComment using PATCH.
        /// </summary>
        /// <param name="documentCommentToUpdate">The DocumentComment to update.</param>
        /// <returns>The updated DocumentComment.</returns>
        public System.Threading.Tasks.Task<DocumentComment> UpdateAsync(DocumentComment documentCommentToUpdate)
        {
            return this.UpdateAsync(documentCommentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DocumentComment using PATCH.
        /// </summary>
        /// <param name="documentCommentToUpdate">The DocumentComment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DocumentComment.</returns>
        public async System.Threading.Tasks.Task<DocumentComment> UpdateAsync(DocumentComment documentCommentToUpdate, CancellationToken cancellationToken)
        {
			if (documentCommentToUpdate.AdditionalData != null)
			{
				if (documentCommentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					documentCommentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, documentCommentToUpdate.GetType().Name)
						});
				}
			}
            if (documentCommentToUpdate.AdditionalData != null)
            {
                if (documentCommentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    documentCommentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, documentCommentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DocumentComment>(documentCommentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDocumentCommentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDocumentCommentRequest Expand(Expression<Func<DocumentComment, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDocumentCommentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDocumentCommentRequest Select(Expression<Func<DocumentComment, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="documentCommentToInitialize">The <see cref="DocumentComment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DocumentComment documentCommentToInitialize)
        {

            if (documentCommentToInitialize != null && documentCommentToInitialize.AdditionalData != null)
            {

                if (documentCommentToInitialize.Replies != null && documentCommentToInitialize.Replies.CurrentPage != null)
                {
                    documentCommentToInitialize.Replies.AdditionalData = documentCommentToInitialize.AdditionalData;

                    object nextPageLink;
                    documentCommentToInitialize.AdditionalData.TryGetValue("replies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        documentCommentToInitialize.Replies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

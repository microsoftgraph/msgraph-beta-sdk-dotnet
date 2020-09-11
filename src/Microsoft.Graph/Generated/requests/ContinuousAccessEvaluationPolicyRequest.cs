// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ContinuousAccessEvaluationPolicyRequest.
    /// </summary>
    public partial class ContinuousAccessEvaluationPolicyRequest : BaseRequest, IContinuousAccessEvaluationPolicyRequest
    {
        /// <summary>
        /// Constructs a new ContinuousAccessEvaluationPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ContinuousAccessEvaluationPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ContinuousAccessEvaluationPolicy using POST.
        /// </summary>
        /// <param name="continuousAccessEvaluationPolicyToCreate">The ContinuousAccessEvaluationPolicy to create.</param>
        /// <returns>The created ContinuousAccessEvaluationPolicy.</returns>
        public System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> CreateAsync(ContinuousAccessEvaluationPolicy continuousAccessEvaluationPolicyToCreate)
        {
            return this.CreateAsync(continuousAccessEvaluationPolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ContinuousAccessEvaluationPolicy using POST.
        /// </summary>
        /// <param name="continuousAccessEvaluationPolicyToCreate">The ContinuousAccessEvaluationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ContinuousAccessEvaluationPolicy.</returns>
        public async System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> CreateAsync(ContinuousAccessEvaluationPolicy continuousAccessEvaluationPolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ContinuousAccessEvaluationPolicy>(continuousAccessEvaluationPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ContinuousAccessEvaluationPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <returns>The ContinuousAccessEvaluationPolicy.</returns>
        public System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ContinuousAccessEvaluationPolicy.</returns>
        public async System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ContinuousAccessEvaluationPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ContinuousAccessEvaluationPolicy using PATCH.
        /// </summary>
        /// <param name="continuousAccessEvaluationPolicyToUpdate">The ContinuousAccessEvaluationPolicy to update.</param>
        /// <returns>The updated ContinuousAccessEvaluationPolicy.</returns>
        public System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> UpdateAsync(ContinuousAccessEvaluationPolicy continuousAccessEvaluationPolicyToUpdate)
        {
            return this.UpdateAsync(continuousAccessEvaluationPolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ContinuousAccessEvaluationPolicy using PATCH.
        /// </summary>
        /// <param name="continuousAccessEvaluationPolicyToUpdate">The ContinuousAccessEvaluationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ContinuousAccessEvaluationPolicy.</returns>
        public async System.Threading.Tasks.Task<ContinuousAccessEvaluationPolicy> UpdateAsync(ContinuousAccessEvaluationPolicy continuousAccessEvaluationPolicyToUpdate, CancellationToken cancellationToken)
        {
			if (continuousAccessEvaluationPolicyToUpdate.AdditionalData != null)
			{
				if (continuousAccessEvaluationPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					continuousAccessEvaluationPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, continuousAccessEvaluationPolicyToUpdate.GetType().Name)
						});
				}
			}
            if (continuousAccessEvaluationPolicyToUpdate.AdditionalData != null)
            {
                if (continuousAccessEvaluationPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    continuousAccessEvaluationPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, continuousAccessEvaluationPolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ContinuousAccessEvaluationPolicy>(continuousAccessEvaluationPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IContinuousAccessEvaluationPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IContinuousAccessEvaluationPolicyRequest Expand(Expression<Func<ContinuousAccessEvaluationPolicy, object>> expandExpression)
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
        public IContinuousAccessEvaluationPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IContinuousAccessEvaluationPolicyRequest Select(Expression<Func<ContinuousAccessEvaluationPolicy, object>> selectExpression)
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
        /// <param name="continuousAccessEvaluationPolicyToInitialize">The <see cref="ContinuousAccessEvaluationPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ContinuousAccessEvaluationPolicy continuousAccessEvaluationPolicyToInitialize)
        {

        }
    }
}
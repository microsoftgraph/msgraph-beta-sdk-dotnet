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
    /// The type IosikEv2VpnConfigurationRequest.
    /// </summary>
    public partial class IosikEv2VpnConfigurationRequest : BaseRequest, IIosikEv2VpnConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosikEv2VpnConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosikEv2VpnConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosikEv2VpnConfiguration using POST.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToCreate">The IosikEv2VpnConfiguration to create.</param>
        /// <returns>The created IosikEv2VpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosikEv2VpnConfiguration> CreateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToCreate)
        {
            return this.CreateAsync(iosikEv2VpnConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosikEv2VpnConfiguration using POST.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToCreate">The IosikEv2VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosikEv2VpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosikEv2VpnConfiguration> CreateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosikEv2VpnConfiguration>(iosikEv2VpnConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosikEv2VpnConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <returns>The IosikEv2VpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosikEv2VpnConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosikEv2VpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosikEv2VpnConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosikEv2VpnConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration to update.</param>
        /// <returns>The updated IosikEv2VpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosikEv2VpnConfiguration> UpdateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate)
        {
            return this.UpdateAsync(iosikEv2VpnConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosikEv2VpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosikEv2VpnConfiguration> UpdateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (iosikEv2VpnConfigurationToUpdate.AdditionalData != null)
			{
				if (iosikEv2VpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosikEv2VpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosikEv2VpnConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (iosikEv2VpnConfigurationToUpdate.AdditionalData != null)
            {
                if (iosikEv2VpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosikEv2VpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosikEv2VpnConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosikEv2VpnConfiguration>(iosikEv2VpnConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosikEv2VpnConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosikEv2VpnConfigurationRequest Expand(Expression<Func<IosikEv2VpnConfiguration, object>> expandExpression)
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
        public IIosikEv2VpnConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosikEv2VpnConfigurationRequest Select(Expression<Func<IosikEv2VpnConfiguration, object>> selectExpression)
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
        /// <param name="iosikEv2VpnConfigurationToInitialize">The <see cref="IosikEv2VpnConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToInitialize)
        {

        }
    }
}
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
    /// The type WindowsPhone81GeneralConfigurationRequest.
    /// </summary>
    public partial class WindowsPhone81GeneralConfigurationRequest : BaseRequest, IWindowsPhone81GeneralConfigurationRequest
    {
        /// <summary>
        /// Constructs a new WindowsPhone81GeneralConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsPhone81GeneralConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsPhone81GeneralConfiguration using POST.
        /// </summary>
        /// <param name="windowsPhone81GeneralConfigurationToCreate">The WindowsPhone81GeneralConfiguration to create.</param>
        /// <returns>The created WindowsPhone81GeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> CreateAsync(WindowsPhone81GeneralConfiguration windowsPhone81GeneralConfigurationToCreate)
        {
            return this.CreateAsync(windowsPhone81GeneralConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsPhone81GeneralConfiguration using POST.
        /// </summary>
        /// <param name="windowsPhone81GeneralConfigurationToCreate">The WindowsPhone81GeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81GeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> CreateAsync(WindowsPhone81GeneralConfiguration windowsPhone81GeneralConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsPhone81GeneralConfiguration>(windowsPhone81GeneralConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81GeneralConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsPhone81GeneralConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsPhone81GeneralConfiguration.
        /// </summary>
        /// <returns>The WindowsPhone81GeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsPhone81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81GeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsPhone81GeneralConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsPhone81GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsPhone81GeneralConfigurationToUpdate">The WindowsPhone81GeneralConfiguration to update.</param>
        /// <returns>The updated WindowsPhone81GeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> UpdateAsync(WindowsPhone81GeneralConfiguration windowsPhone81GeneralConfigurationToUpdate)
        {
            return this.UpdateAsync(windowsPhone81GeneralConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsPhone81GeneralConfigurationToUpdate">The WindowsPhone81GeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81GeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81GeneralConfiguration> UpdateAsync(WindowsPhone81GeneralConfiguration windowsPhone81GeneralConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (windowsPhone81GeneralConfigurationToUpdate.AdditionalData != null)
			{
				if (windowsPhone81GeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsPhone81GeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsPhone81GeneralConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (windowsPhone81GeneralConfigurationToUpdate.AdditionalData != null)
            {
                if (windowsPhone81GeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsPhone81GeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsPhone81GeneralConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsPhone81GeneralConfiguration>(windowsPhone81GeneralConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81GeneralConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81GeneralConfigurationRequest Expand(Expression<Func<WindowsPhone81GeneralConfiguration, object>> expandExpression)
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
        public IWindowsPhone81GeneralConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81GeneralConfigurationRequest Select(Expression<Func<WindowsPhone81GeneralConfiguration, object>> selectExpression)
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
        /// <param name="windowsPhone81GeneralConfigurationToInitialize">The <see cref="WindowsPhone81GeneralConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsPhone81GeneralConfiguration windowsPhone81GeneralConfigurationToInitialize)
        {

        }
    }
}

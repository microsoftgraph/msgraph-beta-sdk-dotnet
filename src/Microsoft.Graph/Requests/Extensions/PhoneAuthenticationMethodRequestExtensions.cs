
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;


    public partial interface IPhoneAuthenticationMethodRequest
    {
        /// <summary>
        /// Updates the specified PhoneAuthenticationMethod using PUT.
        /// </summary>
        /// <param name="phoneAuthenticationMethodToUpdate">The PhoneAuthenticationMethod to update.</param>
        /// <returns>The updated PhoneAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PhoneAuthenticationMethod> PutAsync(PhoneAuthenticationMethod phoneAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified PhoneAuthenticationMethod using PUT.
        /// </summary>
        /// <param name="phoneAuthenticationMethodToUpdate">The PhoneAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PhoneAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PhoneAuthenticationMethod> PutAsync(PhoneAuthenticationMethod phoneAuthenticationMethodToUpdate, CancellationToken cancellationToken);
    }

    public partial class PhoneAuthenticationMethodRequest
    {
        /// <summary>
        /// Updates the specified PhoneAuthenticationMethod using PUT.
        /// </summary>
        /// <param name="phoneAuthenticationMethodToUpdate">The PhoneAuthenticationMethod to update.</param>
        /// <returns>The updated PhoneAuthenticationMethod.</returns>
        public System.Threading.Tasks.Task<PhoneAuthenticationMethod> PutAsync(PhoneAuthenticationMethod phoneAuthenticationMethodToUpdate)
        {
            return this.PutAsync(phoneAuthenticationMethodToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PhoneAuthenticationMethod using PUT.
        /// </summary>
        /// <param name="phoneAuthenticationMethodToUpdate">The PhoneAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PhoneAuthenticationMethod.</returns>
        public async System.Threading.Tasks.Task<PhoneAuthenticationMethod> PutAsync(PhoneAuthenticationMethod phoneAuthenticationMethodToUpdate, CancellationToken cancellationToken)
        {
            if (phoneAuthenticationMethodToUpdate.AdditionalData != null)
            {
                if (phoneAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    phoneAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, phoneAuthenticationMethodToUpdate.GetType().Name)
                        });
                }
            }
            if (phoneAuthenticationMethodToUpdate.AdditionalData != null)
            {
                if (phoneAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    phoneAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, phoneAuthenticationMethodToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PUT";
            var updatedEntity = await this.SendAsync<PhoneAuthenticationMethod>(phoneAuthenticationMethodToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }
    }

}

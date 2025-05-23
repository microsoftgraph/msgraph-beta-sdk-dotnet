// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes
{
    /// <summary>
    /// Provides operations to call the creationOptions method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/authentication/fido2Methods/creationOptions(challengeTimeoutInMinutes=@challengeTimeoutInMinutes){?challengeTimeoutInMinutes*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/authentication/fido2Methods/creationOptions(challengeTimeoutInMinutes=@challengeTimeoutInMinutes){?challengeTimeoutInMinutes*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve creation options required to generate and register a Microsoft Entra ID-compatible passkey. Self-service operations aren&apos;t supported.  
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/fido2authenticationmethod-creationoptions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WebauthnCredentialCreationOptions"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.WebauthnCredentialCreationOptions?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.WebauthnCredentialCreationOptions> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.WebauthnCredentialCreationOptions>(requestInfo, global::Microsoft.Graph.Beta.Models.WebauthnCredentialCreationOptions.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve creation options required to generate and register a Microsoft Entra ID-compatible passkey. Self-service operations aren&apos;t supported.  
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve creation options required to generate and register a Microsoft Entra ID-compatible passkey. Self-service operations aren&apos;t supported.  
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters 
        {
            /// <summary>Usage: challengeTimeoutInMinutes=@challengeTimeoutInMinutes</summary>
            [QueryParameter("challengeTimeoutInMinutes")]
            public int? ChallengeTimeoutInMinutes { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Authentication.Fido2Methods.CreationOptionsWithChallengeTimeoutInMinutes.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilder.CreationOptionsWithChallengeTimeoutInMinutesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

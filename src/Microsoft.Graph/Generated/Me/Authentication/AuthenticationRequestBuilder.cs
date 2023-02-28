using Microsoft.Graph.Beta.Me.Authentication.EmailMethods;
using Microsoft.Graph.Beta.Me.Authentication.Fido2Methods;
using Microsoft.Graph.Beta.Me.Authentication.Methods;
using Microsoft.Graph.Beta.Me.Authentication.MicrosoftAuthenticatorMethods;
using Microsoft.Graph.Beta.Me.Authentication.Operations;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods;
using Microsoft.Graph.Beta.Me.Authentication.PasswordMethods;
using Microsoft.Graph.Beta.Me.Authentication.PhoneMethods;
using Microsoft.Graph.Beta.Me.Authentication.SoftwareOathMethods;
using Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods;
using Microsoft.Graph.Beta.Me.Authentication.WindowsHelloForBusinessMethods;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Me.Authentication {
    /// <summary>
    /// Provides operations to manage the authentication property of the microsoft.graph.user entity.
    /// </summary>
    public class AuthenticationRequestBuilder {
        /// <summary>Provides operations to manage the emailMethods property of the microsoft.graph.authentication entity.</summary>
        public EmailMethodsRequestBuilder EmailMethods { get =>
            new EmailMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the fido2Methods property of the microsoft.graph.authentication entity.</summary>
        public Fido2MethodsRequestBuilder Fido2Methods { get =>
            new Fido2MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the methods property of the microsoft.graph.authentication entity.</summary>
        public MethodsRequestBuilder Methods { get =>
            new MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftAuthenticatorMethods property of the microsoft.graph.authentication entity.</summary>
        public MicrosoftAuthenticatorMethodsRequestBuilder MicrosoftAuthenticatorMethods { get =>
            new MicrosoftAuthenticatorMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.authentication entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passwordlessMicrosoftAuthenticatorMethods property of the microsoft.graph.authentication entity.</summary>
        public PasswordlessMicrosoftAuthenticatorMethodsRequestBuilder PasswordlessMicrosoftAuthenticatorMethods { get =>
            new PasswordlessMicrosoftAuthenticatorMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passwordMethods property of the microsoft.graph.authentication entity.</summary>
        public PasswordMethodsRequestBuilder PasswordMethods { get =>
            new PasswordMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the phoneMethods property of the microsoft.graph.authentication entity.</summary>
        public PhoneMethodsRequestBuilder PhoneMethods { get =>
            new PhoneMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the softwareOathMethods property of the microsoft.graph.authentication entity.</summary>
        public SoftwareOathMethodsRequestBuilder SoftwareOathMethods { get =>
            new SoftwareOathMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the temporaryAccessPassMethods property of the microsoft.graph.authentication entity.</summary>
        public TemporaryAccessPassMethodsRequestBuilder TemporaryAccessPassMethods { get =>
            new TemporaryAccessPassMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the windowsHelloForBusinessMethods property of the microsoft.graph.authentication entity.</summary>
        public WindowsHelloForBusinessMethodsRequestBuilder WindowsHelloForBusinessMethods { get =>
            new WindowsHelloForBusinessMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AuthenticationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AuthenticationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AuthenticationRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AuthenticationRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get authentication from me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Authentication?> GetAsync(Action<AuthenticationRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Authentication> GetAsync(Action<AuthenticationRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Authentication>(requestInfo, Microsoft.Graph.Beta.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Authentication?> PatchAsync(Microsoft.Graph.Beta.Models.Authentication body, Action<AuthenticationRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Authentication> PatchAsync(Microsoft.Graph.Beta.Models.Authentication body, Action<AuthenticationRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Authentication>(requestInfo, Microsoft.Graph.Beta.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AuthenticationRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AuthenticationRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get authentication from me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AuthenticationRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AuthenticationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Authentication body, Action<AuthenticationRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Authentication body, Action<AuthenticationRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new authenticationRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get authentication from me
        /// </summary>
        public class AuthenticationRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AuthenticationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AuthenticationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new authenticationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new authenticationRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

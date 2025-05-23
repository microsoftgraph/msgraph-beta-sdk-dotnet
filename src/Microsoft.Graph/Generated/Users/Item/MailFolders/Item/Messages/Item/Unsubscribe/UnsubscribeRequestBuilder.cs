// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe
{
    /// <summary>
    /// Provides operations to call the unsubscribe method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnsubscribeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe.UnsubscribeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnsubscribeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/messages/{message%2Did}/unsubscribe", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe.UnsubscribeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnsubscribeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/messages/{message%2Did}/unsubscribe", rawUrl)
        {
        }
        /// <summary>
        /// Submits an email request on behalf of the signed-in user to unsubscribe from an email distribution list. Uses the information in the List-Unsubscribe header. Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out. They can do so by specifying the List-Unsubscribe header in each message following RFC-2369. Note In particular, for the unsubscribe action to work, the sender must specify mailto: and not URL-based unsubscribe information. Setting that header would also set the unsubscribeEnabled property of the message instance to true, and the unsubscribeData property to the header data. If the unsubscribeEnabled property of a message is true, you can use the unsubscribe action to unsubscribe the user from similar future messages as managed by the message sender. A successful unsubscribe action moves the message to the Deleted Items folder. The actual exclusion of the user from future mail distribution is managed by the sender.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/message-unsubscribe?view=graph-rest-beta" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Submits an email request on behalf of the signed-in user to unsubscribe from an email distribution list. Uses the information in the List-Unsubscribe header. Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out. They can do so by specifying the List-Unsubscribe header in each message following RFC-2369. Note In particular, for the unsubscribe action to work, the sender must specify mailto: and not URL-based unsubscribe information. Setting that header would also set the unsubscribeEnabled property of the message instance to true, and the unsubscribeData property to the header data. If the unsubscribeEnabled property of a message is true, you can use the unsubscribe action to unsubscribe the user from similar future messages as managed by the message sender. A successful unsubscribe action moves the message to the Deleted Items folder. The actual exclusion of the user from future mail distribution is managed by the sender.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe.UnsubscribeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe.UnsubscribeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.Unsubscribe.UnsubscribeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnsubscribeRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

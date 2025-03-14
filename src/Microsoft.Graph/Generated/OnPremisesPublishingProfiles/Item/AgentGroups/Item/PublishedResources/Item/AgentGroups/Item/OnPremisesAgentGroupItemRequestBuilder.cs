// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \onPremisesPublishingProfiles\{onPremisesPublishingProfile-id}\agentGroups\{onPremisesAgentGroup-id}\publishedResources\{publishedResource-id}\agentGroups\{onPremisesAgentGroup-id1}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnPremisesAgentGroupItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item.OnPremisesAgentGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnPremisesAgentGroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/{onPremisesAgentGroup%2Did1}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Item.OnPremisesAgentGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnPremisesAgentGroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/{onPremisesAgentGroup%2Did1}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

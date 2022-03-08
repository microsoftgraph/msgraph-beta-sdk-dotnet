using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
    public class PublishedResource : Entity, IParsable {
        /// <summary>List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups { get; set; }
        /// <summary>Display Name of the publishedResource.</summary>
        public string DisplayName { get; set; }
        /// <summary>Possible values are: applicationProxy, exchangeOnline, authentication, provisioning, adAdministration.</summary>
        public OnPremisesPublishingType? PublishingType { get; set; }
        /// <summary>Name of the publishedResource.</summary>
        public string ResourceName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PublishedResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublishedResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agentGroups", (o,n) => { (o as PublishedResource).AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as PublishedResource).DisplayName = n.GetStringValue(); } },
                {"publishingType", (o,n) => { (o as PublishedResource).PublishingType = n.GetEnumValue<OnPremisesPublishingType>(); } },
                {"resourceName", (o,n) => { (o as PublishedResource).ResourceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgentGroup>("agentGroups", AgentGroups);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<OnPremisesPublishingType>("publishingType", PublishingType);
            writer.WriteStringValue("resourceName", ResourceName);
        }
    }
}

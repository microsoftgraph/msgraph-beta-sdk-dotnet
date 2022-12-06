using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class PublishedResource : Entity, IParsable {
        /// <summary>List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups {
            get { return BackingStore?.Get<List<OnPremisesAgentGroup>>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
        /// <summary>Display Name of the publishedResource.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The publishingType property</summary>
        public OnPremisesPublishingType? PublishingType {
            get { return BackingStore?.Get<OnPremisesPublishingType?>("publishingType"); }
            set { BackingStore?.Set("publishingType", value); }
        }
        /// <summary>Name of the publishedResource.</summary>
        public string ResourceName {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PublishedResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublishedResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"publishingType", n => { PublishingType = n.GetEnumValue<OnPremisesPublishingType>(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

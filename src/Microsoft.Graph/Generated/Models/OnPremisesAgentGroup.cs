using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
    public class OnPremisesAgentGroup : Entity, IParsable {
        /// <summary>List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
        public List<OnPremisesAgent> Agents {
            get { return BackingStore?.Get<List<OnPremisesAgent>>(nameof(Agents)); }
            set { BackingStore?.Set(nameof(Agents), value); }
        }
        /// <summary>Display name of the onPremisesAgentGroup.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
        public List<PublishedResource> PublishedResources {
            get { return BackingStore?.Get<List<PublishedResource>>(nameof(PublishedResources)); }
            set { BackingStore?.Set(nameof(PublishedResources), value); }
        }
        /// <summary>Possible values are: applicationProxy, exchangeOnline, authentication, provisioning, adAdministration.</summary>
        public OnPremisesPublishingType? PublishingType {
            get { return BackingStore?.Get<OnPremisesPublishingType?>(nameof(PublishingType)); }
            set { BackingStore?.Set(nameof(PublishingType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnPremisesAgentGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgentGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agents", n => { Agents = n.GetCollectionOfObjectValues<OnPremisesAgent>(OnPremisesAgent.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"publishedResources", n => { PublishedResources = n.GetCollectionOfObjectValues<PublishedResource>(PublishedResource.CreateFromDiscriminatorValue).ToList(); } },
                {"publishingType", n => { PublishingType = n.GetEnumValue<OnPremisesPublishingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgent>("agents", Agents);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteCollectionOfObjectValues<PublishedResource>("publishedResources", PublishedResources);
            writer.WriteEnumValue<OnPremisesPublishingType>("publishingType", PublishingType);
        }
    }
}

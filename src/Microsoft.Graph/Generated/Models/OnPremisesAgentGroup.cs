using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesAgentGroup : Entity, IParsable {
        /// <summary>List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesAgent>? Agents {
            get { return BackingStore?.Get<List<OnPremisesAgent>?>("agents"); }
            set { BackingStore?.Set("agents", value); }
        }
#nullable restore
#else
        public List<OnPremisesAgent> Agents {
            get { return BackingStore?.Get<List<OnPremisesAgent>>("agents"); }
            set { BackingStore?.Set("agents", value); }
        }
#endif
        /// <summary>Display name of the onPremisesAgentGroup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PublishedResource>? PublishedResources {
            get { return BackingStore?.Get<List<PublishedResource>?>("publishedResources"); }
            set { BackingStore?.Set("publishedResources", value); }
        }
#nullable restore
#else
        public List<PublishedResource> PublishedResources {
            get { return BackingStore?.Get<List<PublishedResource>>("publishedResources"); }
            set { BackingStore?.Set("publishedResources", value); }
        }
#endif
        /// <summary>The publishingType property</summary>
        public OnPremisesPublishingType? PublishingType {
            get { return BackingStore?.Get<OnPremisesPublishingType?>("publishingType"); }
            set { BackingStore?.Set("publishingType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnPremisesAgentGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgentGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agents", n => { Agents = n.GetCollectionOfObjectValues<OnPremisesAgent>(OnPremisesAgent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"publishedResources", n => { PublishedResources = n.GetCollectionOfObjectValues<PublishedResource>(PublishedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publishingType", n => { PublishingType = n.GetEnumValue<OnPremisesPublishingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

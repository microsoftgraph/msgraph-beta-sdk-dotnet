using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes a relationship between two mobile apps.</summary>
    public class MobileAppRelationship : Entity, IParsable {
        /// <summary>The target mobile app&apos;s display name.</summary>
        public string TargetDisplayName {
            get { return BackingStore?.Get<string>(nameof(TargetDisplayName)); }
            set { BackingStore?.Set(nameof(TargetDisplayName), value); }
        }
        /// <summary>The target mobile app&apos;s display version.</summary>
        public string TargetDisplayVersion {
            get { return BackingStore?.Get<string>(nameof(TargetDisplayVersion)); }
            set { BackingStore?.Set(nameof(TargetDisplayVersion), value); }
        }
        /// <summary>The target mobile app&apos;s app id.</summary>
        public string TargetId {
            get { return BackingStore?.Get<string>(nameof(TargetId)); }
            set { BackingStore?.Set(nameof(TargetId), value); }
        }
        /// <summary>The target mobile app&apos;s publisher.</summary>
        public string TargetPublisher {
            get { return BackingStore?.Get<string>(nameof(TargetPublisher)); }
            set { BackingStore?.Set(nameof(TargetPublisher), value); }
        }
        /// <summary>The type of relationship indicating whether the target is a parent or child. Possible values are: child, parent.</summary>
        public MobileAppRelationshipType? TargetType {
            get { return BackingStore?.Get<MobileAppRelationshipType?>(nameof(TargetType)); }
            set { BackingStore?.Set(nameof(TargetType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mobileAppDependency" => new MobileAppDependency(),
                "#microsoft.graph.mobileAppSupersedence" => new MobileAppSupersedence(),
                _ => new MobileAppRelationship(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetDisplayName", n => { TargetDisplayName = n.GetStringValue(); } },
                {"targetDisplayVersion", n => { TargetDisplayVersion = n.GetStringValue(); } },
                {"targetId", n => { TargetId = n.GetStringValue(); } },
                {"targetPublisher", n => { TargetPublisher = n.GetStringValue(); } },
                {"targetType", n => { TargetType = n.GetEnumValue<MobileAppRelationshipType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetDisplayName", TargetDisplayName);
            writer.WriteStringValue("targetDisplayVersion", TargetDisplayVersion);
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteStringValue("targetPublisher", TargetPublisher);
            writer.WriteEnumValue<MobileAppRelationshipType>("targetType", TargetType);
        }
    }
}

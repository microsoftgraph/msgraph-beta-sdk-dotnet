using Microsoft.Graph.Beta.Models;
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
            get { return BackingStore?.Get<string>("targetDisplayName"); }
            set { BackingStore?.Set("targetDisplayName", value); }
        }
        /// <summary>The target mobile app&apos;s display version.</summary>
        public string TargetDisplayVersion {
            get { return BackingStore?.Get<string>("targetDisplayVersion"); }
            set { BackingStore?.Set("targetDisplayVersion", value); }
        }
        /// <summary>The target mobile app&apos;s app id.</summary>
        public string TargetId {
            get { return BackingStore?.Get<string>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
        /// <summary>The target mobile app&apos;s publisher.</summary>
        public string TargetPublisher {
            get { return BackingStore?.Get<string>("targetPublisher"); }
            set { BackingStore?.Set("targetPublisher", value); }
        }
        /// <summary>Indicates whether the target of a relationship is the parent or the child in the relationship.</summary>
        public MobileAppRelationshipType? TargetType {
            get { return BackingStore?.Get<MobileAppRelationshipType?>("targetType"); }
            set { BackingStore?.Set("targetType", value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppRelationship and sets the default values.
        /// </summary>
        public MobileAppRelationship() : base() {
            OdataType = "#microsoft.graph.mobileAppRelationship";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppRelationship : Entity, IParsable {
        /// <summary>The target mobile app&apos;s display name.</summary>
        public string TargetDisplayName { get; set; }
        /// <summary>The target mobile app&apos;s display version.</summary>
        public string TargetDisplayVersion { get; set; }
        /// <summary>The target mobile app&apos;s app id.</summary>
        public string TargetId { get; set; }
        /// <summary>The target mobile app&apos;s publisher.</summary>
        public string TargetPublisher { get; set; }
        /// <summary>The type of relationship indicating whether the target is a parent or child. Possible values are: child, parent.</summary>
        public MobileAppRelationshipType? TargetType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppRelationship();
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

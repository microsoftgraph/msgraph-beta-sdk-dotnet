using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MobileAppRelationship : Entity, IParsable {
        /// <summary>The target mobile app's display name.</summary>
        public string TargetDisplayName { get; set; }
        /// <summary>The target mobile app's display version.</summary>
        public string TargetDisplayVersion { get; set; }
        /// <summary>The target mobile app's app id.</summary>
        public string TargetId { get; set; }
        /// <summary>The target mobile app's publisher.</summary>
        public string TargetPublisher { get; set; }
        /// <summary>The type of relationship indicating whether the target is a parent or child. Possible values are: child, parent.</summary>
        public MobileAppRelationshipType? TargetType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"targetDisplayName", (o,n) => { (o as MobileAppRelationship).TargetDisplayName = n.GetStringValue(); } },
                {"targetDisplayVersion", (o,n) => { (o as MobileAppRelationship).TargetDisplayVersion = n.GetStringValue(); } },
                {"targetId", (o,n) => { (o as MobileAppRelationship).TargetId = n.GetStringValue(); } },
                {"targetPublisher", (o,n) => { (o as MobileAppRelationship).TargetPublisher = n.GetStringValue(); } },
                {"targetType", (o,n) => { (o as MobileAppRelationship).TargetType = n.GetEnumValue<MobileAppRelationshipType>(); } },
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

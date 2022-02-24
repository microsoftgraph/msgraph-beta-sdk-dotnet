using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ConfigManagerCollection : Entity, IParsable {
        /// <summary>The collection identifier in SCCM.</summary>
        public string CollectionIdentifier { get; set; }
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The DisplayName.</summary>
        public string DisplayName { get; set; }
        /// <summary>The Hierarchy Identifier.</summary>
        public string HierarchyIdentifier { get; set; }
        /// <summary>The HierarchyName.</summary>
        public string HierarchyName { get; set; }
        /// <summary>The last modified date.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"collectionIdentifier", (o,n) => { (o as ConfigManagerCollection).CollectionIdentifier = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ConfigManagerCollection).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as ConfigManagerCollection).DisplayName = n.GetStringValue(); } },
                {"hierarchyIdentifier", (o,n) => { (o as ConfigManagerCollection).HierarchyIdentifier = n.GetStringValue(); } },
                {"hierarchyName", (o,n) => { (o as ConfigManagerCollection).HierarchyName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ConfigManagerCollection).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("collectionIdentifier", CollectionIdentifier);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("hierarchyIdentifier", HierarchyIdentifier);
            writer.WriteStringValue("hierarchyName", HierarchyName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}

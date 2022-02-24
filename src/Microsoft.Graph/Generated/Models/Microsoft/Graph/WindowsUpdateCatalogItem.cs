using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WindowsUpdateCatalogItem : Entity, IParsable {
        /// <summary>The display name for the catalog item.</summary>
        public string DisplayName { get; set; }
        /// <summary>The last supported date for a catalog item</summary>
        public DateTimeOffset? EndOfSupportDate { get; set; }
        /// <summary>The date the catalog item was released</summary>
        public DateTimeOffset? ReleaseDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as WindowsUpdateCatalogItem).DisplayName = n.GetStringValue(); } },
                {"endOfSupportDate", (o,n) => { (o as WindowsUpdateCatalogItem).EndOfSupportDate = n.GetDateTimeOffsetValue(); } },
                {"releaseDateTime", (o,n) => { (o as WindowsUpdateCatalogItem).ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endOfSupportDate", EndOfSupportDate);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
        }
    }
}

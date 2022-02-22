using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates {
    public class CatalogEntry : Entity, IParsable {
        /// <summary>The date on which the content is no longer available to deploy using the service. Read-only.</summary>
        public DateTimeOffset? DeployableUntilDateTime { get; set; }
        /// <summary>The display name of the content. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The release date for the content. Read-only.</summary>
        public DateTimeOffset? ReleaseDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deployableUntilDateTime", (o,n) => { (o as CatalogEntry).DeployableUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as CatalogEntry).DisplayName = n.GetStringValue(); } },
                {"releaseDateTime", (o,n) => { (o as CatalogEntry).ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("deployableUntilDateTime", DeployableUntilDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
        }
    }
}

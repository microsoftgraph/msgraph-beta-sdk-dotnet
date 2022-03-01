using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Search {
    public class SearchAnswer : Entity, IParsable {
        /// <summary>Search answer description shown on search results page.</summary>
        public string Description { get; set; }
        /// <summary>Search answer name displayed in search results.</summary>
        public string DisplayName { get; set; }
        /// <summary>Details of the user that created or last modified the search answer. Read-only.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Timestamp of when the search answer is created or edited. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Search answer URL link. When users click this search answer in search results, they will go to this URL.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as SearchAnswer).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SearchAnswer).DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as SearchAnswer).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SearchAnswer).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"webUrl", (o,n) => { (o as SearchAnswer).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}

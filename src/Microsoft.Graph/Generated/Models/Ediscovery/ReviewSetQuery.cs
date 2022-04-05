using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class ReviewSetQuery : Entity, IParsable {
        /// <summary>The user who created the query.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy { get; set; }
        /// <summary>The time and date when the query was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of the query.</summary>
        public string DisplayName { get; set; }
        /// <summary>The user who last modified the query.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy { get; set; }
        /// <summary>The date and time the query was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The query string in KQL (Keyword Query Language) query. For details, see Document metadata fields in Advanced eDiscovery.  This field maps directly to the keywords condition.  You can refine searches by using fields listed in the searchable field name paired with values; for example, subject:&apos;Quarterly Financials&apos; AND Date&gt;=06/01/2016 AND Date&lt;=07/01/2016.</summary>
        public string Query { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ReviewSetQuery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReviewSetQuery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as ReviewSetQuery).CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as ReviewSetQuery).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as ReviewSetQuery).DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as ReviewSetQuery).LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as ReviewSetQuery).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"query", (o,n) => { (o as ReviewSetQuery).Query = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("query", Query);
        }
    }
}

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class PersonAward : ItemFacet, IParsable {
        /// <summary>Descpription of the award or honor.</summary>
        public string Description { get; set; }
        /// <summary>Name of the award or honor.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date that the award or honor was granted.</summary>
        public Date? IssuedDate { get; set; }
        /// <summary>Authority which granted the award or honor.</summary>
        public string IssuingAuthority { get; set; }
        /// <summary>URL referencing a thumbnail of the award or honor.</summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>URL referencing the award or honor.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PersonAward CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonAward();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as PersonAward).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PersonAward).DisplayName = n.GetStringValue(); } },
                {"issuedDate", (o,n) => { (o as PersonAward).IssuedDate = n.GetDateValue(); } },
                {"issuingAuthority", (o,n) => { (o as PersonAward).IssuingAuthority = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as PersonAward).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as PersonAward).WebUrl = n.GetStringValue(); } },
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
            writer.WriteDateValue("issuedDate", IssuedDate);
            writer.WriteStringValue("issuingAuthority", IssuingAuthority);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}

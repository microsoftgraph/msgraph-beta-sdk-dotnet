using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class UserSource : DataSource, IParsable {
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The includedSources property</summary>
        public SourceType? IncludedSources { get; set; }
        /// <summary>The siteWebUrl property</summary>
        public string SiteWebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"email", n => { Email = n.GetStringValue(); } },
                {"includedSources", n => { IncludedSources = n.GetEnumValue<SourceType>(); } },
                {"siteWebUrl", n => { SiteWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("email", Email);
            writer.WriteEnumValue<SourceType>("includedSources", IncludedSources);
            writer.WriteStringValue("siteWebUrl", SiteWebUrl);
        }
    }
}

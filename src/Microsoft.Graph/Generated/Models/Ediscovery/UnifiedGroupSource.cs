using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class UnifiedGroupSource : DataSource, IParsable {
        /// <summary>The group property</summary>
        public Microsoft.Graph.Beta.Models.Group Group { get; set; }
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public SourceType? IncludedSources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedGroupSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"group", (o,n) => { (o as UnifiedGroupSource).Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"includedSources", (o,n) => { (o as UnifiedGroupSource).IncludedSources = n.GetEnumValue<SourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteEnumValue<SourceType>("includedSources", IncludedSources);
        }
    }
}

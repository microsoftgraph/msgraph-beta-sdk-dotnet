using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class UnifiedGroupSource : DataSource, IParsable {
        /// <summary>The group property</summary>
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>(nameof(Group)); }
            set { BackingStore?.Set(nameof(Group), value); }
        }
        /// <summary>The includedSources property</summary>
        public SourceType? IncludedSources {
            get { return BackingStore?.Get<SourceType?>(nameof(IncludedSources)); }
            set { BackingStore?.Set(nameof(IncludedSources), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"includedSources", n => { IncludedSources = n.GetEnumValue<SourceType>(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProtectSite : LabelActionBase, IParsable {
        /// <summary>The accessType property</summary>
        public SiteAccessType? AccessType {
            get { return BackingStore?.Get<SiteAccessType?>("accessType"); }
            set { BackingStore?.Set("accessType", value); }
        }
        /// <summary>The conditionalAccessProtectionLevelId property</summary>
        public string ConditionalAccessProtectionLevelId {
            get { return BackingStore?.Get<string>("conditionalAccessProtectionLevelId"); }
            set { BackingStore?.Set("conditionalAccessProtectionLevelId", value); }
        }
        /// <summary>
        /// Instantiates a new ProtectSite and sets the default values.
        /// </summary>
        public ProtectSite() : base() {
            OdataType = "#microsoft.graph.protectSite";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProtectSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessType", n => { AccessType = n.GetEnumValue<SiteAccessType>(); } },
                {"conditionalAccessProtectionLevelId", n => { ConditionalAccessProtectionLevelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SiteAccessType>("accessType", AccessType);
            writer.WriteStringValue("conditionalAccessProtectionLevelId", ConditionalAccessProtectionLevelId);
        }
    }
}

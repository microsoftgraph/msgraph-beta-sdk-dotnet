using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Warranty status entity for a given OEM</summary>
    public class OemWarrantyInformationOnboarding : Entity, IParsable {
        /// <summary>Specifies whether warranty API is available. This property is read-only.</summary>
        public bool? Available {
            get { return BackingStore?.Get<bool?>("available"); }
            set { BackingStore?.Set("available", value); }
        }
        /// <summary>Specifies whether warranty query is enabled for given OEM. This property is read-only.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>OEM name. This property is read-only.</summary>
        public string OemName {
            get { return BackingStore?.Get<string>("oemName"); }
            set { BackingStore?.Set("oemName", value); }
        }
        /// <summary>
        /// Instantiates a new oemWarrantyInformationOnboarding and sets the default values.
        /// </summary>
        public OemWarrantyInformationOnboarding() : base() {
            OdataType = "#microsoft.graph.oemWarrantyInformationOnboarding";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OemWarrantyInformationOnboarding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OemWarrantyInformationOnboarding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"available", n => { Available = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"oemName", n => { OemName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("available", Available);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("oemName", OemName);
        }
    }
}

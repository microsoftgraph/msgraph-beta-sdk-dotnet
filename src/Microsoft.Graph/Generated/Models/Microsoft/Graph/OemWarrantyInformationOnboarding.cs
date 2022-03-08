using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class OemWarrantyInformationOnboarding : Entity, IParsable {
        /// <summary>Specifies whether warranty API is available. This property is read-only.</summary>
        public bool? Available { get; set; }
        /// <summary>Specifies whether warranty query is enabled for given OEM. This property is read-only.</summary>
        public bool? Enabled { get; set; }
        /// <summary>OEM name. This property is read-only.</summary>
        public string OemName { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"available", (o,n) => { (o as OemWarrantyInformationOnboarding).Available = n.GetBoolValue(); } },
                {"enabled", (o,n) => { (o as OemWarrantyInformationOnboarding).Enabled = n.GetBoolValue(); } },
                {"oemName", (o,n) => { (o as OemWarrantyInformationOnboarding).OemName = n.GetStringValue(); } },
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

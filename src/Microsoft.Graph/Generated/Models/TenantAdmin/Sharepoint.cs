using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class Sharepoint : Entity, IParsable {
        /// <summary>Represents the tenant-level settings for SharePoint and OneDrive.</summary>
        public Microsoft.Graph.Beta.Models.TenantAdmin.Settings Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.Settings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Sharepoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Sharepoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Settings>(Microsoft.Graph.Beta.Models.TenantAdmin.Settings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Settings>("settings", Settings);
        }
    }
}

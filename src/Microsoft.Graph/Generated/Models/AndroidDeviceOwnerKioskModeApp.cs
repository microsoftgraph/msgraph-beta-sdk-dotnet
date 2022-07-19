using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerKioskModeApp : AndroidDeviceOwnerKioskModeFolderItem, IParsable {
        /// <summary>Class name of application</summary>
        public string ClassName {
            get { return BackingStore?.Get<string>("className"); }
            set { BackingStore?.Set("className", value); }
        }
        /// <summary>Package name of application</summary>
        public string Package {
            get { return BackingStore?.Get<string>("package"); }
            set { BackingStore?.Set("package", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerKioskModeApp and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeApp() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerKioskModeApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerKioskModeApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"className", n => { ClassName = n.GetStringValue(); } },
                {"package", n => { Package = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("className", ClassName);
            writer.WriteStringValue("package", Package);
        }
    }
}

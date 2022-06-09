using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows81WifiImportConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Payload. (UTF8 encoded byte array). This is the XML file saved on the device you used to connect to the Wi-Fi endpoint.</summary>
        public byte[] Payload {
            get { return BackingStore?.Get<byte[]>(nameof(Payload)); }
            set { BackingStore?.Set(nameof(Payload), value); }
        }
        /// <summary>Payload file name (.xml).</summary>
        public string PayloadFileName {
            get { return BackingStore?.Get<string>(nameof(PayloadFileName)); }
            set { BackingStore?.Set(nameof(PayloadFileName), value); }
        }
        /// <summary>Profile name displayed in the UI.</summary>
        public string ProfileName {
            get { return BackingStore?.Get<string>(nameof(ProfileName)); }
            set { BackingStore?.Set(nameof(ProfileName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows81WifiImportConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81WifiImportConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"payload", n => { Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("profileName", ProfileName);
        }
    }
}

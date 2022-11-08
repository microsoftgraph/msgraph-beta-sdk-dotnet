using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSCustomConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates the channel used to deploy the configuration profile. Available choices are DeviceChannel, UserChannel</summary>
        public AppleDeploymentChannel? DeploymentChannel {
            get { return BackingStore?.Get<AppleDeploymentChannel?>("deploymentChannel"); }
            set { BackingStore?.Set("deploymentChannel", value); }
        }
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
        public byte[] Payload {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
        /// <summary>Payload file name (.mobileconfig</summary>
        public string PayloadFileName {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
        /// <summary>Name that is displayed to the user.</summary>
        public string PayloadName {
            get { return BackingStore?.Get<string>("payloadName"); }
            set { BackingStore?.Set("payloadName", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSCustomConfiguration and sets the default values.
        /// </summary>
        public MacOSCustomConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deploymentChannel", n => { DeploymentChannel = n.GetEnumValue<AppleDeploymentChannel>(); } },
                {"payload", n => { Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                {"payloadName", n => { PayloadName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AppleDeploymentChannel>("deploymentChannel", DeploymentChannel);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("payloadName", PayloadName);
        }
    }
}

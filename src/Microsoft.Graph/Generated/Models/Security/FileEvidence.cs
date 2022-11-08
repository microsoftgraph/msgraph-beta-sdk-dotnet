using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class FileEvidence : AlertEvidence, IParsable {
        /// <summary>The status of the detection.The possible values are: detected, blocked, prevented, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.DetectionStatus? DetectionStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionStatus?>("detectionStatus"); }
            set { BackingStore?.Set("detectionStatus", value); }
        }
        /// <summary>The file details.</summary>
        public Microsoft.Graph.Beta.Models.Security.FileDetails FileDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FileDetails>("fileDetails"); }
            set { BackingStore?.Set("fileDetails", value); }
        }
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
        public string MdeDeviceId {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
        /// <summary>
        /// Instantiates a new FileEvidence and sets the default values.
        /// </summary>
        public FileEvidence() : base() {
            OdataType = "#microsoft.graph.security.fileEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionStatus", n => { DetectionStatus = n.GetEnumValue<DetectionStatus>(); } },
                {"fileDetails", n => { FileDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.FileDetails>(Microsoft.Graph.Beta.Models.Security.FileDetails.CreateFromDiscriminatorValue); } },
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DetectionStatus>("detectionStatus", DetectionStatus);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.FileDetails>("fileDetails", FileDetails);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
        }
    }
}

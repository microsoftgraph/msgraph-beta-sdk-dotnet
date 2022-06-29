using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeleconferenceDeviceVideoQuality : TeleconferenceDeviceMediaQuality, IParsable {
        /// <summary>The average inbound stream video bit rate per second.</summary>
        public double? AverageInboundBitRate {
            get { return BackingStore?.Get<double?>(nameof(AverageInboundBitRate)); }
            set { BackingStore?.Set(nameof(AverageInboundBitRate), value); }
        }
        /// <summary>The average inbound stream video frame rate per second.</summary>
        public double? AverageInboundFrameRate {
            get { return BackingStore?.Get<double?>(nameof(AverageInboundFrameRate)); }
            set { BackingStore?.Set(nameof(AverageInboundFrameRate), value); }
        }
        /// <summary>The average outbound stream video bit rate per second.</summary>
        public double? AverageOutboundBitRate {
            get { return BackingStore?.Get<double?>(nameof(AverageOutboundBitRate)); }
            set { BackingStore?.Set(nameof(AverageOutboundBitRate), value); }
        }
        /// <summary>The average outbound stream video frame rate per second.</summary>
        public double? AverageOutboundFrameRate {
            get { return BackingStore?.Get<double?>(nameof(AverageOutboundFrameRate)); }
            set { BackingStore?.Set(nameof(AverageOutboundFrameRate), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeleconferenceDeviceVideoQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.teleconferenceDeviceScreenSharingQuality" => new TeleconferenceDeviceScreenSharingQuality(),
                _ => new TeleconferenceDeviceVideoQuality(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"averageInboundBitRate", n => { AverageInboundBitRate = n.GetDoubleValue(); } },
                {"averageInboundFrameRate", n => { AverageInboundFrameRate = n.GetDoubleValue(); } },
                {"averageOutboundBitRate", n => { AverageOutboundBitRate = n.GetDoubleValue(); } },
                {"averageOutboundFrameRate", n => { AverageOutboundFrameRate = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("averageInboundBitRate", AverageInboundBitRate);
            writer.WriteDoubleValue("averageInboundFrameRate", AverageInboundFrameRate);
            writer.WriteDoubleValue("averageOutboundBitRate", AverageOutboundBitRate);
            writer.WriteDoubleValue("averageOutboundFrameRate", AverageOutboundFrameRate);
        }
    }
}

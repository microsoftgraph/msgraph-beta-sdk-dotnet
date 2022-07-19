using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationBandwidthHoursWithPercentage : DeliveryOptimizationBandwidth, IParsable {
        /// <summary>Background download percentage hours.</summary>
        public DeliveryOptimizationBandwidthBusinessHoursLimit BandwidthBackgroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthBackgroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthBackgroundPercentageHours", value); }
        }
        /// <summary>Foreground download percentage hours.</summary>
        public DeliveryOptimizationBandwidthBusinessHoursLimit BandwidthForegroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthForegroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthForegroundPercentageHours", value); }
        }
        /// <summary>
        /// Instantiates a new DeliveryOptimizationBandwidthHoursWithPercentage and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthHoursWithPercentage() : base() {
            OdataType = "#microsoft.graph.deliveryOptimizationBandwidthHoursWithPercentage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeliveryOptimizationBandwidthHoursWithPercentage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthHoursWithPercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bandwidthBackgroundPercentageHours", n => { BandwidthBackgroundPercentageHours = n.GetObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>(DeliveryOptimizationBandwidthBusinessHoursLimit.CreateFromDiscriminatorValue); } },
                {"bandwidthForegroundPercentageHours", n => { BandwidthForegroundPercentageHours = n.GetObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>(DeliveryOptimizationBandwidthBusinessHoursLimit.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthBackgroundPercentageHours", BandwidthBackgroundPercentageHours);
            writer.WriteObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthForegroundPercentageHours", BandwidthForegroundPercentageHours);
        }
    }
}

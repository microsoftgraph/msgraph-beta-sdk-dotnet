using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationMaxCacheSizeAbsolute : DeliveryOptimizationMaxCacheSize, IParsable {
        /// <summary>Specifies the maximum size in GB of Delivery Optimization cache. Valid values 0 to 4294967295</summary>
        public long? MaximumCacheSizeInGigabytes {
            get { return BackingStore?.Get<long?>("maximumCacheSizeInGigabytes"); }
            set { BackingStore?.Set("maximumCacheSizeInGigabytes", value); }
        }
        /// <summary>
        /// Instantiates a new DeliveryOptimizationMaxCacheSizeAbsolute and sets the default values.
        /// </summary>
        public DeliveryOptimizationMaxCacheSizeAbsolute() : base() {
            OdataType = "#microsoft.graph.deliveryOptimizationMaxCacheSizeAbsolute";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeliveryOptimizationMaxCacheSizeAbsolute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationMaxCacheSizeAbsolute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumCacheSizeInGigabytes", n => { MaximumCacheSizeInGigabytes = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("maximumCacheSizeInGigabytes", MaximumCacheSizeInGigabytes);
        }
    }
}

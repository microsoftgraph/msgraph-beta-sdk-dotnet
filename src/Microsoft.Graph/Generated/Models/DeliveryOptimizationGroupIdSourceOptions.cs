using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// GroupId Support Types
    /// </summary>
    public class DeliveryOptimizationGroupIdSourceOptions : DeliveryOptimizationGroupIdSource, IParsable {
        /// <summary>Possible values for the DeliveryOptimizationGroupIdOptionsType setting.</summary>
        public DeliveryOptimizationGroupIdOptionsType? GroupIdSourceOption {
            get { return BackingStore?.Get<DeliveryOptimizationGroupIdOptionsType?>("groupIdSourceOption"); }
            set { BackingStore?.Set("groupIdSourceOption", value); }
        }
        /// <summary>
        /// Instantiates a new deliveryOptimizationGroupIdSourceOptions and sets the default values.
        /// </summary>
        public DeliveryOptimizationGroupIdSourceOptions() : base() {
            OdataType = "#microsoft.graph.deliveryOptimizationGroupIdSourceOptions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeliveryOptimizationGroupIdSourceOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationGroupIdSourceOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupIdSourceOption", n => { GroupIdSourceOption = n.GetEnumValue<DeliveryOptimizationGroupIdOptionsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeliveryOptimizationGroupIdOptionsType>("groupIdSourceOption", GroupIdSourceOption);
        }
    }
}

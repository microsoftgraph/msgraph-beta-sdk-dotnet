using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationGroupIdSourceOptions : DeliveryOptimizationGroupIdSource, IParsable {
        /// <summary>Set this policy to restrict peer selection to a specific source. Possible values are: notConfigured, adSite, authenticatedDomainSid, dhcpUserOption, dnsSuffix.</summary>
        public DeliveryOptimizationGroupIdOptionsType? GroupIdSourceOption {
            get { return BackingStore?.Get<DeliveryOptimizationGroupIdOptionsType?>(nameof(GroupIdSourceOption)); }
            set { BackingStore?.Set(nameof(GroupIdSourceOption), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeliveryOptimizationGroupIdOptionsType>("groupIdSourceOption", GroupIdSourceOption);
        }
    }
}

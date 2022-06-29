using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConfigurationManagerActionResult : DeviceActionResult, IParsable {
        /// <summary>State of the action being delivered to on-prem server. Possible values are: unknown, pendingDelivery, deliveredToConnectorService, failedToDeliverToConnectorService, deliveredToOnPremisesServer.</summary>
        public ConfigurationManagerActionDeliveryStatus? ActionDeliveryStatus {
            get { return BackingStore?.Get<ConfigurationManagerActionDeliveryStatus?>(nameof(ActionDeliveryStatus)); }
            set { BackingStore?.Set(nameof(ActionDeliveryStatus), value); }
        }
        /// <summary>Error code of Configuration Manager action from client</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConfigurationManagerActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionDeliveryStatus", n => { ActionDeliveryStatus = n.GetEnumValue<ConfigurationManagerActionDeliveryStatus>(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ConfigurationManagerActionDeliveryStatus>("actionDeliveryStatus", ActionDeliveryStatus);
            writer.WriteIntValue("errorCode", ErrorCode);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementDomainJoinConnector : Entity, IParsable {
        /// <summary>The connector display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Last time connector contacted Intune.</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>The connector state. Possible values are: active, error, inactive.</summary>
        public DeviceManagementDomainJoinConnectorState? State { get; set; }
        /// <summary>The version of the connector.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementDomainJoinConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementDomainJoinConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DeviceManagementDomainJoinConnector).DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", (o,n) => { (o as DeviceManagementDomainJoinConnector).LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as DeviceManagementDomainJoinConnector).State = n.GetEnumValue<DeviceManagementDomainJoinConnectorState>(); } },
                {"version", (o,n) => { (o as DeviceManagementDomainJoinConnector).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteEnumValue<DeviceManagementDomainJoinConnectorState>("state", State);
            writer.WriteStringValue("version", Version);
        }
    }
}

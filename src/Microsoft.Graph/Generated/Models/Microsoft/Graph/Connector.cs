using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Connector : Entity, IParsable {
        /// <summary>The external IP address as detected by the the connector server. Read-only.</summary>
        public string ExternalIp { get; set; }
        /// <summary>The machine name the connector is installed and running on.</summary>
        public string MachineName { get; set; }
        /// <summary>The connectorGroup that the connector is a member of. Read-only.</summary>
        public List<ConnectorGroup> MemberOf { get; set; }
        /// <summary>Indicates the status of the connector. Possible values are: active, inactive. Read-only.</summary>
        public ConnectorStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"externalIp", (o,n) => { (o as Connector).ExternalIp = n.GetStringValue(); } },
                {"machineName", (o,n) => { (o as Connector).MachineName = n.GetStringValue(); } },
                {"memberOf", (o,n) => { (o as Connector).MemberOf = n.GetCollectionOfObjectValues<ConnectorGroup>().ToList(); } },
                {"status", (o,n) => { (o as Connector).Status = n.GetEnumValue<ConnectorStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteCollectionOfObjectValues<ConnectorGroup>("memberOf", MemberOf);
            writer.WriteEnumValue<ConnectorStatus>("status", Status);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CertificateConnectorDetails : Entity, IParsable {
        /// <summary>Connector name (set during enrollment).</summary>
        public string ConnectorName { get; set; }
        /// <summary>Date/time when this connector was enrolled.</summary>
        public DateTimeOffset? EnrollmentDateTime { get; set; }
        /// <summary>Date/time when this connector last connected to the service.</summary>
        public DateTimeOffset? LastCheckinDateTime { get; set; }
        /// <summary>Name of the machine hosting this connector service.</summary>
        public string MachineName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"connectorName", (o,n) => { (o as CertificateConnectorDetails).ConnectorName = n.GetStringValue(); } },
                {"enrollmentDateTime", (o,n) => { (o as CertificateConnectorDetails).EnrollmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastCheckinDateTime", (o,n) => { (o as CertificateConnectorDetails).LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"machineName", (o,n) => { (o as CertificateConnectorDetails).MachineName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectorName", ConnectorName);
            writer.WriteDateTimeOffsetValue("enrollmentDateTime", EnrollmentDateTime);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("machineName", MachineName);
        }
    }
}

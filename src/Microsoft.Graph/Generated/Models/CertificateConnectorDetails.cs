using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CertificateConnectorDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectorName", n => { ConnectorName = n.GetStringValue(); } },
                {"enrollmentDateTime", n => { EnrollmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastCheckinDateTime", n => { LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
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

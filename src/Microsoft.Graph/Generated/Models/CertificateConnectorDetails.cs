using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CertificateConnectorDetails : Entity, IParsable {
        /// <summary>Connector name (set during enrollment).</summary>
        public string ConnectorName {
            get { return BackingStore?.Get<string>("connectorName"); }
            set { BackingStore?.Set("connectorName", value); }
        }
        /// <summary>Version of the connector installed.</summary>
        public string ConnectorVersion {
            get { return BackingStore?.Get<string>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
        /// <summary>Date/time when this connector was enrolled.</summary>
        public DateTimeOffset? EnrollmentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrollmentDateTime"); }
            set { BackingStore?.Set("enrollmentDateTime", value); }
        }
        /// <summary>Date/time when this connector last connected to the service.</summary>
        public DateTimeOffset? LastCheckinDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckinDateTime"); }
            set { BackingStore?.Set("lastCheckinDateTime", value); }
        }
        /// <summary>Name of the machine hosting this connector service.</summary>
        public string MachineName {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
        /// <summary>
        /// Instantiates a new CertificateConnectorDetails and sets the default values.
        /// </summary>
        public CertificateConnectorDetails() : base() {
            OdataType = "#microsoft.graph.certificateConnectorDetails";
        }
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
                {"connectorVersion", n => { ConnectorVersion = n.GetStringValue(); } },
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
            writer.WriteStringValue("connectorVersion", ConnectorVersion);
            writer.WriteDateTimeOffsetValue("enrollmentDateTime", EnrollmentDateTime);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("machineName", MachineName);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Connector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Connector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"externalIp", (o,n) => { (o as Connector).ExternalIp = n.GetStringValue(); } },
                {"machineName", (o,n) => { (o as Connector).MachineName = n.GetStringValue(); } },
                {"memberOf", (o,n) => { (o as Connector).MemberOf = n.GetCollectionOfObjectValues<ConnectorGroup>(ConnectorGroup.CreateFromDiscriminatorValue).ToList(); } },
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

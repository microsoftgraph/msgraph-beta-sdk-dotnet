using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Connector : Entity, IParsable {
        /// <summary>The external IP address as detected by the the connector server. Read-only.</summary>
        public string ExternalIp {
            get { return BackingStore?.Get<string>(nameof(ExternalIp)); }
            set { BackingStore?.Set(nameof(ExternalIp), value); }
        }
        /// <summary>The machine name the connector is installed and running on.</summary>
        public string MachineName {
            get { return BackingStore?.Get<string>(nameof(MachineName)); }
            set { BackingStore?.Set(nameof(MachineName), value); }
        }
        /// <summary>The connectorGroup that the connector is a member of. Read-only.</summary>
        public List<ConnectorGroup> MemberOf {
            get { return BackingStore?.Get<List<ConnectorGroup>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>Indicates the status of the connector. Possible values are: active, inactive. Read-only.</summary>
        public ConnectorStatus? Status {
            get { return BackingStore?.Get<ConnectorStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"externalIp", n => { ExternalIp = n.GetStringValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<ConnectorGroup>(ConnectorGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<ConnectorStatus>(); } },
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

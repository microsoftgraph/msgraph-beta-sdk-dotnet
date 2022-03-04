using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ConnectorGroup : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<Application> Applications { get; set; }
        /// <summary>Indicates the type of hybrid agent. This pre-set by the system. Possible values are: applicationProxy. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectorGroupType? ConnectorGroupType { get; set; }
        /// <summary>Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<Connector> Members { get; set; }
        /// <summary>The name associated with the connectorGroup.</summary>
        public string Name { get; set; }
        /// <summary>The region the connectorGroup is assigned to and will optimize traffic for. This region can only be set if no connectors or applications are assigned to the connectorGroup. The possible values are: nam (for North America), eur (for Europe), aus (for Australia), asia (for Asia), ind (for India), and unknownFutureValue.</summary>
        public ConnectorGroupRegion? Region { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConnectorGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectorGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applications", (o,n) => { (o as ConnectorGroup).Applications = n.GetCollectionOfObjectValues<Application>(Application.CreateFromDiscriminatorValue).ToList(); } },
                {"connectorGroupType", (o,n) => { (o as ConnectorGroup).ConnectorGroupType = n.GetEnumValue<ConnectorGroupType>(); } },
                {"isDefault", (o,n) => { (o as ConnectorGroup).IsDefault = n.GetBoolValue(); } },
                {"members", (o,n) => { (o as ConnectorGroup).Members = n.GetCollectionOfObjectValues<Connector>(Connector.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as ConnectorGroup).Name = n.GetStringValue(); } },
                {"region", (o,n) => { (o as ConnectorGroup).Region = n.GetEnumValue<ConnectorGroupRegion>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Application>("applications", Applications);
            writer.WriteEnumValue<ConnectorGroupType>("connectorGroupType", ConnectorGroupType);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteCollectionOfObjectValues<Connector>("members", Members);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<ConnectorGroupRegion>("region", Region);
        }
    }
}

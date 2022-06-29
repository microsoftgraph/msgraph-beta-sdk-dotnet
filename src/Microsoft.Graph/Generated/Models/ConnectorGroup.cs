using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ConnectorGroup : Entity, IParsable {
        /// <summary>The applications property</summary>
        public List<Application> Applications {
            get { return BackingStore?.Get<List<Application>>(nameof(Applications)); }
            set { BackingStore?.Set(nameof(Applications), value); }
        }
        /// <summary>Indicates the type of hybrid agent. This pre-set by the system. Possible values are: applicationProxy. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ConnectorGroupType? ConnectorGroupType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectorGroupType?>(nameof(ConnectorGroupType)); }
            set { BackingStore?.Set(nameof(ConnectorGroupType), value); }
        }
        /// <summary>Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>The members property</summary>
        public List<Connector> Members {
            get { return BackingStore?.Get<List<Connector>>(nameof(Members)); }
            set { BackingStore?.Set(nameof(Members), value); }
        }
        /// <summary>The name associated with the connectorGroup.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The region the connectorGroup is assigned to and will optimize traffic for. This region can only be set if no connectors or applications are assigned to the connectorGroup. The possible values are: nam (for North America), eur (for Europe), aus (for Australia), asia (for Asia), ind (for India), and unknownFutureValue.</summary>
        public ConnectorGroupRegion? Region {
            get { return BackingStore?.Get<ConnectorGroupRegion?>(nameof(Region)); }
            set { BackingStore?.Set(nameof(Region), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applications", n => { Applications = n.GetCollectionOfObjectValues<Application>(Application.CreateFromDiscriminatorValue).ToList(); } },
                {"connectorGroupType", n => { ConnectorGroupType = n.GetEnumValue<ConnectorGroupType>(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<Connector>(Connector.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"region", n => { Region = n.GetEnumValue<ConnectorGroupRegion>(); } },
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

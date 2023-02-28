using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConnectorGroup : Entity, IParsable {
        /// <summary>The applications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Application>? Applications {
            get { return BackingStore?.Get<List<Application>?>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#nullable restore
#else
        public List<Application> Applications {
            get { return BackingStore?.Get<List<Application>>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#endif
        /// <summary>The connectorGroupType property</summary>
        public Microsoft.Graph.Beta.Models.ConnectorGroupType? ConnectorGroupType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectorGroupType?>("connectorGroupType"); }
            set { BackingStore?.Set("connectorGroupType", value); }
        }
        /// <summary>Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>The members property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Connector>? Members {
            get { return BackingStore?.Get<List<Connector>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<Connector> Members {
            get { return BackingStore?.Get<List<Connector>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The name associated with the connectorGroup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The region the connectorGroup is assigned to and will optimize traffic for. This region can only be set if no connectors or applications are assigned to the connectorGroup. The possible values are: nam (for North America), eur (for Europe), aus (for Australia), asia (for Asia), ind (for India), and unknownFutureValue.</summary>
        public ConnectorGroupRegion? Region {
            get { return BackingStore?.Get<ConnectorGroupRegion?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectorGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectorGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applications", n => { Applications = n.GetCollectionOfObjectValues<Application>(Application.CreateFromDiscriminatorValue)?.ToList(); } },
                {"connectorGroupType", n => { ConnectorGroupType = n.GetEnumValue<ConnectorGroupType>(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<Connector>(Connector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"region", n => { Region = n.GetEnumValue<ConnectorGroupRegion>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

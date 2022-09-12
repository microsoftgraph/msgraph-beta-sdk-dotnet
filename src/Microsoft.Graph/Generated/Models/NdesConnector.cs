using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity which represents an OnPrem Ndes connector.</summary>
    public class NdesConnector : Entity, IParsable {
        /// <summary>The build version of the Ndes Connector.</summary>
        public string ConnectorVersion {
            get { return BackingStore?.Get<string>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
        /// <summary>The friendly name of the Ndes Connector.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Timestamp when on-prem certificate connector was enrolled in Intune.</summary>
        public DateTimeOffset? EnrolledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrolledDateTime"); }
            set { BackingStore?.Set("enrolledDateTime", value); }
        }
        /// <summary>Last connection time for the Ndes Connector</summary>
        public DateTimeOffset? LastConnectionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastConnectionDateTime"); }
            set { BackingStore?.Set("lastConnectionDateTime", value); }
        }
        /// <summary>Name of the machine running on-prem certificate connector service.</summary>
        public string MachineName {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The current status of the Ndes Connector.</summary>
        public NdesConnectorState? State {
            get { return BackingStore?.Get<NdesConnectorState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new ndesConnector and sets the default values.
        /// </summary>
        public NdesConnector() : base() {
            OdataType = "#microsoft.graph.ndesConnector";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new NdesConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NdesConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectorVersion", n => { ConnectorVersion = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastConnectionDateTime", n => { LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<NdesConnectorState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectorVersion", ConnectorVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("enrolledDateTime", EnrolledDateTime);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<NdesConnectorState>("state", State);
        }
    }
}

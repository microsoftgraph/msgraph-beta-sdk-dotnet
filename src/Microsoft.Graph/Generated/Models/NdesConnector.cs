using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NdesConnector : Entity, IParsable {
        /// <summary>The friendly name of the Ndes Connector.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Last connection time for the Ndes Connector</summary>
        public DateTimeOffset? LastConnectionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastConnectionDateTime"); }
            set { BackingStore?.Set("lastConnectionDateTime", value); }
        }
        /// <summary>The current status of the Ndes Connector.</summary>
        public NdesConnectorState? State {
            get { return BackingStore?.Get<NdesConnectorState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new NdesConnector and sets the default values.
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
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", n => { LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteEnumValue<NdesConnectorState>("state", State);
        }
    }
}

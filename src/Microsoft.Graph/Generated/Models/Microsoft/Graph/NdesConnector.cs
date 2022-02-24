using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class NdesConnector : Entity, IParsable {
        /// <summary>The friendly name of the Ndes Connector.</summary>
        public string DisplayName { get; set; }
        /// <summary>Last connection time for the Ndes Connector</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>Ndes Connector Status. Possible values are: none, active, inactive.</summary>
        public NdesConnectorState? State { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as NdesConnector).DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", (o,n) => { (o as NdesConnector).LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as NdesConnector).State = n.GetEnumValue<NdesConnectorState>(); } },
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

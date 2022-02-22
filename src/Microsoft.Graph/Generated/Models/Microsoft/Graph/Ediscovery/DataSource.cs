using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Ediscovery {
    public class DataSource : Entity, IParsable {
        /// <summary>The user who created the dataSource.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the dataSource was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the dataSource. This will be the name of the SharePoint site.</summary>
        public string DisplayName { get; set; }
        public DataSourceHoldStatus? HoldStatus { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as DataSource).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as DataSource).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as DataSource).DisplayName = n.GetStringValue(); } },
                {"holdStatus", (o,n) => { (o as DataSource).HoldStatus = n.GetEnumValue<DataSourceHoldStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<DataSourceHoldStatus>("holdStatus", HoldStatus);
        }
    }
}

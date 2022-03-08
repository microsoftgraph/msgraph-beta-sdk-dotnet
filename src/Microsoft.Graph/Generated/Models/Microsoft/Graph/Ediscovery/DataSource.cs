using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class DataSource : Entity, IParsable {
        /// <summary>The user who created the dataSource.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the dataSource was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the dataSource. This will be the name of the SharePoint site.</summary>
        public string DisplayName { get; set; }
        public DataSourceHoldStatus? HoldStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as DataSource).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
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

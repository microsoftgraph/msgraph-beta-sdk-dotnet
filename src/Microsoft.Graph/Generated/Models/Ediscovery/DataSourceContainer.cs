using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class DataSourceContainer : Entity, IParsable {
        /// <summary>Created date and time of the dataSourceContainer entity.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Display name of the dataSourceContainer entity.</summary>
        public string DisplayName { get; set; }
        /// <summary>The holdStatus property</summary>
        public DataSourceHoldStatus? HoldStatus { get; set; }
        /// <summary>The lastIndexOperation property</summary>
        public CaseIndexOperation LastIndexOperation { get; set; }
        /// <summary>Last modified date and time of the dataSourceContainer.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time that the dataSourceContainer was released from the case.</summary>
        public DateTimeOffset? ReleasedDateTime { get; set; }
        /// <summary>Latest status of the dataSourceContainer. Possible values are: Active, Released.</summary>
        public DataSourceContainerStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataSourceContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataSourceContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"holdStatus", n => { HoldStatus = n.GetEnumValue<DataSourceHoldStatus>(); } },
                {"lastIndexOperation", n => { LastIndexOperation = n.GetObjectValue<CaseIndexOperation>(CaseIndexOperation.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"releasedDateTime", n => { ReleasedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<DataSourceContainerStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<DataSourceHoldStatus>("holdStatus", HoldStatus);
            writer.WriteObjectValue<CaseIndexOperation>("lastIndexOperation", LastIndexOperation);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("releasedDateTime", ReleasedDateTime);
            writer.WriteEnumValue<DataSourceContainerStatus>("status", Status);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Ediscovery {
    public class DataSourceContainer : Entity, IParsable {
        /// <summary>Created date and time of the dataSourceContainer entity.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Display name of the dataSourceContainer entity.</summary>
        public string DisplayName { get; set; }
        public DataSourceHoldStatus? HoldStatus { get; set; }
        public CaseIndexOperation LastIndexOperation { get; set; }
        /// <summary>Last modified date and time of the dataSourceContainer.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time that the dataSourceContainer was released from the case.</summary>
        public DateTimeOffset? ReleasedDateTime { get; set; }
        /// <summary>Latest status of the dataSourceContainer. Possible values are: Active, Released.</summary>
        public DataSourceContainerStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as DataSourceContainer).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as DataSourceContainer).DisplayName = n.GetStringValue(); } },
                {"holdStatus", (o,n) => { (o as DataSourceContainer).HoldStatus = n.GetEnumValue<DataSourceHoldStatus>(); } },
                {"lastIndexOperation", (o,n) => { (o as DataSourceContainer).LastIndexOperation = n.GetObjectValue<CaseIndexOperation>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DataSourceContainer).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"releasedDateTime", (o,n) => { (o as DataSourceContainer).ReleasedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as DataSourceContainer).Status = n.GetEnumValue<DataSourceContainerStatus>(); } },
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

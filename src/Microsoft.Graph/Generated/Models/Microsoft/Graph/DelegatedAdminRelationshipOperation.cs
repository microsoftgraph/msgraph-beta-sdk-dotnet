using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminRelationshipOperation : Entity, IParsable {
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string Data { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DelegatedAdminRelationshipOperationType? OperationType { get; set; }
        public DelegatedAdminRelationshipOperationStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as DelegatedAdminRelationshipOperation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"data", (o,n) => { (o as DelegatedAdminRelationshipOperation).Data = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DelegatedAdminRelationshipOperation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", (o,n) => { (o as DelegatedAdminRelationshipOperation).OperationType = n.GetEnumValue<DelegatedAdminRelationshipOperationType>(); } },
                {"status", (o,n) => { (o as DelegatedAdminRelationshipOperation).Status = n.GetEnumValue<DelegatedAdminRelationshipOperationStatus>(); } },
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
            writer.WriteStringValue("data", Data);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminRelationshipOperationType>("operationType", OperationType);
            writer.WriteEnumValue<DelegatedAdminRelationshipOperationStatus>("status", Status);
        }
    }
}

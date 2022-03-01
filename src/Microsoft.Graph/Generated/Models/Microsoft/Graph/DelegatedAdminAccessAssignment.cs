using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminAccessAssignment : Entity, IParsable {
        public DelegatedAdminAccessContainer AccessContainer { get; set; }
        public DelegatedAdminAccessDetails AccessDetails { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DelegatedAdminAccessAssignmentStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessContainer", (o,n) => { (o as DelegatedAdminAccessAssignment).AccessContainer = n.GetObjectValue<DelegatedAdminAccessContainer>(); } },
                {"accessDetails", (o,n) => { (o as DelegatedAdminAccessAssignment).AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(); } },
                {"createdDateTime", (o,n) => { (o as DelegatedAdminAccessAssignment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DelegatedAdminAccessAssignment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as DelegatedAdminAccessAssignment).Status = n.GetEnumValue<DelegatedAdminAccessAssignmentStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DelegatedAdminAccessContainer>("accessContainer", AccessContainer);
            writer.WriteObjectValue<DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminAccessAssignmentStatus>("status", Status);
        }
    }
}

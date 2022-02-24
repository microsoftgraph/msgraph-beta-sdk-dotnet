using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class JobResponseBase : Entity, IParsable {
        public DateTimeOffset? CreationDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public ClassificationError Error { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        public string Status { get; set; }
        public string TenantId { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"creationDateTime", (o,n) => { (o as JobResponseBase).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", (o,n) => { (o as JobResponseBase).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as JobResponseBase).Error = n.GetObjectValue<ClassificationError>(); } },
                {"startDateTime", (o,n) => { (o as JobResponseBase).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as JobResponseBase).Status = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as JobResponseBase).TenantId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as JobResponseBase).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<ClassificationError>("error", Error);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("type", Type);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcAuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity. Optional.</summary>
        public string Activity { get; set; }
        /// <summary>The date time in UTC when the activity was performed. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>The HTTP operation type of the activity. Possible values include create, delete, patch and other. Read-only.</summary>
        public CloudPcAuditActivityOperationType? ActivityOperationType { get; set; }
        /// <summary>The result of the activity. Read-only.</summary>
        public CloudPcAuditActivityResult? ActivityResult { get; set; }
        /// <summary>The type of activity that was performed. Read-only.</summary>
        public string ActivityType { get; set; }
        public CloudPcAuditActor Actor { get; set; }
        /// <summary>Audit category. Read-only.</summary>
        public CloudPcAuditCategory? Category { get; set; }
        /// <summary>Component name. Read-only.</summary>
        public string ComponentName { get; set; }
        /// <summary>The client request identifier, used to correlate activity within the system. Read-only.</summary>
        public string CorrelationId { get; set; }
        /// <summary>Event display name. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>List of cloudPcAuditResource objects. Read-only.</summary>
        public List<CloudPcAuditResource> Resources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as CloudPcAuditEvent).Activity = n.GetStringValue(); } },
                {"activityDateTime", (o,n) => { (o as CloudPcAuditEvent).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", (o,n) => { (o as CloudPcAuditEvent).ActivityOperationType = n.GetEnumValue<CloudPcAuditActivityOperationType>(); } },
                {"activityResult", (o,n) => { (o as CloudPcAuditEvent).ActivityResult = n.GetEnumValue<CloudPcAuditActivityResult>(); } },
                {"activityType", (o,n) => { (o as CloudPcAuditEvent).ActivityType = n.GetStringValue(); } },
                {"actor", (o,n) => { (o as CloudPcAuditEvent).Actor = n.GetObjectValue<CloudPcAuditActor>(); } },
                {"category", (o,n) => { (o as CloudPcAuditEvent).Category = n.GetEnumValue<CloudPcAuditCategory>(); } },
                {"componentName", (o,n) => { (o as CloudPcAuditEvent).ComponentName = n.GetStringValue(); } },
                {"correlationId", (o,n) => { (o as CloudPcAuditEvent).CorrelationId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloudPcAuditEvent).DisplayName = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as CloudPcAuditEvent).Resources = n.GetCollectionOfObjectValues<CloudPcAuditResource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteEnumValue<CloudPcAuditActivityOperationType>("activityOperationType", ActivityOperationType);
            writer.WriteEnumValue<CloudPcAuditActivityResult>("activityResult", ActivityResult);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<CloudPcAuditActor>("actor", Actor);
            writer.WriteEnumValue<CloudPcAuditCategory>("category", Category);
            writer.WriteStringValue("componentName", ComponentName);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<CloudPcAuditResource>("resources", Resources);
        }
    }
}

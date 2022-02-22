using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity.</summary>
        public string Activity { get; set; }
        /// <summary>The date time in UTC when the activity was performed.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>The HTTP operation type of the activity.</summary>
        public string ActivityOperationType { get; set; }
        /// <summary>The result of the activity.</summary>
        public string ActivityResult { get; set; }
        /// <summary>The type of activity that was being performed.</summary>
        public string ActivityType { get; set; }
        /// <summary>AAD user and application that are associated with the audit event.</summary>
        public AuditActor Actor { get; set; }
        /// <summary>Audit category.</summary>
        public string Category { get; set; }
        /// <summary>Component name.</summary>
        public string ComponentName { get; set; }
        /// <summary>The client request Id that is used to correlate activity within the system.</summary>
        public string CorrelationId { get; set; }
        /// <summary>Event display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Resources being modified.</summary>
        public List<AuditResource> Resources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as AuditEvent).Activity = n.GetStringValue(); } },
                {"activityDateTime", (o,n) => { (o as AuditEvent).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", (o,n) => { (o as AuditEvent).ActivityOperationType = n.GetStringValue(); } },
                {"activityResult", (o,n) => { (o as AuditEvent).ActivityResult = n.GetStringValue(); } },
                {"activityType", (o,n) => { (o as AuditEvent).ActivityType = n.GetStringValue(); } },
                {"actor", (o,n) => { (o as AuditEvent).Actor = n.GetObjectValue<AuditActor>(); } },
                {"category", (o,n) => { (o as AuditEvent).Category = n.GetStringValue(); } },
                {"componentName", (o,n) => { (o as AuditEvent).ComponentName = n.GetStringValue(); } },
                {"correlationId", (o,n) => { (o as AuditEvent).CorrelationId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuditEvent).DisplayName = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as AuditEvent).Resources = n.GetCollectionOfObjectValues<AuditResource>().ToList(); } },
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
            writer.WriteStringValue("activityOperationType", ActivityOperationType);
            writer.WriteStringValue("activityResult", ActivityResult);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<AuditActor>("actor", Actor);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("componentName", ComponentName);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AuditResource>("resources", Resources);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        /// <summary>The actor property</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcAuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcAuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", n => { ActivityOperationType = n.GetEnumValue<CloudPcAuditActivityOperationType>(); } },
                {"activityResult", n => { ActivityResult = n.GetEnumValue<CloudPcAuditActivityResult>(); } },
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"actor", n => { Actor = n.GetObjectValue<CloudPcAuditActor>(CloudPcAuditActor.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetEnumValue<CloudPcAuditCategory>(); } },
                {"componentName", n => { ComponentName = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<CloudPcAuditResource>(CloudPcAuditResource.CreateFromDiscriminatorValue).ToList(); } },
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

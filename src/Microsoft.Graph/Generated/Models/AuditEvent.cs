using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity.</summary>
        public string Activity {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>The date time in UTC when the activity was performed.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The HTTP operation type of the activity.</summary>
        public string ActivityOperationType {
            get { return BackingStore?.Get<string>("activityOperationType"); }
            set { BackingStore?.Set("activityOperationType", value); }
        }
        /// <summary>The result of the activity.</summary>
        public string ActivityResult {
            get { return BackingStore?.Get<string>("activityResult"); }
            set { BackingStore?.Set("activityResult", value); }
        }
        /// <summary>The type of activity that was being performed.</summary>
        public string ActivityType {
            get { return BackingStore?.Get<string>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
        /// <summary>AAD user and application that are associated with the audit event.</summary>
        public AuditActor Actor {
            get { return BackingStore?.Get<AuditActor>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
        /// <summary>Audit category.</summary>
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Component name.</summary>
        public string ComponentName {
            get { return BackingStore?.Get<string>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
        /// <summary>The client request Id that is used to correlate activity within the system.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
        /// <summary>Event display name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Resources being modified.</summary>
        public List<AuditResource> Resources {
            get { return BackingStore?.Get<List<AuditResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
        /// <summary>
        /// Instantiates a new AuditEvent and sets the default values.
        /// </summary>
        public AuditEvent() : base() {
            OdataType = "#microsoft.graph.auditEvent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", n => { ActivityOperationType = n.GetStringValue(); } },
                {"activityResult", n => { ActivityResult = n.GetStringValue(); } },
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"actor", n => { Actor = n.GetObjectValue<AuditActor>(AuditActor.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"componentName", n => { ComponentName = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<AuditResource>(AuditResource.CreateFromDiscriminatorValue)?.ToList(); } },
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

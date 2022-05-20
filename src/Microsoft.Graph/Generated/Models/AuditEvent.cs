using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the properties for Audit Event.</summary>
    public class AuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity.</summary>
        public string Activity {
            get { return BackingStore?.Get<string>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>The date time in UTC when the activity was performed.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActivityDateTime)); }
            set { BackingStore?.Set(nameof(ActivityDateTime), value); }
        }
        /// <summary>The HTTP operation type of the activity.</summary>
        public string ActivityOperationType {
            get { return BackingStore?.Get<string>(nameof(ActivityOperationType)); }
            set { BackingStore?.Set(nameof(ActivityOperationType), value); }
        }
        /// <summary>The result of the activity.</summary>
        public string ActivityResult {
            get { return BackingStore?.Get<string>(nameof(ActivityResult)); }
            set { BackingStore?.Set(nameof(ActivityResult), value); }
        }
        /// <summary>The type of activity that was being performed.</summary>
        public string ActivityType {
            get { return BackingStore?.Get<string>(nameof(ActivityType)); }
            set { BackingStore?.Set(nameof(ActivityType), value); }
        }
        /// <summary>AAD user and application that are associated with the audit event.</summary>
        public AuditActor Actor {
            get { return BackingStore?.Get<AuditActor>(nameof(Actor)); }
            set { BackingStore?.Set(nameof(Actor), value); }
        }
        /// <summary>Audit category.</summary>
        public string Category {
            get { return BackingStore?.Get<string>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>Component name.</summary>
        public string ComponentName {
            get { return BackingStore?.Get<string>(nameof(ComponentName)); }
            set { BackingStore?.Set(nameof(ComponentName), value); }
        }
        /// <summary>The client request Id that is used to correlate activity within the system.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>(nameof(CorrelationId)); }
            set { BackingStore?.Set(nameof(CorrelationId), value); }
        }
        /// <summary>Event display name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Resources being modified.</summary>
        public List<AuditResource> Resources {
            get { return BackingStore?.Get<List<AuditResource>>(nameof(Resources)); }
            set { BackingStore?.Set(nameof(Resources), value); }
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
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<AuditResource>(AuditResource.CreateFromDiscriminatorValue).ToList(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class RetentionLabel : Entity, IParsable {
        /// <summary>Specifies the action to take on a document with this label applied during the retention period. The possible values are: none, delete, startDispositionReview, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.ActionAfterRetentionPeriod? ActionAfterRetentionPeriod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ActionAfterRetentionPeriod?>("actionAfterRetentionPeriod"); }
            set { BackingStore?.Set("actionAfterRetentionPeriod", value); }
        }
        /// <summary>Specifies how the behavior of a document with this label should be during the retention period. The possible values are: doNotRetain, retain, retainAsRecord, retainAsRegulatoryRecord, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.BehaviorDuringRetentionPeriod?>("behaviorDuringRetentionPeriod"); }
            set { BackingStore?.Set("behaviorDuringRetentionPeriod", value); }
        }
        /// <summary>Represents the user who created the retentionLabel.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>Represents the date and time in which the retentionLabel is created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Specifies the locked or unlocked state of a record label when it is created.The possible values are: startLocked, startUnlocked, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.DefaultRecordBehavior? DefaultRecordBehavior {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DefaultRecordBehavior?>("defaultRecordBehavior"); }
            set { BackingStore?.Set("defaultRecordBehavior", value); }
        }
        /// <summary>Provides label information for the admin. Optional.</summary>
        public string DescriptionForAdmins {
            get { return BackingStore?.Get<string>("descriptionForAdmins"); }
            set { BackingStore?.Set("descriptionForAdmins", value); }
        }
        /// <summary>Provides the label information for the user. Optional.</summary>
        public string DescriptionForUsers {
            get { return BackingStore?.Get<string>("descriptionForUsers"); }
            set { BackingStore?.Set("descriptionForUsers", value); }
        }
        /// <summary>Unique string that defines a label name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Review stages during which reviewers are notified to determine whether a document must be deleted or retained.</summary>
        public List<DispositionReviewStage> DispositionReviewStages {
            get { return BackingStore?.Get<List<DispositionReviewStage>>("dispositionReviewStages"); }
            set { BackingStore?.Set("dispositionReviewStages", value); }
        }
        /// <summary>Specifies whether the label is currently being used.</summary>
        public bool? IsInUse {
            get { return BackingStore?.Get<bool?>("isInUse"); }
            set { BackingStore?.Set("isInUse", value); }
        }
        /// <summary>Specifies the replacement label to be applied automatically after the retention period of the current label ends.</summary>
        public string LabelToBeApplied {
            get { return BackingStore?.Get<string>("labelToBeApplied"); }
            set { BackingStore?.Set("labelToBeApplied", value); }
        }
        /// <summary>The user who last modified the retentionLabel.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The latest date time when the retentionLabel was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Specifies the number of days to retain the content.</summary>
        public Microsoft.Graph.Beta.Models.Security.RetentionDuration RetentionDuration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.RetentionDuration>("retentionDuration"); }
            set { BackingStore?.Set("retentionDuration", value); }
        }
        /// <summary>The retentionEventType property</summary>
        public Microsoft.Graph.Beta.Models.Security.RetentionEventType RetentionEventType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.RetentionEventType>("retentionEventType"); }
            set { BackingStore?.Set("retentionEventType", value); }
        }
        /// <summary>Specifies whether the retention duration is calculated from the content creation date, labeled date, or last modification date. The possible values are: dateLabeled, dateCreated, dateModified, dateOfEvent, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.RetentionTrigger? RetentionTrigger {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.RetentionTrigger?>("retentionTrigger"); }
            set { BackingStore?.Set("retentionTrigger", value); }
        }
        /// <summary>
        /// Instantiates a new retentionLabel and sets the default values.
        /// </summary>
        public RetentionLabel() : base() {
            OdataType = "#microsoft.graph.security.retentionLabel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RetentionLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionAfterRetentionPeriod", n => { ActionAfterRetentionPeriod = n.GetEnumValue<ActionAfterRetentionPeriod>(); } },
                {"behaviorDuringRetentionPeriod", n => { BehaviorDuringRetentionPeriod = n.GetEnumValue<BehaviorDuringRetentionPeriod>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultRecordBehavior", n => { DefaultRecordBehavior = n.GetEnumValue<DefaultRecordBehavior>(); } },
                {"descriptionForAdmins", n => { DescriptionForAdmins = n.GetStringValue(); } },
                {"descriptionForUsers", n => { DescriptionForUsers = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dispositionReviewStages", n => { DispositionReviewStages = n.GetCollectionOfObjectValues<DispositionReviewStage>(DispositionReviewStage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isInUse", n => { IsInUse = n.GetBoolValue(); } },
                {"labelToBeApplied", n => { LabelToBeApplied = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"retentionDuration", n => { RetentionDuration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionDuration>(Microsoft.Graph.Beta.Models.Security.RetentionDuration.CreateFromDiscriminatorValue); } },
                {"retentionEventType", n => { RetentionEventType = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionEventType>(Microsoft.Graph.Beta.Models.Security.RetentionEventType.CreateFromDiscriminatorValue); } },
                {"retentionTrigger", n => { RetentionTrigger = n.GetEnumValue<RetentionTrigger>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ActionAfterRetentionPeriod>("actionAfterRetentionPeriod", ActionAfterRetentionPeriod);
            writer.WriteEnumValue<BehaviorDuringRetentionPeriod>("behaviorDuringRetentionPeriod", BehaviorDuringRetentionPeriod);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<DefaultRecordBehavior>("defaultRecordBehavior", DefaultRecordBehavior);
            writer.WriteStringValue("descriptionForAdmins", DescriptionForAdmins);
            writer.WriteStringValue("descriptionForUsers", DescriptionForUsers);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DispositionReviewStage>("dispositionReviewStages", DispositionReviewStages);
            writer.WriteBoolValue("isInUse", IsInUse);
            writer.WriteStringValue("labelToBeApplied", LabelToBeApplied);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionDuration>("retentionDuration", RetentionDuration);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionEventType>("retentionEventType", RetentionEventType);
            writer.WriteEnumValue<RetentionTrigger>("retentionTrigger", RetentionTrigger);
        }
    }
}

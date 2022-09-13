using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class AlertRecord : Entity, IParsable {
        /// <summary>The alertImpact property</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact AlertImpact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>("alertImpact"); }
            set { BackingStore?.Set("alertImpact", value); }
        }
        /// <summary>The alertRuleId property</summary>
        public string AlertRuleId {
            get { return BackingStore?.Get<string>("alertRuleId"); }
            set { BackingStore?.Set("alertRuleId", value); }
        }
        /// <summary>The alertRuleTemplate property</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>The detectedDateTime property</summary>
        public DateTimeOffset? DetectedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("detectedDateTime"); }
            set { BackingStore?.Set("detectedDateTime", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The resolvedDateTime property</summary>
        public DateTimeOffset? ResolvedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedDateTime"); }
            set { BackingStore?.Set("resolvedDateTime", value); }
        }
        /// <summary>The severity property</summary>
        public RuleSeverityType? Severity {
            get { return BackingStore?.Get<RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public AlertStatusType? Status {
            get { return BackingStore?.Get<AlertStatusType?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new alertRecord and sets the default values.
        /// </summary>
        public AlertRecord() : base() {
            OdataType = "#microsoft.graph.deviceManagement.alertRecord";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AlertRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertImpact", n => { AlertImpact = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>(Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact.CreateFromDiscriminatorValue); } },
                {"alertRuleId", n => { AlertRuleId = n.GetStringValue(); } },
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatusType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>("alertImpact", AlertImpact);
            writer.WriteStringValue("alertRuleId", AlertRuleId);
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteEnumValue<AlertStatusType>("status", Status);
        }
    }
}

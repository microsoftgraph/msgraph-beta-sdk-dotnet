using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class AlertRecord : Entity, IParsable {
        /// <summary>The impact of the alert event. Consists of a number followed by the aggregation type. For example, 6 affectedCloudPcCount means that 6 Cloud PCs are affected. 12 affectedCloudPcPercentage means 12% of Cloud PCs are affected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact? AlertImpact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact?>("alertImpact"); }
            set { BackingStore?.Set("alertImpact", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact AlertImpact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>("alertImpact"); }
            set { BackingStore?.Set("alertImpact", value); }
        }
#endif
        /// <summary>The corresponding ID of the alert rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRuleId {
            get { return BackingStore?.Get<string?>("alertRuleId"); }
            set { BackingStore?.Set("alertRuleId", value); }
        }
#nullable restore
#else
        public string AlertRuleId {
            get { return BackingStore?.Get<string>("alertRuleId"); }
            set { BackingStore?.Set("alertRuleId", value); }
        }
#endif
        /// <summary>The rule template of the alert event. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>The date and time when the alert event was detected. The Timestamp type represents date and time information using ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DetectedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("detectedDateTime"); }
            set { BackingStore?.Set("detectedDateTime", value); }
        }
        /// <summary>The display name of the alert record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date and time when the alert record was last updated. The Timestamp type represents date and time information using ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The date and time when the alert event was resolved. The Timestamp type represents date and time information using ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ResolvedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedDateTime"); }
            set { BackingStore?.Set("resolvedDateTime", value); }
        }
        /// <summary>The severity of the alert event. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public RuleSeverityType? Severity {
            get { return BackingStore?.Get<RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status of the alert record. The possible values are: active, resolved, unknownFutureValue.</summary>
        public AlertStatusType? Status {
            get { return BackingStore?.Get<AlertStatusType?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class AlertRule : Entity, IParsable {
        /// <summary>The rule template of the alert event. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>The rule description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name of the rule.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The status of the rule that indicates whether the rule is enabled or disabled. If true, the rule is enabled; otherwise, the rule is disabled.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Indicates whether the rule is a system rule. If true, the rule is a system rule; otherwise, the rule is a custom defined rule and can be edited. System rules are built-in and only</summary>
        public bool? IsSystemRule {
            get { return BackingStore?.Get<bool?>("isSystemRule"); }
            set { BackingStore?.Set("isSystemRule", value); }
        }
        /// <summary>The notificationChannels property</summary>
        public List<NotificationChannel> NotificationChannels {
            get { return BackingStore?.Get<List<NotificationChannel>>("notificationChannels"); }
            set { BackingStore?.Set("notificationChannels", value); }
        }
        /// <summary>The severity property</summary>
        public RuleSeverityType? Severity {
            get { return BackingStore?.Get<RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The threshold property</summary>
        public RuleThreshold Threshold {
            get { return BackingStore?.Get<RuleThreshold>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
        /// <summary>
        /// Instantiates a new alertRule and sets the default values.
        /// </summary>
        public AlertRule() : base() {
            OdataType = "#microsoft.graph.deviceManagement.alertRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AlertRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"isSystemRule", n => { IsSystemRule = n.GetBoolValue(); } },
                {"notificationChannels", n => { NotificationChannels = n.GetCollectionOfObjectValues<NotificationChannel>(NotificationChannel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
                {"threshold", n => { Threshold = n.GetObjectValue<RuleThreshold>(RuleThreshold.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isSystemRule", IsSystemRule);
            writer.WriteCollectionOfObjectValues<NotificationChannel>("notificationChannels", NotificationChannels);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteObjectValue<RuleThreshold>("threshold", Threshold);
        }
    }
}

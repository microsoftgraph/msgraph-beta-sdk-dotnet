// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AlertRule : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The rule template of the alert event. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue, cloudPcInGracePeriodScenario, cloudPcFrontlineInsufficientLicensesScenario, cloudPcInaccessibleScenario, and cloudPcFrontlineConcurrencyScenario.  Use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: cloudPcInGracePeriodScenario, cloudPcFrontlineInsufficientLicensesScenario, cloudPcInaccessibleScenario, and cloudPcFrontlineConcurrencyScenario.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>The conditions that determine when to send alerts. For example, you can configure a condition to send an alert when provisioning fails for six or more Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition>? Conditions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition>?>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition> Conditions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition>>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#endif
        /// <summary>The rule description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The status of the rule that indicates whether the rule is enabled or disabled. If true, the rule is enabled; otherwise, the rule is disabled.</summary>
        public bool? Enabled
        {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Indicates whether the rule is a system rule. If true, the rule is a system rule; otherwise, the rule is a custom-defined rule and can be edited. System rules are built in and only a few properties can be edited.</summary>
        public bool? IsSystemRule
        {
            get { return BackingStore?.Get<bool?>("isSystemRule"); }
            set { BackingStore?.Set("isSystemRule", value); }
        }
        /// <summary>The notification channels of the rule selected by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel>? NotificationChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel>?>("notificationChannels"); }
            set { BackingStore?.Set("notificationChannels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel> NotificationChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel>>("notificationChannels"); }
            set { BackingStore?.Set("notificationChannels", value); }
        }
#endif
        /// <summary>The severity of the rule. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleSeverityType? Severity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The conditions that determine when to send alerts. For example, you can configure a condition to send an alert when provisioning fails for six or more Cloud PCs. This property is deprecated. Use conditions instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold? Threshold
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold?>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold Threshold
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate>(); } },
                { "conditions", n => { Conditions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition>(global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "isSystemRule", n => { IsSystemRule = n.GetBoolValue(); } },
                { "notificationChannels", n => { NotificationChannels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel>(global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleSeverityType>(); } },
                { "threshold", n => { Threshold = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold>(global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleCondition>("conditions", Conditions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isSystemRule", IsSystemRule);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannel>("notificationChannels", NotificationChannels);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleSeverityType>("severity", Severity);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagement.RuleThreshold>("threshold", Threshold);
        }
    }
}
#pragma warning restore CS0618

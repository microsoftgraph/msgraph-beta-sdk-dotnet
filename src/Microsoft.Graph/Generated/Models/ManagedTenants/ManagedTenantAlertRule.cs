using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenantAlertRule : Entity, IParsable {
        /// <summary>The alertDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AlertDisplayName {
            get { return BackingStore?.Get<string?>("alertDisplayName"); }
            set { BackingStore?.Set("alertDisplayName", value); }
        }
#else
        public string AlertDisplayName {
            get { return BackingStore?.Get<string>("alertDisplayName"); }
            set { BackingStore?.Set("alertDisplayName", value); }
        }
#endif
        /// <summary>The alerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedTenantAlert>? Alerts {
            get { return BackingStore?.Get<List<ManagedTenantAlert>?>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#else
        public List<ManagedTenantAlert> Alerts {
            get { return BackingStore?.Get<List<ManagedTenantAlert>>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#endif
        /// <summary>The alertTTL property</summary>
        public int? AlertTTL {
            get { return BackingStore?.Get<int?>("alertTTL"); }
            set { BackingStore?.Set("alertTTL", value); }
        }
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#else
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#else
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The lastRunDateTime property</summary>
        public DateTimeOffset? LastRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRunDateTime"); }
            set { BackingStore?.Set("lastRunDateTime", value); }
        }
        /// <summary>The notificationFinalDestinations property</summary>
        public NotificationDestination? NotificationFinalDestinations {
            get { return BackingStore?.Get<NotificationDestination?>("notificationFinalDestinations"); }
            set { BackingStore?.Set("notificationFinalDestinations", value); }
        }
        /// <summary>The ruleDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public ManagedTenantAlertRuleDefinition? RuleDefinition {
            get { return BackingStore?.Get<ManagedTenantAlertRuleDefinition?>("ruleDefinition"); }
            set { BackingStore?.Set("ruleDefinition", value); }
        }
#else
        public ManagedTenantAlertRuleDefinition RuleDefinition {
            get { return BackingStore?.Get<ManagedTenantAlertRuleDefinition>("ruleDefinition"); }
            set { BackingStore?.Set("ruleDefinition", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The targets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<NotificationTarget>? Targets {
            get { return BackingStore?.Get<List<NotificationTarget>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#else
        public List<NotificationTarget> Targets {
            get { return BackingStore?.Get<List<NotificationTarget>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The tenantIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TenantInfo>? TenantIds {
            get { return BackingStore?.Get<List<TenantInfo>?>("tenantIds"); }
            set { BackingStore?.Set("tenantIds", value); }
        }
#else
        public List<TenantInfo> TenantIds {
            get { return BackingStore?.Get<List<TenantInfo>>("tenantIds"); }
            set { BackingStore?.Set("tenantIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedTenantAlertRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenantAlertRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertDisplayName", n => { AlertDisplayName = n.GetStringValue(); } },
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<ManagedTenantAlert>(ManagedTenantAlert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertTTL", n => { AlertTTL = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRunDateTime", n => { LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"notificationFinalDestinations", n => { NotificationFinalDestinations = n.GetEnumValue<NotificationDestination>(); } },
                {"ruleDefinition", n => { RuleDefinition = n.GetObjectValue<ManagedTenantAlertRuleDefinition>(ManagedTenantAlertRuleDefinition.CreateFromDiscriminatorValue); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<NotificationTarget>(NotificationTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantIds", n => { TenantIds = n.GetCollectionOfObjectValues<TenantInfo>(TenantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("alertDisplayName", AlertDisplayName);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlert>("alerts", Alerts);
            writer.WriteIntValue("alertTTL", AlertTTL);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteEnumValue<NotificationDestination>("notificationFinalDestinations", NotificationFinalDestinations);
            writer.WriteObjectValue<ManagedTenantAlertRuleDefinition>("ruleDefinition", RuleDefinition);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteCollectionOfObjectValues<NotificationTarget>("targets", Targets);
            writer.WriteCollectionOfObjectValues<TenantInfo>("tenantIds", TenantIds);
        }
    }
}

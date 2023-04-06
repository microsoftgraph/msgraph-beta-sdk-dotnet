using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenantAlert : Entity, IParsable {
        /// <summary>The alertData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ManagedTenants.AlertData? AlertData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.AlertData?>("alertData"); }
            set { BackingStore?.Set("alertData", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ManagedTenants.AlertData AlertData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.AlertData>("alertData"); }
            set { BackingStore?.Set("alertData", value); }
        }
#endif
        /// <summary>The alertDataReferenceStrings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertDataReferenceString>? AlertDataReferenceStrings {
            get { return BackingStore?.Get<List<AlertDataReferenceString>?>("alertDataReferenceStrings"); }
            set { BackingStore?.Set("alertDataReferenceStrings", value); }
        }
#nullable restore
#else
        public List<AlertDataReferenceString> AlertDataReferenceStrings {
            get { return BackingStore?.Get<List<AlertDataReferenceString>>("alertDataReferenceStrings"); }
            set { BackingStore?.Set("alertDataReferenceStrings", value); }
        }
#endif
        /// <summary>The alertLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlertLog>? AlertLogs {
            get { return BackingStore?.Get<List<ManagedTenantAlertLog>?>("alertLogs"); }
            set { BackingStore?.Set("alertLogs", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlertLog> AlertLogs {
            get { return BackingStore?.Get<List<ManagedTenantAlertLog>>("alertLogs"); }
            set { BackingStore?.Set("alertLogs", value); }
        }
#endif
        /// <summary>The alertRule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedTenantAlertRule? AlertRule {
            get { return BackingStore?.Get<ManagedTenantAlertRule?>("alertRule"); }
            set { BackingStore?.Set("alertRule", value); }
        }
#nullable restore
#else
        public ManagedTenantAlertRule AlertRule {
            get { return BackingStore?.Get<ManagedTenantAlertRule>("alertRule"); }
            set { BackingStore?.Set("alertRule", value); }
        }
#endif
        /// <summary>The alertRuleDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRuleDisplayName {
            get { return BackingStore?.Get<string?>("alertRuleDisplayName"); }
            set { BackingStore?.Set("alertRuleDisplayName", value); }
        }
#nullable restore
#else
        public string AlertRuleDisplayName {
            get { return BackingStore?.Get<string>("alertRuleDisplayName"); }
            set { BackingStore?.Set("alertRuleDisplayName", value); }
        }
#endif
        /// <summary>The apiNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantApiNotification>? ApiNotifications {
            get { return BackingStore?.Get<List<ManagedTenantApiNotification>?>("apiNotifications"); }
            set { BackingStore?.Set("apiNotifications", value); }
        }
#nullable restore
#else
        public List<ManagedTenantApiNotification> ApiNotifications {
            get { return BackingStore?.Get<List<ManagedTenantApiNotification>>("apiNotifications"); }
            set { BackingStore?.Set("apiNotifications", value); }
        }
#endif
        /// <summary>The assignedToUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedToUserId {
            get { return BackingStore?.Get<string?>("assignedToUserId"); }
            set { BackingStore?.Set("assignedToUserId", value); }
        }
#nullable restore
#else
        public string AssignedToUserId {
            get { return BackingStore?.Get<string>("assignedToUserId"); }
            set { BackingStore?.Set("assignedToUserId", value); }
        }
#endif
        /// <summary>The correlationCount property</summary>
        public int? CorrelationCount {
            get { return BackingStore?.Get<int?>("correlationCount"); }
            set { BackingStore?.Set("correlationCount", value); }
        }
        /// <summary>The correlationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
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
        /// <summary>The emailNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantEmailNotification>? EmailNotifications {
            get { return BackingStore?.Get<List<ManagedTenantEmailNotification>?>("emailNotifications"); }
            set { BackingStore?.Set("emailNotifications", value); }
        }
#nullable restore
#else
        public List<ManagedTenantEmailNotification> EmailNotifications {
            get { return BackingStore?.Get<List<ManagedTenantEmailNotification>>("emailNotifications"); }
            set { BackingStore?.Set("emailNotifications", value); }
        }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
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
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public AlertStatus? Status {
            get { return BackingStore?.Get<AlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedTenantAlert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenantAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertData", n => { AlertData = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.AlertData>(Microsoft.Graph.Beta.Models.ManagedTenants.AlertData.CreateFromDiscriminatorValue); } },
                {"alertDataReferenceStrings", n => { AlertDataReferenceStrings = n.GetCollectionOfObjectValues<AlertDataReferenceString>(AlertDataReferenceString.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertLogs", n => { AlertLogs = n.GetCollectionOfObjectValues<ManagedTenantAlertLog>(ManagedTenantAlertLog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertRule", n => { AlertRule = n.GetObjectValue<ManagedTenantAlertRule>(ManagedTenantAlertRule.CreateFromDiscriminatorValue); } },
                {"alertRuleDisplayName", n => { AlertRuleDisplayName = n.GetStringValue(); } },
                {"apiNotifications", n => { ApiNotifications = n.GetCollectionOfObjectValues<ManagedTenantApiNotification>(ManagedTenantApiNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedToUserId", n => { AssignedToUserId = n.GetStringValue(); } },
                {"correlationCount", n => { CorrelationCount = n.GetIntValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"emailNotifications", n => { EmailNotifications = n.GetCollectionOfObjectValues<ManagedTenantEmailNotification>(ManagedTenantEmailNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.AlertData>("alertData", AlertData);
            writer.WriteCollectionOfObjectValues<AlertDataReferenceString>("alertDataReferenceStrings", AlertDataReferenceStrings);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertLog>("alertLogs", AlertLogs);
            writer.WriteObjectValue<ManagedTenantAlertRule>("alertRule", AlertRule);
            writer.WriteStringValue("alertRuleDisplayName", AlertRuleDisplayName);
            writer.WriteCollectionOfObjectValues<ManagedTenantApiNotification>("apiNotifications", ApiNotifications);
            writer.WriteStringValue("assignedToUserId", AssignedToUserId);
            writer.WriteIntValue("correlationCount", CorrelationCount);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ManagedTenantEmailNotification>("emailNotifications", EmailNotifications);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("title", Title);
        }
    }
}

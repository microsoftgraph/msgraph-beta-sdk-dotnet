using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleManagementAlert : Entity, IParsable {
        /// <summary>The alertConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleManagementAlertConfiguration? AlertConfiguration {
            get { return BackingStore?.Get<UnifiedRoleManagementAlertConfiguration?>("alertConfiguration"); }
            set { BackingStore?.Set("alertConfiguration", value); }
        }
#nullable restore
#else
        public UnifiedRoleManagementAlertConfiguration AlertConfiguration {
            get { return BackingStore?.Get<UnifiedRoleManagementAlertConfiguration>("alertConfiguration"); }
            set { BackingStore?.Set("alertConfiguration", value); }
        }
#endif
        /// <summary>The alertDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleManagementAlertDefinition? AlertDefinition {
            get { return BackingStore?.Get<UnifiedRoleManagementAlertDefinition?>("alertDefinition"); }
            set { BackingStore?.Set("alertDefinition", value); }
        }
#nullable restore
#else
        public UnifiedRoleManagementAlertDefinition AlertDefinition {
            get { return BackingStore?.Get<UnifiedRoleManagementAlertDefinition>("alertDefinition"); }
            set { BackingStore?.Set("alertDefinition", value); }
        }
#endif
        /// <summary>The alertDefinitionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertDefinitionId {
            get { return BackingStore?.Get<string?>("alertDefinitionId"); }
            set { BackingStore?.Set("alertDefinitionId", value); }
        }
#nullable restore
#else
        public string AlertDefinitionId {
            get { return BackingStore?.Get<string>("alertDefinitionId"); }
            set { BackingStore?.Set("alertDefinitionId", value); }
        }
#endif
        /// <summary>The alertIncidents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlertIncident>? AlertIncidents {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertIncident>?>("alertIncidents"); }
            set { BackingStore?.Set("alertIncidents", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementAlertIncident> AlertIncidents {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertIncident>>("alertIncidents"); }
            set { BackingStore?.Set("alertIncidents", value); }
        }
#endif
        /// <summary>The incidentCount property</summary>
        public int? IncidentCount {
            get { return BackingStore?.Get<int?>("incidentCount"); }
            set { BackingStore?.Set("incidentCount", value); }
        }
        /// <summary>The isActive property</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The lastScannedDateTime property</summary>
        public DateTimeOffset? LastScannedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastScannedDateTime"); }
            set { BackingStore?.Set("lastScannedDateTime", value); }
        }
        /// <summary>The scopeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId {
            get { return BackingStore?.Get<string?>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#nullable restore
#else
        public string ScopeId {
            get { return BackingStore?.Get<string>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#endif
        /// <summary>The scopeType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType {
            get { return BackingStore?.Get<string?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#nullable restore
#else
        public string ScopeType {
            get { return BackingStore?.Get<string>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementAlert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertConfiguration", n => { AlertConfiguration = n.GetObjectValue<UnifiedRoleManagementAlertConfiguration>(UnifiedRoleManagementAlertConfiguration.CreateFromDiscriminatorValue); } },
                {"alertDefinition", n => { AlertDefinition = n.GetObjectValue<UnifiedRoleManagementAlertDefinition>(UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue); } },
                {"alertDefinitionId", n => { AlertDefinitionId = n.GetStringValue(); } },
                {"alertIncidents", n => { AlertIncidents = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlertIncident>(UnifiedRoleManagementAlertIncident.CreateFromDiscriminatorValue)?.ToList(); } },
                {"incidentCount", n => { IncidentCount = n.GetIntValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastScannedDateTime", n => { LastScannedDateTime = n.GetDateTimeOffsetValue(); } },
                {"scopeId", n => { ScopeId = n.GetStringValue(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleManagementAlertConfiguration>("alertConfiguration", AlertConfiguration);
            writer.WriteObjectValue<UnifiedRoleManagementAlertDefinition>("alertDefinition", AlertDefinition);
            writer.WriteStringValue("alertDefinitionId", AlertDefinitionId);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlertIncident>("alertIncidents", AlertIncidents);
            writer.WriteIntValue("incidentCount", IncidentCount);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastScannedDateTime", LastScannedDateTime);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}

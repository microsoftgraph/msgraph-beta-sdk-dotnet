using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleManagementAlertConfiguration : Entity, IParsable {
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
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
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
        public static new UnifiedRoleManagementAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.invalidLicenseAlertConfiguration" => new InvalidLicenseAlertConfiguration(),
                "#microsoft.graph.noMfaOnRoleActivationAlertConfiguration" => new NoMfaOnRoleActivationAlertConfiguration(),
                "#microsoft.graph.redundantAssignmentAlertConfiguration" => new RedundantAssignmentAlertConfiguration(),
                "#microsoft.graph.rolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration" => new RolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration(),
                "#microsoft.graph.sequentialActivationRenewalsAlertConfiguration" => new SequentialActivationRenewalsAlertConfiguration(),
                "#microsoft.graph.staleSignInAlertConfiguration" => new StaleSignInAlertConfiguration(),
                "#microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration" => new TooManyGlobalAdminsAssignedToTenantAlertConfiguration(),
                _ => new UnifiedRoleManagementAlertConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertDefinition", n => { AlertDefinition = n.GetObjectValue<UnifiedRoleManagementAlertDefinition>(UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue); } },
                {"alertDefinitionId", n => { AlertDefinitionId = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
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
            writer.WriteObjectValue<UnifiedRoleManagementAlertDefinition>("alertDefinition", AlertDefinition);
            writer.WriteStringValue("alertDefinitionId", AlertDefinitionId);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}

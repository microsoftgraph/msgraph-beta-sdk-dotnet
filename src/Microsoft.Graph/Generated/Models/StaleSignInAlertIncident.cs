using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StaleSignInAlertIncident : UnifiedRoleManagementAlertIncident, IParsable {
        /// <summary>The assigneeDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeDisplayName {
            get { return BackingStore?.Get<string?>("assigneeDisplayName"); }
            set { BackingStore?.Set("assigneeDisplayName", value); }
        }
#nullable restore
#else
        public string AssigneeDisplayName {
            get { return BackingStore?.Get<string>("assigneeDisplayName"); }
            set { BackingStore?.Set("assigneeDisplayName", value); }
        }
#endif
        /// <summary>The assigneeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeId {
            get { return BackingStore?.Get<string?>("assigneeId"); }
            set { BackingStore?.Set("assigneeId", value); }
        }
#nullable restore
#else
        public string AssigneeId {
            get { return BackingStore?.Get<string>("assigneeId"); }
            set { BackingStore?.Set("assigneeId", value); }
        }
#endif
        /// <summary>The assigneeUserPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeUserPrincipalName {
            get { return BackingStore?.Get<string?>("assigneeUserPrincipalName"); }
            set { BackingStore?.Set("assigneeUserPrincipalName", value); }
        }
#nullable restore
#else
        public string AssigneeUserPrincipalName {
            get { return BackingStore?.Get<string>("assigneeUserPrincipalName"); }
            set { BackingStore?.Set("assigneeUserPrincipalName", value); }
        }
#endif
        /// <summary>The assignmentCreatedDateTime property</summary>
        public DateTimeOffset? AssignmentCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("assignmentCreatedDateTime"); }
            set { BackingStore?.Set("assignmentCreatedDateTime", value); }
        }
        /// <summary>The lastSignInDateTime property</summary>
        public DateTimeOffset? LastSignInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSignInDateTime"); }
            set { BackingStore?.Set("lastSignInDateTime", value); }
        }
        /// <summary>The roleDefinitionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The roleDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDisplayName {
            get { return BackingStore?.Get<string?>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#nullable restore
#else
        public string RoleDisplayName {
            get { return BackingStore?.Get<string>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#endif
        /// <summary>The roleTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId {
            get { return BackingStore?.Get<string?>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#nullable restore
#else
        public string RoleTemplateId {
            get { return BackingStore?.Get<string>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new StaleSignInAlertIncident and sets the default values.
        /// </summary>
        public StaleSignInAlertIncident() : base() {
            OdataType = "#microsoft.graph.staleSignInAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new StaleSignInAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StaleSignInAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assigneeDisplayName", n => { AssigneeDisplayName = n.GetStringValue(); } },
                {"assigneeId", n => { AssigneeId = n.GetStringValue(); } },
                {"assigneeUserPrincipalName", n => { AssigneeUserPrincipalName = n.GetStringValue(); } },
                {"assignmentCreatedDateTime", n => { AssignmentCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSignInDateTime", n => { LastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"roleDisplayName", n => { RoleDisplayName = n.GetStringValue(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assigneeDisplayName", AssigneeDisplayName);
            writer.WriteStringValue("assigneeId", AssigneeId);
            writer.WriteStringValue("assigneeUserPrincipalName", AssigneeUserPrincipalName);
            writer.WriteDateTimeOffsetValue("assignmentCreatedDateTime", AssignmentCreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastSignInDateTime", LastSignInDateTime);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("roleDisplayName", RoleDisplayName);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
        }
    }
}

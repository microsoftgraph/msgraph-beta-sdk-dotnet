using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UnifiedRoleScheduleBase : Entity, IParsable {
        /// <summary>Read-only property with details of the app specific scope when the assignment scope is app specific. Containment entity.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AppScope AppScope { get; set; }
        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.</summary>
        public string AppScopeId { get; set; }
        /// <summary>Time that the schedule was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Identifier of the roleAssignmentScheduleRequest that created this schedule.</summary>
        public string CreatedUsing { get; set; }
        /// <summary>Property referencing the directory object that is the scope of the assignment. Provided so that callers can get the directory object using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject DirectoryScope { get; set; }
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
        public string DirectoryScopeId { get; set; }
        /// <summary>Last time the schedule was updated.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Property referencing the principal that is getting a role assignment through the request. Provided so that callers can get the principal using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject Principal { get; set; }
        /// <summary>Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).</summary>
        public string PrincipalId { get; set; }
        /// <summary>Property indicating the roleDefinition the assignment is for. Provided so that callers can get the role definition using $expand at the same time as getting the role assignment. roleDefinition.Id will be auto expanded.</summary>
        public UnifiedRoleDefinition RoleDefinition { get; set; }
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appScope", (o,n) => { (o as UnifiedRoleScheduleBase).AppScope = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AppScope>(); } },
                {"appScopeId", (o,n) => { (o as UnifiedRoleScheduleBase).AppScopeId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as UnifiedRoleScheduleBase).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdUsing", (o,n) => { (o as UnifiedRoleScheduleBase).CreatedUsing = n.GetStringValue(); } },
                {"directoryScope", (o,n) => { (o as UnifiedRoleScheduleBase).DirectoryScope = n.GetObjectValue<DirectoryObject>(); } },
                {"directoryScopeId", (o,n) => { (o as UnifiedRoleScheduleBase).DirectoryScopeId = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as UnifiedRoleScheduleBase).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"principal", (o,n) => { (o as UnifiedRoleScheduleBase).Principal = n.GetObjectValue<DirectoryObject>(); } },
                {"principalId", (o,n) => { (o as UnifiedRoleScheduleBase).PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as UnifiedRoleScheduleBase).RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(); } },
                {"roleDefinitionId", (o,n) => { (o as UnifiedRoleScheduleBase).RoleDefinitionId = n.GetStringValue(); } },
                {"status", (o,n) => { (o as UnifiedRoleScheduleBase).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("createdUsing", CreatedUsing);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("status", Status);
        }
    }
}

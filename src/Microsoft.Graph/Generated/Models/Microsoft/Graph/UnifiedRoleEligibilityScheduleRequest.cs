using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UnifiedRoleEligibilityScheduleRequest : Request, IParsable {
        /// <summary>Represents the type of the operation on the role eligibility assignment. The possible values are: AdminAssign: For administrators to assign role eligibility to users or groups to roles.AdminExtend: For administrators to extend expiring assignments.AdminUpdate: For administrators to change existing role assignments.AdminRenew: For administrators to renew expired assignments.AdminRemove: For administrators to remove users or groups from eligible roles.UserAdd: For users to activate their eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.</summary>
        public string Action { get; set; }
        /// <summary>Read-only property with details of the app-specific scope when the assignment scope is app-specific. Containment entity.</summary>
        public AppScope AppScope { get; set; }
        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.</summary>
        public string AppScopeId { get; set; }
        /// <summary>Property referencing the directory object that is the scope of the assignment. Provided so that callers can get the directory object using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject DirectoryScope { get; set; }
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
        public string DirectoryScopeId { get; set; }
        /// <summary>A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly { get; set; }
        /// <summary>A message provided by users and administrators when create the request about why it is needed.</summary>
        public string Justification { get; set; }
        /// <summary>Property referencing the principal that is getting a role assignment through the request. Provided so that callers can get the principal using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject Principal { get; set; }
        /// <summary>Identifier of the principal to which the assignment is being granted to. For example, a user or a group. For groups, they must be assignable to roles, that is, the isAssignableToRole of the group property set to true.</summary>
        public string PrincipalId { get; set; }
        /// <summary>Property indicating the roleDefinition the assignment is for. Provided so that callers can get the role definition using $expand at the same time as getting the role assignment. roleDefinition.Id will be auto expanded.</summary>
        public UnifiedRoleDefinition RoleDefinition { get; set; }
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for. Read only.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The schedule object of the role assignment request.</summary>
        public RequestSchedule ScheduleInfo { get; set; }
        /// <summary>Property indicating the schedule for an eligible role assignment.</summary>
        public UnifiedRoleEligibilitySchedule TargetSchedule { get; set; }
        /// <summary>The time period for which the eligibility assignment is valid.</summary>
        public string TargetScheduleId { get; set; }
        /// <summary>The details of the ticket number and ticket system that is attached to the role assignment request.</summary>
        public TicketInfo TicketInfo { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"action", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).Action = n.GetStringValue(); } },
                {"appScope", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).AppScope = n.GetObjectValue<AppScope>(); } },
                {"appScopeId", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).AppScopeId = n.GetStringValue(); } },
                {"directoryScope", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).DirectoryScope = n.GetObjectValue<DirectoryObject>(); } },
                {"directoryScopeId", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).DirectoryScopeId = n.GetStringValue(); } },
                {"isValidationOnly", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).IsValidationOnly = n.GetBoolValue(); } },
                {"justification", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).Justification = n.GetStringValue(); } },
                {"principal", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).Principal = n.GetObjectValue<DirectoryObject>(); } },
                {"principalId", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(); } },
                {"roleDefinitionId", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).RoleDefinitionId = n.GetStringValue(); } },
                {"scheduleInfo", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).ScheduleInfo = n.GetObjectValue<RequestSchedule>(); } },
                {"targetSchedule", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).TargetSchedule = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(); } },
                {"targetScheduleId", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).TargetScheduleId = n.GetStringValue(); } },
                {"ticketInfo", (o,n) => { (o as UnifiedRoleEligibilityScheduleRequest).TicketInfo = n.GetObjectValue<TicketInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("action", Action);
            writer.WriteObjectValue<AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<UnifiedRoleEligibilitySchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
            writer.WriteObjectValue<TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}

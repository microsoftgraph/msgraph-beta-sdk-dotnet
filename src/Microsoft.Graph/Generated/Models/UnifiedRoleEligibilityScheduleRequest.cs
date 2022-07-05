using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleEligibilityScheduleRequest : Request, IParsable {
        /// <summary>Represents the type of operation on the role eligibility request. The possible values are: AdminAssign: For administrators to assign eligible roles to principals.AdminRemove: For administrators to remove eligible roles from principals. AdminUpdate: For administrators to change existing role eligibilities.AdminExtend: For administrators to extend expiring role eligibilities.AdminRenew: For administrators to renew expired eligibilities.UserAdd: For users to activate their eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.</summary>
        public string Action {
            get { return BackingStore?.Get<string>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>Read-only property with details of the app-specific scope when the role eligibility is scoped to an app. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AppScope AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppScope>(nameof(AppScope)); }
            set { BackingStore?.Set(nameof(AppScope), value); }
        }
        /// <summary>Identifier of the app-specific scope when the role eligibility is scoped to an app. The scope of a role eligibility determines the set of resources for which the principal is eligible to access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, ne, and on null values).</summary>
        public string AppScopeId {
            get { return BackingStore?.Get<string>(nameof(AppScopeId)); }
            set { BackingStore?.Set(nameof(AppScopeId), value); }
        }
        /// <summary>The directory object that is the scope of the role eligibility. Read-only. Supports $expand.</summary>
        public DirectoryObject DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject>(nameof(DirectoryScope)); }
            set { BackingStore?.Set(nameof(DirectoryScope), value); }
        }
        /// <summary>Identifier of the directory object representing the scope of the role eligibility. The scope of a role eligibility determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, ne, and on null values).</summary>
        public string DirectoryScopeId {
            get { return BackingStore?.Get<string>(nameof(DirectoryScopeId)); }
            set { BackingStore?.Set(nameof(DirectoryScopeId), value); }
        }
        /// <summary>Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>(nameof(IsValidationOnly)); }
            set { BackingStore?.Set(nameof(IsValidationOnly), value); }
        }
        /// <summary>A message provided by users and administrators when create they create the unifiedRoleEligibilityScheduleRequest object.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>The principal that&apos;s getting a role eligibility through the request. Supports $expand.</summary>
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>(nameof(Principal)); }
            set { BackingStore?.Set(nameof(Principal), value); }
        }
        /// <summary>Identifier of the principal that has been granted the role eligibility. Supports $filter (eq, ne).</summary>
        public string PrincipalId {
            get { return BackingStore?.Get<string>(nameof(PrincipalId)); }
            set { BackingStore?.Set(nameof(PrincipalId), value); }
        }
        /// <summary>Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property. Supports $expand.</summary>
        public UnifiedRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition>(nameof(RoleDefinition)); }
            set { BackingStore?.Set(nameof(RoleDefinition), value); }
        }
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal. Supports $filter (eq, ne).</summary>
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RoleDefinitionId)); }
            set { BackingStore?.Set(nameof(RoleDefinitionId), value); }
        }
        /// <summary>The period of the role eligibility. Recurring schedules are currently unsupported.</summary>
        public RequestSchedule ScheduleInfo {
            get { return BackingStore?.Get<RequestSchedule>(nameof(ScheduleInfo)); }
            set { BackingStore?.Set(nameof(ScheduleInfo), value); }
        }
        /// <summary>The schedule for a role eligibility that is referenced through the targetScheduleId property. Supports $expand.</summary>
        public UnifiedRoleEligibilitySchedule TargetSchedule {
            get { return BackingStore?.Get<UnifiedRoleEligibilitySchedule>(nameof(TargetSchedule)); }
            set { BackingStore?.Set(nameof(TargetSchedule), value); }
        }
        /// <summary>Identifier of the schedule object that&apos;s linked to the eligibility request. Supports $filter (eq, ne).</summary>
        public string TargetScheduleId {
            get { return BackingStore?.Get<string>(nameof(TargetScheduleId)); }
            set { BackingStore?.Set(nameof(TargetScheduleId), value); }
        }
        /// <summary>Ticket details linked to the role eligibility request including details of the ticket number and ticket system. Optional.</summary>
        public Microsoft.Graph.Beta.Models.TicketInfo TicketInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TicketInfo>(nameof(TicketInfo)); }
            set { BackingStore?.Set(nameof(TicketInfo), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleEligibilityScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetStringValue(); } },
                {"appScope", n => { AppScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.AppScope>(Microsoft.Graph.Beta.Models.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                {"directoryScope", n => { DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
                {"ticketInfo", n => { TicketInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.TicketInfo>(Microsoft.Graph.Beta.Models.TicketInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AppScope>("appScope", AppScope);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}

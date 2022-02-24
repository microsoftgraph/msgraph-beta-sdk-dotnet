using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceRoleAssignmentRequest : Entity, IParsable {
        /// <summary>Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).</summary>
        public string AssignmentState { get; set; }
        /// <summary>If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.</summary>
        public string LinkedEligibleRoleAssignmentId { get; set; }
        /// <summary>A message provided by users and administrators when create the request about why it is needed.</summary>
        public string Reason { get; set; }
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RequestedDateTime { get; set; }
        /// <summary>Read-only. The resource that the request aims to.</summary>
        public GovernanceResource Resource { get; set; }
        /// <summary>Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.</summary>
        public string ResourceId { get; set; }
        /// <summary>Read-only. The role definition that the request aims to.</summary>
        public GovernanceRoleDefinition RoleDefinition { get; set; }
        /// <summary>Required. The identifier of the Azure role definition that the role assignment request is associated with.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The schedule object of the role assignment request.</summary>
        public GovernanceSchedule Schedule { get; set; }
        /// <summary>The status of the role assignment request.</summary>
        public GovernanceRoleAssignmentRequestStatus Status { get; set; }
        /// <summary>Read-only. The user/group principal.</summary>
        public GovernanceSubject Subject { get; set; }
        /// <summary>Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.</summary>
        public string SubjectId { get; set; }
        /// <summary>Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.</summary>
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentState", (o,n) => { (o as GovernanceRoleAssignmentRequest).AssignmentState = n.GetStringValue(); } },
                {"linkedEligibleRoleAssignmentId", (o,n) => { (o as GovernanceRoleAssignmentRequest).LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as GovernanceRoleAssignmentRequest).Reason = n.GetStringValue(); } },
                {"requestedDateTime", (o,n) => { (o as GovernanceRoleAssignmentRequest).RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", (o,n) => { (o as GovernanceRoleAssignmentRequest).Resource = n.GetObjectValue<GovernanceResource>(); } },
                {"resourceId", (o,n) => { (o as GovernanceRoleAssignmentRequest).ResourceId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as GovernanceRoleAssignmentRequest).RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(); } },
                {"roleDefinitionId", (o,n) => { (o as GovernanceRoleAssignmentRequest).RoleDefinitionId = n.GetStringValue(); } },
                {"schedule", (o,n) => { (o as GovernanceRoleAssignmentRequest).Schedule = n.GetObjectValue<GovernanceSchedule>(); } },
                {"status", (o,n) => { (o as GovernanceRoleAssignmentRequest).Status = n.GetObjectValue<GovernanceRoleAssignmentRequestStatus>(); } },
                {"subject", (o,n) => { (o as GovernanceRoleAssignmentRequest).Subject = n.GetObjectValue<GovernanceSubject>(); } },
                {"subjectId", (o,n) => { (o as GovernanceRoleAssignmentRequest).SubjectId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as GovernanceRoleAssignmentRequest).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("reason", Reason);
            writer.WriteDateTimeOffsetValue("requestedDateTime", RequestedDateTime);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<GovernanceSchedule>("schedule", Schedule);
            writer.WriteObjectValue<GovernanceRoleAssignmentRequestStatus>("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
            writer.WriteStringValue("type", Type);
        }
    }
}

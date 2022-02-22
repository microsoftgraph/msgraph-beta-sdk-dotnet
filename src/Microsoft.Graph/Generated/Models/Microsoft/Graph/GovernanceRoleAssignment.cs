using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class GovernanceRoleAssignment : Entity, IParsable {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment or Active if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
        public string AssignmentState { get; set; }
        /// <summary>For a non-permanent role assignment, this is the time when the role assignment will be expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID the resource that is used to identify the role assignment in the provider.</summary>
        public string ExternalId { get; set; }
        /// <summary>Read-only. If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.</summary>
        public GovernanceRoleAssignment LinkedEligibleRoleAssignment { get; set; }
        /// <summary>If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.</summary>
        public string LinkedEligibleRoleAssignmentId { get; set; }
        /// <summary>The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment is not inherited, but comes from the membership of a group assignment), or User (if the role assignment is neither inherited nor from a group assignment).</summary>
        public string MemberType { get; set; }
        /// <summary>Read-only. The resource associated with the role assignment.</summary>
        public GovernanceResource Resource { get; set; }
        /// <summary>Required. The ID of the resource which the role assignment is associated with.</summary>
        public string ResourceId { get; set; }
        /// <summary>Read-only. The role definition associated with the role assignment.</summary>
        public GovernanceRoleDefinition RoleDefinition { get; set; }
        /// <summary>Required. The ID of the role definition which the role assignment is associated with.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        public string Status { get; set; }
        /// <summary>Read-only. The subject associated with the role assignment.</summary>
        public GovernanceSubject Subject { get; set; }
        /// <summary>Required. The ID of the subject which the role assignment is associated with.</summary>
        public string SubjectId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentState", (o,n) => { (o as GovernanceRoleAssignment).AssignmentState = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as GovernanceRoleAssignment).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as GovernanceRoleAssignment).ExternalId = n.GetStringValue(); } },
                {"linkedEligibleRoleAssignment", (o,n) => { (o as GovernanceRoleAssignment).LinkedEligibleRoleAssignment = n.GetObjectValue<GovernanceRoleAssignment>(); } },
                {"linkedEligibleRoleAssignmentId", (o,n) => { (o as GovernanceRoleAssignment).LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                {"memberType", (o,n) => { (o as GovernanceRoleAssignment).MemberType = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as GovernanceRoleAssignment).Resource = n.GetObjectValue<GovernanceResource>(); } },
                {"resourceId", (o,n) => { (o as GovernanceRoleAssignment).ResourceId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as GovernanceRoleAssignment).RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(); } },
                {"roleDefinitionId", (o,n) => { (o as GovernanceRoleAssignment).RoleDefinitionId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as GovernanceRoleAssignment).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as GovernanceRoleAssignment).Status = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as GovernanceRoleAssignment).Subject = n.GetObjectValue<GovernanceSubject>(); } },
                {"subjectId", (o,n) => { (o as GovernanceRoleAssignment).SubjectId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<GovernanceRoleAssignment>("linkedEligibleRoleAssignment", LinkedEligibleRoleAssignment);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}

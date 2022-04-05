using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleAssignmentRequest : Entity, IParsable {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment Active - if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
        public string AssignmentState { get; set; }
        /// <summary>The duration of a role assignment.</summary>
        public string Duration { get; set; }
        /// <summary>The reason for the role assignment.</summary>
        public string Reason { get; set; }
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RequestedDateTime { get; set; }
        /// <summary>The id of the role.</summary>
        public string RoleId { get; set; }
        /// <summary>The roleInfo object of the role assignment request.</summary>
        public PrivilegedRole RoleInfo { get; set; }
        /// <summary>The schedule object of the role assignment request.</summary>
        public GovernanceSchedule Schedule { get; set; }
        /// <summary>Read-only.The status of the role assignment request. The value can be NotStarted,Completed,RequestedApproval,Scheduled,Approved,ApprovalDenied,ApprovalAborted,Cancelling,Cancelled,Revoked,RequestExpired.</summary>
        public string Status { get; set; }
        /// <summary>The ticketNumber for the role assignment.</summary>
        public string TicketNumber { get; set; }
        /// <summary>The ticketSystem for the role assignment.</summary>
        public string TicketSystem { get; set; }
        /// <summary>Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators add users to roles;UserAdd: Users add role assignments.</summary>
        public string Type { get; set; }
        /// <summary>The id of the user.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedRoleAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentState", (o,n) => { (o as PrivilegedRoleAssignmentRequest).AssignmentState = n.GetStringValue(); } },
                {"duration", (o,n) => { (o as PrivilegedRoleAssignmentRequest).Duration = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as PrivilegedRoleAssignmentRequest).Reason = n.GetStringValue(); } },
                {"requestedDateTime", (o,n) => { (o as PrivilegedRoleAssignmentRequest).RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleId", (o,n) => { (o as PrivilegedRoleAssignmentRequest).RoleId = n.GetStringValue(); } },
                {"roleInfo", (o,n) => { (o as PrivilegedRoleAssignmentRequest).RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"schedule", (o,n) => { (o as PrivilegedRoleAssignmentRequest).Schedule = n.GetObjectValue<GovernanceSchedule>(GovernanceSchedule.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as PrivilegedRoleAssignmentRequest).Status = n.GetStringValue(); } },
                {"ticketNumber", (o,n) => { (o as PrivilegedRoleAssignmentRequest).TicketNumber = n.GetStringValue(); } },
                {"ticketSystem", (o,n) => { (o as PrivilegedRoleAssignmentRequest).TicketSystem = n.GetStringValue(); } },
                {"type", (o,n) => { (o as PrivilegedRoleAssignmentRequest).Type = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as PrivilegedRoleAssignmentRequest).UserId = n.GetStringValue(); } },
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
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("reason", Reason);
            writer.WriteDateTimeOffsetValue("requestedDateTime", RequestedDateTime);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteObjectValue<GovernanceSchedule>("schedule", Schedule);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("ticketNumber", TicketNumber);
            writer.WriteStringValue("ticketSystem", TicketSystem);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userId", UserId);
        }
    }
}

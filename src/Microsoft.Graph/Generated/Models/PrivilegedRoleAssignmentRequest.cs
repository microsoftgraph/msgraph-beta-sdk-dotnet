using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of privilegedRoleAssignmentRequest entities.</summary>
    public class PrivilegedRoleAssignmentRequest : Entity, IParsable {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment Active - if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
        public string AssignmentState {
            get { return BackingStore?.Get<string>(nameof(AssignmentState)); }
            set { BackingStore?.Set(nameof(AssignmentState), value); }
        }
        /// <summary>The duration of a role assignment.</summary>
        public string Duration {
            get { return BackingStore?.Get<string>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>The reason for the role assignment.</summary>
        public string Reason {
            get { return BackingStore?.Get<string>(nameof(Reason)); }
            set { BackingStore?.Set(nameof(Reason), value); }
        }
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RequestedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RequestedDateTime)); }
            set { BackingStore?.Set(nameof(RequestedDateTime), value); }
        }
        /// <summary>The id of the role.</summary>
        public string RoleId {
            get { return BackingStore?.Get<string>(nameof(RoleId)); }
            set { BackingStore?.Set(nameof(RoleId), value); }
        }
        /// <summary>The roleInfo object of the role assignment request.</summary>
        public PrivilegedRole RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole>(nameof(RoleInfo)); }
            set { BackingStore?.Set(nameof(RoleInfo), value); }
        }
        /// <summary>The schedule object of the role assignment request.</summary>
        public GovernanceSchedule Schedule {
            get { return BackingStore?.Get<GovernanceSchedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>Read-only.The status of the role assignment request. The value can be NotStarted,Completed,RequestedApproval,Scheduled,Approved,ApprovalDenied,ApprovalAborted,Cancelling,Cancelled,Revoked,RequestExpired.</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The ticketNumber for the role assignment.</summary>
        public string TicketNumber {
            get { return BackingStore?.Get<string>(nameof(TicketNumber)); }
            set { BackingStore?.Set(nameof(TicketNumber), value); }
        }
        /// <summary>The ticketSystem for the role assignment.</summary>
        public string TicketSystem {
            get { return BackingStore?.Get<string>(nameof(TicketSystem)); }
            set { BackingStore?.Set(nameof(TicketSystem), value); }
        }
        /// <summary>Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators add users to roles;UserAdd: Users add role assignments.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The id of the user.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"requestedDateTime", n => { RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleInfo", n => { RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"schedule", n => { Schedule = n.GetObjectValue<GovernanceSchedule>(GovernanceSchedule.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"ticketNumber", n => { TicketNumber = n.GetStringValue(); } },
                {"ticketSystem", n => { TicketSystem = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
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

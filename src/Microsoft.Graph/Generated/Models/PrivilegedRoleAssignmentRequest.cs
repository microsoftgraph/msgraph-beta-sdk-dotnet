using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleAssignmentRequest : Entity, IParsable {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment Active - if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState {
            get { return BackingStore?.Get<string?>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#nullable restore
#else
        public string AssignmentState {
            get { return BackingStore?.Get<string>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#endif
        /// <summary>The duration of a role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Duration {
            get { return BackingStore?.Get<string?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
#nullable restore
#else
        public string Duration {
            get { return BackingStore?.Get<string>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
#endif
        /// <summary>The reason for the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RequestedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedDateTime"); }
            set { BackingStore?.Set("requestedDateTime", value); }
        }
        /// <summary>The id of the role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId {
            get { return BackingStore?.Get<string?>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#nullable restore
#else
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#endif
        /// <summary>The roleInfo object of the role assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedRole? RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole?>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#nullable restore
#else
        public PrivilegedRole RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#endif
        /// <summary>The schedule object of the role assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceSchedule? Schedule {
            get { return BackingStore?.Get<GovernanceSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public GovernanceSchedule Schedule {
            get { return BackingStore?.Get<GovernanceSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>Read-only.The status of the role assignment request. The value can be NotStarted,Completed,RequestedApproval,Scheduled,Approved,ApprovalDenied,ApprovalAborted,Cancelling,Cancelled,Revoked,RequestExpired.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The ticketNumber for the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TicketNumber {
            get { return BackingStore?.Get<string?>("ticketNumber"); }
            set { BackingStore?.Set("ticketNumber", value); }
        }
#nullable restore
#else
        public string TicketNumber {
            get { return BackingStore?.Get<string>("ticketNumber"); }
            set { BackingStore?.Set("ticketNumber", value); }
        }
#endif
        /// <summary>The ticketSystem for the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TicketSystem {
            get { return BackingStore?.Get<string?>("ticketSystem"); }
            set { BackingStore?.Set("ticketSystem", value); }
        }
#nullable restore
#else
        public string TicketSystem {
            get { return BackingStore?.Get<string>("ticketSystem"); }
            set { BackingStore?.Set("ticketSystem", value); }
        }
#endif
        /// <summary>Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators add users to roles;UserAdd: Users add role assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>The id of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

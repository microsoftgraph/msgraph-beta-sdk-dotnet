using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrivilegedApproval : Entity, IParsable {
        /// <summary>The approvalDuration property</summary>
        public TimeSpan? ApprovalDuration { get; set; }
        /// <summary>Possible values are: pending, approved, denied, aborted, canceled.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ApprovalState? ApprovalState { get; set; }
        /// <summary>The approvalType property</summary>
        public string ApprovalType { get; set; }
        /// <summary>The approverReason property</summary>
        public string ApproverReason { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Read-only. The role assignment request for this approval object</summary>
        public PrivilegedRoleAssignmentRequest Request { get; set; }
        /// <summary>The requestorReason property</summary>
        public string RequestorReason { get; set; }
        /// <summary>The roleId property</summary>
        public string RoleId { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public PrivilegedRole RoleInfo { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The userId property</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedApproval CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"approvalDuration", (o,n) => { (o as PrivilegedApproval).ApprovalDuration = n.GetTimeSpanValue(); } },
                {"approvalState", (o,n) => { (o as PrivilegedApproval).ApprovalState = n.GetEnumValue<ApprovalState>(); } },
                {"approvalType", (o,n) => { (o as PrivilegedApproval).ApprovalType = n.GetStringValue(); } },
                {"approverReason", (o,n) => { (o as PrivilegedApproval).ApproverReason = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as PrivilegedApproval).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"request", (o,n) => { (o as PrivilegedApproval).Request = n.GetObjectValue<PrivilegedRoleAssignmentRequest>(PrivilegedRoleAssignmentRequest.CreateFromDiscriminatorValue); } },
                {"requestorReason", (o,n) => { (o as PrivilegedApproval).RequestorReason = n.GetStringValue(); } },
                {"roleId", (o,n) => { (o as PrivilegedApproval).RoleId = n.GetStringValue(); } },
                {"roleInfo", (o,n) => { (o as PrivilegedApproval).RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"startDateTime", (o,n) => { (o as PrivilegedApproval).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", (o,n) => { (o as PrivilegedApproval).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("approvalDuration", ApprovalDuration);
            writer.WriteEnumValue<ApprovalState>("approvalState", ApprovalState);
            writer.WriteStringValue("approvalType", ApprovalType);
            writer.WriteStringValue("approverReason", ApproverReason);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<PrivilegedRoleAssignmentRequest>("request", Request);
            writer.WriteStringValue("requestorReason", RequestorReason);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}

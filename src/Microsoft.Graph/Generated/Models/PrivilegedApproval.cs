using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedApproval : Entity, IParsable {
        /// <summary>The approvalDuration property</summary>
        public TimeSpan? ApprovalDuration { get; set; }
        /// <summary>Possible values are: pending, approved, denied, aborted, canceled.</summary>
        public Microsoft.Graph.Beta.Models.ApprovalState? ApprovalState { get; set; }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalDuration", n => { ApprovalDuration = n.GetTimeSpanValue(); } },
                {"approvalState", n => { ApprovalState = n.GetEnumValue<ApprovalState>(); } },
                {"approvalType", n => { ApprovalType = n.GetStringValue(); } },
                {"approverReason", n => { ApproverReason = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"request", n => { Request = n.GetObjectValue<PrivilegedRoleAssignmentRequest>(PrivilegedRoleAssignmentRequest.CreateFromDiscriminatorValue); } },
                {"requestorReason", n => { RequestorReason = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleInfo", n => { RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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

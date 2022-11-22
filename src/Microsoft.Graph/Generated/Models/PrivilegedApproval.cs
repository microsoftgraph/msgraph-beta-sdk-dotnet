using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class PrivilegedApproval : Entity, IParsable {
        /// <summary>The approvalDuration property</summary>
        public TimeSpan? ApprovalDuration {
            get { return BackingStore?.Get<TimeSpan?>("approvalDuration"); }
            set { BackingStore?.Set("approvalDuration", value); }
        }
        /// <summary>Possible values are: pending, approved, denied, aborted, canceled.</summary>
        public Microsoft.Graph.Beta.Models.ApprovalState? ApprovalState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApprovalState?>("approvalState"); }
            set { BackingStore?.Set("approvalState", value); }
        }
        /// <summary>The approvalType property</summary>
        public string ApprovalType {
            get { return BackingStore?.Get<string>("approvalType"); }
            set { BackingStore?.Set("approvalType", value); }
        }
        /// <summary>The approverReason property</summary>
        public string ApproverReason {
            get { return BackingStore?.Get<string>("approverReason"); }
            set { BackingStore?.Set("approverReason", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Read-only. The role assignment request for this approval object</summary>
        public PrivilegedRoleAssignmentRequest Request {
            get { return BackingStore?.Get<PrivilegedRoleAssignmentRequest>("request"); }
            set { BackingStore?.Set("request", value); }
        }
        /// <summary>The requestorReason property</summary>
        public string RequestorReason {
            get { return BackingStore?.Get<string>("requestorReason"); }
            set { BackingStore?.Set("requestorReason", value); }
        }
        /// <summary>The roleId property</summary>
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
        /// <summary>The roleInfo property</summary>
        public PrivilegedRole RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The userId property</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the roleManagement singleton.</summary>
    public class UnifiedRoleAssignmentScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>If the roleAssignmentScheduleInstance is activated by a roleEligibilityScheduleRequest, this is the link to the related schedule instance.</summary>
        public UnifiedRoleEligibilityScheduleInstance ActivatedUsing { get; set; }
        /// <summary>Type of the assignment. It can either be Assigned or Activated.</summary>
        public string AssignmentType { get; set; }
        /// <summary>Time that the roleAssignmentInstance will expire</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Membership type of the assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType { get; set; }
        /// <summary>ID of the roleAssignment in the directory</summary>
        public string RoleAssignmentOriginId { get; set; }
        /// <summary>ID of the parent roleAssignmentSchedule for this instance</summary>
        public string RoleAssignmentScheduleId { get; set; }
        /// <summary>Time that the roleAssignmentInstance will start</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleAssignmentScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleAssignmentScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activatedUsing", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).ActivatedUsing = n.GetObjectValue<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue); } },
                {"assignmentType", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).AssignmentType = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).MemberType = n.GetStringValue(); } },
                {"roleAssignmentOriginId", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).RoleAssignmentOriginId = n.GetStringValue(); } },
                {"roleAssignmentScheduleId", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).RoleAssignmentScheduleId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as UnifiedRoleAssignmentScheduleInstance).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleEligibilityScheduleInstance>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentType", AssignmentType);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteStringValue("roleAssignmentOriginId", RoleAssignmentOriginId);
            writer.WriteStringValue("roleAssignmentScheduleId", RoleAssignmentScheduleId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}

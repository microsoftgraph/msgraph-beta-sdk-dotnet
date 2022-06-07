using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the roleManagement singleton.</summary>
    public class UnifiedRoleAssignmentScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation. Otherwise, it is null. Supports $expand.</summary>
        public UnifiedRoleEligibilityScheduleInstance ActivatedUsing {
            get { return BackingStore?.Get<UnifiedRoleEligibilityScheduleInstance>(nameof(ActivatedUsing)); }
            set { BackingStore?.Set(nameof(ActivatedUsing), value); }
        }
        /// <summary>Type of the assignment which can either be Assigned or Activated. Supports $filter (eq, ne).</summary>
        public string AssignmentType {
            get { return BackingStore?.Get<string>(nameof(AssignmentType)); }
            set { BackingStore?.Set(nameof(AssignmentType), value); }
        }
        /// <summary>The end date of the schedule instance.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>How the assignments is inherited. It can either be Inherited, Direct, or Group. It can further imply whether the unifiedRoleAssignmentSchedule can be managed by the caller. Supports $filter (eq, ne).</summary>
        public string MemberType {
            get { return BackingStore?.Get<string>(nameof(MemberType)); }
            set { BackingStore?.Set(nameof(MemberType), value); }
        }
        /// <summary>The identifier of the role assignment in Azure AD.</summary>
        public string RoleAssignmentOriginId {
            get { return BackingStore?.Get<string>(nameof(RoleAssignmentOriginId)); }
            set { BackingStore?.Set(nameof(RoleAssignmentOriginId), value); }
        }
        /// <summary>The identifier of the unifiedRoleAssignmentSchedule object from which this instance was created.</summary>
        public string RoleAssignmentScheduleId {
            get { return BackingStore?.Get<string>(nameof(RoleAssignmentScheduleId)); }
            set { BackingStore?.Set(nameof(RoleAssignmentScheduleId), value); }
        }
        /// <summary>When this instance starts.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activatedUsing", n => { ActivatedUsing = n.GetObjectValue<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue); } },
                {"assignmentType", n => { AssignmentType = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"roleAssignmentOriginId", n => { RoleAssignmentOriginId = n.GetStringValue(); } },
                {"roleAssignmentScheduleId", n => { RoleAssignmentScheduleId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UnifiedRoleAssignmentSchedule : UnifiedRoleScheduleBase, IParsable {
        /// <summary>If the roleAssignmentSchedule is activated by a roleEligibilitySchedule, this is the link to that schedule.</summary>
        public UnifiedRoleEligibilitySchedule ActivatedUsing { get; set; }
        /// <summary>Type of the assignment. It can either be Assigned or Activated.</summary>
        public string AssignmentType { get; set; }
        /// <summary>Membership type of the assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType { get; set; }
        /// <summary>The schedule object of the role assignment request.</summary>
        public RequestSchedule ScheduleInfo { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activatedUsing", (o,n) => { (o as UnifiedRoleAssignmentSchedule).ActivatedUsing = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(); } },
                {"assignmentType", (o,n) => { (o as UnifiedRoleAssignmentSchedule).AssignmentType = n.GetStringValue(); } },
                {"memberType", (o,n) => { (o as UnifiedRoleAssignmentSchedule).MemberType = n.GetStringValue(); } },
                {"scheduleInfo", (o,n) => { (o as UnifiedRoleAssignmentSchedule).ScheduleInfo = n.GetObjectValue<RequestSchedule>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleEligibilitySchedule>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentType", AssignmentType);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
        }
    }
}

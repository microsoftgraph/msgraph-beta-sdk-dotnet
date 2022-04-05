using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleEligibilityScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>Time that the roleEligibilityScheduleInstance will expire.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Membership type of the assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType { get; set; }
        /// <summary>Identifier of the parent roleEligibilitySchedule for this instance.</summary>
        public string RoleEligibilityScheduleId { get; set; }
        /// <summary>Time that the roleEligibilityScheduleInstance will start.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"endDateTime", (o,n) => { (o as UnifiedRoleEligibilityScheduleInstance).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", (o,n) => { (o as UnifiedRoleEligibilityScheduleInstance).MemberType = n.GetStringValue(); } },
                {"roleEligibilityScheduleId", (o,n) => { (o as UnifiedRoleEligibilityScheduleInstance).RoleEligibilityScheduleId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as UnifiedRoleEligibilityScheduleInstance).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteStringValue("roleEligibilityScheduleId", RoleEligibilityScheduleId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}

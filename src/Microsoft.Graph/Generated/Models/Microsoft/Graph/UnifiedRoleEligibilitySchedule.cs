using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UnifiedRoleEligibilitySchedule : UnifiedRoleScheduleBase, IParsable {
        /// <summary>Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType { get; set; }
        /// <summary>The schedule object of the eligible role assignment request.</summary>
        public RequestSchedule ScheduleInfo { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"memberType", (o,n) => { (o as UnifiedRoleEligibilitySchedule).MemberType = n.GetStringValue(); } },
                {"scheduleInfo", (o,n) => { (o as UnifiedRoleEligibilitySchedule).ScheduleInfo = n.GetObjectValue<RequestSchedule>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleEligibilityScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>Time that the roleEligibilityScheduleInstance will expire.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Membership type of the assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType {
            get { return BackingStore?.Get<string>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
        /// <summary>Identifier of the parent roleEligibilitySchedule for this instance.</summary>
        public string RoleEligibilityScheduleId {
            get { return BackingStore?.Get<string>("roleEligibilityScheduleId"); }
            set { BackingStore?.Set("roleEligibilityScheduleId", value); }
        }
        /// <summary>Time that the roleEligibilityScheduleInstance will start.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new unifiedRoleEligibilityScheduleInstance and sets the default values.
        /// </summary>
        public UnifiedRoleEligibilityScheduleInstance() : base() {
            OdataType = "#microsoft.graph.unifiedRoleEligibilityScheduleInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"roleEligibilityScheduleId", n => { RoleEligibilityScheduleId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

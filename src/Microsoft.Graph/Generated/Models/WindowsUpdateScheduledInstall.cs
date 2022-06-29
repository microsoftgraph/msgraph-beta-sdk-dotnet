using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsUpdateScheduledInstall : WindowsUpdateInstallScheduleType, IParsable {
        /// <summary>Scheduled Install Day in week. Possible values are: userDefined, everyday, sunday, monday, tuesday, wednesday, thursday, friday, saturday, noScheduledScan.</summary>
        public WeeklySchedule? ScheduledInstallDay {
            get { return BackingStore?.Get<WeeklySchedule?>(nameof(ScheduledInstallDay)); }
            set { BackingStore?.Set(nameof(ScheduledInstallDay), value); }
        }
        /// <summary>Scheduled Install Time during day</summary>
        public Time? ScheduledInstallTime {
            get { return BackingStore?.Get<Time?>(nameof(ScheduledInstallTime)); }
            set { BackingStore?.Set(nameof(ScheduledInstallTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateScheduledInstall CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateScheduledInstall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"scheduledInstallDay", n => { ScheduledInstallDay = n.GetEnumValue<WeeklySchedule>(); } },
                {"scheduledInstallTime", n => { ScheduledInstallTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WeeklySchedule>("scheduledInstallDay", ScheduledInstallDay);
            writer.WriteTimeValue("scheduledInstallTime", ScheduledInstallTime);
        }
    }
}

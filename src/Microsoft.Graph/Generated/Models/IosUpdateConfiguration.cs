using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosUpdateConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Active Hours End (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursEnd {
            get { return BackingStore?.Get<Time?>(nameof(ActiveHoursEnd)); }
            set { BackingStore?.Set(nameof(ActiveHoursEnd), value); }
        }
        /// <summary>Active Hours Start (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursStart {
            get { return BackingStore?.Get<Time?>(nameof(ActiveHoursStart)); }
            set { BackingStore?.Set(nameof(ActiveHoursStart), value); }
        }
        /// <summary>If update schedule type is set to use time window scheduling, custom time windows when updates will be scheduled. This collection can contain a maximum of 20 elements.</summary>
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>>(nameof(CustomUpdateTimeWindows)); }
            set { BackingStore?.Set(nameof(CustomUpdateTimeWindows), value); }
        }
        /// <summary>If left unspecified, devices will update to the latest version of the OS.</summary>
        public string DesiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(DesiredOsVersion)); }
            set { BackingStore?.Set(nameof(DesiredOsVersion), value); }
        }
        /// <summary>Days before software updates are visible to iOS devices ranging from 0 to 90 inclusive</summary>
        public int? EnforcedSoftwareUpdateDelayInDays {
            get { return BackingStore?.Get<int?>(nameof(EnforcedSoftwareUpdateDelayInDays)); }
            set { BackingStore?.Set(nameof(EnforcedSoftwareUpdateDelayInDays), value); }
        }
        /// <summary>Is setting enabled in UI</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsEnabled)); }
            set { BackingStore?.Set(nameof(IsEnabled), value); }
        }
        /// <summary>Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.</summary>
        public List<string> ScheduledInstallDays {
            get { return BackingStore?.Get<List<string>>(nameof(ScheduledInstallDays)); }
            set { BackingStore?.Set(nameof(ScheduledInstallDays), value); }
        }
        /// <summary>Update schedule type. Possible values are: updateOutsideOfActiveHours, alwaysUpdate, updateDuringTimeWindows, updateOutsideOfTimeWindows.</summary>
        public IosSoftwareUpdateScheduleType? UpdateScheduleType {
            get { return BackingStore?.Get<IosSoftwareUpdateScheduleType?>(nameof(UpdateScheduleType)); }
            set { BackingStore?.Set(nameof(UpdateScheduleType), value); }
        }
        /// <summary>UTC Time Offset indicated in minutes</summary>
        public int? UtcTimeOffsetInMinutes {
            get { return BackingStore?.Get<int?>(nameof(UtcTimeOffsetInMinutes)); }
            set { BackingStore?.Set(nameof(UtcTimeOffsetInMinutes), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeHoursEnd", n => { ActiveHoursEnd = n.GetTimeValue(); } },
                {"activeHoursStart", n => { ActiveHoursStart = n.GetTimeValue(); } },
                {"customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<CustomUpdateTimeWindow>(CustomUpdateTimeWindow.CreateFromDiscriminatorValue).ToList(); } },
                {"desiredOsVersion", n => { DesiredOsVersion = n.GetStringValue(); } },
                {"enforcedSoftwareUpdateDelayInDays", n => { EnforcedSoftwareUpdateDelayInDays = n.GetIntValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"scheduledInstallDays", n => { ScheduledInstallDays = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<IosSoftwareUpdateScheduleType>(); } },
                {"utcTimeOffsetInMinutes", n => { UtcTimeOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeValue("activeHoursEnd", ActiveHoursEnd);
            writer.WriteTimeValue("activeHoursStart", ActiveHoursStart);
            writer.WriteCollectionOfObjectValues<CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteStringValue("desiredOsVersion", DesiredOsVersion);
            writer.WriteIntValue("enforcedSoftwareUpdateDelayInDays", EnforcedSoftwareUpdateDelayInDays);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("scheduledInstallDays", ScheduledInstallDays);
            writer.WriteEnumValue<IosSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("utcTimeOffsetInMinutes", UtcTimeOffsetInMinutes);
        }
    }
}

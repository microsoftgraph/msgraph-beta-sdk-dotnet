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
            get { return BackingStore?.Get<Time?>("activeHoursEnd"); }
            set { BackingStore?.Set("activeHoursEnd", value); }
        }
        /// <summary>Active Hours Start (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursStart {
            get { return BackingStore?.Get<Time?>("activeHoursStart"); }
            set { BackingStore?.Set("activeHoursStart", value); }
        }
        /// <summary>If update schedule type is set to use time window scheduling, custom time windows when updates will be scheduled. This collection can contain a maximum of 20 elements.</summary>
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
        /// <summary>If left unspecified, devices will update to the latest version of the OS.</summary>
        public string DesiredOsVersion {
            get { return BackingStore?.Get<string>("desiredOsVersion"); }
            set { BackingStore?.Set("desiredOsVersion", value); }
        }
        /// <summary>Days before software updates are visible to iOS devices ranging from 0 to 90 inclusive</summary>
        public int? EnforcedSoftwareUpdateDelayInDays {
            get { return BackingStore?.Get<int?>("enforcedSoftwareUpdateDelayInDays"); }
            set { BackingStore?.Set("enforcedSoftwareUpdateDelayInDays", value); }
        }
        /// <summary>Is setting enabled in UI</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.</summary>
        public List<DayOfWeekObject?> ScheduledInstallDays {
            get { return BackingStore?.Get<List<DayOfWeekObject?>>("scheduledInstallDays"); }
            set { BackingStore?.Set("scheduledInstallDays", value); }
        }
        /// <summary>Update schedule type for iOS software updates.</summary>
        public IosSoftwareUpdateScheduleType? UpdateScheduleType {
            get { return BackingStore?.Get<IosSoftwareUpdateScheduleType?>("updateScheduleType"); }
            set { BackingStore?.Set("updateScheduleType", value); }
        }
        /// <summary>UTC Time Offset indicated in minutes</summary>
        public int? UtcTimeOffsetInMinutes {
            get { return BackingStore?.Get<int?>("utcTimeOffsetInMinutes"); }
            set { BackingStore?.Set("utcTimeOffsetInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new IosUpdateConfiguration and sets the default values.
        /// </summary>
        public IosUpdateConfiguration() : base() {
            OdataType = "#microsoft.graph.iosUpdateConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<CustomUpdateTimeWindow>(CustomUpdateTimeWindow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"desiredOsVersion", n => { DesiredOsVersion = n.GetStringValue(); } },
                {"enforcedSoftwareUpdateDelayInDays", n => { EnforcedSoftwareUpdateDelayInDays = n.GetIntValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"scheduledInstallDays", n => { ScheduledInstallDays = n.GetCollectionOfEnumValues<DayOfWeekObject>()?.ToList(); } },
                {"updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<IosSoftwareUpdateScheduleType>(); } },
                {"utcTimeOffsetInMinutes", n => { UtcTimeOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeValue("activeHoursEnd", ActiveHoursEnd);
            writer.WriteTimeValue("activeHoursStart", ActiveHoursStart);
            writer.WriteCollectionOfObjectValues<CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteStringValue("desiredOsVersion", DesiredOsVersion);
            writer.WriteIntValue("enforcedSoftwareUpdateDelayInDays", EnforcedSoftwareUpdateDelayInDays);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfEnumValues<DayOfWeekObject>("scheduledInstallDays", ScheduledInstallDays);
            writer.WriteEnumValue<IosSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("utcTimeOffsetInMinutes", UtcTimeOffsetInMinutes);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSSoftwareUpdateConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Update behavior for all other updates. Possible values are: notConfigured, default, downloadOnly, installASAP, notifyOnly, installLater.</summary>
        public MacOSSoftwareUpdateBehavior? AllOtherUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>(nameof(AllOtherUpdateBehavior)); }
            set { BackingStore?.Set(nameof(AllOtherUpdateBehavior), value); }
        }
        /// <summary>Update behavior for configuration data file updates. Possible values are: notConfigured, default, downloadOnly, installASAP, notifyOnly, installLater.</summary>
        public MacOSSoftwareUpdateBehavior? ConfigDataUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>(nameof(ConfigDataUpdateBehavior)); }
            set { BackingStore?.Set(nameof(ConfigDataUpdateBehavior), value); }
        }
        /// <summary>Update behavior for critical updates. Possible values are: notConfigured, default, downloadOnly, installASAP, notifyOnly, installLater.</summary>
        public MacOSSoftwareUpdateBehavior? CriticalUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>(nameof(CriticalUpdateBehavior)); }
            set { BackingStore?.Set(nameof(CriticalUpdateBehavior), value); }
        }
        /// <summary>Custom Time windows when updates will be allowed or blocked. This collection can contain a maximum of 20 elements.</summary>
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>>(nameof(CustomUpdateTimeWindows)); }
            set { BackingStore?.Set(nameof(CustomUpdateTimeWindows), value); }
        }
        /// <summary>Update behavior for firmware updates. Possible values are: notConfigured, default, downloadOnly, installASAP, notifyOnly, installLater.</summary>
        public MacOSSoftwareUpdateBehavior? FirmwareUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>(nameof(FirmwareUpdateBehavior)); }
            set { BackingStore?.Set(nameof(FirmwareUpdateBehavior), value); }
        }
        /// <summary>Update schedule type. Possible values are: alwaysUpdate, updateDuringTimeWindows, updateOutsideOfTimeWindows.</summary>
        public MacOSSoftwareUpdateScheduleType? UpdateScheduleType {
            get { return BackingStore?.Get<MacOSSoftwareUpdateScheduleType?>(nameof(UpdateScheduleType)); }
            set { BackingStore?.Set(nameof(UpdateScheduleType), value); }
        }
        /// <summary>Minutes indicating UTC offset for each update time window</summary>
        public int? UpdateTimeWindowUtcOffsetInMinutes {
            get { return BackingStore?.Get<int?>(nameof(UpdateTimeWindowUtcOffsetInMinutes)); }
            set { BackingStore?.Set(nameof(UpdateTimeWindowUtcOffsetInMinutes), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSSoftwareUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allOtherUpdateBehavior", n => { AllOtherUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"configDataUpdateBehavior", n => { ConfigDataUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"criticalUpdateBehavior", n => { CriticalUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<CustomUpdateTimeWindow>(CustomUpdateTimeWindow.CreateFromDiscriminatorValue).ToList(); } },
                {"firmwareUpdateBehavior", n => { FirmwareUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<MacOSSoftwareUpdateScheduleType>(); } },
                {"updateTimeWindowUtcOffsetInMinutes", n => { UpdateTimeWindowUtcOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("allOtherUpdateBehavior", AllOtherUpdateBehavior);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("configDataUpdateBehavior", ConfigDataUpdateBehavior);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("criticalUpdateBehavior", CriticalUpdateBehavior);
            writer.WriteCollectionOfObjectValues<CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("firmwareUpdateBehavior", FirmwareUpdateBehavior);
            writer.WriteEnumValue<MacOSSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("updateTimeWindowUtcOffsetInMinutes", UpdateTimeWindowUtcOffsetInMinutes);
        }
    }
}

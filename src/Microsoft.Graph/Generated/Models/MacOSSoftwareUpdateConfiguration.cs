using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSSoftwareUpdateConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? AllOtherUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("allOtherUpdateBehavior"); }
            set { BackingStore?.Set("allOtherUpdateBehavior", value); }
        }
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? ConfigDataUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("configDataUpdateBehavior"); }
            set { BackingStore?.Set("configDataUpdateBehavior", value); }
        }
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? CriticalUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("criticalUpdateBehavior"); }
            set { BackingStore?.Set("criticalUpdateBehavior", value); }
        }
        /// <summary>Custom Time windows when updates will be allowed or blocked. This collection can contain a maximum of 20 elements.</summary>
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? FirmwareUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("firmwareUpdateBehavior"); }
            set { BackingStore?.Set("firmwareUpdateBehavior", value); }
        }
        /// <summary>Update schedule type for macOS software updates.</summary>
        public MacOSSoftwareUpdateScheduleType? UpdateScheduleType {
            get { return BackingStore?.Get<MacOSSoftwareUpdateScheduleType?>("updateScheduleType"); }
            set { BackingStore?.Set("updateScheduleType", value); }
        }
        /// <summary>Minutes indicating UTC offset for each update time window</summary>
        public int? UpdateTimeWindowUtcOffsetInMinutes {
            get { return BackingStore?.Get<int?>("updateTimeWindowUtcOffsetInMinutes"); }
            set { BackingStore?.Set("updateTimeWindowUtcOffsetInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSSoftwareUpdateConfiguration and sets the default values.
        /// </summary>
        public MacOSSoftwareUpdateConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSSoftwareUpdateConfiguration";
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

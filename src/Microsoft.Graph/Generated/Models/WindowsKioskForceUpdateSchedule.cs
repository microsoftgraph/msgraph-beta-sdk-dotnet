using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 force update schedule for Kiosk devices.</summary>
    public class WindowsKioskForceUpdateSchedule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Day of month. Valid values 1 to 31</summary>
        public int? DayofMonth {
            get { return BackingStore?.Get<int?>(nameof(DayofMonth)); }
            set { BackingStore?.Set(nameof(DayofMonth), value); }
        }
        /// <summary>Day of week. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.</summary>
        public Microsoft.Graph.Beta.Models.DayOfWeek? DayofWeek {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DayOfWeek?>(nameof(DayofWeek)); }
            set { BackingStore?.Set(nameof(DayofWeek), value); }
        }
        /// <summary>Recurrence schedule. Possible values are: none, daily, weekly, monthly.</summary>
        public Windows10AppsUpdateRecurrence? Recurrence {
            get { return BackingStore?.Get<Windows10AppsUpdateRecurrence?>(nameof(Recurrence)); }
            set { BackingStore?.Set(nameof(Recurrence), value); }
        }
        /// <summary>If true, runs the task immediately if StartDateTime is in the past, else, runs at the next recurrence.</summary>
        public bool? RunImmediatelyIfAfterStartDateTime {
            get { return BackingStore?.Get<bool?>(nameof(RunImmediatelyIfAfterStartDateTime)); }
            set { BackingStore?.Set(nameof(RunImmediatelyIfAfterStartDateTime), value); }
        }
        /// <summary>The start time for the force restart.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>
        /// Instantiates a new windowsKioskForceUpdateSchedule and sets the default values.
        /// </summary>
        public WindowsKioskForceUpdateSchedule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsKioskForceUpdateSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskForceUpdateSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dayofMonth", n => { DayofMonth = n.GetIntValue(); } },
                {"dayofWeek", n => { DayofWeek = n.GetEnumValue<DayOfWeek>(); } },
                {"recurrence", n => { Recurrence = n.GetEnumValue<Windows10AppsUpdateRecurrence>(); } },
                {"runImmediatelyIfAfterStartDateTime", n => { RunImmediatelyIfAfterStartDateTime = n.GetBoolValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayofMonth", DayofMonth);
            writer.WriteEnumValue<DayOfWeek>("dayofWeek", DayofWeek);
            writer.WriteEnumValue<Windows10AppsUpdateRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("runImmediatelyIfAfterStartDateTime", RunImmediatelyIfAfterStartDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

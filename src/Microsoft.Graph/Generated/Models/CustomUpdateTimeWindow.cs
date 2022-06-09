using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Custom update time window</summary>
    public class CustomUpdateTimeWindow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>End day of the time window. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.</summary>
        public DayOfWeek? EndDay {
            get { return BackingStore?.Get<DayOfWeek?>(nameof(EndDay)); }
            set { BackingStore?.Set(nameof(EndDay), value); }
        }
        /// <summary>End time of the time window</summary>
        public Time? EndTime {
            get { return BackingStore?.Get<Time?>(nameof(EndTime)); }
            set { BackingStore?.Set(nameof(EndTime), value); }
        }
        /// <summary>Start day of the time window. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.</summary>
        public DayOfWeek? StartDay {
            get { return BackingStore?.Get<DayOfWeek?>(nameof(StartDay)); }
            set { BackingStore?.Set(nameof(StartDay), value); }
        }
        /// <summary>Start time of the time window</summary>
        public Time? StartTime {
            get { return BackingStore?.Get<Time?>(nameof(StartTime)); }
            set { BackingStore?.Set(nameof(StartTime), value); }
        }
        /// <summary>
        /// Instantiates a new customUpdateTimeWindow and sets the default values.
        /// </summary>
        public CustomUpdateTimeWindow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CustomUpdateTimeWindow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomUpdateTimeWindow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDay", n => { EndDay = n.GetEnumValue<DayOfWeek>(); } },
                {"endTime", n => { EndTime = n.GetTimeValue(); } },
                {"startDay", n => { StartDay = n.GetEnumValue<DayOfWeek>(); } },
                {"startTime", n => { StartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DayOfWeek>("endDay", EndDay);
            writer.WriteTimeValue("endTime", EndTime);
            writer.WriteEnumValue<DayOfWeek>("startDay", StartDay);
            writer.WriteTimeValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

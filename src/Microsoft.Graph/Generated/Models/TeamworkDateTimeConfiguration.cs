using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDateTimeConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the device.</summary>
        public string DateFormat {
            get { return BackingStore?.Get<string>(nameof(DateFormat)); }
            set { BackingStore?.Set(nameof(DateFormat), value); }
        }
        /// <summary>The time of the day when the device is turned off.</summary>
        public Time? OfficeHoursEndTime {
            get { return BackingStore?.Get<Time?>(nameof(OfficeHoursEndTime)); }
            set { BackingStore?.Set(nameof(OfficeHoursEndTime), value); }
        }
        /// <summary>The time of the day when the device is turned on.</summary>
        public Time? OfficeHoursStartTime {
            get { return BackingStore?.Get<Time?>(nameof(OfficeHoursStartTime)); }
            set { BackingStore?.Set(nameof(OfficeHoursStartTime), value); }
        }
        /// <summary>The time format for the device.</summary>
        public string TimeFormat {
            get { return BackingStore?.Get<string>(nameof(TimeFormat)); }
            set { BackingStore?.Set(nameof(TimeFormat), value); }
        }
        /// <summary>The time zone to which the office hours apply.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>(nameof(TimeZone)); }
            set { BackingStore?.Set(nameof(TimeZone), value); }
        }
        /// <summary>
        /// Instantiates a new teamworkDateTimeConfiguration and sets the default values.
        /// </summary>
        public TeamworkDateTimeConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkDateTimeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDateTimeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"officeHoursEndTime", n => { OfficeHoursEndTime = n.GetTimeValue(); } },
                {"officeHoursStartTime", n => { OfficeHoursStartTime = n.GetTimeValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteTimeValue("officeHoursEndTime", OfficeHoursEndTime);
            writer.WriteTimeValue("officeHoursStartTime", OfficeHoursStartTime);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RegionalFormatOverrides : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The calendar to use, e.g., Gregorian Calendar.Returned by default.</summary>
        public string Calendar {
            get { return BackingStore?.Get<string>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
        /// <summary>The first day of the week to use, e.g., Sunday.Returned by default.</summary>
        public string FirstDayOfWeek {
            get { return BackingStore?.Get<string>("firstDayOfWeek"); }
            set { BackingStore?.Set("firstDayOfWeek", value); }
        }
        /// <summary>The long date time format to be used for displaying dates.Returned by default.</summary>
        public string LongDateFormat {
            get { return BackingStore?.Get<string>("longDateFormat"); }
            set { BackingStore?.Set("longDateFormat", value); }
        }
        /// <summary>The long time format to be used for displaying time.Returned by default.</summary>
        public string LongTimeFormat {
            get { return BackingStore?.Get<string>("longTimeFormat"); }
            set { BackingStore?.Set("longTimeFormat", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The short date time format to be used for displaying dates.Returned by default.</summary>
        public string ShortDateFormat {
            get { return BackingStore?.Get<string>("shortDateFormat"); }
            set { BackingStore?.Set("shortDateFormat", value); }
        }
        /// <summary>The short time format to be used for displaying time.Returned by default.</summary>
        public string ShortTimeFormat {
            get { return BackingStore?.Get<string>("shortTimeFormat"); }
            set { BackingStore?.Set("shortTimeFormat", value); }
        }
        /// <summary>The timezone to be used for displaying time.Returned by default.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
        /// <summary>
        /// Instantiates a new regionalFormatOverrides and sets the default values.
        /// </summary>
        public RegionalFormatOverrides() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.regionalFormatOverrides";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RegionalFormatOverrides CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegionalFormatOverrides();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calendar", n => { Calendar = n.GetStringValue(); } },
                {"firstDayOfWeek", n => { FirstDayOfWeek = n.GetStringValue(); } },
                {"longDateFormat", n => { LongDateFormat = n.GetStringValue(); } },
                {"longTimeFormat", n => { LongTimeFormat = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"shortDateFormat", n => { ShortDateFormat = n.GetStringValue(); } },
                {"shortTimeFormat", n => { ShortTimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calendar", Calendar);
            writer.WriteStringValue("firstDayOfWeek", FirstDayOfWeek);
            writer.WriteStringValue("longDateFormat", LongDateFormat);
            writer.WriteStringValue("longTimeFormat", LongTimeFormat);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("shortDateFormat", ShortDateFormat);
            writer.WriteStringValue("shortTimeFormat", ShortTimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

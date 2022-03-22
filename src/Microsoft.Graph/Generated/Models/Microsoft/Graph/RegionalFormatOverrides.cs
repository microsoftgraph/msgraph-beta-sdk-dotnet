using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RegionalFormatOverrides : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The calendar to use, e.g., Gregorian Calendar.Returned by default.</summary>
        public string Calendar { get; set; }
        /// <summary>The first day of the week to use, e.g., Sunday.Returned by default.</summary>
        public string FirstDayOfWeek { get; set; }
        /// <summary>The long date time format to be used for displaying dates.Returned by default.</summary>
        public string LongDateFormat { get; set; }
        /// <summary>The long time format to be used for displaying time.Returned by default.</summary>
        public string LongTimeFormat { get; set; }
        /// <summary>The short date time format to be used for displaying dates.Returned by default.</summary>
        public string ShortDateFormat { get; set; }
        /// <summary>The short time format to be used for displaying time.Returned by default.</summary>
        public string ShortTimeFormat { get; set; }
        /// <summary>The timezone to be used for displaying time.Returned by default.</summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new regionalFormatOverrides and sets the default values.
        /// </summary>
        public RegionalFormatOverrides() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RegionalFormatOverrides CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegionalFormatOverrides();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calendar", (o,n) => { (o as RegionalFormatOverrides).Calendar = n.GetStringValue(); } },
                {"firstDayOfWeek", (o,n) => { (o as RegionalFormatOverrides).FirstDayOfWeek = n.GetStringValue(); } },
                {"longDateFormat", (o,n) => { (o as RegionalFormatOverrides).LongDateFormat = n.GetStringValue(); } },
                {"longTimeFormat", (o,n) => { (o as RegionalFormatOverrides).LongTimeFormat = n.GetStringValue(); } },
                {"shortDateFormat", (o,n) => { (o as RegionalFormatOverrides).ShortDateFormat = n.GetStringValue(); } },
                {"shortTimeFormat", (o,n) => { (o as RegionalFormatOverrides).ShortTimeFormat = n.GetStringValue(); } },
                {"timeZone", (o,n) => { (o as RegionalFormatOverrides).TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calendar", Calendar);
            writer.WriteStringValue("firstDayOfWeek", FirstDayOfWeek);
            writer.WriteStringValue("longDateFormat", LongDateFormat);
            writer.WriteStringValue("longTimeFormat", LongTimeFormat);
            writer.WriteStringValue("shortDateFormat", ShortDateFormat);
            writer.WriteStringValue("shortTimeFormat", ShortTimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

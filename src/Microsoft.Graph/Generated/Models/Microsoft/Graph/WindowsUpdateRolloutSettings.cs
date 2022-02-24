using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WindowsUpdateRolloutSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The feature update's ending  of release date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.</summary>
        public DateTimeOffset? OfferEndDateTimeInUTC { get; set; }
        /// <summary>The number of day(s) between each set of offers to be set, updated, and displayed for a feature update profile, for example: if OfferStartDateTimeInUTC is 2020-06-09T10:00:00Z, and OfferIntervalInDays is 1, then the next two sets of offers will be made consecutively on 2020-06-10T10:00:00Z (next day at the same specified time) and 2020-06-11T10:00:00Z (next next day at the same specified time) with 1 day in between each set of offers.</summary>
        public int? OfferIntervalInDays { get; set; }
        /// <summary>The feature update's starting date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.</summary>
        public DateTimeOffset? OfferStartDateTimeInUTC { get; set; }
        /// <summary>
        /// Instantiates a new windowsUpdateRolloutSettings and sets the default values.
        /// </summary>
        public WindowsUpdateRolloutSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"offerEndDateTimeInUTC", (o,n) => { (o as WindowsUpdateRolloutSettings).OfferEndDateTimeInUTC = n.GetDateTimeOffsetValue(); } },
                {"offerIntervalInDays", (o,n) => { (o as WindowsUpdateRolloutSettings).OfferIntervalInDays = n.GetIntValue(); } },
                {"offerStartDateTimeInUTC", (o,n) => { (o as WindowsUpdateRolloutSettings).OfferStartDateTimeInUTC = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("offerEndDateTimeInUTC", OfferEndDateTimeInUTC);
            writer.WriteIntValue("offerIntervalInDays", OfferIntervalInDays);
            writer.WriteDateTimeOffsetValue("offerStartDateTimeInUTC", OfferStartDateTimeInUTC);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

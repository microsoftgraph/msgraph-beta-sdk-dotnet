using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewRecurrenceSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The duration in days for recurrence.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>The count of recurrences, if the value of recurrenceEndType is occurrences, or 0 otherwise.</summary>
        public int? RecurrenceCount { get; set; }
        /// <summary>How the recurrence ends. Possible values: never, endBy, occurrences, or recurrenceCount. If it is never, then there is no explicit end of the recurrence series. If it is endBy, then the recurrence ends at a certain date. If it is occurrences, then the series ends after recurrenceCount instances of the review have completed.</summary>
        public string RecurrenceEndType { get; set; }
        /// <summary>The recurrence interval. Possible vaules: onetime, weekly, monthly, quarterly, halfyearly or annual.</summary>
        public string RecurrenceType { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewRecurrenceSettings and sets the default values.
        /// </summary>
        public AccessReviewRecurrenceSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessReviewRecurrenceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewRecurrenceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"durationInDays", (o,n) => { (o as AccessReviewRecurrenceSettings).DurationInDays = n.GetIntValue(); } },
                {"recurrenceCount", (o,n) => { (o as AccessReviewRecurrenceSettings).RecurrenceCount = n.GetIntValue(); } },
                {"recurrenceEndType", (o,n) => { (o as AccessReviewRecurrenceSettings).RecurrenceEndType = n.GetStringValue(); } },
                {"recurrenceType", (o,n) => { (o as AccessReviewRecurrenceSettings).RecurrenceType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteIntValue("recurrenceCount", RecurrenceCount);
            writer.WriteStringValue("recurrenceEndType", RecurrenceEndType);
            writer.WriteStringValue("recurrenceType", RecurrenceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

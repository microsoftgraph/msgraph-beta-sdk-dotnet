using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ActivityStatistics : Entity, IParsable {
        /// <summary>The type of activity for which statistics are returned. The possible values are: call, chat, email, focus, and meeting.</summary>
        public AnalyticsActivityType? Activity { get; set; }
        /// <summary>Total hours spent on the activity. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Duration { get; set; }
        /// <summary>Date when the activity ended, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-03&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? EndDate { get; set; }
        /// <summary>Date when the activity started, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-04&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The time zone that the user sets in Microsoft Outlook is used for the computation. For example, the property value could be &apos;Pacific Standard Time.&apos;</summary>
        public string TimeZoneUsed { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActivityStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivityStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as ActivityStatistics).Activity = n.GetEnumValue<AnalyticsActivityType>(); } },
                {"duration", (o,n) => { (o as ActivityStatistics).Duration = n.GetTimeSpanValue(); } },
                {"endDate", (o,n) => { (o as ActivityStatistics).EndDate = n.GetDateValue(); } },
                {"startDate", (o,n) => { (o as ActivityStatistics).StartDate = n.GetDateValue(); } },
                {"timeZoneUsed", (o,n) => { (o as ActivityStatistics).TimeZoneUsed = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AnalyticsActivityType>("activity", Activity);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteStringValue("timeZoneUsed", TimeZoneUsed);
        }
    }
}

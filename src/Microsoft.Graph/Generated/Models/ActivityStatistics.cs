using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the admin singleton.
    /// </summary>
    public class ActivityStatistics : Entity, IParsable {
        /// <summary>The type of activity for which statistics are returned. The possible values are: call, chat, email, focus, and meeting.</summary>
        public AnalyticsActivityType? Activity {
            get { return BackingStore?.Get<AnalyticsActivityType?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>Total hours spent on the activity. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>Date when the activity ended, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-03&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
        /// <summary>Date when the activity started, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-04&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>The time zone that the user sets in Microsoft Outlook is used for the computation. For example, the property value could be &apos;Pacific Standard Time.&apos;</summary>
        public string TimeZoneUsed {
            get { return BackingStore?.Get<string>("timeZoneUsed"); }
            set { BackingStore?.Set("timeZoneUsed", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ActivityStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.callActivityStatistics" => new CallActivityStatistics(),
                "#microsoft.graph.chatActivityStatistics" => new ChatActivityStatistics(),
                "#microsoft.graph.emailActivityStatistics" => new EmailActivityStatistics(),
                "#microsoft.graph.focusActivityStatistics" => new FocusActivityStatistics(),
                "#microsoft.graph.meetingActivityStatistics" => new MeetingActivityStatistics(),
                _ => new ActivityStatistics(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetEnumValue<AnalyticsActivityType>(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"timeZoneUsed", n => { TimeZoneUsed = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

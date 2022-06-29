using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ActivityStatistics : Entity, IParsable {
        /// <summary>The type of activity for which statistics are returned. The possible values are: call, chat, email, focus, and meeting.</summary>
        public AnalyticsActivityType? Activity {
            get { return BackingStore?.Get<AnalyticsActivityType?>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>Total hours spent on the activity. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>Date when the activity ended, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-03&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>(nameof(EndDate)); }
            set { BackingStore?.Set(nameof(EndDate), value); }
        }
        /// <summary>Date when the activity started, expressed in ISO 8601 format for calendar dates. For example, the property value could be &apos;2019-07-04&apos; that follows the YYYY-MM-DD format.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>(nameof(StartDate)); }
            set { BackingStore?.Set(nameof(StartDate), value); }
        }
        /// <summary>The time zone that the user sets in Microsoft Outlook is used for the computation. For example, the property value could be &apos;Pacific Standard Time.&apos;</summary>
        public string TimeZoneUsed {
            get { return BackingStore?.Get<string>(nameof(TimeZoneUsed)); }
            set { BackingStore?.Set(nameof(TimeZoneUsed), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActivityStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
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

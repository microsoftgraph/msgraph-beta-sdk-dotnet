using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingActivityStatistics : ActivityStatistics, IParsable {
        /// <summary>Time spent on meetings outside of working hours, which is based on the user&apos;s Outlook calendar setting for work hours. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? AfterHours {
            get { return BackingStore?.Get<TimeSpan?>("afterHours"); }
            set { BackingStore?.Set("afterHours", value); }
        }
        /// <summary>Time spent in conflicting meetings (meetings that overlap with other meetings that the person accepted and where the person’s status is set to Busy). The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Conflicting {
            get { return BackingStore?.Get<TimeSpan?>("conflicting"); }
            set { BackingStore?.Set("conflicting", value); }
        }
        /// <summary>Time spent in long meetings (more than an hour in duration). The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Long {
            get { return BackingStore?.Get<TimeSpan?>("long"); }
            set { BackingStore?.Set("long", value); }
        }
        /// <summary>Time spent in meetings where the person was multitasking (read/sent more than a minimum number of emails and/or sent more than a minimum number of messages in Teams or in Skype for Business). The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Multitasking {
            get { return BackingStore?.Get<TimeSpan?>("multitasking"); }
            set { BackingStore?.Set("multitasking", value); }
        }
        /// <summary>Time spent in meetings organized by the user. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Organized {
            get { return BackingStore?.Get<TimeSpan?>("organized"); }
            set { BackingStore?.Set("organized", value); }
        }
        /// <summary>Time spent on recurring meetings. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? Recurring {
            get { return BackingStore?.Get<TimeSpan?>("recurring"); }
            set { BackingStore?.Set("recurring", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingActivityStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingActivityStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"afterHours", n => { AfterHours = n.GetTimeSpanValue(); } },
                {"conflicting", n => { Conflicting = n.GetTimeSpanValue(); } },
                {"long", n => { Long = n.GetTimeSpanValue(); } },
                {"multitasking", n => { Multitasking = n.GetTimeSpanValue(); } },
                {"organized", n => { Organized = n.GetTimeSpanValue(); } },
                {"recurring", n => { Recurring = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("afterHours", AfterHours);
            writer.WriteTimeSpanValue("conflicting", Conflicting);
            writer.WriteTimeSpanValue("long", Long);
            writer.WriteTimeSpanValue("multitasking", Multitasking);
            writer.WriteTimeSpanValue("organized", Organized);
            writer.WriteTimeSpanValue("recurring", Recurring);
        }
    }
}

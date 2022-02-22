using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessReviewSettings : IParsable {
        /// <summary>Indicates whether showing recommendations to reviewers is enabled.</summary>
        public bool? AccessRecommendationsEnabled { get; set; }
        /// <summary>The number of days of user activities to show to reviewers.</summary>
        public int? ActivityDurationInDays { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the auto-apply capability, to automatically change the target object access resource, is enabled.  If not enabled, a user must, after the review completes, apply the access review.</summary>
        public bool? AutoApplyReviewResultsEnabled { get; set; }
        /// <summary>Indicates whether a decision should be set if the reviewer did not supply one. For use when auto-apply is enabled. If you don't want to have a review decision recorded unless the reviewer makes an explicit choice, set it to false.</summary>
        public bool? AutoReviewEnabled { get; set; }
        /// <summary>Detailed settings for how the feature should set the review decision. For use when auto-apply is enabled.</summary>
        public AutoReviewSettings AutoReviewSettings { get; set; }
        /// <summary>Indicates whether reviewers are required to provide a justification when reviewing access.</summary>
        public bool? JustificationRequiredOnApproval { get; set; }
        /// <summary>Indicates whether sending mails to reviewers and the review creator is enabled.</summary>
        public bool? MailNotificationsEnabled { get; set; }
        /// <summary>Detailed settings for recurrence.</summary>
        public AccessReviewRecurrenceSettings RecurrenceSettings { get; set; }
        /// <summary>Indicates whether sending reminder emails to reviewers is enabled.</summary>
        public bool? RemindersEnabled { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewSettings and sets the default values.
        /// </summary>
        public AccessReviewSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessRecommendationsEnabled", (o,n) => { (o as AccessReviewSettings).AccessRecommendationsEnabled = n.GetBoolValue(); } },
                {"activityDurationInDays", (o,n) => { (o as AccessReviewSettings).ActivityDurationInDays = n.GetIntValue(); } },
                {"autoApplyReviewResultsEnabled", (o,n) => { (o as AccessReviewSettings).AutoApplyReviewResultsEnabled = n.GetBoolValue(); } },
                {"autoReviewEnabled", (o,n) => { (o as AccessReviewSettings).AutoReviewEnabled = n.GetBoolValue(); } },
                {"autoReviewSettings", (o,n) => { (o as AccessReviewSettings).AutoReviewSettings = n.GetObjectValue<AutoReviewSettings>(); } },
                {"justificationRequiredOnApproval", (o,n) => { (o as AccessReviewSettings).JustificationRequiredOnApproval = n.GetBoolValue(); } },
                {"mailNotificationsEnabled", (o,n) => { (o as AccessReviewSettings).MailNotificationsEnabled = n.GetBoolValue(); } },
                {"recurrenceSettings", (o,n) => { (o as AccessReviewSettings).RecurrenceSettings = n.GetObjectValue<AccessReviewRecurrenceSettings>(); } },
                {"remindersEnabled", (o,n) => { (o as AccessReviewSettings).RemindersEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("accessRecommendationsEnabled", AccessRecommendationsEnabled);
            writer.WriteIntValue("activityDurationInDays", ActivityDurationInDays);
            writer.WriteBoolValue("autoApplyReviewResultsEnabled", AutoApplyReviewResultsEnabled);
            writer.WriteBoolValue("autoReviewEnabled", AutoReviewEnabled);
            writer.WriteObjectValue<AutoReviewSettings>("autoReviewSettings", AutoReviewSettings);
            writer.WriteBoolValue("justificationRequiredOnApproval", JustificationRequiredOnApproval);
            writer.WriteBoolValue("mailNotificationsEnabled", MailNotificationsEnabled);
            writer.WriteObjectValue<AccessReviewRecurrenceSettings>("recurrenceSettings", RecurrenceSettings);
            writer.WriteBoolValue("remindersEnabled", RemindersEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessReviewStage : Entity, IParsable {
        /// <summary>Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
        public List<AccessReviewInstanceDecisionItem> Decisions { get; set; }
        /// <summary>DateTime when review stage is scheduled to end. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This property is the cumulative total of the durationInDays for all stages. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.</summary>
        public List<AccessReviewReviewerScope> FallbackReviewers { get; set; }
        /// <summary>This collection of access review scopes is used to define who the reviewers are. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.</summary>
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>DateTime when review stage is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Specifies the status of an accessReviewStage. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $orderby, and $filter (eq only). Read-only.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"decisions", (o,n) => { (o as AccessReviewStage).Decisions = n.GetCollectionOfObjectValues<AccessReviewInstanceDecisionItem>().ToList(); } },
                {"endDateTime", (o,n) => { (o as AccessReviewStage).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessReviewStage).FallbackReviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>().ToList(); } },
                {"reviewers", (o,n) => { (o as AccessReviewStage).Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>().ToList(); } },
                {"startDateTime", (o,n) => { (o as AccessReviewStage).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as AccessReviewStage).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}

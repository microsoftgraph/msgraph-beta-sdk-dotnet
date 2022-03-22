using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AssignmentReviewSettings : IAdditionalDataHolder, IParsable {
        /// <summary>The default decision to apply if the request is not reviewed within the period specified in durationInDays. The possible values are: acceptAccessRecommendation, keepAccess, removeAccess, and unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessReviewTimeoutBehavior? AccessReviewTimeoutBehavior { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days within which reviewers should provide input.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>Specifies whether to display recommendations to the reviewer. The default value is true</summary>
        public bool? IsAccessRecommendationEnabled { get; set; }
        /// <summary>Specifies whether the reviewer must provide justification for the approval. The default value is true.</summary>
        public bool? IsApprovalJustificationRequired { get; set; }
        /// <summary>If true, access reviews are required for assignments from this policy.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The interval for recurrence, such as monthly or quarterly.</summary>
        public string RecurrenceType { get; set; }
        /// <summary>If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers.</summary>
        public List<UserSet> Reviewers { get; set; }
        /// <summary>Who should be asked to do the review, either Self or Reviewers.</summary>
        public string ReviewerType { get; set; }
        /// <summary>When the first review should start.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new assignmentReviewSettings and sets the default values.
        /// </summary>
        public AssignmentReviewSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentReviewSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentReviewSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessReviewTimeoutBehavior", (o,n) => { (o as AssignmentReviewSettings).AccessReviewTimeoutBehavior = n.GetEnumValue<AccessReviewTimeoutBehavior>(); } },
                {"durationInDays", (o,n) => { (o as AssignmentReviewSettings).DurationInDays = n.GetIntValue(); } },
                {"isAccessRecommendationEnabled", (o,n) => { (o as AssignmentReviewSettings).IsAccessRecommendationEnabled = n.GetBoolValue(); } },
                {"isApprovalJustificationRequired", (o,n) => { (o as AssignmentReviewSettings).IsApprovalJustificationRequired = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as AssignmentReviewSettings).IsEnabled = n.GetBoolValue(); } },
                {"recurrenceType", (o,n) => { (o as AssignmentReviewSettings).RecurrenceType = n.GetStringValue(); } },
                {"reviewers", (o,n) => { (o as AssignmentReviewSettings).Reviewers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewerType", (o,n) => { (o as AssignmentReviewSettings).ReviewerType = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as AssignmentReviewSettings).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessReviewTimeoutBehavior>("accessReviewTimeoutBehavior", AccessReviewTimeoutBehavior);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteBoolValue("isAccessRecommendationEnabled", IsAccessRecommendationEnabled);
            writer.WriteBoolValue("isApprovalJustificationRequired", IsApprovalJustificationRequired);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("recurrenceType", RecurrenceType);
            writer.WriteCollectionOfObjectValues<UserSet>("reviewers", Reviewers);
            writer.WriteStringValue("reviewerType", ReviewerType);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

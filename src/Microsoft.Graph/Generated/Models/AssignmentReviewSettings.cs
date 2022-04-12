using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AssignmentReviewSettings : IAdditionalDataHolder, IParsable {
        /// <summary>The default decision to apply if the request is not reviewed within the period specified in durationInDays. The possible values are: acceptAccessRecommendation, keepAccess, removeAccess, and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.AccessReviewTimeoutBehavior? AccessReviewTimeoutBehavior { get; set; }
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessReviewTimeoutBehavior", n => { AccessReviewTimeoutBehavior = n.GetEnumValue<AccessReviewTimeoutBehavior>(); } },
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"isAccessRecommendationEnabled", n => { IsAccessRecommendationEnabled = n.GetBoolValue(); } },
                {"isApprovalJustificationRequired", n => { IsApprovalJustificationRequired = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"recurrenceType", n => { RecurrenceType = n.GetStringValue(); } },
                {"reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewerType", n => { ReviewerType = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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

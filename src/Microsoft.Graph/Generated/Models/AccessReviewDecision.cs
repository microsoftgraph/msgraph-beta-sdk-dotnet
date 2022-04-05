using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewDecision : Entity, IParsable {
        /// <summary>The feature- generated recommendation shown to the reviewer, one of Approve, Deny or NotAvailable.</summary>
        public string AccessRecommendation { get; set; }
        /// <summary>The feature-generated id of the access review.</summary>
        public string AccessReviewId { get; set; }
        /// <summary>When the review completes, if the results were manually applied, the user identity of the user who applied the decision. If the review was auto-applied, the userPrincipalName is empty.</summary>
        public UserIdentity AppliedBy { get; set; }
        /// <summary>The date and time when the review decision was applied.</summary>
        public DateTimeOffset? AppliedDateTime { get; set; }
        /// <summary>The outcome of applying the decision, one of NotApplied, Success, Failed, NotFound or NotSupported.</summary>
        public string ApplyResult { get; set; }
        /// <summary>The reviewer&apos;s business justification, if supplied.</summary>
        public string Justification { get; set; }
        /// <summary>The identity of the reviewer. If the recommendation was used as the review, the userPrincipalName is empty.</summary>
        public UserIdentity ReviewedBy { get; set; }
        /// <summary>The reviewedDateTime property</summary>
        public DateTimeOffset? ReviewedDateTime { get; set; }
        /// <summary>The result of the review, one of NotReviewed, Deny, DontKnow or Approve.</summary>
        public string ReviewResult { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReviewDecision CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewDecision();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessRecommendation", (o,n) => { (o as AccessReviewDecision).AccessRecommendation = n.GetStringValue(); } },
                {"accessReviewId", (o,n) => { (o as AccessReviewDecision).AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", (o,n) => { (o as AccessReviewDecision).AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", (o,n) => { (o as AccessReviewDecision).AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", (o,n) => { (o as AccessReviewDecision).ApplyResult = n.GetStringValue(); } },
                {"justification", (o,n) => { (o as AccessReviewDecision).Justification = n.GetStringValue(); } },
                {"reviewedBy", (o,n) => { (o as AccessReviewDecision).ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", (o,n) => { (o as AccessReviewDecision).ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewResult", (o,n) => { (o as AccessReviewDecision).ReviewResult = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accessRecommendation", AccessRecommendation);
            writer.WriteStringValue("accessReviewId", AccessReviewId);
            writer.WriteObjectValue<UserIdentity>("appliedBy", AppliedBy);
            writer.WriteDateTimeOffsetValue("appliedDateTime", AppliedDateTime);
            writer.WriteStringValue("applyResult", ApplyResult);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<UserIdentity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
            writer.WriteStringValue("reviewResult", ReviewResult);
        }
    }
}

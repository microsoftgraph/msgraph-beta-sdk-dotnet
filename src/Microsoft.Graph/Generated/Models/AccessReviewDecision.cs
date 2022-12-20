using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class AccessReviewDecision : Entity, IParsable {
        /// <summary>The feature- generated recommendation shown to the reviewer, one of Approve, Deny or NotAvailable.</summary>
        public string AccessRecommendation {
            get { return BackingStore?.Get<string>("accessRecommendation"); }
            set { BackingStore?.Set("accessRecommendation", value); }
        }
        /// <summary>The feature-generated id of the access review.</summary>
        public string AccessReviewId {
            get { return BackingStore?.Get<string>("accessReviewId"); }
            set { BackingStore?.Set("accessReviewId", value); }
        }
        /// <summary>When the review completes, if the results were manually applied, the user identity of the user who applied the decision. If the review was auto-applied, the userPrincipalName is empty.</summary>
        public UserIdentity AppliedBy {
            get { return BackingStore?.Get<UserIdentity>("appliedBy"); }
            set { BackingStore?.Set("appliedBy", value); }
        }
        /// <summary>The date and time when the review decision was applied.</summary>
        public DateTimeOffset? AppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("appliedDateTime"); }
            set { BackingStore?.Set("appliedDateTime", value); }
        }
        /// <summary>The outcome of applying the decision, one of NotApplied, Success, Failed, NotFound or NotSupported.</summary>
        public string ApplyResult {
            get { return BackingStore?.Get<string>("applyResult"); }
            set { BackingStore?.Set("applyResult", value); }
        }
        /// <summary>The reviewer&apos;s business justification, if supplied.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
        /// <summary>The identity of the reviewer. If the recommendation was used as the review, the userPrincipalName is empty.</summary>
        public UserIdentity ReviewedBy {
            get { return BackingStore?.Get<UserIdentity>("reviewedBy"); }
            set { BackingStore?.Set("reviewedBy", value); }
        }
        /// <summary>The reviewedDateTime property</summary>
        public DateTimeOffset? ReviewedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewedDateTime"); }
            set { BackingStore?.Set("reviewedDateTime", value); }
        }
        /// <summary>The result of the review, one of NotReviewed, Deny, DontKnow or Approve.</summary>
        public string ReviewResult {
            get { return BackingStore?.Get<string>("reviewResult"); }
            set { BackingStore?.Set("reviewResult", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewDecision CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewDecision();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessRecommendation", n => { AccessRecommendation = n.GetStringValue(); } },
                {"accessReviewId", n => { AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", n => { AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", n => { AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", n => { ApplyResult = n.GetStringValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"reviewedBy", n => { ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewResult", n => { ReviewResult = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

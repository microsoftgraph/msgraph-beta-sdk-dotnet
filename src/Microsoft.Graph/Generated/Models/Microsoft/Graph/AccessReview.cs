using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessReview : Entity, IParsable {
        /// <summary>The business flow template identifier. Required on create.  This value is case sensitive.</summary>
        public string BusinessFlowTemplateId { get; set; }
        /// <summary>The user who created this review.</summary>
        public UserIdentity CreatedBy { get; set; }
        /// <summary>The collection of decisions for this access review.</summary>
        public List<AccessReviewDecision> Decisions { get; set; }
        /// <summary>The description provided by the access review creator, to show to the reviewers.</summary>
        public string Description { get; set; }
        /// <summary>The access review name. Required on create.</summary>
        public string DisplayName { get; set; }
        /// <summary>The DateTime when the review is scheduled to end. This must be at least one day later than the start date.  Required on create.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The collection of access reviews instances past, present and future, if this object is a recurring access review.</summary>
        public List<AccessReview> Instances { get; set; }
        /// <summary>The collection of decisions for the caller, if the caller is a reviewer.</summary>
        public List<AccessReviewDecision> MyDecisions { get; set; }
        /// <summary>The object for which the access reviews is reviewing the access rights assignments. This can be the group for the review of memberships of users in a group, or the app for a review of assignments of users to an application. Required on create.</summary>
        public Identity ReviewedEntity { get; set; }
        /// <summary>The collection of reviewers for an access review, if access review reviewerType is of type delegated.</summary>
        public List<AccessReviewReviewer> Reviewers { get; set; }
        /// <summary>The relationship type of reviewer to the target object, one of self, delegated or entityOwners. Required on create.</summary>
        public string ReviewerType { get; set; }
        /// <summary>The settings of an accessReview, see type definition below.</summary>
        public AccessReviewSettings Settings { get; set; }
        /// <summary>The DateTime when the review is scheduled to be start.  This could be a date in the future.  Required on create.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>This read-only field specifies the status of an accessReview. The typical states include Initializing, NotStarted, Starting,InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"businessFlowTemplateId", (o,n) => { (o as AccessReview).BusinessFlowTemplateId = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as AccessReview).CreatedBy = n.GetObjectValue<UserIdentity>(); } },
                {"decisions", (o,n) => { (o as AccessReview).Decisions = n.GetCollectionOfObjectValues<AccessReviewDecision>().ToList(); } },
                {"description", (o,n) => { (o as AccessReview).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessReview).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as AccessReview).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"instances", (o,n) => { (o as AccessReview).Instances = n.GetCollectionOfObjectValues<AccessReview>().ToList(); } },
                {"myDecisions", (o,n) => { (o as AccessReview).MyDecisions = n.GetCollectionOfObjectValues<AccessReviewDecision>().ToList(); } },
                {"reviewedEntity", (o,n) => { (o as AccessReview).ReviewedEntity = n.GetObjectValue<Identity>(); } },
                {"reviewers", (o,n) => { (o as AccessReview).Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewer>().ToList(); } },
                {"reviewerType", (o,n) => { (o as AccessReview).ReviewerType = n.GetStringValue(); } },
                {"settings", (o,n) => { (o as AccessReview).Settings = n.GetObjectValue<AccessReviewSettings>(); } },
                {"startDateTime", (o,n) => { (o as AccessReview).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as AccessReview).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("businessFlowTemplateId", BusinessFlowTemplateId);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteCollectionOfObjectValues<AccessReviewDecision>("decisions", Decisions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<AccessReview>("instances", Instances);
            writer.WriteCollectionOfObjectValues<AccessReviewDecision>("myDecisions", MyDecisions);
            writer.WriteObjectValue<Identity>("reviewedEntity", ReviewedEntity);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewer>("reviewers", Reviewers);
            writer.WriteStringValue("reviewerType", ReviewerType);
            writer.WriteObjectValue<AccessReviewSettings>("settings", Settings);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}

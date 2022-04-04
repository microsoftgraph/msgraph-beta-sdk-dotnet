using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessReviewInstanceDecisionItem : Entity, IParsable {
        /// <summary>The identifier of the accessReviewInstance parent. Supports $select. Read-only.</summary>
        public string AccessReviewId { get; set; }
        /// <summary>The identifier of the user who applied the decision. Read-only.</summary>
        public UserIdentity AppliedBy { get; set; }
        /// <summary>The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.</summary>
        public DateTimeOffset? AppliedDateTime { get; set; }
        /// <summary>The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string ApplyResult { get; set; }
        /// <summary>Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).</summary>
        public string Decision { get; set; }
        /// <summary>Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.</summary>
        public List<GovernanceInsight> Insights { get; set; }
        /// <summary>There is exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.</summary>
        public AccessReviewInstance Instance { get; set; }
        /// <summary>Justification left by the reviewer when they made the decision.</summary>
        public string Justification { get; set; }
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the principal. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is &apos;Bob&apos; and the resource is &apos;Sales&apos;. Principals can be of two types - userIdentity and servicePrincipalIdentity. Supports $select. Read-only.</summary>
        public Identity Principal { get; set; }
        /// <summary>A link to the principal object. For example, https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.</summary>
        public string PrincipalLink { get; set; }
        /// <summary>The principalResourceMembership property</summary>
        public DecisionItemPrincipalResourceMembership PrincipalResourceMembership { get; set; }
        /// <summary>A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string Recommendation { get; set; }
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the resource. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is Bob and the resource is &apos;Sales&apos;. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource. Read-only.</summary>
        public AccessReviewInstanceDecisionItemResource Resource { get; set; }
        /// <summary>A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.</summary>
        public string ResourceLink { get; set; }
        /// <summary>The identifier of the reviewer. Supports $select. Read-only.</summary>
        public UserIdentity ReviewedBy { get; set; }
        /// <summary>The timestamp when the review decision occurred. Supports $select. Read-only.</summary>
        public DateTimeOffset? ReviewedDateTime { get; set; }
        /// <summary>The target of this specific decision. Decision targets can be of different types – each one with its own specific properties. See accessReviewInstanceDecisionItemTarget. Read-only.  This property has been replaced by the principal and resource properties in v1.0.</summary>
        public AccessReviewInstanceDecisionItemTarget Target { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReviewInstanceDecisionItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInstanceDecisionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessReviewId", (o,n) => { (o as AccessReviewInstanceDecisionItem).AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", (o,n) => { (o as AccessReviewInstanceDecisionItem).AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", (o,n) => { (o as AccessReviewInstanceDecisionItem).AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", (o,n) => { (o as AccessReviewInstanceDecisionItem).ApplyResult = n.GetStringValue(); } },
                {"decision", (o,n) => { (o as AccessReviewInstanceDecisionItem).Decision = n.GetStringValue(); } },
                {"insights", (o,n) => { (o as AccessReviewInstanceDecisionItem).Insights = n.GetCollectionOfObjectValues<GovernanceInsight>(GovernanceInsight.CreateFromDiscriminatorValue).ToList(); } },
                {"instance", (o,n) => { (o as AccessReviewInstanceDecisionItem).Instance = n.GetObjectValue<AccessReviewInstance>(AccessReviewInstance.CreateFromDiscriminatorValue); } },
                {"justification", (o,n) => { (o as AccessReviewInstanceDecisionItem).Justification = n.GetStringValue(); } },
                {"principal", (o,n) => { (o as AccessReviewInstanceDecisionItem).Principal = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"principalLink", (o,n) => { (o as AccessReviewInstanceDecisionItem).PrincipalLink = n.GetStringValue(); } },
                {"principalResourceMembership", (o,n) => { (o as AccessReviewInstanceDecisionItem).PrincipalResourceMembership = n.GetObjectValue<DecisionItemPrincipalResourceMembership>(DecisionItemPrincipalResourceMembership.CreateFromDiscriminatorValue); } },
                {"recommendation", (o,n) => { (o as AccessReviewInstanceDecisionItem).Recommendation = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as AccessReviewInstanceDecisionItem).Resource = n.GetObjectValue<AccessReviewInstanceDecisionItemResource>(AccessReviewInstanceDecisionItemResource.CreateFromDiscriminatorValue); } },
                {"resourceLink", (o,n) => { (o as AccessReviewInstanceDecisionItem).ResourceLink = n.GetStringValue(); } },
                {"reviewedBy", (o,n) => { (o as AccessReviewInstanceDecisionItem).ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", (o,n) => { (o as AccessReviewInstanceDecisionItem).ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"target", (o,n) => { (o as AccessReviewInstanceDecisionItem).Target = n.GetObjectValue<AccessReviewInstanceDecisionItemTarget>(AccessReviewInstanceDecisionItemTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accessReviewId", AccessReviewId);
            writer.WriteObjectValue<UserIdentity>("appliedBy", AppliedBy);
            writer.WriteDateTimeOffsetValue("appliedDateTime", AppliedDateTime);
            writer.WriteStringValue("applyResult", ApplyResult);
            writer.WriteStringValue("decision", Decision);
            writer.WriteCollectionOfObjectValues<GovernanceInsight>("insights", Insights);
            writer.WriteObjectValue<AccessReviewInstance>("instance", Instance);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Identity>("principal", Principal);
            writer.WriteStringValue("principalLink", PrincipalLink);
            writer.WriteObjectValue<DecisionItemPrincipalResourceMembership>("principalResourceMembership", PrincipalResourceMembership);
            writer.WriteStringValue("recommendation", Recommendation);
            writer.WriteObjectValue<AccessReviewInstanceDecisionItemResource>("resource", Resource);
            writer.WriteStringValue("resourceLink", ResourceLink);
            writer.WriteObjectValue<UserIdentity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
            writer.WriteObjectValue<AccessReviewInstanceDecisionItemTarget>("target", Target);
        }
    }
}

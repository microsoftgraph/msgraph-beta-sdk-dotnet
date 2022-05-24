using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class AccessReviewInstanceDecisionItem : Entity, IParsable {
        /// <summary>The identifier of the accessReviewInstance parent. Supports $select. Read-only.</summary>
        public string AccessReviewId {
            get { return BackingStore?.Get<string>(nameof(AccessReviewId)); }
            set { BackingStore?.Set(nameof(AccessReviewId), value); }
        }
        /// <summary>The identifier of the user who applied the decision. Read-only.</summary>
        public UserIdentity AppliedBy {
            get { return BackingStore?.Get<UserIdentity>(nameof(AppliedBy)); }
            set { BackingStore?.Set(nameof(AppliedBy), value); }
        }
        /// <summary>The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.</summary>
        public DateTimeOffset? AppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AppliedDateTime)); }
            set { BackingStore?.Set(nameof(AppliedDateTime), value); }
        }
        /// <summary>The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string ApplyResult {
            get { return BackingStore?.Get<string>(nameof(ApplyResult)); }
            set { BackingStore?.Set(nameof(ApplyResult), value); }
        }
        /// <summary>Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).</summary>
        public string Decision {
            get { return BackingStore?.Get<string>(nameof(Decision)); }
            set { BackingStore?.Set(nameof(Decision), value); }
        }
        /// <summary>Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.</summary>
        public List<GovernanceInsight> Insights {
            get { return BackingStore?.Get<List<GovernanceInsight>>(nameof(Insights)); }
            set { BackingStore?.Set(nameof(Insights), value); }
        }
        /// <summary>There is exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.</summary>
        public AccessReviewInstance Instance {
            get { return BackingStore?.Get<AccessReviewInstance>(nameof(Instance)); }
            set { BackingStore?.Set(nameof(Instance), value); }
        }
        /// <summary>Justification left by the reviewer when they made the decision.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the principal. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is &apos;Bob&apos; and the resource is &apos;Sales&apos;. Principals can be of two types - userIdentity and servicePrincipalIdentity. Supports $select. Read-only.</summary>
        public Identity Principal {
            get { return BackingStore?.Get<Identity>(nameof(Principal)); }
            set { BackingStore?.Set(nameof(Principal), value); }
        }
        /// <summary>Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.</summary>
        public string PrincipalLink {
            get { return BackingStore?.Get<string>(nameof(PrincipalLink)); }
            set { BackingStore?.Set(nameof(PrincipalLink), value); }
        }
        /// <summary>The principalResourceMembership property</summary>
        public DecisionItemPrincipalResourceMembership PrincipalResourceMembership {
            get { return BackingStore?.Get<DecisionItemPrincipalResourceMembership>(nameof(PrincipalResourceMembership)); }
            set { BackingStore?.Set(nameof(PrincipalResourceMembership), value); }
        }
        /// <summary>A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string Recommendation {
            get { return BackingStore?.Get<string>(nameof(Recommendation)); }
            set { BackingStore?.Set(nameof(Recommendation), value); }
        }
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the resource. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is Bob and the resource is &apos;Sales&apos;. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource. Read-only.</summary>
        public AccessReviewInstanceDecisionItemResource Resource {
            get { return BackingStore?.Get<AccessReviewInstanceDecisionItemResource>(nameof(Resource)); }
            set { BackingStore?.Set(nameof(Resource), value); }
        }
        /// <summary>A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.</summary>
        public string ResourceLink {
            get { return BackingStore?.Get<string>(nameof(ResourceLink)); }
            set { BackingStore?.Set(nameof(ResourceLink), value); }
        }
        /// <summary>The identifier of the reviewer. Supports $select. Read-only.</summary>
        public UserIdentity ReviewedBy {
            get { return BackingStore?.Get<UserIdentity>(nameof(ReviewedBy)); }
            set { BackingStore?.Set(nameof(ReviewedBy), value); }
        }
        /// <summary>The timestamp when the review decision occurred. Supports $select. Read-only.</summary>
        public DateTimeOffset? ReviewedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReviewedDateTime)); }
            set { BackingStore?.Set(nameof(ReviewedDateTime), value); }
        }
        /// <summary>The target of this specific decision. Decision targets can be of different types – each one with its own specific properties. See accessReviewInstanceDecisionItemTarget. Read-only.  This property has been replaced by the principal and resource properties in v1.0.</summary>
        public AccessReviewInstanceDecisionItemTarget Target {
            get { return BackingStore?.Get<AccessReviewInstanceDecisionItemTarget>(nameof(Target)); }
            set { BackingStore?.Set(nameof(Target), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessReviewId", n => { AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", n => { AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", n => { AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", n => { ApplyResult = n.GetStringValue(); } },
                {"decision", n => { Decision = n.GetStringValue(); } },
                {"insights", n => { Insights = n.GetCollectionOfObjectValues<GovernanceInsight>(GovernanceInsight.CreateFromDiscriminatorValue).ToList(); } },
                {"instance", n => { Instance = n.GetObjectValue<AccessReviewInstance>(AccessReviewInstance.CreateFromDiscriminatorValue); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"principalLink", n => { PrincipalLink = n.GetStringValue(); } },
                {"principalResourceMembership", n => { PrincipalResourceMembership = n.GetObjectValue<DecisionItemPrincipalResourceMembership>(DecisionItemPrincipalResourceMembership.CreateFromDiscriminatorValue); } },
                {"recommendation", n => { Recommendation = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<AccessReviewInstanceDecisionItemResource>(AccessReviewInstanceDecisionItemResource.CreateFromDiscriminatorValue); } },
                {"resourceLink", n => { ResourceLink = n.GetStringValue(); } },
                {"reviewedBy", n => { ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"target", n => { Target = n.GetObjectValue<AccessReviewInstanceDecisionItemTarget>(AccessReviewInstanceDecisionItemTarget.CreateFromDiscriminatorValue); } },
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

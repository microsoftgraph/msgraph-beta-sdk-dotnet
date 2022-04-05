using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DelegatedAdminRelationship : Entity, IParsable {
        /// <summary>The access assignments associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminAccessAssignment> AccessAssignments { get; set; }
        /// <summary>The accessDetails property</summary>
        public DelegatedAdminAccessDetails AccessDetails { get; set; }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship became active. Read-only.</summary>
        public DateTimeOffset? ActivatedDateTime { get; set; }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name and unique identifier of the customer of the relationship. This is configured either by the partner at the time the relationship is created or by the system after the customer approves the relationship. Cannot be changed by the customer.</summary>
        public DelegatedAdminRelationshipCustomerParticipant Customer { get; set; }
        /// <summary>The display name of the relationship used for ease of identification. Must be unique across all delegated admin relationships of the partner. This is set by the partner only when the relationship is in the created status and cannot be changed by the customer.</summary>
        public string DisplayName { get; set; }
        /// <summary>The duration of the relationship in ISO 8601 format. Must be a value between P1D and P2Y inclusive. This is set by the partner only when the relationship is in the created status and cannot be changed by the customer.</summary>
        public TimeSpan? Duration { get; set; }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the status of relationship changes to either terminated or expired. Calculated as endDateTime = activatedDateTime + duration. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The long running operations associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminRelationshipOperation> Operations { get; set; }
        /// <summary>The partner property</summary>
        public DelegatedAdminRelationshipParticipant Partner { get; set; }
        /// <summary>The requests associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminRelationshipRequest> Requests { get; set; }
        /// <summary>The status of the relationship. Read Only. The possible values are: activating, active, approvalPending, approved, created, expired, expiring, terminated, terminating, terminationRequested, unknownFutureValue. Supports $orderBy.</summary>
        public DelegatedAdminRelationshipStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessAssignments", (o,n) => { (o as DelegatedAdminRelationship).AccessAssignments = n.GetCollectionOfObjectValues<DelegatedAdminAccessAssignment>(DelegatedAdminAccessAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessDetails", (o,n) => { (o as DelegatedAdminRelationship).AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"activatedDateTime", (o,n) => { (o as DelegatedAdminRelationship).ActivatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as DelegatedAdminRelationship).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customer", (o,n) => { (o as DelegatedAdminRelationship).Customer = n.GetObjectValue<DelegatedAdminRelationshipCustomerParticipant>(DelegatedAdminRelationshipCustomerParticipant.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as DelegatedAdminRelationship).DisplayName = n.GetStringValue(); } },
                {"duration", (o,n) => { (o as DelegatedAdminRelationship).Duration = n.GetTimeSpanValue(); } },
                {"endDateTime", (o,n) => { (o as DelegatedAdminRelationship).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DelegatedAdminRelationship).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operations", (o,n) => { (o as DelegatedAdminRelationship).Operations = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipOperation>(DelegatedAdminRelationshipOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"partner", (o,n) => { (o as DelegatedAdminRelationship).Partner = n.GetObjectValue<DelegatedAdminRelationshipParticipant>(DelegatedAdminRelationshipParticipant.CreateFromDiscriminatorValue); } },
                {"requests", (o,n) => { (o as DelegatedAdminRelationship).Requests = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipRequest>(DelegatedAdminRelationshipRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"status", (o,n) => { (o as DelegatedAdminRelationship).Status = n.GetEnumValue<DelegatedAdminRelationshipStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DelegatedAdminAccessAssignment>("accessAssignments", AccessAssignments);
            writer.WriteObjectValue<DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("activatedDateTime", ActivatedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DelegatedAdminRelationshipCustomerParticipant>("customer", Customer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipOperation>("operations", Operations);
            writer.WriteObjectValue<DelegatedAdminRelationshipParticipant>("partner", Partner);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipRequest>("requests", Requests);
            writer.WriteEnumValue<DelegatedAdminRelationshipStatus>("status", Status);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class DelegatedAdminRelationship : Entity, IParsable {
        /// <summary>The access assignments associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminAccessAssignment> AccessAssignments {
            get { return BackingStore?.Get<List<DelegatedAdminAccessAssignment>>(nameof(AccessAssignments)); }
            set { BackingStore?.Set(nameof(AccessAssignments), value); }
        }
        /// <summary>The accessDetails property</summary>
        public DelegatedAdminAccessDetails AccessDetails {
            get { return BackingStore?.Get<DelegatedAdminAccessDetails>(nameof(AccessDetails)); }
            set { BackingStore?.Set(nameof(AccessDetails), value); }
        }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship became active. Read-only.</summary>
        public DateTimeOffset? ActivatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActivatedDateTime)); }
            set { BackingStore?.Set(nameof(ActivatedDateTime), value); }
        }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The display name and unique identifier of the customer of the relationship. This is configured either by the partner at the time the relationship is created or by the system after the customer approves the relationship. Cannot be changed by the customer.</summary>
        public DelegatedAdminRelationshipCustomerParticipant Customer {
            get { return BackingStore?.Get<DelegatedAdminRelationshipCustomerParticipant>(nameof(Customer)); }
            set { BackingStore?.Set(nameof(Customer), value); }
        }
        /// <summary>The display name of the relationship used for ease of identification. Must be unique across all delegated admin relationships of the partner. This is set by the partner only when the relationship is in the created status and cannot be changed by the customer.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The duration of the relationship in ISO 8601 format. Must be a value between P1D and P2Y inclusive. This is set by the partner only when the relationship is in the created status and cannot be changed by the customer.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the status of relationship changes to either terminated or expired. Calculated as endDateTime = activatedDateTime + duration. Read-only.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The long running operations associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminRelationshipOperation> Operations {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The partner property</summary>
        public DelegatedAdminRelationshipParticipant Partner {
            get { return BackingStore?.Get<DelegatedAdminRelationshipParticipant>(nameof(Partner)); }
            set { BackingStore?.Set(nameof(Partner), value); }
        }
        /// <summary>The requests associated with the delegated admin relationship.</summary>
        public List<DelegatedAdminRelationshipRequest> Requests {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipRequest>>(nameof(Requests)); }
            set { BackingStore?.Set(nameof(Requests), value); }
        }
        /// <summary>The status of the relationship. Read Only. The possible values are: activating, active, approvalPending, approved, created, expired, expiring, terminated, terminating, terminationRequested, unknownFutureValue. Supports $orderBy.</summary>
        public DelegatedAdminRelationshipStatus? Status {
            get { return BackingStore?.Get<DelegatedAdminRelationshipStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessAssignments", n => { AccessAssignments = n.GetCollectionOfObjectValues<DelegatedAdminAccessAssignment>(DelegatedAdminAccessAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessDetails", n => { AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"activatedDateTime", n => { ActivatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<DelegatedAdminRelationshipCustomerParticipant>(DelegatedAdminRelationshipCustomerParticipant.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipOperation>(DelegatedAdminRelationshipOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"partner", n => { Partner = n.GetObjectValue<DelegatedAdminRelationshipParticipant>(DelegatedAdminRelationshipParticipant.CreateFromDiscriminatorValue); } },
                {"requests", n => { Requests = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipRequest>(DelegatedAdminRelationshipRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<DelegatedAdminRelationshipStatus>(); } },
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

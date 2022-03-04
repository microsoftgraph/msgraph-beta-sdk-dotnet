using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminRelationship : Entity, IParsable {
        public List<DelegatedAdminAccessAssignment> AccessAssignments { get; set; }
        public DelegatedAdminAccessDetails AccessDetails { get; set; }
        public DateTimeOffset? ActivatedDateTime { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DelegatedAdminRelationshipCustomerParticipant Customer { get; set; }
        public string DisplayName { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public List<DelegatedAdminRelationshipOperation> Operations { get; set; }
        public DelegatedAdminRelationshipParticipant Partner { get; set; }
        public List<DelegatedAdminRelationshipRequest> Requests { get; set; }
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

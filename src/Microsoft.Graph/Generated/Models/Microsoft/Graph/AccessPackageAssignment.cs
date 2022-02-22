using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageAssignment : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy AccessPackageAssignmentPolicy { get; set; }
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests { get; set; }
        /// <summary>The resource roles delivered to the target user for this assignment. Read-only. Nullable.</summary>
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles { get; set; }
        /// <summary>The identifier of the access package. Read-only.</summary>
        public string AccessPackageId { get; set; }
        /// <summary>The identifier of the access package assignment policy. Read-only.</summary>
        public string AssignmentPolicyId { get; set; }
        /// <summary>The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only. Supports $filter (eq).</summary>
        public string AssignmentState { get; set; }
        /// <summary>More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.</summary>
        public string AssignmentStatus { get; set; }
        /// <summary>The identifier of the catalog containing the access package. Read-only.</summary>
        public string CatalogId { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>Indicates whether the access package assignment is extended. Read-only.</summary>
        public bool? IsExtended { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
        public RequestSchedule Schedule { get; set; }
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject Target { get; set; }
        /// <summary>The ID of the subject with the assignment. Read-only.</summary>
        public string TargetId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignment).AccessPackage = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>(); } },
                {"accessPackageAssignmentPolicy", (o,n) => { (o as AccessPackageAssignment).AccessPackageAssignmentPolicy = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>(); } },
                {"accessPackageAssignmentRequests", (o,n) => { (o as AccessPackageAssignment).AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>().ToList(); } },
                {"accessPackageAssignmentResourceRoles", (o,n) => { (o as AccessPackageAssignment).AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>().ToList(); } },
                {"accessPackageId", (o,n) => { (o as AccessPackageAssignment).AccessPackageId = n.GetStringValue(); } },
                {"assignmentPolicyId", (o,n) => { (o as AccessPackageAssignment).AssignmentPolicyId = n.GetStringValue(); } },
                {"assignmentState", (o,n) => { (o as AccessPackageAssignment).AssignmentState = n.GetStringValue(); } },
                {"assignmentStatus", (o,n) => { (o as AccessPackageAssignment).AssignmentStatus = n.GetStringValue(); } },
                {"catalogId", (o,n) => { (o as AccessPackageAssignment).CatalogId = n.GetStringValue(); } },
                {"expiredDateTime", (o,n) => { (o as AccessPackageAssignment).ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"isExtended", (o,n) => { (o as AccessPackageAssignment).IsExtended = n.GetBoolValue(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignment).Schedule = n.GetObjectValue<RequestSchedule>(); } },
                {"target", (o,n) => { (o as AccessPackageAssignment).Target = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>(); } },
                {"targetId", (o,n) => { (o as AccessPackageAssignment).TargetId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicy", AccessPackageAssignmentPolicy);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteStringValue("assignmentPolicyId", AssignmentPolicyId);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("assignmentStatus", AssignmentStatus);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteBoolValue("isExtended", IsExtended);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>("target", Target);
            writer.WriteStringValue("targetId", TargetId);
        }
    }
}

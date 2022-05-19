using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageAssignment : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackage AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage>(nameof(AccessPackage)); }
            set { BackingStore?.Set(nameof(AccessPackage), value); }
        }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy AccessPackageAssignmentPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>(nameof(AccessPackageAssignmentPolicy)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentPolicy), value); }
        }
        /// <summary>The accessPackageAssignmentRequests property</summary>
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>>(nameof(AccessPackageAssignmentRequests)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentRequests), value); }
        }
        /// <summary>The resource roles delivered to the target user for this assignment. Read-only. Nullable.</summary>
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageAssignmentResourceRole>>(nameof(AccessPackageAssignmentResourceRoles)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentResourceRoles), value); }
        }
        /// <summary>The identifier of the access package. Read-only.</summary>
        public string AccessPackageId {
            get { return BackingStore?.Get<string>(nameof(AccessPackageId)); }
            set { BackingStore?.Set(nameof(AccessPackageId), value); }
        }
        /// <summary>The identifier of the access package assignment policy. Read-only.</summary>
        public string AssignmentPolicyId {
            get { return BackingStore?.Get<string>(nameof(AssignmentPolicyId)); }
            set { BackingStore?.Set(nameof(AssignmentPolicyId), value); }
        }
        /// <summary>The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only. Supports $filter (eq).</summary>
        public string AssignmentState {
            get { return BackingStore?.Get<string>(nameof(AssignmentState)); }
            set { BackingStore?.Set(nameof(AssignmentState), value); }
        }
        /// <summary>More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.</summary>
        public string AssignmentStatus {
            get { return BackingStore?.Get<string>(nameof(AssignmentStatus)); }
            set { BackingStore?.Set(nameof(AssignmentStatus), value); }
        }
        /// <summary>The identifier of the catalog containing the access package. Read-only.</summary>
        public string CatalogId {
            get { return BackingStore?.Get<string>(nameof(CatalogId)); }
            set { BackingStore?.Set(nameof(CatalogId), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpiredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpiredDateTime)); }
            set { BackingStore?.Set(nameof(ExpiredDateTime), value); }
        }
        /// <summary>Indicates whether the access package assignment is extended. Read-only.</summary>
        public bool? IsExtended {
            get { return BackingStore?.Get<bool?>(nameof(IsExtended)); }
            set { BackingStore?.Set(nameof(IsExtended), value); }
        }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
        public RequestSchedule Schedule {
            get { return BackingStore?.Get<RequestSchedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
        public AccessPackageSubject Target {
            get { return BackingStore?.Get<AccessPackageSubject>(nameof(Target)); }
            set { BackingStore?.Set(nameof(Target), value); }
        }
        /// <summary>The ID of the subject with the assignment. Read-only.</summary>
        public string TargetId {
            get { return BackingStore?.Get<string>(nameof(TargetId)); }
            set { BackingStore?.Set(nameof(TargetId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"accessPackageAssignmentPolicy", n => { AccessPackageAssignmentPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>(Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                {"accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
                {"assignmentPolicyId", n => { AssignmentPolicyId = n.GetStringValue(); } },
                {"assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                {"assignmentStatus", n => { AssignmentStatus = n.GetStringValue(); } },
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"expiredDateTime", n => { ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"isExtended", n => { IsExtended = n.GetBoolValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"targetId", n => { TargetId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicy", AccessPackageAssignmentPolicy);
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
            writer.WriteObjectValue<AccessPackageSubject>("target", Target);
            writer.WriteStringValue("targetId", TargetId);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageAssignmentRequest : Entity, IParsable {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable.  Supports $expand.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        /// <summary>For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.  For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.  Supports $expand.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment AccessPackageAssignment { get; set; }
        /// <summary>Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.</summary>
        public List<AccessPackageAnswer> Answers { get; set; }
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDate { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        public List<CustomExtensionHandlerInstance> CustomExtensionHandlerInstances { get; set; }
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>True if the request is not to be processed for assignment.</summary>
        public bool? IsValidationOnly { get; set; }
        /// <summary>The requestor's supplied justification.</summary>
        public string Justification { get; set; }
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject Requestor { get; set; }
        /// <summary>One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, DeliveryFailed, Submitted or Scheduled. Read-only.</summary>
        public string RequestState { get; set; }
        /// <summary>More information on the request processing status. Read-only.</summary>
        public string RequestStatus { get; set; }
        /// <summary>The type of the request. The possible values are: notSpecified, userAdd, userUpdate, userRemove, adminAdd, adminUpdate, adminRemove, systemAdd, systemUpdate, systemRemove, onBehalfAdd, unknownFutureValue. A request from the user themselves would have requestType of UserAdd or UserRemove. This property cannot be changed once set.</summary>
        public string RequestType { get; set; }
        /// <summary>The range of dates that access is to be assigned to the requestor. This property cannot be changed once set.</summary>
        public RequestSchedule Schedule { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignmentRequest).AccessPackage = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>(); } },
                {"accessPackageAssignment", (o,n) => { (o as AccessPackageAssignmentRequest).AccessPackageAssignment = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>(); } },
                {"answers", (o,n) => { (o as AccessPackageAssignmentRequest).Answers = n.GetCollectionOfObjectValues<AccessPackageAnswer>().ToList(); } },
                {"completedDate", (o,n) => { (o as AccessPackageAssignmentRequest).CompletedDate = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageAssignmentRequest).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionHandlerInstances", (o,n) => { (o as AccessPackageAssignmentRequest).CustomExtensionHandlerInstances = n.GetCollectionOfObjectValues<CustomExtensionHandlerInstance>().ToList(); } },
                {"expirationDateTime", (o,n) => { (o as AccessPackageAssignmentRequest).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isValidationOnly", (o,n) => { (o as AccessPackageAssignmentRequest).IsValidationOnly = n.GetBoolValue(); } },
                {"justification", (o,n) => { (o as AccessPackageAssignmentRequest).Justification = n.GetStringValue(); } },
                {"requestor", (o,n) => { (o as AccessPackageAssignmentRequest).Requestor = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>(); } },
                {"requestState", (o,n) => { (o as AccessPackageAssignmentRequest).RequestState = n.GetStringValue(); } },
                {"requestStatus", (o,n) => { (o as AccessPackageAssignmentRequest).RequestStatus = n.GetStringValue(); } },
                {"requestType", (o,n) => { (o as AccessPackageAssignmentRequest).RequestType = n.GetStringValue(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignmentRequest).Schedule = n.GetObjectValue<RequestSchedule>(); } },
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
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>("accessPackageAssignment", AccessPackageAssignment);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("answers", Answers);
            writer.WriteDateTimeOffsetValue("completedDate", CompletedDate);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandlerInstance>("customExtensionHandlerInstances", CustomExtensionHandlerInstances);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
        }
    }
}

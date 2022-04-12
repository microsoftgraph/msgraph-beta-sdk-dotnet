using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentRequestRequirements : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Answers that have already been provided.</summary>
        public List<AccessPackageAnswer> ExistingAnswers { get; set; }
        /// <summary>Indicates whether a request must be approved by an approver.</summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>Indicates whether approval is required when a user tries to extend their access.</summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Indicates whether the requestor is allowed to set a custom schedule.</summary>
        public bool? IsCustomAssignmentScheduleAllowed { get; set; }
        /// <summary>Indicates whether a requestor must supply justification when submitting an assignment request.</summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>The description of the policy that the user is trying to request access using.</summary>
        public string PolicyDescription { get; set; }
        /// <summary>The display name of the policy that the user is trying to request access using.</summary>
        public string PolicyDisplayName { get; set; }
        /// <summary>The identifier of the policy that these requirements are associated with. This identifier can be used when creating a new assignment request.</summary>
        public string PolicyId { get; set; }
        /// <summary>Questions that are configured on the policy. The questions can be required or optional; callers can determine whether a question is required or optional based on the isRequired property on accessPackageQuestion.</summary>
        public List<AccessPackageQuestion> Questions { get; set; }
        /// <summary>Schedule restrictions enforced, if any.</summary>
        public RequestSchedule Schedule { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestRequirements and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestRequirements() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentRequestRequirements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestRequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"existingAnswers", n => { ExistingAnswers = n.GetCollectionOfObjectValues<AccessPackageAnswer>(AccessPackageAnswer.CreateFromDiscriminatorValue).ToList(); } },
                {"isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                {"isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                {"isCustomAssignmentScheduleAllowed", n => { IsCustomAssignmentScheduleAllowed = n.GetBoolValue(); } },
                {"isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
                {"policyDescription", n => { PolicyDescription = n.GetStringValue(); } },
                {"policyDisplayName", n => { PolicyDisplayName = n.GetStringValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("existingAnswers", ExistingAnswers);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isCustomAssignmentScheduleAllowed", IsCustomAssignmentScheduleAllowed);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteStringValue("policyDescription", PolicyDescription);
            writer.WriteStringValue("policyDisplayName", PolicyDisplayName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

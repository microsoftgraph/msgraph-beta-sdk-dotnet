using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of governanceRoleAssignmentRequest entities.</summary>
    public class GovernanceRoleAssignmentRequest : Entity, IParsable {
        /// <summary>Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).</summary>
        public string AssignmentState {
            get { return BackingStore?.Get<string>(nameof(AssignmentState)); }
            set { BackingStore?.Set(nameof(AssignmentState), value); }
        }
        /// <summary>If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.</summary>
        public string LinkedEligibleRoleAssignmentId {
            get { return BackingStore?.Get<string>(nameof(LinkedEligibleRoleAssignmentId)); }
            set { BackingStore?.Set(nameof(LinkedEligibleRoleAssignmentId), value); }
        }
        /// <summary>A message provided by users and administrators when create the request about why it is needed.</summary>
        public string Reason {
            get { return BackingStore?.Get<string>(nameof(Reason)); }
            set { BackingStore?.Set(nameof(Reason), value); }
        }
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RequestedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RequestedDateTime)); }
            set { BackingStore?.Set(nameof(RequestedDateTime), value); }
        }
        /// <summary>Read-only. The resource that the request aims to.</summary>
        public GovernanceResource Resource {
            get { return BackingStore?.Get<GovernanceResource>(nameof(Resource)); }
            set { BackingStore?.Set(nameof(Resource), value); }
        }
        /// <summary>Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.</summary>
        public string ResourceId {
            get { return BackingStore?.Get<string>(nameof(ResourceId)); }
            set { BackingStore?.Set(nameof(ResourceId), value); }
        }
        /// <summary>Read-only. The role definition that the request aims to.</summary>
        public GovernanceRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<GovernanceRoleDefinition>(nameof(RoleDefinition)); }
            set { BackingStore?.Set(nameof(RoleDefinition), value); }
        }
        /// <summary>Required. The identifier of the Azure role definition that the role assignment request is associated with.</summary>
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RoleDefinitionId)); }
            set { BackingStore?.Set(nameof(RoleDefinitionId), value); }
        }
        /// <summary>The schedule object of the role assignment request.</summary>
        public GovernanceSchedule Schedule {
            get { return BackingStore?.Get<GovernanceSchedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>The status of the role assignment request.</summary>
        public GovernanceRoleAssignmentRequestStatus Status {
            get { return BackingStore?.Get<GovernanceRoleAssignmentRequestStatus>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Read-only. The user/group principal.</summary>
        public GovernanceSubject Subject {
            get { return BackingStore?.Get<GovernanceSubject>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.</summary>
        public string SubjectId {
            get { return BackingStore?.Get<string>(nameof(SubjectId)); }
            set { BackingStore?.Set(nameof(SubjectId), value); }
        }
        /// <summary>Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceRoleAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                {"linkedEligibleRoleAssignmentId", n => { LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"requestedDateTime", n => { RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<GovernanceSchedule>(GovernanceSchedule.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<GovernanceRoleAssignmentRequestStatus>(GovernanceRoleAssignmentRequestStatus.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetObjectValue<GovernanceSubject>(GovernanceSubject.CreateFromDiscriminatorValue); } },
                {"subjectId", n => { SubjectId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("reason", Reason);
            writer.WriteDateTimeOffsetValue("requestedDateTime", RequestedDateTime);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<GovernanceSchedule>("schedule", Schedule);
            writer.WriteObjectValue<GovernanceRoleAssignmentRequestStatus>("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
            writer.WriteStringValue("type", Type);
        }
    }
}

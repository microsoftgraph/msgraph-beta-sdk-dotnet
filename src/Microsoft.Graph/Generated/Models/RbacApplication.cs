using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RbacApplication : Entity, IParsable {
        /// <summary>The resourceNamespaces property</summary>
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces { get; set; }
        /// <summary>The roleAssignmentApprovals property</summary>
        public List<Approval> RoleAssignmentApprovals { get; set; }
        /// <summary>Resource to grant access to users or groups.</summary>
        public List<UnifiedRoleAssignment> RoleAssignments { get; set; }
        /// <summary>The roleAssignmentScheduleInstances property</summary>
        public List<UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances { get; set; }
        /// <summary>The roleAssignmentScheduleRequests property</summary>
        public List<UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests { get; set; }
        /// <summary>The roleAssignmentSchedules property</summary>
        public List<UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules { get; set; }
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions { get; set; }
        /// <summary>The roleEligibilityScheduleInstances property</summary>
        public List<UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances { get; set; }
        /// <summary>The roleEligibilityScheduleRequests property</summary>
        public List<UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests { get; set; }
        /// <summary>The roleEligibilitySchedules property</summary>
        public List<UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules { get; set; }
        /// <summary>The transitiveRoleAssignments property</summary>
        public List<UnifiedRoleAssignment> TransitiveRoleAssignments { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RbacApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RbacApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"resourceNamespaces", (o,n) => { (o as RbacApplication).ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentApprovals", (o,n) => { (o as RbacApplication).RoleAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", (o,n) => { (o as RbacApplication).RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentScheduleInstances", (o,n) => { (o as RbacApplication).RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>(UnifiedRoleAssignmentScheduleInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentScheduleRequests", (o,n) => { (o as RbacApplication).RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>(UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentSchedules", (o,n) => { (o as RbacApplication).RoleAssignmentSchedules = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>(UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", (o,n) => { (o as RbacApplication).RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilityScheduleInstances", (o,n) => { (o as RbacApplication).RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilityScheduleRequests", (o,n) => { (o as RbacApplication).RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>(UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilitySchedules", (o,n) => { (o as RbacApplication).RoleEligibilitySchedules = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveRoleAssignments", (o,n) => { (o as RbacApplication).TransitiveRoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<Approval>("roleAssignmentApprovals", RoleAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>("roleAssignmentScheduleInstances", RoleAssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>("roleAssignmentScheduleRequests", RoleAssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>("roleAssignmentSchedules", RoleAssignmentSchedules);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>("roleEligibilityScheduleInstances", RoleEligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>("roleEligibilityScheduleRequests", RoleEligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>("roleEligibilitySchedules", RoleEligibilitySchedules);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("transitiveRoleAssignments", TransitiveRoleAssignments);
        }
    }
}

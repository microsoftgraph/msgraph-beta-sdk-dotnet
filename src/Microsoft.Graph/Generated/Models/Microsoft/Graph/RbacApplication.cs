using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RbacApplication : Entity, IParsable {
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces { get; set; }
        public List<Approval> RoleAssignmentApprovals { get; set; }
        /// <summary>Resource to grant access to users or groups.</summary>
        public List<UnifiedRoleAssignment> RoleAssignments { get; set; }
        public List<UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances { get; set; }
        public List<UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests { get; set; }
        public List<UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules { get; set; }
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions { get; set; }
        public List<UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances { get; set; }
        public List<UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests { get; set; }
        public List<UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules { get; set; }
        public List<UnifiedRoleAssignment> TransitiveRoleAssignments { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"resourceNamespaces", (o,n) => { (o as RbacApplication).ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>().ToList(); } },
                {"roleAssignmentApprovals", (o,n) => { (o as RbacApplication).RoleAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>().ToList(); } },
                {"roleAssignments", (o,n) => { (o as RbacApplication).RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>().ToList(); } },
                {"roleAssignmentScheduleInstances", (o,n) => { (o as RbacApplication).RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>().ToList(); } },
                {"roleAssignmentScheduleRequests", (o,n) => { (o as RbacApplication).RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>().ToList(); } },
                {"roleAssignmentSchedules", (o,n) => { (o as RbacApplication).RoleAssignmentSchedules = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>().ToList(); } },
                {"roleDefinitions", (o,n) => { (o as RbacApplication).RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>().ToList(); } },
                {"roleEligibilityScheduleInstances", (o,n) => { (o as RbacApplication).RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>().ToList(); } },
                {"roleEligibilityScheduleRequests", (o,n) => { (o as RbacApplication).RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>().ToList(); } },
                {"roleEligibilitySchedules", (o,n) => { (o as RbacApplication).RoleEligibilitySchedules = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>().ToList(); } },
                {"transitiveRoleAssignments", (o,n) => { (o as RbacApplication).TransitiveRoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>().ToList(); } },
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

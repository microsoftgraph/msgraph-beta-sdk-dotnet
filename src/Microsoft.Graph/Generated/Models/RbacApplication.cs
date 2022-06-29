using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RbacApplication : Entity, IParsable {
        /// <summary>The resourceNamespaces property</summary>
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces {
            get { return BackingStore?.Get<List<UnifiedRbacResourceNamespace>>(nameof(ResourceNamespaces)); }
            set { BackingStore?.Set(nameof(ResourceNamespaces), value); }
        }
        /// <summary>The roleAssignmentApprovals property</summary>
        public List<Approval> RoleAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>(nameof(RoleAssignmentApprovals)); }
            set { BackingStore?.Set(nameof(RoleAssignmentApprovals), value); }
        }
        /// <summary>Resource to grant access to users or groups.</summary>
        public List<UnifiedRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>(nameof(RoleAssignments)); }
            set { BackingStore?.Set(nameof(RoleAssignments), value); }
        }
        /// <summary>Instances for active role assignments.</summary>
        public List<UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleInstance>>(nameof(RoleAssignmentScheduleInstances)); }
            set { BackingStore?.Set(nameof(RoleAssignmentScheduleInstances), value); }
        }
        /// <summary>Requests for active role assignments to principals through PIM.</summary>
        public List<UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleRequest>>(nameof(RoleAssignmentScheduleRequests)); }
            set { BackingStore?.Set(nameof(RoleAssignmentScheduleRequests), value); }
        }
        /// <summary>Schedules for active role assignment operations.</summary>
        public List<UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentSchedule>>(nameof(RoleAssignmentSchedules)); }
            set { BackingStore?.Set(nameof(RoleAssignmentSchedules), value); }
        }
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>>(nameof(RoleDefinitions)); }
            set { BackingStore?.Set(nameof(RoleDefinitions), value); }
        }
        /// <summary>Instances for role eligibility requests.</summary>
        public List<UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleInstance>>(nameof(RoleEligibilityScheduleInstances)); }
            set { BackingStore?.Set(nameof(RoleEligibilityScheduleInstances), value); }
        }
        /// <summary>Requests for role eligibilities for principals through PIM.</summary>
        public List<UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleRequest>>(nameof(RoleEligibilityScheduleRequests)); }
            set { BackingStore?.Set(nameof(RoleEligibilityScheduleRequests), value); }
        }
        /// <summary>Schedules for role eligibility operations.</summary>
        public List<UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilitySchedule>>(nameof(RoleEligibilitySchedules)); }
            set { BackingStore?.Set(nameof(RoleEligibilitySchedules), value); }
        }
        /// <summary>The transitiveRoleAssignments property</summary>
        public List<UnifiedRoleAssignment> TransitiveRoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>(nameof(TransitiveRoleAssignments)); }
            set { BackingStore?.Set(nameof(TransitiveRoleAssignments), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentApprovals", n => { RoleAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentScheduleInstances", n => { RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>(UnifiedRoleAssignmentScheduleInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentScheduleRequests", n => { RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>(UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentSchedules", n => { RoleAssignmentSchedules = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>(UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilityScheduleInstances", n => { RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilityScheduleRequests", n => { RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>(UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleEligibilitySchedules", n => { RoleEligibilitySchedules = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveRoleAssignments", n => { TransitiveRoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
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

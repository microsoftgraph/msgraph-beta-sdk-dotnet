using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RbacApplication : Entity, IParsable {
        /// <summary>The resourceNamespaces property</summary>
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces {
            get { return BackingStore?.Get<List<UnifiedRbacResourceNamespace>>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
        /// <summary>The roleAssignmentApprovals property</summary>
        public List<Approval> RoleAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>("roleAssignmentApprovals"); }
            set { BackingStore?.Set("roleAssignmentApprovals", value); }
        }
        /// <summary>The roleAssignments property</summary>
        public List<UnifiedRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
        /// <summary>The roleAssignmentScheduleInstances property</summary>
        public List<UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleInstance>>("roleAssignmentScheduleInstances"); }
            set { BackingStore?.Set("roleAssignmentScheduleInstances", value); }
        }
        /// <summary>The roleAssignmentScheduleRequests property</summary>
        public List<UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleRequest>>("roleAssignmentScheduleRequests"); }
            set { BackingStore?.Set("roleAssignmentScheduleRequests", value); }
        }
        /// <summary>The roleAssignmentSchedules property</summary>
        public List<UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentSchedule>>("roleAssignmentSchedules"); }
            set { BackingStore?.Set("roleAssignmentSchedules", value); }
        }
        /// <summary>The roleDefinitions property</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
        /// <summary>The roleEligibilityScheduleInstances property</summary>
        public List<UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleInstance>>("roleEligibilityScheduleInstances"); }
            set { BackingStore?.Set("roleEligibilityScheduleInstances", value); }
        }
        /// <summary>The roleEligibilityScheduleRequests property</summary>
        public List<UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleRequest>>("roleEligibilityScheduleRequests"); }
            set { BackingStore?.Set("roleEligibilityScheduleRequests", value); }
        }
        /// <summary>The roleEligibilitySchedules property</summary>
        public List<UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilitySchedule>>("roleEligibilitySchedules"); }
            set { BackingStore?.Set("roleEligibilitySchedules", value); }
        }
        /// <summary>The transitiveRoleAssignments property</summary>
        public List<UnifiedRoleAssignment> TransitiveRoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>("transitiveRoleAssignments"); }
            set { BackingStore?.Set("transitiveRoleAssignments", value); }
        }
        /// <summary>
        /// Instantiates a new RbacApplication and sets the default values.
        /// </summary>
        public RbacApplication() : base() {
            OdataType = "#microsoft.graph.rbacApplication";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RbacApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RbacApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentApprovals", n => { RoleAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentScheduleInstances", n => { RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>(UnifiedRoleAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentScheduleRequests", n => { RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>(UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentSchedules", n => { RoleAssignmentSchedules = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>(UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilityScheduleInstances", n => { RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilityScheduleRequests", n => { RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>(UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilitySchedules", n => { RoleEligibilitySchedules = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveRoleAssignments", n => { TransitiveRoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

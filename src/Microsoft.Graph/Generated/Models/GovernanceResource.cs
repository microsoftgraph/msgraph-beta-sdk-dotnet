using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class GovernanceResource : Entity, IParsable {
        /// <summary>The display name of the resource.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The external id of the resource, representing its original id in the external system. For example, a subscription resource&apos;s external id can be &apos;/subscriptions/c14ae696-5e0c-4e5d-88cc-bef6637737ac&apos;.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
        /// <summary>Read-only. The parent resource. for pimforazurerbac scenario, it can represent the subscription the resource belongs to.</summary>
        public GovernanceResource Parent {
            get { return BackingStore?.Get<GovernanceResource>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
        /// <summary>Represents the date time when the resource is registered in PIM.</summary>
        public DateTimeOffset? RegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("registeredDateTime"); }
            set { BackingStore?.Set("registeredDateTime", value); }
        }
        /// <summary>The externalId of the resource&apos;s root scope that is registered in PIM. The root scope can be the parent, grandparent, or higher ancestor resources.</summary>
        public string RegisteredRoot {
            get { return BackingStore?.Get<string>("registeredRoot"); }
            set { BackingStore?.Set("registeredRoot", value); }
        }
        /// <summary>The collection of role assignment requests for the resource.</summary>
        public List<GovernanceRoleAssignmentRequest> RoleAssignmentRequests {
            get { return BackingStore?.Get<List<GovernanceRoleAssignmentRequest>>("roleAssignmentRequests"); }
            set { BackingStore?.Set("roleAssignmentRequests", value); }
        }
        /// <summary>The collection of role assignments for the resource.</summary>
        public List<GovernanceRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<GovernanceRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
        /// <summary>The collection of role defintions for the resource.</summary>
        public List<GovernanceRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<GovernanceRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
        /// <summary>The collection of role settings for the resource.</summary>
        public List<GovernanceRoleSetting> RoleSettings {
            get { return BackingStore?.Get<List<GovernanceRoleSetting>>("roleSettings"); }
            set { BackingStore?.Set("roleSettings", value); }
        }
        /// <summary>The status of a given resource. For example, it could represent whether the resource is locked or not (values: Active/Locked). Note: This property may be extended in the future to support more scenarios.</summary>
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Required. Resource type. For example, for Azure resources, the type could be &apos;Subscription&apos;, &apos;ResourceGroup&apos;, &apos;Microsoft.Sql/server&apos;, etc.</summary>
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GovernanceResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredRoot", n => { RegisteredRoot = n.GetStringValue(); } },
                {"roleAssignmentRequests", n => { RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>(GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleSettings", n => { RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>(GovernanceRoleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<GovernanceResource>("parent", Parent);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
            writer.WriteStringValue("registeredRoot", RegisteredRoot);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignmentRequest>("roleAssignmentRequests", RoleAssignmentRequests);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<GovernanceRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<GovernanceRoleSetting>("roleSettings", RoleSettings);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
        }
    }
}

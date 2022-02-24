using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceResource : Entity, IParsable {
        /// <summary>The display name of the resource.</summary>
        public string DisplayName { get; set; }
        /// <summary>The external id of the resource, representing its original id in the external system. For example, a subscription resource's external id can be '/subscriptions/c14ae696-5e0c-4e5d-88cc-bef6637737ac'.</summary>
        public string ExternalId { get; set; }
        /// <summary>Read-only. The parent resource. for pimforazurerbac scenario, it can represent the subscription the resource belongs to.</summary>
        public GovernanceResource Parent { get; set; }
        /// <summary>Represents the date time when the resource is registered in PIM.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>The externalId of the resource's root scope that is registered in PIM. The root scope can be the parent, grandparent, or higher ancestor resources.</summary>
        public string RegisteredRoot { get; set; }
        /// <summary>The collection of role assignment requests for the resource.</summary>
        public List<GovernanceRoleAssignmentRequest> RoleAssignmentRequests { get; set; }
        /// <summary>The collection of role assignments for the resource.</summary>
        public List<GovernanceRoleAssignment> RoleAssignments { get; set; }
        /// <summary>The collection of role defintions for the resource.</summary>
        public List<GovernanceRoleDefinition> RoleDefinitions { get; set; }
        /// <summary>The collection of role settings for the resource.</summary>
        public List<GovernanceRoleSetting> RoleSettings { get; set; }
        /// <summary>The status of a given resource. For example, it could represent whether the resource is locked or not (values: Active/Locked). Note: This property may be extended in the future to support more scenarios.</summary>
        public string Status { get; set; }
        /// <summary>Required. Resource type. For example, for Azure resources, the type could be 'Subscription', 'ResourceGroup', 'Microsoft.Sql/server', etc.</summary>
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as GovernanceResource).DisplayName = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as GovernanceResource).ExternalId = n.GetStringValue(); } },
                {"parent", (o,n) => { (o as GovernanceResource).Parent = n.GetObjectValue<GovernanceResource>(); } },
                {"registeredDateTime", (o,n) => { (o as GovernanceResource).RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredRoot", (o,n) => { (o as GovernanceResource).RegisteredRoot = n.GetStringValue(); } },
                {"roleAssignmentRequests", (o,n) => { (o as GovernanceResource).RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>().ToList(); } },
                {"roleAssignments", (o,n) => { (o as GovernanceResource).RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>().ToList(); } },
                {"roleDefinitions", (o,n) => { (o as GovernanceResource).RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>().ToList(); } },
                {"roleSettings", (o,n) => { (o as GovernanceResource).RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>().ToList(); } },
                {"status", (o,n) => { (o as GovernanceResource).Status = n.GetStringValue(); } },
                {"type", (o,n) => { (o as GovernanceResource).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

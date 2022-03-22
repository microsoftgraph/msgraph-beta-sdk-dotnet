using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UnifiedRoleScheduleInstanceBase : Entity, IParsable {
        /// <summary>Read-only property with details of the app specific scope when the assignment scope is app specific. Containment entity.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope AppScope { get; set; }
        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.</summary>
        public string AppScopeId { get; set; }
        /// <summary>The directory object that is the scope of the assignment. Enables the retrieval of the directory object using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject DirectoryScope { get; set; }
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
        public string DirectoryScopeId { get; set; }
        /// <summary>The principal that is getting a role assignment through the request. Enables the retrieval of the principal using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject Principal { get; set; }
        /// <summary>Identifier of the principal to which the assignment is being granted to. Can be a group or a user.</summary>
        public string PrincipalId { get; set; }
        /// <summary>The roleDefinition for the assignment. Enables the retrieval of the role definition using $expand at the same time as getting the role assignment. The roleDefinition.Id is automatically expanded.</summary>
        public UnifiedRoleDefinition RoleDefinition { get; set; }
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleScheduleInstanceBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleScheduleInstanceBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appScope", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).AppScope = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope>(MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).AppScopeId = n.GetStringValue(); } },
                {"directoryScope", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).DirectoryScopeId = n.GetStringValue(); } },
                {"principal", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", (o,n) => { (o as UnifiedRoleScheduleInstanceBase).RoleDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}

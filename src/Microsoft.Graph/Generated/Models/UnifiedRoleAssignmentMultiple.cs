using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class UnifiedRoleAssignmentMultiple : Entity, IParsable {
        /// <summary>Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.</summary>
        public List<string> AppScopeIds {
            get { return BackingStore?.Get<List<string>>(nameof(AppScopeIds)); }
            set { BackingStore?.Set(nameof(AppScopeIds), value); }
        }
        /// <summary>Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.</summary>
        public List<AppScope> AppScopes {
            get { return BackingStore?.Get<List<AppScope>>(nameof(AppScopes)); }
            set { BackingStore?.Set(nameof(AppScopes), value); }
        }
        /// <summary>The condition property</summary>
        public string Condition {
            get { return BackingStore?.Get<string>(nameof(Condition)); }
            set { BackingStore?.Set(nameof(Condition), value); }
        }
        /// <summary>Description of the role assignment.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.</summary>
        public List<string> DirectoryScopeIds {
            get { return BackingStore?.Get<List<string>>(nameof(DirectoryScopeIds)); }
            set { BackingStore?.Set(nameof(DirectoryScopeIds), value); }
        }
        /// <summary>Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.</summary>
        public List<DirectoryObject> DirectoryScopes {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(DirectoryScopes)); }
            set { BackingStore?.Set(nameof(DirectoryScopes), value); }
        }
        /// <summary>Name of the role assignment. Required.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).</summary>
        public List<string> PrincipalIds {
            get { return BackingStore?.Get<List<string>>(nameof(PrincipalIds)); }
            set { BackingStore?.Set(nameof(PrincipalIds), value); }
        }
        /// <summary>Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.</summary>
        public List<DirectoryObject> Principals {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(Principals)); }
            set { BackingStore?.Set(nameof(Principals), value); }
        }
        /// <summary>Specifies the roleDefinition that the assignment is for. Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.  Supports $filter (eq operator on id, isBuiltIn, and displayName, and startsWith operator on displayName)  and $expand.</summary>
        public UnifiedRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition>(nameof(RoleDefinition)); }
            set { BackingStore?.Set(nameof(RoleDefinition), value); }
        }
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for.</summary>
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RoleDefinitionId)); }
            set { BackingStore?.Set(nameof(RoleDefinitionId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleAssignmentMultiple CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleAssignmentMultiple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appScopeIds", n => { AppScopeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appScopes", n => { AppScopes = n.GetCollectionOfObjectValues<AppScope>(AppScope.CreateFromDiscriminatorValue).ToList(); } },
                {"condition", n => { Condition = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"directoryScopeIds", n => { DirectoryScopeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"directoryScopes", n => { DirectoryScopes = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"principalIds", n => { PrincipalIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"principals", n => { Principals = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("appScopeIds", AppScopeIds);
            writer.WriteCollectionOfObjectValues<AppScope>("appScopes", AppScopes);
            writer.WriteStringValue("condition", Condition);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("directoryScopeIds", DirectoryScopeIds);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directoryScopes", DirectoryScopes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("principalIds", PrincipalIds);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("principals", Principals);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}

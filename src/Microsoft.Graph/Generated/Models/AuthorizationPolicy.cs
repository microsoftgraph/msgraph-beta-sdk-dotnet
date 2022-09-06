using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthorizationPolicy : PolicyBase, IParsable {
        /// <summary>Indicates whether users can sign up for email based subscriptions.</summary>
        public bool? AllowedToSignUpEmailBasedSubscriptions {
            get { return BackingStore?.Get<bool?>("allowedToSignUpEmailBasedSubscriptions"); }
            set { BackingStore?.Set("allowedToSignUpEmailBasedSubscriptions", value); }
        }
        /// <summary>Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant.</summary>
        public bool? AllowedToUseSSPR {
            get { return BackingStore?.Get<bool?>("allowedToUseSSPR"); }
            set { BackingStore?.Set("allowedToUseSSPR", value); }
        }
        /// <summary>Indicates whether a user can join the tenant by email validation.</summary>
        public bool? AllowEmailVerifiedUsersToJoinOrganization {
            get { return BackingStore?.Get<bool?>("allowEmailVerifiedUsersToJoinOrganization"); }
            set { BackingStore?.Set("allowEmailVerifiedUsersToJoinOrganization", value); }
        }
        /// <summary>Indicates who can invite external users to the organization. Possible values are: none, adminsAndGuestInviters, adminsGuestInvitersAndAllMembers, everyone.  everyone is the default setting for all cloud environments except US Government. See more in the table below.</summary>
        public Microsoft.Graph.Beta.Models.AllowInvitesFrom? AllowInvitesFrom {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AllowInvitesFrom?>("allowInvitesFrom"); }
            set { BackingStore?.Set("allowInvitesFrom", value); }
        }
        /// <summary>The allowUserConsentForRiskyApps property</summary>
        public bool? AllowUserConsentForRiskyApps {
            get { return BackingStore?.Get<bool?>("allowUserConsentForRiskyApps"); }
            set { BackingStore?.Set("allowUserConsentForRiskyApps", value); }
        }
        /// <summary>To disable the use of MSOL PowerShell set this property to true. This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell. This does not affect Azure AD Connect or Microsoft Graph.</summary>
        public bool? BlockMsolPowerShell {
            get { return BackingStore?.Get<bool?>("blockMsolPowerShell"); }
            set { BackingStore?.Set("blockMsolPowerShell", value); }
        }
        /// <summary>The defaultUserRoleOverrides property</summary>
        public List<DefaultUserRoleOverride> DefaultUserRoleOverrides {
            get { return BackingStore?.Get<List<DefaultUserRoleOverride>>("defaultUserRoleOverrides"); }
            set { BackingStore?.Set("defaultUserRoleOverrides", value); }
        }
        /// <summary>The defaultUserRolePermissions property</summary>
        public Microsoft.Graph.Beta.Models.DefaultUserRolePermissions DefaultUserRolePermissions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>("defaultUserRolePermissions"); }
            set { BackingStore?.Set("defaultUserRolePermissions", value); }
        }
        /// <summary>List of features enabled for private preview on the tenant.</summary>
        public List<string> EnabledPreviewFeatures {
            get { return BackingStore?.Get<List<string>>("enabledPreviewFeatures"); }
            set { BackingStore?.Set("enabledPreviewFeatures", value); }
        }
        /// <summary>Represents role templateId for the role that should be granted to guest user. Refer to List unifiedRoleDefinitions to find the list of available role templates. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).</summary>
        public string GuestUserRoleId {
            get { return BackingStore?.Get<string>("guestUserRoleId"); }
            set { BackingStore?.Set("guestUserRoleId", value); }
        }
        /// <summary>Indicates if user consent to apps is allowed, and if it is, which app consent policy (permissionGrantPolicy) governs the permission for users to grant consent. Values should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.</summary>
        public List<string> PermissionGrantPolicyIdsAssignedToDefaultUserRole {
            get { return BackingStore?.Get<List<string>>("permissionGrantPolicyIdsAssignedToDefaultUserRole"); }
            set { BackingStore?.Set("permissionGrantPolicyIdsAssignedToDefaultUserRole", value); }
        }
        /// <summary>
        /// Instantiates a new AuthorizationPolicy and sets the default values.
        /// </summary>
        public AuthorizationPolicy() : base() {
            OdataType = "#microsoft.graph.authorizationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthorizationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthorizationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedToSignUpEmailBasedSubscriptions", n => { AllowedToSignUpEmailBasedSubscriptions = n.GetBoolValue(); } },
                {"allowedToUseSSPR", n => { AllowedToUseSSPR = n.GetBoolValue(); } },
                {"allowEmailVerifiedUsersToJoinOrganization", n => { AllowEmailVerifiedUsersToJoinOrganization = n.GetBoolValue(); } },
                {"allowInvitesFrom", n => { AllowInvitesFrom = n.GetEnumValue<AllowInvitesFrom>(); } },
                {"allowUserConsentForRiskyApps", n => { AllowUserConsentForRiskyApps = n.GetBoolValue(); } },
                {"blockMsolPowerShell", n => { BlockMsolPowerShell = n.GetBoolValue(); } },
                {"defaultUserRoleOverrides", n => { DefaultUserRoleOverrides = n.GetCollectionOfObjectValues<DefaultUserRoleOverride>(DefaultUserRoleOverride.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultUserRolePermissions", n => { DefaultUserRolePermissions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>(Microsoft.Graph.Beta.Models.DefaultUserRolePermissions.CreateFromDiscriminatorValue); } },
                {"enabledPreviewFeatures", n => { EnabledPreviewFeatures = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"guestUserRoleId", n => { GuestUserRoleId = n.GetStringValue(); } },
                {"permissionGrantPolicyIdsAssignedToDefaultUserRole", n => { PermissionGrantPolicyIdsAssignedToDefaultUserRole = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowedToSignUpEmailBasedSubscriptions", AllowedToSignUpEmailBasedSubscriptions);
            writer.WriteBoolValue("allowedToUseSSPR", AllowedToUseSSPR);
            writer.WriteBoolValue("allowEmailVerifiedUsersToJoinOrganization", AllowEmailVerifiedUsersToJoinOrganization);
            writer.WriteEnumValue<AllowInvitesFrom>("allowInvitesFrom", AllowInvitesFrom);
            writer.WriteBoolValue("allowUserConsentForRiskyApps", AllowUserConsentForRiskyApps);
            writer.WriteBoolValue("blockMsolPowerShell", BlockMsolPowerShell);
            writer.WriteCollectionOfObjectValues<DefaultUserRoleOverride>("defaultUserRoleOverrides", DefaultUserRoleOverrides);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>("defaultUserRolePermissions", DefaultUserRolePermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledPreviewFeatures", EnabledPreviewFeatures);
            writer.WriteStringValue("guestUserRoleId", GuestUserRoleId);
            writer.WriteCollectionOfPrimitiveValues<string>("permissionGrantPolicyIdsAssignedToDefaultUserRole", PermissionGrantPolicyIdsAssignedToDefaultUserRole);
        }
    }
}

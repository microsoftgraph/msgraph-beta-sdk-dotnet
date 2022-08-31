using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>The method the user or admin selected as default for performing multi-factor authentication for the user. The possible values are: none, mobilePhone, alternateMobilePhone, officePhone, microsoftAuthenticatorPush, softwareOneTimePasscode, unknownFutureValue.</summary>
        public DefaultMfaMethodType? DefaultMfaMethod {
            get { return BackingStore?.Get<DefaultMfaMethodType?>("defaultMfaMethod"); }
            set { BackingStore?.Set("defaultMfaMethod", value); }
        }
        /// <summary>Whether the user has an admin role in the tenant. This value can be used to check the authentication methods that privileged accounts are registered for and capable of.</summary>
        public bool? IsAdmin {
            get { return BackingStore?.Get<bool?>("isAdmin"); }
            set { BackingStore?.Set("isAdmin", value); }
        }
        /// <summary>Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaCapable {
            get { return BackingStore?.Get<bool?>("isMfaCapable"); }
            set { BackingStore?.Set("isMfaCapable", value); }
        }
        /// <summary>Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).</summary>
        public bool? IsMfaRegistered {
            get { return BackingStore?.Get<bool?>("isMfaRegistered"); }
            set { BackingStore?.Set("isMfaRegistered", value); }
        }
        /// <summary>Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsPasswordlessCapable {
            get { return BackingStore?.Get<bool?>("isPasswordlessCapable"); }
            set { BackingStore?.Set("isPasswordlessCapable", value); }
        }
        /// <summary>Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprCapable {
            get { return BackingStore?.Get<bool?>("isSsprCapable"); }
            set { BackingStore?.Set("isSsprCapable", value); }
        }
        /// <summary>Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).</summary>
        public bool? IsSsprEnabled {
            get { return BackingStore?.Get<bool?>("isSsprEnabled"); }
            set { BackingStore?.Set("isSsprEnabled", value); }
        }
        /// <summary>Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprRegistered {
            get { return BackingStore?.Get<bool?>("isSsprRegistered"); }
            set { BackingStore?.Set("isSsprRegistered", value); }
        }
        /// <summary>Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).</summary>
        public List<string> MethodsRegistered {
            get { return BackingStore?.Get<List<string>>("methodsRegistered"); }
            set { BackingStore?.Set("methodsRegistered", value); }
        }
        /// <summary>The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
        /// <summary>The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>Identifies whether the user is a member or guest in the tenant. The possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType {
            get { return BackingStore?.Get<SignInUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Instantiates a new userRegistrationDetails and sets the default values.
        /// </summary>
        public UserRegistrationDetails() : base() {
            OdataType = "#microsoft.graph.userRegistrationDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultMfaMethod", n => { DefaultMfaMethod = n.GetEnumValue<DefaultMfaMethodType>(); } },
                {"isAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"isMfaCapable", n => { IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", n => { IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", n => { IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", n => { IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", n => { IsSsprRegistered = n.GetBoolValue(); } },
                {"methodsRegistered", n => { MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DefaultMfaMethodType>("defaultMfaMethod", DefaultMfaMethod);
            writer.WriteBoolValue("isAdmin", IsAdmin);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}

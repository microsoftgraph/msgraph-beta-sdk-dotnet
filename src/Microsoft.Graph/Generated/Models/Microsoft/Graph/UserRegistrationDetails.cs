using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaCapable { get; set; }
        /// <summary>Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).</summary>
        public bool? IsMfaRegistered { get; set; }
        /// <summary>Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsPasswordlessCapable { get; set; }
        /// <summary>Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprCapable { get; set; }
        /// <summary>Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).</summary>
        public bool? IsSsprEnabled { get; set; }
        /// <summary>Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprRegistered { get; set; }
        /// <summary>Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).</summary>
        public List<string> MethodsRegistered { get; set; }
        /// <summary>The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isMfaCapable", (o,n) => { (o as UserRegistrationDetails).IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", (o,n) => { (o as UserRegistrationDetails).IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", (o,n) => { (o as UserRegistrationDetails).IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", (o,n) => { (o as UserRegistrationDetails).IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", (o,n) => { (o as UserRegistrationDetails).IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", (o,n) => { (o as UserRegistrationDetails).IsSsprRegistered = n.GetBoolValue(); } },
                {"methodsRegistered", (o,n) => { (o as UserRegistrationDetails).MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userDisplayName", (o,n) => { (o as UserRegistrationDetails).UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserRegistrationDetails).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}

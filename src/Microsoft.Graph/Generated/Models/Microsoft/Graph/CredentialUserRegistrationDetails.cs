using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CredentialUserRegistrationDetails : Entity, IParsable {
        /// <summary>Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.</summary>
        public List<RegistrationAuthMethod?> AuthMethods { get; set; }
        /// <summary>Indicates whether the user is ready to perform self-service password reset or MFA.</summary>
        public bool? IsCapable { get; set; }
        /// <summary>Indicates whether the user enabled to perform self-service password reset.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Indicates whether the user is registered for MFA.</summary>
        public bool? IsMfaRegistered { get; set; }
        /// <summary>Indicates whether the user has registered any authentication methods for self-service password reset.</summary>
        public bool? IsRegistered { get; set; }
        /// <summary>Provides the user name of the corresponding user.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Provides the user principal name of the corresponding user.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authMethods", (o,n) => { (o as CredentialUserRegistrationDetails).AuthMethods = n.GetCollectionOfEnumValues<RegistrationAuthMethod>().ToList(); } },
                {"isCapable", (o,n) => { (o as CredentialUserRegistrationDetails).IsCapable = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as CredentialUserRegistrationDetails).IsEnabled = n.GetBoolValue(); } },
                {"isMfaRegistered", (o,n) => { (o as CredentialUserRegistrationDetails).IsMfaRegistered = n.GetBoolValue(); } },
                {"isRegistered", (o,n) => { (o as CredentialUserRegistrationDetails).IsRegistered = n.GetBoolValue(); } },
                {"userDisplayName", (o,n) => { (o as CredentialUserRegistrationDetails).UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as CredentialUserRegistrationDetails).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<RegistrationAuthMethod>("authMethods", AuthMethods);
            writer.WriteBoolValue("isCapable", IsCapable);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isRegistered", IsRegistered);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}

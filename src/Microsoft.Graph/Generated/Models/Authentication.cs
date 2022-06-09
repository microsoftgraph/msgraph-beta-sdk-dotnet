using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class Authentication : Entity, IParsable {
        /// <summary>Represents the email addresses registered to a user for authentication.</summary>
        public List<EmailAuthenticationMethod> EmailMethods {
            get { return BackingStore?.Get<List<EmailAuthenticationMethod>>(nameof(EmailMethods)); }
            set { BackingStore?.Set(nameof(EmailMethods), value); }
        }
        /// <summary>Represents the FIDO2 security keys registered to a user for authentication.</summary>
        public List<Fido2AuthenticationMethod> Fido2Methods {
            get { return BackingStore?.Get<List<Fido2AuthenticationMethod>>(nameof(Fido2Methods)); }
            set { BackingStore?.Set(nameof(Fido2Methods), value); }
        }
        /// <summary>Represents all authentication methods registered to a user.</summary>
        public List<AuthenticationMethod> Methods {
            get { return BackingStore?.Get<List<AuthenticationMethod>>(nameof(Methods)); }
            set { BackingStore?.Set(nameof(Methods), value); }
        }
        /// <summary>The details of the Microsoft Authenticator app registered to a user for authentication.</summary>
        public List<MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods {
            get { return BackingStore?.Get<List<MicrosoftAuthenticatorAuthenticationMethod>>(nameof(MicrosoftAuthenticatorMethods)); }
            set { BackingStore?.Set(nameof(MicrosoftAuthenticatorMethods), value); }
        }
        /// <summary>The operations property</summary>
        public List<LongRunningOperation> Operations {
            get { return BackingStore?.Get<List<LongRunningOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>Represents the Microsoft Authenticator Passwordless Phone Sign-in methods registered to a user for authentication.</summary>
        public List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> PasswordlessMicrosoftAuthenticatorMethods {
            get { return BackingStore?.Get<List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>>(nameof(PasswordlessMicrosoftAuthenticatorMethods)); }
            set { BackingStore?.Set(nameof(PasswordlessMicrosoftAuthenticatorMethods), value); }
        }
        /// <summary>Represents the details of the password authentication method registered to a user for authentication.</summary>
        public List<PasswordAuthenticationMethod> PasswordMethods {
            get { return BackingStore?.Get<List<PasswordAuthenticationMethod>>(nameof(PasswordMethods)); }
            set { BackingStore?.Set(nameof(PasswordMethods), value); }
        }
        /// <summary>Represents the phone registered to a user for authentication.</summary>
        public List<PhoneAuthenticationMethod> PhoneMethods {
            get { return BackingStore?.Get<List<PhoneAuthenticationMethod>>(nameof(PhoneMethods)); }
            set { BackingStore?.Set(nameof(PhoneMethods), value); }
        }
        /// <summary>The softwareOathMethods property</summary>
        public List<SoftwareOathAuthenticationMethod> SoftwareOathMethods {
            get { return BackingStore?.Get<List<SoftwareOathAuthenticationMethod>>(nameof(SoftwareOathMethods)); }
            set { BackingStore?.Set(nameof(SoftwareOathMethods), value); }
        }
        /// <summary>Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.</summary>
        public List<TemporaryAccessPassAuthenticationMethod> TemporaryAccessPassMethods {
            get { return BackingStore?.Get<List<TemporaryAccessPassAuthenticationMethod>>(nameof(TemporaryAccessPassMethods)); }
            set { BackingStore?.Set(nameof(TemporaryAccessPassMethods), value); }
        }
        /// <summary>Represents the Windows Hello for Business authentication method registered to a user for authentication.</summary>
        public List<WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods {
            get { return BackingStore?.Get<List<WindowsHelloForBusinessAuthenticationMethod>>(nameof(WindowsHelloForBusinessMethods)); }
            set { BackingStore?.Set(nameof(WindowsHelloForBusinessMethods), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Authentication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Authentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"emailMethods", n => { EmailMethods = n.GetCollectionOfObjectValues<EmailAuthenticationMethod>(EmailAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"fido2Methods", n => { Fido2Methods = n.GetCollectionOfObjectValues<Fido2AuthenticationMethod>(Fido2AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"methods", n => { Methods = n.GetCollectionOfObjectValues<AuthenticationMethod>(AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftAuthenticatorMethods", n => { MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>(MicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<LongRunningOperation>(LongRunningOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordlessMicrosoftAuthenticatorMethods", n => { PasswordlessMicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>(PasswordlessMicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordMethods", n => { PasswordMethods = n.GetCollectionOfObjectValues<PasswordAuthenticationMethod>(PasswordAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"phoneMethods", n => { PhoneMethods = n.GetCollectionOfObjectValues<PhoneAuthenticationMethod>(PhoneAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"softwareOathMethods", n => { SoftwareOathMethods = n.GetCollectionOfObjectValues<SoftwareOathAuthenticationMethod>(SoftwareOathAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"temporaryAccessPassMethods", n => { TemporaryAccessPassMethods = n.GetCollectionOfObjectValues<TemporaryAccessPassAuthenticationMethod>(TemporaryAccessPassAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsHelloForBusinessMethods", n => { WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>(WindowsHelloForBusinessAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EmailAuthenticationMethod>("emailMethods", EmailMethods);
            writer.WriteCollectionOfObjectValues<Fido2AuthenticationMethod>("fido2Methods", Fido2Methods);
            writer.WriteCollectionOfObjectValues<AuthenticationMethod>("methods", Methods);
            writer.WriteCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>("microsoftAuthenticatorMethods", MicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>("passwordlessMicrosoftAuthenticatorMethods", PasswordlessMicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<PasswordAuthenticationMethod>("passwordMethods", PasswordMethods);
            writer.WriteCollectionOfObjectValues<PhoneAuthenticationMethod>("phoneMethods", PhoneMethods);
            writer.WriteCollectionOfObjectValues<SoftwareOathAuthenticationMethod>("softwareOathMethods", SoftwareOathMethods);
            writer.WriteCollectionOfObjectValues<TemporaryAccessPassAuthenticationMethod>("temporaryAccessPassMethods", TemporaryAccessPassMethods);
            writer.WriteCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>("windowsHelloForBusinessMethods", WindowsHelloForBusinessMethods);
        }
    }
}

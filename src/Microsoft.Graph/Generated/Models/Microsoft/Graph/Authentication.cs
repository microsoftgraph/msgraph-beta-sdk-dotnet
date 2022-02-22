using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Authentication : Entity, IParsable {
        public List<EmailAuthenticationMethod> EmailMethods { get; set; }
        public List<Fido2AuthenticationMethod> Fido2Methods { get; set; }
        public List<AuthenticationMethod> Methods { get; set; }
        public List<MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods { get; set; }
        public List<LongRunningOperation> Operations { get; set; }
        public List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> PasswordlessMicrosoftAuthenticatorMethods { get; set; }
        public List<PasswordAuthenticationMethod> PasswordMethods { get; set; }
        public List<PhoneAuthenticationMethod> PhoneMethods { get; set; }
        public List<SoftwareOathAuthenticationMethod> SoftwareOathMethods { get; set; }
        public List<TemporaryAccessPassAuthenticationMethod> TemporaryAccessPassMethods { get; set; }
        public List<WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"emailMethods", (o,n) => { (o as Authentication).EmailMethods = n.GetCollectionOfObjectValues<EmailAuthenticationMethod>().ToList(); } },
                {"fido2Methods", (o,n) => { (o as Authentication).Fido2Methods = n.GetCollectionOfObjectValues<Fido2AuthenticationMethod>().ToList(); } },
                {"methods", (o,n) => { (o as Authentication).Methods = n.GetCollectionOfObjectValues<AuthenticationMethod>().ToList(); } },
                {"microsoftAuthenticatorMethods", (o,n) => { (o as Authentication).MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>().ToList(); } },
                {"operations", (o,n) => { (o as Authentication).Operations = n.GetCollectionOfObjectValues<LongRunningOperation>().ToList(); } },
                {"passwordlessMicrosoftAuthenticatorMethods", (o,n) => { (o as Authentication).PasswordlessMicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>().ToList(); } },
                {"passwordMethods", (o,n) => { (o as Authentication).PasswordMethods = n.GetCollectionOfObjectValues<PasswordAuthenticationMethod>().ToList(); } },
                {"phoneMethods", (o,n) => { (o as Authentication).PhoneMethods = n.GetCollectionOfObjectValues<PhoneAuthenticationMethod>().ToList(); } },
                {"softwareOathMethods", (o,n) => { (o as Authentication).SoftwareOathMethods = n.GetCollectionOfObjectValues<SoftwareOathAuthenticationMethod>().ToList(); } },
                {"temporaryAccessPassMethods", (o,n) => { (o as Authentication).TemporaryAccessPassMethods = n.GetCollectionOfObjectValues<TemporaryAccessPassAuthenticationMethod>().ToList(); } },
                {"windowsHelloForBusinessMethods", (o,n) => { (o as Authentication).WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>().ToList(); } },
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

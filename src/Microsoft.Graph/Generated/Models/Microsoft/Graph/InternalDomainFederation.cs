using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class InternalDomainFederation : SamlOrWsFedProvider, IParsable {
        /// <summary>The activeSignInUri property</summary>
        public string ActiveSignInUri { get; set; }
        /// <summary>The federatedIdpMfaBehavior property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.FederatedIdpMfaBehavior? FederatedIdpMfaBehavior { get; set; }
        /// <summary>The isSignedAuthenticationRequestRequired property</summary>
        public bool? IsSignedAuthenticationRequestRequired { get; set; }
        /// <summary>The nextSigningCertificate property</summary>
        public string NextSigningCertificate { get; set; }
        /// <summary>The promptLoginBehavior property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PromptLoginBehavior? PromptLoginBehavior { get; set; }
        /// <summary>The signingCertificateUpdateStatus property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SigningCertificateUpdateStatus SigningCertificateUpdateStatus { get; set; }
        /// <summary>The signOutUri property</summary>
        public string SignOutUri { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InternalDomainFederation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InternalDomainFederation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeSignInUri", (o,n) => { (o as InternalDomainFederation).ActiveSignInUri = n.GetStringValue(); } },
                {"federatedIdpMfaBehavior", (o,n) => { (o as InternalDomainFederation).FederatedIdpMfaBehavior = n.GetEnumValue<FederatedIdpMfaBehavior>(); } },
                {"isSignedAuthenticationRequestRequired", (o,n) => { (o as InternalDomainFederation).IsSignedAuthenticationRequestRequired = n.GetBoolValue(); } },
                {"nextSigningCertificate", (o,n) => { (o as InternalDomainFederation).NextSigningCertificate = n.GetStringValue(); } },
                {"promptLoginBehavior", (o,n) => { (o as InternalDomainFederation).PromptLoginBehavior = n.GetEnumValue<PromptLoginBehavior>(); } },
                {"signingCertificateUpdateStatus", (o,n) => { (o as InternalDomainFederation).SigningCertificateUpdateStatus = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SigningCertificateUpdateStatus>(MicrosoftGraphSdk.Models.Microsoft.Graph.SigningCertificateUpdateStatus.CreateFromDiscriminatorValue); } },
                {"signOutUri", (o,n) => { (o as InternalDomainFederation).SignOutUri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeSignInUri", ActiveSignInUri);
            writer.WriteEnumValue<FederatedIdpMfaBehavior>("federatedIdpMfaBehavior", FederatedIdpMfaBehavior);
            writer.WriteBoolValue("isSignedAuthenticationRequestRequired", IsSignedAuthenticationRequestRequired);
            writer.WriteStringValue("nextSigningCertificate", NextSigningCertificate);
            writer.WriteEnumValue<PromptLoginBehavior>("promptLoginBehavior", PromptLoginBehavior);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SigningCertificateUpdateStatus>("signingCertificateUpdateStatus", SigningCertificateUpdateStatus);
            writer.WriteStringValue("signOutUri", SignOutUri);
        }
    }
}

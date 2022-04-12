using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InternalDomainFederation : SamlOrWsFedProvider, IParsable {
        /// <summary>The activeSignInUri property</summary>
        public string ActiveSignInUri { get; set; }
        /// <summary>The federatedIdpMfaBehavior property</summary>
        public Microsoft.Graph.Beta.Models.FederatedIdpMfaBehavior? FederatedIdpMfaBehavior { get; set; }
        /// <summary>The isSignedAuthenticationRequestRequired property</summary>
        public bool? IsSignedAuthenticationRequestRequired { get; set; }
        /// <summary>The nextSigningCertificate property</summary>
        public string NextSigningCertificate { get; set; }
        /// <summary>The promptLoginBehavior property</summary>
        public Microsoft.Graph.Beta.Models.PromptLoginBehavior? PromptLoginBehavior { get; set; }
        /// <summary>The signingCertificateUpdateStatus property</summary>
        public Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus SigningCertificateUpdateStatus { get; set; }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeSignInUri", n => { ActiveSignInUri = n.GetStringValue(); } },
                {"federatedIdpMfaBehavior", n => { FederatedIdpMfaBehavior = n.GetEnumValue<FederatedIdpMfaBehavior>(); } },
                {"isSignedAuthenticationRequestRequired", n => { IsSignedAuthenticationRequestRequired = n.GetBoolValue(); } },
                {"nextSigningCertificate", n => { NextSigningCertificate = n.GetStringValue(); } },
                {"promptLoginBehavior", n => { PromptLoginBehavior = n.GetEnumValue<PromptLoginBehavior>(); } },
                {"signingCertificateUpdateStatus", n => { SigningCertificateUpdateStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus>(Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus.CreateFromDiscriminatorValue); } },
                {"signOutUri", n => { SignOutUri = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus>("signingCertificateUpdateStatus", SigningCertificateUpdateStatus);
            writer.WriteStringValue("signOutUri", SignOutUri);
        }
    }
}

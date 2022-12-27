using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class X509CertificateAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>Defines strong authentication configurations. This configuration includes the default authentication mode and the different rules for strong authentication bindings.</summary>
        public X509CertificateAuthenticationModeConfiguration AuthenticationModeConfiguration {
            get { return BackingStore?.Get<X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration"); }
            set { BackingStore?.Set("authenticationModeConfiguration", value); }
        }
        /// <summary>Defines fields in the X.509 certificate that map to attributes of the Azure AD user object in order to bind the certificate to the user. The priority of the object determines the order in which the binding is carried out. The first binding that matches will be used and the rest ignored.</summary>
        public List<X509CertificateUserBinding> CertificateUserBindings {
            get { return BackingStore?.Get<List<X509CertificateUserBinding>>("certificateUserBindings"); }
            set { BackingStore?.Set("certificateUserBindings", value); }
        }
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
        public List<AuthenticationMethodTarget> IncludeTargets {
            get { return BackingStore?.Get<List<AuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
        /// <summary>
        /// Instantiates a new X509CertificateAuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new X509CertificateAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationModeConfiguration", n => { AuthenticationModeConfiguration = n.GetObjectValue<X509CertificateAuthenticationModeConfiguration>(X509CertificateAuthenticationModeConfiguration.CreateFromDiscriminatorValue); } },
                {"certificateUserBindings", n => { CertificateUserBindings = n.GetCollectionOfObjectValues<X509CertificateUserBinding>(X509CertificateUserBinding.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration", AuthenticationModeConfiguration);
            writer.WriteCollectionOfObjectValues<X509CertificateUserBinding>("certificateUserBindings", CertificateUserBindings);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class X509CertificateAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>Defines strong authentication configurations. This configuration includes the default authentication mode and the different rules for strong authentication bindings.</summary>
        public X509CertificateAuthenticationModeConfiguration AuthenticationModeConfiguration {
            get { return BackingStore?.Get<X509CertificateAuthenticationModeConfiguration>(nameof(AuthenticationModeConfiguration)); }
            set { BackingStore?.Set(nameof(AuthenticationModeConfiguration), value); }
        }
        /// <summary>Defines fields in the X.509 certificate that map to attributes of the Azure AD user object in order to bind the certificate to the user. The priority of the object determines the order in which the binding is carried out. The first binding that matches will be used and the rest ignored.</summary>
        public List<X509CertificateUserBinding> CertificateUserBindings {
            get { return BackingStore?.Get<List<X509CertificateUserBinding>>(nameof(CertificateUserBindings)); }
            set { BackingStore?.Set(nameof(CertificateUserBindings), value); }
        }
        /// <summary>A collection of users or groups who are enabled to use the authentication method.</summary>
        public List<AuthenticationMethodTarget> IncludeTargets {
            get { return BackingStore?.Get<List<AuthenticationMethodTarget>>(nameof(IncludeTargets)); }
            set { BackingStore?.Set(nameof(IncludeTargets), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"certificateUserBindings", n => { CertificateUserBindings = n.GetCollectionOfObjectValues<X509CertificateUserBinding>(X509CertificateUserBinding.CreateFromDiscriminatorValue).ToList(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration", AuthenticationModeConfiguration);
            writer.WriteCollectionOfObjectValues<X509CertificateUserBinding>("certificateUserBindings", CertificateUserBindings);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}

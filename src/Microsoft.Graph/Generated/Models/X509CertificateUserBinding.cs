using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class X509CertificateUserBinding : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The priority of the binding. Azure AD uses the binding with the highest priority. This value must be a non-negative integer and unique in the collection of objects in the certificateUserBindings property of an x509CertificateAuthenticationMethodConfiguration object. Required</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>Defines the Azure AD user property of the user object to use for the binding. The possible values are: userPrincipalName, onPremisesUserPrincipalName, email. Required.</summary>
        public string UserProperty {
            get { return BackingStore?.Get<string>(nameof(UserProperty)); }
            set { BackingStore?.Set(nameof(UserProperty), value); }
        }
        /// <summary>The field on the X.509 certificate to use for the binding. The possible values are: PrincipalName, RFC822Name.</summary>
        public string X509CertificateField {
            get { return BackingStore?.Get<string>(nameof(X509CertificateField)); }
            set { BackingStore?.Set(nameof(X509CertificateField), value); }
        }
        /// <summary>
        /// Instantiates a new x509CertificateUserBinding and sets the default values.
        /// </summary>
        public X509CertificateUserBinding() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static X509CertificateUserBinding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateUserBinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"userProperty", n => { UserProperty = n.GetStringValue(); } },
                {"x509CertificateField", n => { X509CertificateField = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("userProperty", UserProperty);
            writer.WriteStringValue("x509CertificateField", X509CertificateField);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

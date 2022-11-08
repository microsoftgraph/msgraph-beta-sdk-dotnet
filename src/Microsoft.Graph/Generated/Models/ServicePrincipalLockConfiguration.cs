using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServicePrincipalLockConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The allProperties property</summary>
        public bool? AllProperties {
            get { return BackingStore?.Get<bool?>("allProperties"); }
            set { BackingStore?.Set("allProperties", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The credentialsWithUsageSign property</summary>
        public bool? CredentialsWithUsageSign {
            get { return BackingStore?.Get<bool?>("credentialsWithUsageSign"); }
            set { BackingStore?.Set("credentialsWithUsageSign", value); }
        }
        /// <summary>The credentialsWithUsageVerify property</summary>
        public bool? CredentialsWithUsageVerify {
            get { return BackingStore?.Get<bool?>("credentialsWithUsageVerify"); }
            set { BackingStore?.Set("credentialsWithUsageVerify", value); }
        }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The tokenEncryptionKeyId property</summary>
        public bool? TokenEncryptionKeyId {
            get { return BackingStore?.Get<bool?>("tokenEncryptionKeyId"); }
            set { BackingStore?.Set("tokenEncryptionKeyId", value); }
        }
        /// <summary>
        /// Instantiates a new servicePrincipalLockConfiguration and sets the default values.
        /// </summary>
        public ServicePrincipalLockConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.servicePrincipalLockConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServicePrincipalLockConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalLockConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allProperties", n => { AllProperties = n.GetBoolValue(); } },
                {"credentialsWithUsageSign", n => { CredentialsWithUsageSign = n.GetBoolValue(); } },
                {"credentialsWithUsageVerify", n => { CredentialsWithUsageVerify = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allProperties", AllProperties);
            writer.WriteBoolValue("credentialsWithUsageSign", CredentialsWithUsageSign);
            writer.WriteBoolValue("credentialsWithUsageVerify", CredentialsWithUsageVerify);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

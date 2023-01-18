using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class KerberosSignOnSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? KerberosServicePrincipalName {
            get { return BackingStore?.Get<string?>("kerberosServicePrincipalName"); }
            set { BackingStore?.Set("kerberosServicePrincipalName", value); }
        }
#else
        public string KerberosServicePrincipalName {
            get { return BackingStore?.Get<string>("kerberosServicePrincipalName"); }
            set { BackingStore?.Set("kerberosServicePrincipalName", value); }
        }
#endif
        /// <summary>The Delegated Login Identity for the connector to use on behalf of your users. For more information, see Working with different on-premises and cloud identities . Possible values are: userPrincipalName, onPremisesUserPrincipalName, userPrincipalUsername, onPremisesUserPrincipalUsername, onPremisesSAMAccountName.</summary>
        public Microsoft.Graph.Beta.Models.KerberosSignOnMappingAttributeType? KerberosSignOnMappingAttributeType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KerberosSignOnMappingAttributeType?>("kerberosSignOnMappingAttributeType"); }
            set { BackingStore?.Set("kerberosSignOnMappingAttributeType", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new kerberosSignOnSettings and sets the default values.
        /// </summary>
        public KerberosSignOnSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KerberosSignOnSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KerberosSignOnSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"kerberosServicePrincipalName", n => { KerberosServicePrincipalName = n.GetStringValue(); } },
                {"kerberosSignOnMappingAttributeType", n => { KerberosSignOnMappingAttributeType = n.GetEnumValue<KerberosSignOnMappingAttributeType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("kerberosServicePrincipalName", KerberosServicePrincipalName);
            writer.WriteEnumValue<KerberosSignOnMappingAttributeType>("kerberosSignOnMappingAttributeType", KerberosSignOnMappingAttributeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

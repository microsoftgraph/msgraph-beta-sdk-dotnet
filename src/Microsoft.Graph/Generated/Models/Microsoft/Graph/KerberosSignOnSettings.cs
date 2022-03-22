using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class KerberosSignOnSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.</summary>
        public string KerberosServicePrincipalName { get; set; }
        /// <summary>The Delegated Login Identity for the connector to use on behalf of your users. For more information, see Working with different on-premises and cloud identities . Possible values are: userPrincipalName, onPremisesUserPrincipalName, userPrincipalUsername, onPremisesUserPrincipalUsername, onPremisesSAMAccountName.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.KerberosSignOnMappingAttributeType? KerberosSignOnMappingAttributeType { get; set; }
        /// <summary>
        /// Instantiates a new kerberosSignOnSettings and sets the default values.
        /// </summary>
        public KerberosSignOnSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KerberosSignOnSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KerberosSignOnSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"kerberosServicePrincipalName", (o,n) => { (o as KerberosSignOnSettings).KerberosServicePrincipalName = n.GetStringValue(); } },
                {"kerberosSignOnMappingAttributeType", (o,n) => { (o as KerberosSignOnSettings).KerberosSignOnMappingAttributeType = n.GetEnumValue<KerberosSignOnMappingAttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("kerberosServicePrincipalName", KerberosServicePrincipalName);
            writer.WriteEnumValue<KerberosSignOnMappingAttributeType>("kerberosSignOnMappingAttributeType", KerberosSignOnMappingAttributeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

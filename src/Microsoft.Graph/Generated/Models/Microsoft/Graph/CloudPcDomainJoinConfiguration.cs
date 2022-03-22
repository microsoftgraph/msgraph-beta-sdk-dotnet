using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcDomainJoinConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The on-premises connection ID that matches the virtual network IT admins want the provisioning policy to use when they create Cloud PCs. You can use this property in both domain join types: Azure AD joined or Hybrid Azure AD joined. If you enter an onPremisesConnectionId, leave regionName as empty.</summary>
        public string OnPremisesConnectionId { get; set; }
        /// <summary>The supported Azure region where the IT admin wants the provisioning policy to create Cloud PCs. The underlying virtual network will be created and managed by the Windows 365 service. This can only be entered if the IT admin chooses Azure AD joined as the domain join type. If you enter a regionName, leave onPremisesConnectionId as empty.</summary>
        public string RegionName { get; set; }
        /// <summary>Specifies how the provisioned Cloud PC will be joined to Azure AD. If you choose the hybridAzureADJoin type, only provide a value for the onPremisesConnectionId property and leave regionName as empty. If you choose the azureADJoin type, provide a value for either onPremisesConnectionId or regionName. The possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcDomainJoinType? Type { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcDomainJoinConfiguration and sets the default values.
        /// </summary>
        public CloudPcDomainJoinConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"onPremisesConnectionId", (o,n) => { (o as CloudPcDomainJoinConfiguration).OnPremisesConnectionId = n.GetStringValue(); } },
                {"regionName", (o,n) => { (o as CloudPcDomainJoinConfiguration).RegionName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CloudPcDomainJoinConfiguration).Type = n.GetEnumValue<CloudPcDomainJoinType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteStringValue("regionName", RegionName);
            writer.WriteEnumValue<CloudPcDomainJoinType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

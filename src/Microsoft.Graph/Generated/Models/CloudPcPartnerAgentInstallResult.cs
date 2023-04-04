using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcPartnerAgentInstallResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The status of a partner agent installation. Possible values are: installed, installFailed, installing, uninstalling, uninstallFailed and licensed. Read-Only.</summary>
        public CloudPcPartnerAgentInstallStatus? InstallStatus {
            get { return BackingStore?.Get<CloudPcPartnerAgentInstallStatus?>("installStatus"); }
            set { BackingStore?.Set("installStatus", value); }
        }
        /// <summary>Indicates if the partner agent is a third party. When &apos;TRUE&apos;, the agent is a third-party (non-Microsoft) agent.  When &apos;FALSE&apos;, the agent is a Microsoft agent or is not known.  The default value is &apos;FALSE&apos;.</summary>
        public bool? IsThirdPartyPartner {
            get { return BackingStore?.Get<bool?>("isThirdPartyPartner"); }
            set { BackingStore?.Set("isThirdPartyPartner", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates the name of a partner agent and includes first-party and third-party. Currently, Citrix is the only third-party value. Read-Only.</summary>
        public CloudPcPartnerAgentName? PartnerAgentName {
            get { return BackingStore?.Get<CloudPcPartnerAgentName?>("partnerAgentName"); }
            set { BackingStore?.Set("partnerAgentName", value); }
        }
        /// <summary>Indicates if the partner agent is a third party. When &apos;TRUE&apos;, the agent is a third-party (non-Microsoft) agent. When &apos;FALSE&apos;, the agent is a Microsoft agent or is not known. The default value is &apos;FALSE&apos;.</summary>
        public bool? Retriable {
            get { return BackingStore?.Get<bool?>("retriable"); }
            set { BackingStore?.Set("retriable", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcPartnerAgentInstallResult and sets the default values.
        /// </summary>
        public CloudPcPartnerAgentInstallResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcPartnerAgentInstallResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcPartnerAgentInstallResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"installStatus", n => { InstallStatus = n.GetEnumValue<CloudPcPartnerAgentInstallStatus>(); } },
                {"isThirdPartyPartner", n => { IsThirdPartyPartner = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"partnerAgentName", n => { PartnerAgentName = n.GetEnumValue<CloudPcPartnerAgentName>(); } },
                {"retriable", n => { Retriable = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcPartnerAgentInstallStatus>("installStatus", InstallStatus);
            writer.WriteBoolValue("isThirdPartyPartner", IsThirdPartyPartner);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<CloudPcPartnerAgentName>("partnerAgentName", PartnerAgentName);
            writer.WriteBoolValue("retriable", Retriable);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

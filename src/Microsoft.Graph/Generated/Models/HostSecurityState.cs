using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class HostSecurityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Host FQDN (Fully Qualified Domain Name) (for example, machine.company.com).</summary>
        public string Fqdn {
            get { return BackingStore?.Get<string>(nameof(Fqdn)); }
            set { BackingStore?.Set(nameof(Fqdn), value); }
        }
        /// <summary>The isAzureAdJoined property</summary>
        public bool? IsAzureAdJoined {
            get { return BackingStore?.Get<bool?>(nameof(IsAzureAdJoined)); }
            set { BackingStore?.Set(nameof(IsAzureAdJoined), value); }
        }
        /// <summary>The isAzureAdRegistered property</summary>
        public bool? IsAzureAdRegistered {
            get { return BackingStore?.Get<bool?>(nameof(IsAzureAdRegistered)); }
            set { BackingStore?.Set(nameof(IsAzureAdRegistered), value); }
        }
        /// <summary>True if the host is domain joined to an on-premises Active Directory domain.</summary>
        public bool? IsHybridAzureDomainJoined {
            get { return BackingStore?.Get<bool?>(nameof(IsHybridAzureDomainJoined)); }
            set { BackingStore?.Set(nameof(IsHybridAzureDomainJoined), value); }
        }
        /// <summary>The local host name, without the DNS domain name.</summary>
        public string NetBiosName {
            get { return BackingStore?.Get<string>(nameof(NetBiosName)); }
            set { BackingStore?.Set(nameof(NetBiosName), value); }
        }
        /// <summary>Host Operating System. (For example, Windows10, MacOS, RHEL, etc.).</summary>
        public string Os {
            get { return BackingStore?.Get<string>(nameof(Os)); }
            set { BackingStore?.Set(nameof(Os), value); }
        }
        /// <summary>Private (not routable) IPv4 or IPv6 address (see RFC 1918) at the time of the alert.</summary>
        public string PrivateIpAddress {
            get { return BackingStore?.Get<string>(nameof(PrivateIpAddress)); }
            set { BackingStore?.Set(nameof(PrivateIpAddress), value); }
        }
        /// <summary>Publicly routable IPv4 or IPv6 address (see RFC 1918) at time of the alert.</summary>
        public string PublicIpAddress {
            get { return BackingStore?.Get<string>(nameof(PublicIpAddress)); }
            set { BackingStore?.Set(nameof(PublicIpAddress), value); }
        }
        /// <summary>Provider-generated/calculated risk score of the host.  Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore {
            get { return BackingStore?.Get<string>(nameof(RiskScore)); }
            set { BackingStore?.Set(nameof(RiskScore), value); }
        }
        /// <summary>
        /// Instantiates a new hostSecurityState and sets the default values.
        /// </summary>
        public HostSecurityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HostSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fqdn", n => { Fqdn = n.GetStringValue(); } },
                {"isAzureAdJoined", n => { IsAzureAdJoined = n.GetBoolValue(); } },
                {"isAzureAdRegistered", n => { IsAzureAdRegistered = n.GetBoolValue(); } },
                {"isHybridAzureDomainJoined", n => { IsHybridAzureDomainJoined = n.GetBoolValue(); } },
                {"netBiosName", n => { NetBiosName = n.GetStringValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"privateIpAddress", n => { PrivateIpAddress = n.GetStringValue(); } },
                {"publicIpAddress", n => { PublicIpAddress = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteBoolValue("isAzureAdJoined", IsAzureAdJoined);
            writer.WriteBoolValue("isAzureAdRegistered", IsAzureAdRegistered);
            writer.WriteBoolValue("isHybridAzureDomainJoined", IsHybridAzureDomainJoined);
            writer.WriteStringValue("netBiosName", NetBiosName);
            writer.WriteStringValue("os", Os);
            writer.WriteStringValue("privateIpAddress", PrivateIpAddress);
            writer.WriteStringValue("publicIpAddress", PublicIpAddress);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

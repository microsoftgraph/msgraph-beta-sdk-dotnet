using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN On-Demand Rule definition.</summary>
    public class VpnOnDemandRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>VPN On-Demand Rule Connection Action.</summary>
        public VpnOnDemandRuleConnectionAction? Action {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DNS Search Domains.</summary>
        public List<string> DnsSearchDomains {
            get { return BackingStore?.Get<List<string>>("dnsSearchDomains"); }
            set { BackingStore?.Set("dnsSearchDomains", value); }
        }
        /// <summary>VPN On-Demand Rule Connection Domain Action.</summary>
        public VpnOnDemandRuleConnectionDomainAction? DomainAction {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionDomainAction?>("domainAction"); }
            set { BackingStore?.Set("domainAction", value); }
        }
        /// <summary>Domains (Only applicable when Action is evaluate connection).</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
        /// <summary>Probe Required Url (Only applicable when Action is evaluate connection and DomainAction is connect if needed).</summary>
        public string ProbeRequiredUrl {
            get { return BackingStore?.Get<string>("probeRequiredUrl"); }
            set { BackingStore?.Set("probeRequiredUrl", value); }
        }
        /// <summary>A URL to probe. If this URL is successfully fetched (returning a 200 HTTP status code) without redirection, this rule matches.</summary>
        public string ProbeUrl {
            get { return BackingStore?.Get<string>("probeUrl"); }
            set { BackingStore?.Set("probeUrl", value); }
        }
        /// <summary>Network Service Set Identifiers (SSIDs).</summary>
        public List<string> Ssids {
            get { return BackingStore?.Get<List<string>>("ssids"); }
            set { BackingStore?.Set("ssids", value); }
        }
        /// <summary>
        /// Instantiates a new vpnOnDemandRule and sets the default values.
        /// </summary>
        public VpnOnDemandRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VpnOnDemandRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnOnDemandRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<VpnOnDemandRuleConnectionAction>(); } },
                {"dnsSearchDomains", n => { DnsSearchDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"domainAction", n => { DomainAction = n.GetEnumValue<VpnOnDemandRuleConnectionDomainAction>(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"probeRequiredUrl", n => { ProbeRequiredUrl = n.GetStringValue(); } },
                {"probeUrl", n => { ProbeUrl = n.GetStringValue(); } },
                {"ssids", n => { Ssids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VpnOnDemandRuleConnectionAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSearchDomains", DnsSearchDomains);
            writer.WriteEnumValue<VpnOnDemandRuleConnectionDomainAction>("domainAction", DomainAction);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteStringValue("probeRequiredUrl", ProbeRequiredUrl);
            writer.WriteStringValue("probeUrl", ProbeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("ssids", Ssids);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

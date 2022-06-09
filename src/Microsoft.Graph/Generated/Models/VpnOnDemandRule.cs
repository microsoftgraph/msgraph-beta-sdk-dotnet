using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN On-Demand Rule definition.</summary>
    public class VpnOnDemandRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Action. Possible values are: connect, evaluateConnection, ignore, disconnect.</summary>
        public VpnOnDemandRuleConnectionAction? Action {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionAction?>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DNS Search Domains.</summary>
        public List<string> DnsSearchDomains {
            get { return BackingStore?.Get<List<string>>(nameof(DnsSearchDomains)); }
            set { BackingStore?.Set(nameof(DnsSearchDomains), value); }
        }
        /// <summary>Domain Action (Only applicable when Action is evaluate connection). Possible values are: connectIfNeeded, neverConnect.</summary>
        public VpnOnDemandRuleConnectionDomainAction? DomainAction {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionDomainAction?>(nameof(DomainAction)); }
            set { BackingStore?.Set(nameof(DomainAction), value); }
        }
        /// <summary>Domains (Only applicable when Action is evaluate connection).</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>(nameof(Domains)); }
            set { BackingStore?.Set(nameof(Domains), value); }
        }
        /// <summary>Probe Required Url (Only applicable when Action is evaluate connection and DomainAction is connect if needed).</summary>
        public string ProbeRequiredUrl {
            get { return BackingStore?.Get<string>(nameof(ProbeRequiredUrl)); }
            set { BackingStore?.Set(nameof(ProbeRequiredUrl), value); }
        }
        /// <summary>A URL to probe. If this URL is successfully fetched (returning a 200 HTTP status code) without redirection, this rule matches.</summary>
        public string ProbeUrl {
            get { return BackingStore?.Get<string>(nameof(ProbeUrl)); }
            set { BackingStore?.Set(nameof(ProbeUrl), value); }
        }
        /// <summary>Network Service Set Identifiers (SSIDs).</summary>
        public List<string> Ssids {
            get { return BackingStore?.Get<List<string>>(nameof(Ssids)); }
            set { BackingStore?.Set(nameof(Ssids), value); }
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

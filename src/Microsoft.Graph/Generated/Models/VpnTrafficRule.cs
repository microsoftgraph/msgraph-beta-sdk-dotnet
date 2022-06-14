using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN Traffic Rule definition.</summary>
    public class VpnTrafficRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>App identifier, if this traffic rule is triggered by an app.</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>App type, if this traffic rule is triggered by an app. Possible values are: none, desktop, universal.</summary>
        public VpnTrafficRuleAppType? AppType {
            get { return BackingStore?.Get<VpnTrafficRuleAppType?>(nameof(AppType)); }
            set { BackingStore?.Set(nameof(AppType), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Claims associated with this traffic rule.</summary>
        public string Claims {
            get { return BackingStore?.Get<string>(nameof(Claims)); }
            set { BackingStore?.Set(nameof(Claims), value); }
        }
        /// <summary>Local address range. This collection can contain a maximum of 500 elements.</summary>
        public List<IPv4Range> LocalAddressRanges {
            get { return BackingStore?.Get<List<IPv4Range>>(nameof(LocalAddressRanges)); }
            set { BackingStore?.Set(nameof(LocalAddressRanges), value); }
        }
        /// <summary>Local port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.</summary>
        public List<NumberRange> LocalPortRanges {
            get { return BackingStore?.Get<List<NumberRange>>(nameof(LocalPortRanges)); }
            set { BackingStore?.Set(nameof(LocalPortRanges), value); }
        }
        /// <summary>Name.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Protocols (0-255). Valid values 0 to 255</summary>
        public int? Protocols {
            get { return BackingStore?.Get<int?>(nameof(Protocols)); }
            set { BackingStore?.Set(nameof(Protocols), value); }
        }
        /// <summary>Remote address range. This collection can contain a maximum of 500 elements.</summary>
        public List<IPv4Range> RemoteAddressRanges {
            get { return BackingStore?.Get<List<IPv4Range>>(nameof(RemoteAddressRanges)); }
            set { BackingStore?.Set(nameof(RemoteAddressRanges), value); }
        }
        /// <summary>Remote port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.</summary>
        public List<NumberRange> RemotePortRanges {
            get { return BackingStore?.Get<List<NumberRange>>(nameof(RemotePortRanges)); }
            set { BackingStore?.Set(nameof(RemotePortRanges), value); }
        }
        /// <summary>When app triggered, indicates whether to enable split tunneling along this route. Possible values are: none, splitTunnel, forceTunnel.</summary>
        public VpnTrafficRuleRoutingPolicyType? RoutingPolicyType {
            get { return BackingStore?.Get<VpnTrafficRuleRoutingPolicyType?>(nameof(RoutingPolicyType)); }
            set { BackingStore?.Set(nameof(RoutingPolicyType), value); }
        }
        /// <summary>
        /// Instantiates a new vpnTrafficRule and sets the default values.
        /// </summary>
        public VpnTrafficRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VpnTrafficRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnTrafficRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appType", n => { AppType = n.GetEnumValue<VpnTrafficRuleAppType>(); } },
                {"claims", n => { Claims = n.GetStringValue(); } },
                {"localAddressRanges", n => { LocalAddressRanges = n.GetCollectionOfObjectValues<IPv4Range>(IPv4Range.CreateFromDiscriminatorValue).ToList(); } },
                {"localPortRanges", n => { LocalPortRanges = n.GetCollectionOfObjectValues<NumberRange>(NumberRange.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"protocols", n => { Protocols = n.GetIntValue(); } },
                {"remoteAddressRanges", n => { RemoteAddressRanges = n.GetCollectionOfObjectValues<IPv4Range>(IPv4Range.CreateFromDiscriminatorValue).ToList(); } },
                {"remotePortRanges", n => { RemotePortRanges = n.GetCollectionOfObjectValues<NumberRange>(NumberRange.CreateFromDiscriminatorValue).ToList(); } },
                {"routingPolicyType", n => { RoutingPolicyType = n.GetEnumValue<VpnTrafficRuleRoutingPolicyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteEnumValue<VpnTrafficRuleAppType>("appType", AppType);
            writer.WriteStringValue("claims", Claims);
            writer.WriteCollectionOfObjectValues<IPv4Range>("localAddressRanges", LocalAddressRanges);
            writer.WriteCollectionOfObjectValues<NumberRange>("localPortRanges", LocalPortRanges);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("protocols", Protocols);
            writer.WriteCollectionOfObjectValues<IPv4Range>("remoteAddressRanges", RemoteAddressRanges);
            writer.WriteCollectionOfObjectValues<NumberRange>("remotePortRanges", RemotePortRanges);
            writer.WriteEnumValue<VpnTrafficRuleRoutingPolicyType>("routingPolicyType", RoutingPolicyType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

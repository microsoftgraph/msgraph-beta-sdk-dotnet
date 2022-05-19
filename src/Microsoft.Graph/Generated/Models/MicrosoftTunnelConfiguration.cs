using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that represents a collection of Microsoft Tunnel settings</summary>
    public class MicrosoftTunnelConfiguration : Entity, IParsable {
        /// <summary>Additional settings that may be applied to the server</summary>
        public List<KeyValuePair> AdvancedSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(AdvancedSettings)); }
            set { BackingStore?.Set(nameof(AdvancedSettings), value); }
        }
        /// <summary>The Default Domain appendix that will be used by the clients</summary>
        public string DefaultDomainSuffix {
            get { return BackingStore?.Get<string>(nameof(DefaultDomainSuffix)); }
            set { BackingStore?.Set(nameof(DefaultDomainSuffix), value); }
        }
        /// <summary>The MicrosoftTunnelConfiguration&apos;s description</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to tansfer data.</summary>
        public bool? DisableUdpConnections {
            get { return BackingStore?.Get<bool?>(nameof(DisableUdpConnections)); }
            set { BackingStore?.Set(nameof(DisableUdpConnections), value); }
        }
        /// <summary>The MicrosoftTunnelConfiguration&apos;s display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The DNS servers that will be used by the clients</summary>
        public List<string> DnsServers {
            get { return BackingStore?.Get<List<string>>(nameof(DnsServers)); }
            set { BackingStore?.Set(nameof(DnsServers), value); }
        }
        /// <summary>When the MicrosoftTunnelConfiguration was last updated</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdateDateTime), value); }
        }
        /// <summary>The port that both TCP and UPD will listen over on the server</summary>
        public int? ListenPort {
            get { return BackingStore?.Get<int?>(nameof(ListenPort)); }
            set { BackingStore?.Set(nameof(ListenPort), value); }
        }
        /// <summary>The subnet that will be used to allocate virtual address for the clients</summary>
        public string Network {
            get { return BackingStore?.Get<string>(nameof(Network)); }
            set { BackingStore?.Set(nameof(Network), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Subsets of the routes that will not be routed by the server</summary>
        public List<string> RoutesExclude {
            get { return BackingStore?.Get<List<string>>(nameof(RoutesExclude)); }
            set { BackingStore?.Set(nameof(RoutesExclude), value); }
        }
        /// <summary>The routs that will be routed by the server</summary>
        public List<string> RoutesInclude {
            get { return BackingStore?.Get<List<string>>(nameof(RoutesInclude)); }
            set { BackingStore?.Set(nameof(RoutesInclude), value); }
        }
        /// <summary>The domains that will be resolved using the provided dns servers</summary>
        public List<string> SplitDNS {
            get { return BackingStore?.Get<List<string>>(nameof(SplitDNS)); }
            set { BackingStore?.Set(nameof(SplitDNS), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedSettings", n => { AdvancedSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultDomainSuffix", n => { DefaultDomainSuffix = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disableUdpConnections", n => { DisableUdpConnections = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dnsServers", n => { DnsServers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"listenPort", n => { ListenPort = n.GetIntValue(); } },
                {"network", n => { Network = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"routesExclude", n => { RoutesExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"routesInclude", n => { RoutesInclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"splitDNS", n => { SplitDNS = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("advancedSettings", AdvancedSettings);
            writer.WriteStringValue("defaultDomainSuffix", DefaultDomainSuffix);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("disableUdpConnections", DisableUdpConnections);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsServers", DnsServers);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("listenPort", ListenPort);
            writer.WriteStringValue("network", Network);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfPrimitiveValues<string>("routesExclude", RoutesExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("routesInclude", RoutesInclude);
            writer.WriteCollectionOfPrimitiveValues<string>("splitDNS", SplitDNS);
        }
    }
}

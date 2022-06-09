using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A rule controlling traffic through the Windows Firewall.</summary>
    public class WindowsFirewallRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The action the rule enforces. If not specified, the default is Allowed. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? Action {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description of the rule.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the rule. Does not need to be unique.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Indicates whether edge traversal is enabled or disabled for this rule. The EdgeTraversal setting indicates that specific inbound traffic is allowed to tunnel through NATs and other edge devices using the Teredo tunneling technology. In order for this setting to work correctly, the application or service with the inbound firewall rule needs to support IPv6. The primary application of this setting allows listeners on the host to be globally addressable through a Teredo IPv6 address. New rules have the EdgeTraversal property disabled by default. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? EdgeTraversal {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(EdgeTraversal)); }
            set { BackingStore?.Set(nameof(EdgeTraversal), value); }
        }
        /// <summary>The full file path of an app that&apos;s affected by the firewall rule.</summary>
        public string FilePath {
            get { return BackingStore?.Get<string>(nameof(FilePath)); }
            set { BackingStore?.Set(nameof(FilePath), value); }
        }
        /// <summary>The interface types of the rule. Possible values are: notConfigured, remoteAccess, wireless, lan.</summary>
        public WindowsFirewallRuleInterfaceTypes? InterfaceTypes {
            get { return BackingStore?.Get<WindowsFirewallRuleInterfaceTypes?>(nameof(InterfaceTypes)); }
            set { BackingStore?.Set(nameof(InterfaceTypes), value); }
        }
        /// <summary>List of local addresses covered by the rule. Default is any address. Valid tokens include:&apos;&apos; indicates any local address. If present, this must be the only token included.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of &apos;start address - end address&apos; with no spaces included.An IPv6 address range in the format of &apos;start address - end address&apos; with no spaces included.</summary>
        public List<string> LocalAddressRanges {
            get { return BackingStore?.Get<List<string>>(nameof(LocalAddressRanges)); }
            set { BackingStore?.Set(nameof(LocalAddressRanges), value); }
        }
        /// <summary>List of local port ranges. For example, &apos;100-120&apos;, &apos;200&apos;, &apos;300-320&apos;. If not specified, the default is All.</summary>
        public List<string> LocalPortRanges {
            get { return BackingStore?.Get<List<string>>(nameof(LocalPortRanges)); }
            set { BackingStore?.Set(nameof(LocalPortRanges), value); }
        }
        /// <summary>Specifies the list of authorized local users for the app container. This is a string in Security Descriptor Definition Language (SDDL) format.</summary>
        public string LocalUserAuthorizations {
            get { return BackingStore?.Get<string>(nameof(LocalUserAuthorizations)); }
            set { BackingStore?.Set(nameof(LocalUserAuthorizations), value); }
        }
        /// <summary>The package family name of a Microsoft Store application that&apos;s affected by the firewall rule.</summary>
        public string PackageFamilyName {
            get { return BackingStore?.Get<string>(nameof(PackageFamilyName)); }
            set { BackingStore?.Set(nameof(PackageFamilyName), value); }
        }
        /// <summary>Specifies the profiles to which the rule belongs. If not specified, the default is All. Possible values are: notConfigured, domain, private, public.</summary>
        public WindowsFirewallRuleNetworkProfileTypes? ProfileTypes {
            get { return BackingStore?.Get<WindowsFirewallRuleNetworkProfileTypes?>(nameof(ProfileTypes)); }
            set { BackingStore?.Set(nameof(ProfileTypes), value); }
        }
        /// <summary>0-255 number representing the IP protocol (TCP = 6, UDP = 17). If not specified, the default is All. Valid values 0 to 255</summary>
        public int? Protocol {
            get { return BackingStore?.Get<int?>(nameof(Protocol)); }
            set { BackingStore?.Set(nameof(Protocol), value); }
        }
        /// <summary>List of tokens specifying the remote addresses covered by the rule. Tokens are case insensitive. Default is any address. Valid tokens include:&apos;&apos; indicates any remote address. If present, this must be the only token included.&apos;Defaultgateway&apos;&apos;DHCP&apos;&apos;DNS&apos;&apos;WINS&apos;&apos;Intranet&apos; (supported on Windows versions 1809+)&apos;RmtIntranet&apos; (supported on Windows versions 1809+)&apos;Internet&apos; (supported on Windows versions 1809+)&apos;Ply2Renders&apos; (supported on Windows versions 1809+)&apos;LocalSubnet&apos; indicates any local address on the local subnet.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of &apos;start address - end address&apos; with no spaces included.An IPv6 address range in the format of &apos;start address - end address&apos; with no spaces included.</summary>
        public List<string> RemoteAddressRanges {
            get { return BackingStore?.Get<List<string>>(nameof(RemoteAddressRanges)); }
            set { BackingStore?.Set(nameof(RemoteAddressRanges), value); }
        }
        /// <summary>List of remote port ranges. For example, &apos;100-120&apos;, &apos;200&apos;, &apos;300-320&apos;. If not specified, the default is All.</summary>
        public List<string> RemotePortRanges {
            get { return BackingStore?.Get<List<string>>(nameof(RemotePortRanges)); }
            set { BackingStore?.Set(nameof(RemotePortRanges), value); }
        }
        /// <summary>The name used in cases when a service, not an application, is sending or receiving traffic.</summary>
        public string ServiceName {
            get { return BackingStore?.Get<string>(nameof(ServiceName)); }
            set { BackingStore?.Set(nameof(ServiceName), value); }
        }
        /// <summary>The traffic direction that the rule is enabled for. If not specified, the default is Out. Possible values are: notConfigured, out, in.</summary>
        public WindowsFirewallRuleTrafficDirectionType? TrafficDirection {
            get { return BackingStore?.Get<WindowsFirewallRuleTrafficDirectionType?>(nameof(TrafficDirection)); }
            set { BackingStore?.Set(nameof(TrafficDirection), value); }
        }
        /// <summary>
        /// Instantiates a new windowsFirewallRule and sets the default values.
        /// </summary>
        public WindowsFirewallRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsFirewallRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsFirewallRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<StateManagementSetting>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"edgeTraversal", n => { EdgeTraversal = n.GetEnumValue<StateManagementSetting>(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"interfaceTypes", n => { InterfaceTypes = n.GetEnumValue<WindowsFirewallRuleInterfaceTypes>(); } },
                {"localAddressRanges", n => { LocalAddressRanges = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"localPortRanges", n => { LocalPortRanges = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"localUserAuthorizations", n => { LocalUserAuthorizations = n.GetStringValue(); } },
                {"packageFamilyName", n => { PackageFamilyName = n.GetStringValue(); } },
                {"profileTypes", n => { ProfileTypes = n.GetEnumValue<WindowsFirewallRuleNetworkProfileTypes>(); } },
                {"protocol", n => { Protocol = n.GetIntValue(); } },
                {"remoteAddressRanges", n => { RemoteAddressRanges = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"remotePortRanges", n => { RemotePortRanges = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"trafficDirection", n => { TrafficDirection = n.GetEnumValue<WindowsFirewallRuleTrafficDirectionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<StateManagementSetting>("action", Action);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<StateManagementSetting>("edgeTraversal", EdgeTraversal);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteEnumValue<WindowsFirewallRuleInterfaceTypes>("interfaceTypes", InterfaceTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("localAddressRanges", LocalAddressRanges);
            writer.WriteCollectionOfPrimitiveValues<string>("localPortRanges", LocalPortRanges);
            writer.WriteStringValue("localUserAuthorizations", LocalUserAuthorizations);
            writer.WriteStringValue("packageFamilyName", PackageFamilyName);
            writer.WriteEnumValue<WindowsFirewallRuleNetworkProfileTypes>("profileTypes", ProfileTypes);
            writer.WriteIntValue("protocol", Protocol);
            writer.WriteCollectionOfPrimitiveValues<string>("remoteAddressRanges", RemoteAddressRanges);
            writer.WriteCollectionOfPrimitiveValues<string>("remotePortRanges", RemotePortRanges);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteEnumValue<WindowsFirewallRuleTrafficDirectionType>("trafficDirection", TrafficDirection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows81VpnConfiguration : WindowsVpnConfiguration, IParsable {
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 {
            get { return BackingStore?.Get<bool?>(nameof(ApplyOnlyToWindows81)); }
            set { BackingStore?.Set(nameof(ApplyOnlyToWindows81), value); }
        }
        /// <summary>Connection type. Possible values are: pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn.</summary>
        public WindowsVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<WindowsVpnConnectionType?>(nameof(ConnectionType)); }
            set { BackingStore?.Set(nameof(ConnectionType), value); }
        }
        /// <summary>Enable split tunneling for the VPN.</summary>
        public bool? EnableSplitTunneling {
            get { return BackingStore?.Get<bool?>(nameof(EnableSplitTunneling)); }
            set { BackingStore?.Set(nameof(EnableSplitTunneling), value); }
        }
        /// <summary>Login group or domain when connection type is set to Dell SonicWALL Mobile Connection.</summary>
        public string LoginGroupOrDomain {
            get { return BackingStore?.Get<string>(nameof(LoginGroupOrDomain)); }
            set { BackingStore?.Set(nameof(LoginGroupOrDomain), value); }
        }
        /// <summary>Proxy Server.</summary>
        public Windows81VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<Windows81VpnProxyServer>(nameof(ProxyServer)); }
            set { BackingStore?.Set(nameof(ProxyServer), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows81VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsPhone81VpnConfiguration" => new WindowsPhone81VpnConfiguration(),
                _ => new Windows81VpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<WindowsVpnConnectionType>(); } },
                {"enableSplitTunneling", n => { EnableSplitTunneling = n.GetBoolValue(); } },
                {"loginGroupOrDomain", n => { LoginGroupOrDomain = n.GetStringValue(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<Windows81VpnProxyServer>(Windows81VpnProxyServer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applyOnlyToWindows81", ApplyOnlyToWindows81);
            writer.WriteEnumValue<WindowsVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteBoolValue("enableSplitTunneling", EnableSplitTunneling);
            writer.WriteStringValue("loginGroupOrDomain", LoginGroupOrDomain);
            writer.WriteObjectValue<Windows81VpnProxyServer>("proxyServer", ProxyServer);
        }
    }
}

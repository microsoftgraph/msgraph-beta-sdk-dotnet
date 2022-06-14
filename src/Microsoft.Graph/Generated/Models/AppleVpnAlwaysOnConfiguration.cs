using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Always On VPN configuration for MacOS and iOS IKEv2</summary>
    public class AppleVpnAlwaysOnConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Determine whether AirPrint service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? AirPrintExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>(nameof(AirPrintExceptionAction)); }
            set { BackingStore?.Set(nameof(AirPrintExceptionAction), value); }
        }
        /// <summary>Specifies whether traffic from all captive network plugins should be allowed outside the vpn</summary>
        public bool? AllowAllCaptiveNetworkPlugins {
            get { return BackingStore?.Get<bool?>(nameof(AllowAllCaptiveNetworkPlugins)); }
            set { BackingStore?.Set(nameof(AllowAllCaptiveNetworkPlugins), value); }
        }
        /// <summary>Determines whether traffic from the Websheet app is allowed outside of the VPN</summary>
        public bool? AllowCaptiveWebSheet {
            get { return BackingStore?.Get<bool?>(nameof(AllowCaptiveWebSheet)); }
            set { BackingStore?.Set(nameof(AllowCaptiveWebSheet), value); }
        }
        /// <summary>Determines whether all, some, or no non-native captive networking apps are allowed</summary>
        public SpecifiedCaptiveNetworkPlugins AllowedCaptiveNetworkPlugins {
            get { return BackingStore?.Get<SpecifiedCaptiveNetworkPlugins>(nameof(AllowedCaptiveNetworkPlugins)); }
            set { BackingStore?.Set(nameof(AllowedCaptiveNetworkPlugins), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determine whether Cellular service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? CellularExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>(nameof(CellularExceptionAction)); }
            set { BackingStore?.Set(nameof(CellularExceptionAction), value); }
        }
        /// <summary>Specifies how often in seconds to send a network address translation keepalive package through the VPN</summary>
        public int? NatKeepAliveIntervalInSeconds {
            get { return BackingStore?.Get<int?>(nameof(NatKeepAliveIntervalInSeconds)); }
            set { BackingStore?.Set(nameof(NatKeepAliveIntervalInSeconds), value); }
        }
        /// <summary>Enable hardware offloading of NAT keepalive signals when the device is asleep</summary>
        public bool? NatKeepAliveOffloadEnable {
            get { return BackingStore?.Get<bool?>(nameof(NatKeepAliveOffloadEnable)); }
            set { BackingStore?.Set(nameof(NatKeepAliveOffloadEnable), value); }
        }
        /// <summary>Determines what connections the specific tunnel configuration applies to. Possible values are: wifiAndCellular, cellular, wifi.</summary>
        public VpnTunnelConfigurationType? TunnelConfiguration {
            get { return BackingStore?.Get<VpnTunnelConfigurationType?>(nameof(TunnelConfiguration)); }
            set { BackingStore?.Set(nameof(TunnelConfiguration), value); }
        }
        /// <summary>Allow the user to toggle the VPN configuration using the UI</summary>
        public bool? UserToggleEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UserToggleEnabled)); }
            set { BackingStore?.Set(nameof(UserToggleEnabled), value); }
        }
        /// <summary>Determine whether voicemail service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? VoicemailExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>(nameof(VoicemailExceptionAction)); }
            set { BackingStore?.Set(nameof(VoicemailExceptionAction), value); }
        }
        /// <summary>
        /// Instantiates a new appleVpnAlwaysOnConfiguration and sets the default values.
        /// </summary>
        public AppleVpnAlwaysOnConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppleVpnAlwaysOnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppleVpnAlwaysOnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"airPrintExceptionAction", n => { AirPrintExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
                {"allowAllCaptiveNetworkPlugins", n => { AllowAllCaptiveNetworkPlugins = n.GetBoolValue(); } },
                {"allowCaptiveWebSheet", n => { AllowCaptiveWebSheet = n.GetBoolValue(); } },
                {"allowedCaptiveNetworkPlugins", n => { AllowedCaptiveNetworkPlugins = n.GetObjectValue<SpecifiedCaptiveNetworkPlugins>(SpecifiedCaptiveNetworkPlugins.CreateFromDiscriminatorValue); } },
                {"cellularExceptionAction", n => { CellularExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
                {"natKeepAliveIntervalInSeconds", n => { NatKeepAliveIntervalInSeconds = n.GetIntValue(); } },
                {"natKeepAliveOffloadEnable", n => { NatKeepAliveOffloadEnable = n.GetBoolValue(); } },
                {"tunnelConfiguration", n => { TunnelConfiguration = n.GetEnumValue<VpnTunnelConfigurationType>(); } },
                {"userToggleEnabled", n => { UserToggleEnabled = n.GetBoolValue(); } },
                {"voicemailExceptionAction", n => { VoicemailExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VpnServiceExceptionAction>("airPrintExceptionAction", AirPrintExceptionAction);
            writer.WriteBoolValue("allowAllCaptiveNetworkPlugins", AllowAllCaptiveNetworkPlugins);
            writer.WriteBoolValue("allowCaptiveWebSheet", AllowCaptiveWebSheet);
            writer.WriteObjectValue<SpecifiedCaptiveNetworkPlugins>("allowedCaptiveNetworkPlugins", AllowedCaptiveNetworkPlugins);
            writer.WriteEnumValue<VpnServiceExceptionAction>("cellularExceptionAction", CellularExceptionAction);
            writer.WriteIntValue("natKeepAliveIntervalInSeconds", NatKeepAliveIntervalInSeconds);
            writer.WriteBoolValue("natKeepAliveOffloadEnable", NatKeepAliveOffloadEnable);
            writer.WriteEnumValue<VpnTunnelConfigurationType>("tunnelConfiguration", TunnelConfiguration);
            writer.WriteBoolValue("userToggleEnabled", UserToggleEnabled);
            writer.WriteEnumValue<VpnServiceExceptionAction>("voicemailExceptionAction", VoicemailExceptionAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

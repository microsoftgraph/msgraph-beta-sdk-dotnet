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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Determine whether AirPrint service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? AirPrintExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>("airPrintExceptionAction"); }
            set { BackingStore?.Set("airPrintExceptionAction", value); }
        }
        /// <summary>Specifies whether traffic from all captive network plugins should be allowed outside the vpn</summary>
        public bool? AllowAllCaptiveNetworkPlugins {
            get { return BackingStore?.Get<bool?>("allowAllCaptiveNetworkPlugins"); }
            set { BackingStore?.Set("allowAllCaptiveNetworkPlugins", value); }
        }
        /// <summary>Determines whether traffic from the Websheet app is allowed outside of the VPN</summary>
        public bool? AllowCaptiveWebSheet {
            get { return BackingStore?.Get<bool?>("allowCaptiveWebSheet"); }
            set { BackingStore?.Set("allowCaptiveWebSheet", value); }
        }
        /// <summary>Determines whether all, some, or no non-native captive networking apps are allowed</summary>
        public SpecifiedCaptiveNetworkPlugins AllowedCaptiveNetworkPlugins {
            get { return BackingStore?.Get<SpecifiedCaptiveNetworkPlugins>("allowedCaptiveNetworkPlugins"); }
            set { BackingStore?.Set("allowedCaptiveNetworkPlugins", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determine whether Cellular service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? CellularExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>("cellularExceptionAction"); }
            set { BackingStore?.Set("cellularExceptionAction", value); }
        }
        /// <summary>Specifies how often in seconds to send a network address translation keepalive package through the VPN</summary>
        public int? NatKeepAliveIntervalInSeconds {
            get { return BackingStore?.Get<int?>("natKeepAliveIntervalInSeconds"); }
            set { BackingStore?.Set("natKeepAliveIntervalInSeconds", value); }
        }
        /// <summary>Enable hardware offloading of NAT keepalive signals when the device is asleep</summary>
        public bool? NatKeepAliveOffloadEnable {
            get { return BackingStore?.Get<bool?>("natKeepAliveOffloadEnable"); }
            set { BackingStore?.Set("natKeepAliveOffloadEnable", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The type of tunnels that will be present to the VPN client for configuration</summary>
        public VpnTunnelConfigurationType? TunnelConfiguration {
            get { return BackingStore?.Get<VpnTunnelConfigurationType?>("tunnelConfiguration"); }
            set { BackingStore?.Set("tunnelConfiguration", value); }
        }
        /// <summary>Allow the user to toggle the VPN configuration using the UI</summary>
        public bool? UserToggleEnabled {
            get { return BackingStore?.Get<bool?>("userToggleEnabled"); }
            set { BackingStore?.Set("userToggleEnabled", value); }
        }
        /// <summary>Determine whether voicemail service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? VoicemailExceptionAction {
            get { return BackingStore?.Get<VpnServiceExceptionAction?>("voicemailExceptionAction"); }
            set { BackingStore?.Set("voicemailExceptionAction", value); }
        }
        /// <summary>
        /// Instantiates a new appleVpnAlwaysOnConfiguration and sets the default values.
        /// </summary>
        public AppleVpnAlwaysOnConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.appleVpnAlwaysOnConfiguration";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<VpnTunnelConfigurationType>("tunnelConfiguration", TunnelConfiguration);
            writer.WriteBoolValue("userToggleEnabled", UserToggleEnabled);
            writer.WriteEnumValue<VpnServiceExceptionAction>("voicemailExceptionAction", VoicemailExceptionAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

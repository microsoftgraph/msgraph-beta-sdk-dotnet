// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The possible security types for Android Wi-Fi profiles. Default value &apos;Open&apos;, indicates no authentication required for the network. The security protocols supported are WEP, WPA and WPA2. &apos;WpaEnterprise&apos; and &apos;Wpa2Enterprise&apos; options are available for Enterprise Wi-Fi profiles. &apos;Wep&apos; and &apos;WpaPersonal&apos; (supports WPA and WPA2) options are available for Basic Wi-Fi profiles.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AndroidWiFiSecurityType
    {
        /// <summary>Default. Indicates Android Wifi Security Type is set to &quot;Open&quot; i.e. no authentication is required. (No Authentication).</summary>
        [EnumMember(Value = "open")]
        Open,
        /// <summary>Indicates Android Wifi Security Type is set to WPA encryption. Must use AndroidWorkProfileEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpaEnterprise")]
        WpaEnterprise,
        /// <summary>Indicates Android Wifi Security Type is set to WPA2 encryption. Must use AndroidWorkProfileEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpa2Enterprise")]
        Wpa2Enterprise,
        /// <summary>Indicates Android Wifi Security Type is set to WEP encryption. This restricts the preSharedKey to a valid passphrase (5 or 13 characters) or a valid HEX key (10 or 26 hexidecimal characters). Use AndroidWorkProfileWifiConfiguration to configure basic Wi-Fi options.</summary>
        [EnumMember(Value = "wep")]
        Wep,
        /// <summary> Indicates Android Wifi Security Type is set to WPA encryption. This restricts the preSharedKey to a string between 8 and 64 characters long. Use AndroidWorkProfileWifiConfiguration to configure basic Wi-Fi options.</summary>
        [EnumMember(Value = "wpaPersonal")]
        WpaPersonal,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}

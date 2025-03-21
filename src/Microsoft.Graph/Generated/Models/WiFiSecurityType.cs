// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Wi-Fi Security Types.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WiFiSecurityType
    {
        /// <summary>Open (No Authentication).</summary>
        [EnumMember(Value = "open")]
        Open,
        /// <summary>WPA-Personal.</summary>
        [EnumMember(Value = "wpaPersonal")]
        WpaPersonal,
        /// <summary>WPA-Enterprise. Must use IOSEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpaEnterprise")]
        WpaEnterprise,
        /// <summary>WEP Encryption.</summary>
        [EnumMember(Value = "wep")]
        Wep,
        /// <summary>WPA2-Personal.</summary>
        [EnumMember(Value = "wpa2Personal")]
        Wpa2Personal,
        /// <summary>WPA2-Enterprise. Must use WindowsWifiEnterpriseEAPConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpa2Enterprise")]
        Wpa2Enterprise,
    }
}

namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum WiFiSecurityType {
        /// <summary>Open (No Authentication).</summary>
        Open,
        /// <summary>WPA-Personal.</summary>
        WpaPersonal,
        /// <summary>WPA-Enterprise. Must use IOSEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        WpaEnterprise,
        /// <summary>WEP Encryption.</summary>
        Wep,
        /// <summary>WPA2-Personal.</summary>
        Wpa2Personal,
        /// <summary>WPA2-Enterprise. Must use WindowsWifiEnterpriseEAPConfiguration type to configure enterprise options.</summary>
        Wpa2Enterprise,
    }
}

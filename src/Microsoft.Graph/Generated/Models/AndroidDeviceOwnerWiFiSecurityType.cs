namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AndroidDeviceOwnerWiFiSecurityType {
        /// <summary>Open (No Authentication).</summary>
        Open,
        /// <summary>WEP Encryption.</summary>
        Wep,
        /// <summary>WPA-Personal/WPA2-Personal.</summary>
        WpaPersonal,
        /// <summary>WPA-Enterprise/WPA2-Enterprise. Must use AndroidDeviceOwnerEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        WpaEnterprise,
    }
}

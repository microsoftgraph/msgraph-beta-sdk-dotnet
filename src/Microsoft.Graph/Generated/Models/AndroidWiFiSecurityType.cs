namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidWiFiSecurityType {
        /// <summary>Open (No Authentication).</summary>
        Open,
        /// <summary>WPA-Enterprise. Must use AndroidEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        WpaEnterprise,
        /// <summary>WPA2-Enterprise. Must use AndroidEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        Wpa2Enterprise,
    }
}

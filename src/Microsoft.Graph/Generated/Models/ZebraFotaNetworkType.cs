namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum ZebraFotaNetworkType {
        /// <summary>The device will install the update regardless of current network type.</summary>
        Any,
        /// <summary>The device will install the update only when connected to WiFi network.</summary>
        Wifi,
        /// <summary>The device will install the update only when connected a Cellular network.</summary>
        Cellular,
        /// <summary>The device will install the update when connected both WiFi and Cellular.</summary>
        WifiAndCellular,
        /// <summary>Unknown future enum value.</summary>
        UnknownFutureValue,
    }
}

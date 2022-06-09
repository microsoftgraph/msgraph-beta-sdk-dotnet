namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WiFiProxySetting {
        /// <summary>No Proxy.</summary>
        None,
        /// <summary>Manual Proxy Settings via Address and Port.</summary>
        Manual,
        /// <summary>Automatic Proxy Settings via URL.</summary>
        Automatic,
    }
}

namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner possible values for states of the device&apos;s plugged-in power modes.</summary>
    public enum AndroidDeviceOwnerBatteryPluggedMode {
        /// <summary>Not configured; this value is ignored.</summary>
        NotConfigured,
        /// <summary>Power source is an AC charger.</summary>
        Ac,
        /// <summary>Power source is a USB port.</summary>
        Usb,
        /// <summary>Power source is wireless.</summary>
        Wireless,
    }
}

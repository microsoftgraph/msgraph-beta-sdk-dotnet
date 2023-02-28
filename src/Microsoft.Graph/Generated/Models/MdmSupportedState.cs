namespace Microsoft.Graph.Beta.Models {
    /// <summary>Mdm Support Status of the setting.</summary>
    public enum MdmSupportedState {
        /// <summary>Mdm support status of the setting is not known.</summary>
        Unknown,
        /// <summary>Setting is supported.</summary>
        Supported,
        /// <summary>Setting is unsupported.</summary>
        Unsupported,
        /// <summary>Setting is depcrecated.</summary>
        Deprecated,
    }
}

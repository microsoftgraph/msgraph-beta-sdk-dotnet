namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates device event level. Possible values are: None, Verbose, Information, Warning, Error, Critical</summary>
    public enum DeviceEventLevel {
        /// <summary>Indicates that the device event level is none.</summary>
        None,
        /// <summary>Indicates that the device event level is verbose.</summary>
        Verbose,
        /// <summary>Indicates that the device event level is information.</summary>
        Information,
        /// <summary>Indicates that the device event level is warning.</summary>
        Warning,
        /// <summary>Indicates that the device event level is error.</summary>
        Error,
        /// <summary>Indicates that the device event level is critical.</summary>
        Critical,
        /// <summary>Placeholder value for future expansion.</summary>
        UnknownFutureValue,
    }
}

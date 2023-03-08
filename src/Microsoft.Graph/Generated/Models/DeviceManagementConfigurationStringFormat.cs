namespace Microsoft.Graph.Beta.Models {
    public enum DeviceManagementConfigurationStringFormat {
        /// <summary>Indicates a string with no well-defined format expected.</summary>
        None,
        /// <summary>Indicates a string that is expected to be a valid email address.</summary>
        Email,
        /// <summary>Indicates a string that is expected to be a valid GUID.</summary>
        Guid,
        /// <summary>Indicates a string that is expected to be a valid IP address.</summary>
        Ip,
        /// <summary>Indicates a string that is base64 encoded.</summary>
        Base64,
        /// <summary>Indicates a string that is expected to be a valid URL.</summary>
        Url,
        /// <summary>Indicates a string that should refer to a version.</summary>
        Version,
        /// <summary>Indicates a string that is expected to be a valid XML.</summary>
        Xml,
        /// <summary>Indicates a string that is expected to be a valid date.</summary>
        Date,
        /// <summary>Indicates a string that is expected to be a valid time.</summary>
        Time,
        Binary,
        /// <summary>Indicates a string that is expected to be a valid Regex string.</summary>
        RegEx,
        /// <summary>Indicates a string that is expected to be a valid JSON string.</summary>
        Json,
        /// <summary>Indicates a string that is expected to be a valid Datetime.</summary>
        DateTime,
        /// <summary>Indicates a Windows SKU applicability value that maps to Intune.</summary>
        SurfaceHub,
        /// <summary>String whose value is a bash script</summary>
        BashScript,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
    }
}

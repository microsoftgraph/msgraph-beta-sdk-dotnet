namespace Microsoft.Graph.Beta.Models {
    /// <summary>This enum indicates the platform type for which the enrollment restriction applies.</summary>
    public enum EnrollmentRestrictionPlatformType {
        /// <summary>Indicates that the enrollment configuration applies to all platforms</summary>
        AllPlatforms,
        /// <summary>Indicates that the enrollment configuration applies only to iOS/iPadOS devices</summary>
        Ios,
        /// <summary>Indicates that the enrollment configuration applies only to Windows devices</summary>
        Windows,
        /// <summary>Indicates that the enrollment configuration applies only to Windows Phone devices</summary>
        WindowsPhone,
        /// <summary>Indicates that the enrollment configuration applies only to Android devices</summary>
        Android,
        /// <summary>Indicates that the enrollment configuration applies only to Android for Work devices</summary>
        AndroidForWork,
        /// <summary>Indicates that the enrollment configuration applies only to macOS devices</summary>
        Mac,
        /// <summary>Indicates that the enrollment configuration applies only to Linux devices</summary>
        Linux,
        /// <summary>Evolvable enumeration sentinel value. Do not use</summary>
        UnknownFutureValue,
    }
}

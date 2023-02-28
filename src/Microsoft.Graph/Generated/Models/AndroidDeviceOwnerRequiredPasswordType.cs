namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner policy required password type.</summary>
    public enum AndroidDeviceOwnerRequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>There must be a password set, but there are no restrictions on type.</summary>
        Required,
        /// <summary>At least numeric.</summary>
        Numeric,
        /// <summary>At least numeric with no repeating or ordered sequences.</summary>
        NumericComplex,
        /// <summary>At least alphabetic password.</summary>
        Alphabetic,
        /// <summary>At least alphanumeric password</summary>
        Alphanumeric,
        /// <summary>At least alphanumeric with symbols.</summary>
        AlphanumericWithSymbols,
        /// <summary>Low security biometrics based password required.</summary>
        LowSecurityBiometric,
        /// <summary>Custom password set by the admin.</summary>
        CustomPassword,
    }
}

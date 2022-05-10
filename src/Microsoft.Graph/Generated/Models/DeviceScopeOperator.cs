namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceScopeOperator {
        /// <summary>No operator set for the device scope configuration.</summary>
        None,
        /// <summary>Operator for the device configuration query to be used (Equals).</summary>
        Equals,
        /// <summary>Placeholder value for future expansion enums such as notEquals, contains, notContains, greaterThan, lessThan.</summary>
        UnknownFutureValue,
    }
}

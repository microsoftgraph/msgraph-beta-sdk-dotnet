namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AndroidRequiredPasswordComplexity {
        /// <summary>Device default value, no password.</summary>
        None,
        /// <summary>The required password complexity on the device is of type low as defined by the Android documentation.</summary>
        Low,
        /// <summary>The required password complexity on the device is of type medium as defined by the Android documentation.</summary>
        Medium,
        /// <summary>The required password complexity on the device is of type high as defined by the Android documentation.</summary>
        High,
    }
}

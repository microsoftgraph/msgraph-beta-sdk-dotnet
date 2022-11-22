namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum BrowserSiteTargetEnvironment {
        /// <summary>Open in Internet Explorer Mode</summary>
        InternetExplorerMode,
        /// <summary>Open in standalone Internet Explorer 11</summary>
        InternetExplorer11,
        /// <summary>Open in Microsoft Edge</summary>
        MicrosoftEdge,
        /// <summary>Configurable type</summary>
        Configurable,
        /// <summary>Open in the browser the employee chooses.</summary>
        None,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}

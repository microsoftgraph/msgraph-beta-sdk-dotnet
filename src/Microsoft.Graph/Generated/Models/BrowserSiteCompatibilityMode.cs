namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum BrowserSiteCompatibilityMode {
        /// <summary>Loads the site using default compatibility mode.</summary>
        Default,
        /// <summary>Loads the site in internetExplorer8 Enterprise Mode</summary>
        InternetExplorer8Enterprise,
        /// <summary>Loads the site in internetExplorer7 Enterprise Mode</summary>
        InternetExplorer7Enterprise,
        /// <summary>Loads the site in internetExplorer11</summary>
        InternetExplorer11,
        /// <summary>Loads the site in internetExplorer10</summary>
        InternetExplorer10,
        /// <summary>Loads the site in internetExplorer9</summary>
        InternetExplorer9,
        /// <summary>Loads the site in internetExplorer8</summary>
        InternetExplorer8,
        /// <summary>Loads the site in internetExplorer7</summary>
        InternetExplorer7,
        /// <summary>Loads the site in internetExplorer5</summary>
        InternetExplorer5,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}

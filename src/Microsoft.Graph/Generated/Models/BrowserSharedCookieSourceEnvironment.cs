namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum BrowserSharedCookieSourceEnvironment {
        /// <summary>Share session cookies from Microsoft Edge to Internet Explorer.</summary>
        MicrosoftEdge,
        /// <summary>Share session cookies from Internet Explorer to Microsoft Edge.</summary>
        InternetExplorer11,
        /// <summary>Share session cookies to and from Microsoft Edge and Internet Explorer.</summary>
        Both,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}

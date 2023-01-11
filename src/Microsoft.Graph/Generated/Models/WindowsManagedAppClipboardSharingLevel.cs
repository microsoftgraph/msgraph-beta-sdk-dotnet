namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the level to which the device&apos;s clipboard may be shared between apps</summary>
    public enum WindowsManagedAppClipboardSharingLevel {
        /// <summary>Org users can paste data from and cut/copy data to any account, document, location or application.</summary>
        AnyDestinationAnySource,
        /// <summary>Org users cannot cut, copy or paste data to or from external accounts, documents, locations or applications from or into the org context.</summary>
        None,
    }
}

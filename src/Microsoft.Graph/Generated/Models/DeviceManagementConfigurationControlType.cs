namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementConfigurationControlType {
        /// <summary>Don’t override default</summary>
        Default,
        /// <summary>Display Choice in dropdown</summary>
        Dropdown,
        /// <summary>Display text input in small text input</summary>
        SmallTextBox,
        /// <summary>Display text input in large text input</summary>
        LargeTextBox,
        /// <summary>Allow for toggle control type</summary>
        Toggle,
        /// <summary>Allow for multiheader grid control type</summary>
        MultiheaderGrid,
        /// <summary>Allow for context pane control type</summary>
        ContextPane,
    }
}

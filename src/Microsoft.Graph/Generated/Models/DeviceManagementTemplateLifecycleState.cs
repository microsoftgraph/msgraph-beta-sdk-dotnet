namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes current lifecycle state of a template</summary>
    public enum DeviceManagementTemplateLifecycleState {
        /// <summary>Invalid</summary>
        Invalid,
        /// <summary>Draft</summary>
        Draft,
        /// <summary>Active</summary>
        Active,
        /// <summary>Superseded</summary>
        Superseded,
        /// <summary>Deprecated</summary>
        Deprecated,
        /// <summary>Retired</summary>
        Retired,
    }
}

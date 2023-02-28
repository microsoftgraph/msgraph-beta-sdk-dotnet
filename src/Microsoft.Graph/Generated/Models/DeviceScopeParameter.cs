namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device scope configuration parameter. It will be expend in future to add more parameter. Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag. Default value: scopeTag.</summary>
    public enum DeviceScopeParameter {
        /// <summary>Device Scope parameter is not set</summary>
        None,
        /// <summary>use Scope Tag as parameter for the device scope configuration.</summary>
        ScopeTag,
        /// <summary>Placeholder value for future expansion.</summary>
        UnknownFutureValue,
    }
}

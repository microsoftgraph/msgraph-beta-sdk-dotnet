namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementTemplateType {
        /// <summary>Security baseline template</summary>
        SecurityBaseline,
        /// <summary>Specialized devices template</summary>
        SpecializedDevices,
        /// <summary>Advanced Threat Protection security baseline template</summary>
        AdvancedThreatProtectionSecurityBaseline,
        /// <summary>Device configuration template</summary>
        DeviceConfiguration,
        /// <summary>Custom admin defined template</summary>
        Custom,
        /// <summary>Templates containing specific security focused settings</summary>
        SecurityTemplate,
        /// <summary>Microsoft Edge security baseline template</summary>
        MicrosoftEdgeSecurityBaseline,
        /// <summary>Microsoft Office 365 ProPlus security baseline template</summary>
        MicrosoftOffice365ProPlusSecurityBaseline,
        /// <summary>Device compliance template</summary>
        DeviceCompliance,
        /// <summary>Device Configuration for Microsoft Office 365 settings</summary>
        DeviceConfigurationForOffice365,
        /// <summary>Windows 365 security baseline template</summary>
        CloudPC,
        /// <summary>Firewall Shared Object templates for reference settings</summary>
        FirewallSharedSettings,
    }
}

namespace Microsoft.Graph.Beta.Models {
    /// <summary>Action type on Configuration Manager client</summary>
    public enum ConfigurationManagerActionType {
        /// <summary>Refresh machine policy on Configuration Manager client</summary>
        RefreshMachinePolicy,
        /// <summary>Refresh user policy on Configuration Manager client</summary>
        RefreshUserPolicy,
        /// <summary>Wake up Configuration Manager client</summary>
        WakeUpClient,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        AppEvaluation,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        QuickScan,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        FullScan,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        WindowsDefenderUpdateSignatures,
    }
}

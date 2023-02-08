namespace Microsoft.Graph.Beta.Models {
    /// <summary>Connectors name for connector status</summary>
    public enum ConnectorName {
        /// <summary>Indicates the expiration date/time for the Apple MDM Push Certificate.</summary>
        ApplePushNotificationServiceExpirationDateTime,
        /// <summary>Indicates the expiration date/time for Vpp Token.</summary>
        VppTokenExpirationDateTime,
        /// <summary>Indicate the last sync data/time that the Vpp Token performed a sync.</summary>
        VppTokenLastSyncDateTime,
        /// <summary>Indicate the last sync date/time that the Windows Autopilot performed a sync.</summary>
        WindowsAutopilotLastSyncDateTime,
        /// <summary>Indicates the last sync date/time that the Windows Store for Business performed a sync.</summary>
        WindowsStoreForBusinessLastSyncDateTime,
        /// <summary>Indicates the last sync date/time that the JAMF connector performed a sync.</summary>
        JamfLastSyncDateTime,
        /// <summary>Indicates the last sync date/time that the NDES connector performed a sync.</summary>
        NdesConnectorLastConnectionDateTime,
        /// <summary>Indicates the expiration date/time for the Apple Enrollment Program token.</summary>
        AppleDepExpirationDateTime,
        /// <summary>Indicates the last sync date/time that the Apple Enrollment Program token performed a sync.</summary>
        AppleDepLastSyncDateTime,
        /// <summary>Indicates the last sync date/time that the Exchange ActiveSync connector performed a sync.</summary>
        OnPremConnectorLastSyncDateTime,
        /// <summary>Indicates the last sync date/time that the Google Play App performed a sync.</summary>
        GooglePlayAppLastSyncDateTime,
        /// <summary>Indicates the last modified date / time that the Google Play connector was updated.</summary>
        GooglePlayConnectorLastModifiedDateTime,
        /// <summary>Indicates the last heartbeat date/time that the Windows Defender ATP connector was contacted.</summary>
        WindowsDefenderATPConnectorLastHeartbeatDateTime,
        /// <summary>Indicates the last heartbeat date/time that the Mobile Threat Defence connector was contacted.</summary>
        MobileThreatDefenceConnectorLastHeartbeatDateTime,
        /// <summary>Indicates the last sync date/time that the Chrombook Last Directory performed a sync.</summary>
        ChromebookLastDirectorySyncDateTime,
        /// <summary>Future use</summary>
        FutureValue,
    }
}

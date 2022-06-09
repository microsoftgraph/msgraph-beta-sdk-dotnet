namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum EmailSyncSchedule {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Sync as messages arrive.</summary>
        AsMessagesArrive,
        /// <summary>Sync manually.</summary>
        Manual,
        /// <summary>Sync every fifteen minutes.</summary>
        FifteenMinutes,
        /// <summary>Sync every thirty minutes.</summary>
        ThirtyMinutes,
        /// <summary>Sync every sixty minutes.</summary>
        SixtyMinutes,
        /// <summary>Sync based on my usage.</summary>
        BasedOnMyUsage,
    }
}

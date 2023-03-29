namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of elevation occured</summary>
    public enum PrivilegeManagementElevationType {
        /// <summary>Default. If the type was unknown on the client for some reasons.</summary>
        Undetermined,
        /// <summary>The elevation was done without any use of endpoint privilege management. For example: the administrator on a client machine elevated an application with their admin right.</summary>
        UnmanagedElevation,
        /// <summary>The elevation was done using the endpoint privilege management zero touch elevation policy.</summary>
        ZeroTouchElevation,
        /// <summary>The elevation was done using the endpoint privilege management user confirmed elevation policy.</summary>
        UserConfirmedElevation,
        /// <summary>The elevation was done using the endpoint privilege management support approved elevation policy.</summary>
        SupportApprovedElevation,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}

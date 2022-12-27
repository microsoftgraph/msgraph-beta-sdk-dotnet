namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum DeviceHealthStatus {
        Active,
        Inactive,
        ImpairedCommunication,
        NoSensorData,
        NoSensorDataImpairedCommunication,
        Unknown,
        UnknownFutureValue,
    }
}

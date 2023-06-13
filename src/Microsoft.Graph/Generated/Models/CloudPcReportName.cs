using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcReportName {
        [EnumMember(Value = "remoteConnectionHistoricalReports")]
        RemoteConnectionHistoricalReports,
        [EnumMember(Value = "dailyAggregatedRemoteConnectionReports")]
        DailyAggregatedRemoteConnectionReports,
        [EnumMember(Value = "totalAggregatedRemoteConnectionReports")]
        TotalAggregatedRemoteConnectionReports,
        [EnumMember(Value = "sharedUseLicenseUsageReport")]
        SharedUseLicenseUsageReport,
        [EnumMember(Value = "sharedUseLicenseUsageRealTimeReport")]
        SharedUseLicenseUsageRealTimeReport,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "noLicenseAvailableConnectivityFailureReport")]
        NoLicenseAvailableConnectivityFailureReport,
    }
}

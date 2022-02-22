using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAppHealthOSVersionPerformance : Entity, IParsable {
        /// <summary>The number of active devices for the OS version. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount { get; set; }
        /// <summary>The mean time to failure for the OS version in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>The OS build number installed on the device.</summary>
        public string OsBuildNumber { get; set; }
        /// <summary>The OS version installed on the device.</summary>
        public string OsVersion { get; set; }
        /// <summary>The app health score of the OS version. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsVersionAppHealthScore { get; set; }
        /// <summary>The overall app health status of the OS version.</summary>
        public string OsVersionAppHealthStatus { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDeviceCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).ActiveDeviceCount = n.GetIntValue(); } },
                {"meanTimeToFailureInMinutes", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"osBuildNumber", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).OsBuildNumber = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).OsVersion = n.GetStringValue(); } },
                {"osVersionAppHealthScore", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).OsVersionAppHealthScore = n.GetDoubleValue(); } },
                {"osVersionAppHealthStatus", (o,n) => { (o as UserExperienceAnalyticsAppHealthOSVersionPerformance).OsVersionAppHealthStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteDoubleValue("osVersionAppHealthScore", OsVersionAppHealthScore);
            writer.WriteStringValue("osVersionAppHealthStatus", OsVersionAppHealthStatus);
        }
    }
}

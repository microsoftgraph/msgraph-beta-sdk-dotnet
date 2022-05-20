using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device OS version performance entity contains OS version performance details.</summary>
    public class UserExperienceAnalyticsAppHealthOSVersionPerformance : Entity, IParsable {
        /// <summary>The number of active devices for the OS version. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ActiveDeviceCount)); }
            set { BackingStore?.Set(nameof(ActiveDeviceCount), value); }
        }
        /// <summary>The mean time to failure for the OS version in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>(nameof(MeanTimeToFailureInMinutes)); }
            set { BackingStore?.Set(nameof(MeanTimeToFailureInMinutes), value); }
        }
        /// <summary>The OS build number installed on the device.</summary>
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>(nameof(OsBuildNumber)); }
            set { BackingStore?.Set(nameof(OsBuildNumber), value); }
        }
        /// <summary>The OS version installed on the device.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>The app health score of the OS version. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsVersionAppHealthScore {
            get { return BackingStore?.Get<double?>(nameof(OsVersionAppHealthScore)); }
            set { BackingStore?.Set(nameof(OsVersionAppHealthScore), value); }
        }
        /// <summary>The overall app health status of the OS version.</summary>
        public string OsVersionAppHealthStatus {
            get { return BackingStore?.Get<string>(nameof(OsVersionAppHealthStatus)); }
            set { BackingStore?.Set(nameof(OsVersionAppHealthStatus), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthOSVersionPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthOSVersionPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"osVersionAppHealthScore", n => { OsVersionAppHealthScore = n.GetDoubleValue(); } },
                {"osVersionAppHealthStatus", n => { OsVersionAppHealthStatus = n.GetStringValue(); } },
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

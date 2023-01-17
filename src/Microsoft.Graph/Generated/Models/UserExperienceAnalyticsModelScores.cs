using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsModelScores : Entity, IParsable {
        /// <summary>The user experience analytics model app reliability score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppReliabilityScore {
            get { return BackingStore?.Get<double?>("appReliabilityScore"); }
            set { BackingStore?.Set("appReliabilityScore", value); }
        }
        /// <summary>The user experience analytics model battery health score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryHealthScore {
            get { return BackingStore?.Get<double?>("batteryHealthScore"); }
            set { BackingStore?.Set("batteryHealthScore", value); }
        }
        /// <summary>The user experience analytics model score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? EndpointAnalyticsScore {
            get { return BackingStore?.Get<double?>("endpointAnalyticsScore"); }
            set { BackingStore?.Set("endpointAnalyticsScore", value); }
        }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>A unique identifier of the user experience analytics model scores: device manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>A unique identifier of the user experience analytics model scores: device model.</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>The user experience analytics model device count. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ModelDeviceCount {
            get { return BackingStore?.Get<long?>("modelDeviceCount"); }
            set { BackingStore?.Set("modelDeviceCount", value); }
        }
        /// <summary>The user experience analytics model startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore {
            get { return BackingStore?.Get<double?>("startupPerformanceScore"); }
            set { BackingStore?.Set("startupPerformanceScore", value); }
        }
        /// <summary>The user experience analytics model work from anywhere score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore {
            get { return BackingStore?.Get<double?>("workFromAnywhereScore"); }
            set { BackingStore?.Set("workFromAnywhereScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsModelScores CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsModelScores();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appReliabilityScore", n => { AppReliabilityScore = n.GetDoubleValue(); } },
                {"batteryHealthScore", n => { BatteryHealthScore = n.GetDoubleValue(); } },
                {"endpointAnalyticsScore", n => { EndpointAnalyticsScore = n.GetDoubleValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"modelDeviceCount", n => { ModelDeviceCount = n.GetLongValue(); } },
                {"startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", n => { WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("appReliabilityScore", AppReliabilityScore);
            writer.WriteDoubleValue("batteryHealthScore", BatteryHealthScore);
            writer.WriteDoubleValue("endpointAnalyticsScore", EndpointAnalyticsScore);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteLongValue("modelDeviceCount", ModelDeviceCount);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}

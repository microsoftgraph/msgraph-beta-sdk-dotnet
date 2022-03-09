using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsModelScores : Entity, IParsable {
        /// <summary>The user experience analytics model app reliability score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppReliabilityScore { get; set; }
        /// <summary>The user experience analytics model score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? EndpointAnalyticsScore { get; set; }
        /// <summary>The health state of the user experience analytics model. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>A unique identifier of the user experience analytics model scores: device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>A unique identifier of the user experience analytics model scores: device model.</summary>
        public string Model { get; set; }
        /// <summary>The user experience analytics model device count. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ModelDeviceCount { get; set; }
        /// <summary>The user experience analytics model startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>The user experience analytics model work from anywhere score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsModelScores CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsModelScores();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appReliabilityScore", (o,n) => { (o as UserExperienceAnalyticsModelScores).AppReliabilityScore = n.GetDoubleValue(); } },
                {"endpointAnalyticsScore", (o,n) => { (o as UserExperienceAnalyticsModelScores).EndpointAnalyticsScore = n.GetDoubleValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsModelScores).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsModelScores).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsModelScores).Model = n.GetStringValue(); } },
                {"modelDeviceCount", (o,n) => { (o as UserExperienceAnalyticsModelScores).ModelDeviceCount = n.GetLongValue(); } },
                {"startupPerformanceScore", (o,n) => { (o as UserExperienceAnalyticsModelScores).StartupPerformanceScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", (o,n) => { (o as UserExperienceAnalyticsModelScores).WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("appReliabilityScore", AppReliabilityScore);
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

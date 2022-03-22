using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAppHealthDevicePerformanceDetails : Entity, IParsable {
        /// <summary>The friendly name of the application for which the event occurred.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher { get; set; }
        /// <summary>The version of the application.</summary>
        public string AppVersion { get; set; }
        /// <summary>The name of the device.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The id of the device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The time the event occurred.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The type of the event.</summary>
        public string EventType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthDevicePerformanceDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthDevicePerformanceDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).AppDisplayName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).AppPublisher = n.GetStringValue(); } },
                {"appVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).AppVersion = n.GetStringValue(); } },
                {"deviceDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).DeviceId = n.GetStringValue(); } },
                {"eventDateTime", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventType", (o,n) => { (o as UserExperienceAnalyticsAppHealthDevicePerformanceDetails).EventType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventType", EventType);
        }
    }
}

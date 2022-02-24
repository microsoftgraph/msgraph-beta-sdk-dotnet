using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory : Entity, IParsable {
        /// <summary>The unique identifier of the device, Intune DeviceID or SCCM device id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? EstimatedRuntimeInMinutes { get; set; }
        /// <summary>The datetime for the instance of runtime history.</summary>
        public string RuntimeDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory).DeviceId = n.GetStringValue(); } },
                {"estimatedRuntimeInMinutes", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory).EstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"runtimeDateTime", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory).RuntimeDateTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("estimatedRuntimeInMinutes", EstimatedRuntimeInMinutes);
            writer.WriteStringValue("runtimeDateTime", RuntimeDateTime);
        }
    }
}

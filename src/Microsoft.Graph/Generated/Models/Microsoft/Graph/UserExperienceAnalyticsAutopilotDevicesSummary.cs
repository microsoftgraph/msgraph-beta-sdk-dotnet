using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAutopilotDevicesSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd.</summary>
        public int? DevicesNotAutopilotRegistered { get; set; }
        /// <summary>The count of intune devices not autopilot profile assigned.</summary>
        public int? DevicesWithoutAutopilotProfileAssigned { get; set; }
        /// <summary>The count of windows 10 devices that are Intune and Comanaged.</summary>
        public int? TotalWindows10DevicesWithoutTenantAttached { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsAutopilotDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAutopilotDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"devicesNotAutopilotRegistered", (o,n) => { (o as UserExperienceAnalyticsAutopilotDevicesSummary).DevicesNotAutopilotRegistered = n.GetIntValue(); } },
                {"devicesWithoutAutopilotProfileAssigned", (o,n) => { (o as UserExperienceAnalyticsAutopilotDevicesSummary).DevicesWithoutAutopilotProfileAssigned = n.GetIntValue(); } },
                {"totalWindows10DevicesWithoutTenantAttached", (o,n) => { (o as UserExperienceAnalyticsAutopilotDevicesSummary).TotalWindows10DevicesWithoutTenantAttached = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("devicesNotAutopilotRegistered", DevicesNotAutopilotRegistered);
            writer.WriteIntValue("devicesWithoutAutopilotProfileAssigned", DevicesWithoutAutopilotProfileAssigned);
            writer.WriteIntValue("totalWindows10DevicesWithoutTenantAttached", TotalWindows10DevicesWithoutTenantAttached);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

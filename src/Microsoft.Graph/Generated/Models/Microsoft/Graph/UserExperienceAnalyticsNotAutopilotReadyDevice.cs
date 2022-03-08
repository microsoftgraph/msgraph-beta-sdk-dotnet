using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsNotAutopilotReadyDevice : Entity, IParsable {
        /// <summary>The intune device's autopilotProfileAssigned.</summary>
        public bool? AutoPilotProfileAssigned { get; set; }
        /// <summary>The intune device's autopilotRegistered.</summary>
        public bool? AutoPilotRegistered { get; set; }
        /// <summary>The intune device's azure Ad joinType.</summary>
        public string AzureAdJoinType { get; set; }
        /// <summary>The intune device's azureAdRegistered.</summary>
        public bool? AzureAdRegistered { get; set; }
        /// <summary>The intune device's name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The intune device's managed by.</summary>
        public string ManagedBy { get; set; }
        /// <summary>The intune device's manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The intune device's model.</summary>
        public string Model { get; set; }
        /// <summary>The intune device's serial number.</summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsNotAutopilotReadyDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsNotAutopilotReadyDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"autoPilotProfileAssigned", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).AutoPilotProfileAssigned = n.GetBoolValue(); } },
                {"autoPilotRegistered", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).AutoPilotRegistered = n.GetBoolValue(); } },
                {"azureAdJoinType", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).AzureAdJoinType = n.GetStringValue(); } },
                {"azureAdRegistered", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).AzureAdRegistered = n.GetBoolValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).DeviceName = n.GetStringValue(); } },
                {"managedBy", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).ManagedBy = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).Model = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as UserExperienceAnalyticsNotAutopilotReadyDevice).SerialNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("autoPilotProfileAssigned", AutoPilotProfileAssigned);
            writer.WriteBoolValue("autoPilotRegistered", AutoPilotRegistered);
            writer.WriteStringValue("azureAdJoinType", AzureAdJoinType);
            writer.WriteBoolValue("azureAdRegistered", AzureAdRegistered);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedBy", ManagedBy);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("serialNumber", SerialNumber);
        }
    }
}

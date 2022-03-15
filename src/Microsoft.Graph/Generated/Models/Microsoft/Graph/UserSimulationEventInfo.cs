using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class UserSimulationEventInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Browser information from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
        public string Browser { get; set; }
        /// <summary>Date and time of the simulation event by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Name of the simulation event by a user in an attack simulation and training campaign.</summary>
        public string EventName { get; set; }
        /// <summary>IP address from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
        public string IpAddress { get; set; }
        /// <summary>The operating system, platform, and device details from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
        public string OsPlatformDeviceDetails { get; set; }
        /// <summary>
        /// Instantiates a new userSimulationEventInfo and sets the default values.
        /// </summary>
        public UserSimulationEventInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserSimulationEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"browser", (o,n) => { (o as UserSimulationEventInfo).Browser = n.GetStringValue(); } },
                {"eventDateTime", (o,n) => { (o as UserSimulationEventInfo).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", (o,n) => { (o as UserSimulationEventInfo).EventName = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as UserSimulationEventInfo).IpAddress = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", (o,n) => { (o as UserSimulationEventInfo).OsPlatformDeviceDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

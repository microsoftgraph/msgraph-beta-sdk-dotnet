using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementTroubleshootingEvent : Entity, IParsable {
        /// <summary>A set of string key and string value pairs which provides additional information on the Troubleshooting event</summary>
        public List<KeyValuePair> AdditionalInformation { get; set; }
        /// <summary>Id used for tracing the failure in the service.</summary>
        public string CorrelationId { get; set; }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Event Name corresponding to the Troubleshooting Event. It is an Optional field</summary>
        public string EventName { get; set; }
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
        public DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementTroubleshootingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"additionalInformation", (o,n) => { (o as DeviceManagementTroubleshootingEvent).AdditionalInformation = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"correlationId", (o,n) => { (o as DeviceManagementTroubleshootingEvent).CorrelationId = n.GetStringValue(); } },
                {"eventDateTime", (o,n) => { (o as DeviceManagementTroubleshootingEvent).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", (o,n) => { (o as DeviceManagementTroubleshootingEvent).EventName = n.GetStringValue(); } },
                {"troubleshootingErrorDetails", (o,n) => { (o as DeviceManagementTroubleshootingEvent).TroubleshootingErrorDetails = n.GetObjectValue<DeviceManagementTroubleshootingErrorDetails>(DeviceManagementTroubleshootingErrorDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteObjectValue<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails", TroubleshootingErrorDetails);
        }
    }
}

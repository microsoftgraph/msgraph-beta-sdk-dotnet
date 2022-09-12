using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Event representing an general failure.</summary>
    public class DeviceManagementTroubleshootingEvent : Entity, IParsable {
        /// <summary>A set of string key and string value pairs which provides additional information on the Troubleshooting event</summary>
        public List<KeyValuePair> AdditionalInformation {
            get { return BackingStore?.Get<List<KeyValuePair>>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
        /// <summary>Id used for tracing the failure in the service.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Event Name corresponding to the Troubleshooting Event. It is an Optional field</summary>
        public string EventName {
            get { return BackingStore?.Get<string>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
        public DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails {
            get { return BackingStore?.Get<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementTroubleshootingEvent and sets the default values.
        /// </summary>
        public DeviceManagementTroubleshootingEvent() : base() {
            OdataType = "#microsoft.graph.deviceManagementTroubleshootingEvent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.appleVppTokenTroubleshootingEvent" => new AppleVppTokenTroubleshootingEvent(),
                "#microsoft.graph.enrollmentTroubleshootingEvent" => new EnrollmentTroubleshootingEvent(),
                "#microsoft.graph.mobileAppTroubleshootingEvent" => new MobileAppTroubleshootingEvent(),
                _ => new DeviceManagementTroubleshootingEvent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", n => { EventName = n.GetStringValue(); } },
                {"troubleshootingErrorDetails", n => { TroubleshootingErrorDetails = n.GetObjectValue<DeviceManagementTroubleshootingErrorDetails>(DeviceManagementTroubleshootingErrorDetails.CreateFromDiscriminatorValue); } },
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

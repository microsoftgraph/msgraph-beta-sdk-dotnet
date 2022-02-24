using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EmbeddedSIMDeviceState : Entity, IParsable {
        /// <summary>The time the embedded SIM device status was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Device name to which the subscription was provisioned e.g. DESKTOP-JOE</summary>
        public string DeviceName { get; set; }
        /// <summary>The time the embedded SIM device last checked in. Updated service side.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>The time the embedded SIM device status was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>The state of the profile operation applied to the device. Possible values are: notEvaluated, failed, installing, installed, deleting, error, deleted, removedByUser.</summary>
        public EmbeddedSIMDeviceStateValue? State { get; set; }
        /// <summary>String description of the provisioning state.</summary>
        public string StateDetails { get; set; }
        /// <summary>The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.</summary>
        public string UniversalIntegratedCircuitCardIdentifier { get; set; }
        /// <summary>Username which the subscription was provisioned to e.g. joe@contoso.com</summary>
        public string UserName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as EmbeddedSIMDeviceState).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", (o,n) => { (o as EmbeddedSIMDeviceState).DeviceName = n.GetStringValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as EmbeddedSIMDeviceState).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedDateTime", (o,n) => { (o as EmbeddedSIMDeviceState).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as EmbeddedSIMDeviceState).State = n.GetEnumValue<EmbeddedSIMDeviceStateValue>(); } },
                {"stateDetails", (o,n) => { (o as EmbeddedSIMDeviceState).StateDetails = n.GetStringValue(); } },
                {"universalIntegratedCircuitCardIdentifier", (o,n) => { (o as EmbeddedSIMDeviceState).UniversalIntegratedCircuitCardIdentifier = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as EmbeddedSIMDeviceState).UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<EmbeddedSIMDeviceStateValue>("state", State);
            writer.WriteStringValue("stateDetails", StateDetails);
            writer.WriteStringValue("universalIntegratedCircuitCardIdentifier", UniversalIntegratedCircuitCardIdentifier);
            writer.WriteStringValue("userName", UserName);
        }
    }
}

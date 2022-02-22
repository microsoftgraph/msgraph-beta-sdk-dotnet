using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementIntentDeviceState : Entity, IParsable {
        /// <summary>Device name that is being reported</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>Device id that is being reported</summary>
        public string DeviceId { get; set; }
        /// <summary>Last modified date time of an intent report</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>Device state for an intent. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The user name that is being reported on a device</summary>
        public string UserName { get; set; }
        /// <summary>The user principal name that is being reported on a device</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceDisplayName", (o,n) => { (o as DeviceManagementIntentDeviceState).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as DeviceManagementIntentDeviceState).DeviceId = n.GetStringValue(); } },
                {"lastReportedDateTime", (o,n) => { (o as DeviceManagementIntentDeviceState).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as DeviceManagementIntentDeviceState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userName", (o,n) => { (o as DeviceManagementIntentDeviceState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceManagementIntentDeviceState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkDeviceOperation : Entity, IParsable {
        /// <summary>Time at which the operation reached a final state (for example, Successful, Failed, and Cancelled).</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>Identity of the user who created the device operation.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The UTC date and time when the device operation was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Error details are available only in case of a failed status.</summary>
        public OperationError Error { get; set; }
        /// <summary>Identity of the user who last modified the device operation.</summary>
        public IdentitySet LastActionBy { get; set; }
        /// <summary>The UTC date and time when the device operation was last modified.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>Type of async operation on a device. The possible values are: deviceRestart, configUpdate, deviceDiagnostics, softwareUpdate, deviceManagementAgentConfigUpdate, remoteLogin, remoteLogout, unknownFutureValue.</summary>
        public TeamworkDeviceOperationType? OperationType { get; set; }
        /// <summary>Time at which the operation was started.</summary>
        public DateTimeOffset? StartedDateTime { get; set; }
        /// <summary>The current status of the async operation, for example, Queued, Scheduled, InProgress,  Successful, Cancelled, and Failed.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completedDateTime", (o,n) => { (o as TeamworkDeviceOperation).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", (o,n) => { (o as TeamworkDeviceOperation).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as TeamworkDeviceOperation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as TeamworkDeviceOperation).Error = n.GetObjectValue<OperationError>(); } },
                {"lastActionBy", (o,n) => { (o as TeamworkDeviceOperation).LastActionBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastActionDateTime", (o,n) => { (o as TeamworkDeviceOperation).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", (o,n) => { (o as TeamworkDeviceOperation).OperationType = n.GetEnumValue<TeamworkDeviceOperationType>(); } },
                {"startedDateTime", (o,n) => { (o as TeamworkDeviceOperation).StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as TeamworkDeviceOperation).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<OperationError>("error", Error);
            writer.WriteObjectValue<IdentitySet>("lastActionBy", LastActionBy);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<TeamworkDeviceOperationType>("operationType", OperationType);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}

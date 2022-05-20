using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkDeviceOperation : Entity, IParsable {
        /// <summary>Time at which the operation reached a final state (for example, Successful, Failed, and Cancelled).</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CompletedDateTime)); }
            set { BackingStore?.Set(nameof(CompletedDateTime), value); }
        }
        /// <summary>Identity of the user who created the device operation.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The UTC date and time when the device operation was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Error details are available only in case of a failed status.</summary>
        public OperationError Error {
            get { return BackingStore?.Get<OperationError>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
        }
        /// <summary>Identity of the user who last modified the device operation.</summary>
        public IdentitySet LastActionBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastActionBy)); }
            set { BackingStore?.Set(nameof(LastActionBy), value); }
        }
        /// <summary>The UTC date and time when the device operation was last modified.</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastActionDateTime)); }
            set { BackingStore?.Set(nameof(LastActionDateTime), value); }
        }
        /// <summary>Type of async operation on a device. The possible values are: deviceRestart, configUpdate, deviceDiagnostics, softwareUpdate, deviceManagementAgentConfigUpdate, remoteLogin, remoteLogout, unknownFutureValue.</summary>
        public TeamworkDeviceOperationType? OperationType {
            get { return BackingStore?.Get<TeamworkDeviceOperationType?>(nameof(OperationType)); }
            set { BackingStore?.Set(nameof(OperationType), value); }
        }
        /// <summary>Time at which the operation was started.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartedDateTime)); }
            set { BackingStore?.Set(nameof(StartedDateTime), value); }
        }
        /// <summary>The current status of the async operation, for example, Queued, Scheduled, InProgress,  Successful, Cancelled, and Failed.</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkDeviceOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<OperationError>(OperationError.CreateFromDiscriminatorValue); } },
                {"lastActionBy", n => { LastActionBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<TeamworkDeviceOperationType>(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
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

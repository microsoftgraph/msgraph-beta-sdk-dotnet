using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceOperation : Entity, IParsable {
        /// <summary>Time at which the operation reached a final state (for example, Successful, Failed, and Cancelled).</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>Identity of the user who created the device operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device operation was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Error details are available only in case of a failed status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OperationError? Error {
            get { return BackingStore?.Get<OperationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public OperationError Error {
            get { return BackingStore?.Get<OperationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>Identity of the user who last modified the device operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastActionBy {
            get { return BackingStore?.Get<IdentitySet?>("lastActionBy"); }
            set { BackingStore?.Set("lastActionBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastActionBy {
            get { return BackingStore?.Get<IdentitySet>("lastActionBy"); }
            set { BackingStore?.Set("lastActionBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device operation was last modified.</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The operationType property</summary>
        public TeamworkDeviceOperationType? OperationType {
            get { return BackingStore?.Get<TeamworkDeviceOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>Time at which the operation was started.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The current status of the async operation, for example, Queued, Scheduled, InProgress,  Successful, Cancelled, and Failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

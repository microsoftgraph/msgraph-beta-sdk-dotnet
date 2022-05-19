using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows Log Collection request entity.</summary>
    public class DeviceLogCollectionResponse : Entity, IParsable {
        /// <summary>The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ErrorCode {
            get { return BackingStore?.Get<long?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>The DateTime of the expiration of the logs</summary>
        public DateTimeOffset? ExpirationDateTimeUTC {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTimeUTC)); }
            set { BackingStore?.Set(nameof(ExpirationDateTimeUTC), value); }
        }
        /// <summary>The UPN for who initiated the request</summary>
        public string InitiatedByUserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(InitiatedByUserPrincipalName)); }
            set { BackingStore?.Set(nameof(InitiatedByUserPrincipalName), value); }
        }
        /// <summary>The device Id</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>The DateTime the request was received</summary>
        public DateTimeOffset? ReceivedDateTimeUTC {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReceivedDateTimeUTC)); }
            set { BackingStore?.Set(nameof(ReceivedDateTimeUTC), value); }
        }
        /// <summary>The DateTime of the request</summary>
        public DateTimeOffset? RequestedDateTimeUTC {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RequestedDateTimeUTC)); }
            set { BackingStore?.Set(nameof(RequestedDateTimeUTC), value); }
        }
        /// <summary>The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Size {
            get { return BackingStore?.Get<double?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>The status of the log collection request</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errorCode", n => { ErrorCode = n.GetLongValue(); } },
                {"expirationDateTimeUTC", n => { ExpirationDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"receivedDateTimeUTC", n => { ReceivedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"requestedDateTimeUTC", n => { RequestedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"size", n => { Size = n.GetDoubleValue(); } },
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
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("expirationDateTimeUTC", ExpirationDateTimeUTC);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("receivedDateTimeUTC", ReceivedDateTimeUTC);
            writer.WriteDateTimeOffsetValue("requestedDateTimeUTC", RequestedDateTimeUTC);
            writer.WriteDoubleValue("size", Size);
            writer.WriteStringValue("status", Status);
        }
    }
}

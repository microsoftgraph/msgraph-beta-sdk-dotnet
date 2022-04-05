using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceLogCollectionResponse : Entity, IParsable {
        /// <summary>The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ErrorCode { get; set; }
        /// <summary>The DateTime of the expiration of the logs</summary>
        public DateTimeOffset? ExpirationDateTimeUTC { get; set; }
        /// <summary>The UPN for who initiated the request</summary>
        public string InitiatedByUserPrincipalName { get; set; }
        /// <summary>The device Id</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The DateTime the request was received</summary>
        public DateTimeOffset? ReceivedDateTimeUTC { get; set; }
        /// <summary>The DateTime of the request</summary>
        public DateTimeOffset? RequestedDateTimeUTC { get; set; }
        /// <summary>The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Size { get; set; }
        /// <summary>The status of the log collection request</summary>
        public string Status { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"errorCode", (o,n) => { (o as DeviceLogCollectionResponse).ErrorCode = n.GetLongValue(); } },
                {"expirationDateTimeUTC", (o,n) => { (o as DeviceLogCollectionResponse).ExpirationDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"initiatedByUserPrincipalName", (o,n) => { (o as DeviceLogCollectionResponse).InitiatedByUserPrincipalName = n.GetStringValue(); } },
                {"managedDeviceId", (o,n) => { (o as DeviceLogCollectionResponse).ManagedDeviceId = n.GetStringValue(); } },
                {"receivedDateTimeUTC", (o,n) => { (o as DeviceLogCollectionResponse).ReceivedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"requestedDateTimeUTC", (o,n) => { (o as DeviceLogCollectionResponse).RequestedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                {"size", (o,n) => { (o as DeviceLogCollectionResponse).Size = n.GetDoubleValue(); } },
                {"status", (o,n) => { (o as DeviceLogCollectionResponse).Status = n.GetStringValue(); } },
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

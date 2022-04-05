using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPCConnectivityIssue : Entity, IParsable {
        /// <summary>The Intune DeviceId of the device the connection is associated with.</summary>
        public string DeviceId { get; set; }
        /// <summary>The error code of the connectivity issue.</summary>
        public string ErrorCode { get; set; }
        /// <summary>The time that the connection initiated. The time is shown in ISO 8601 format and Coordinated Universal Time (UTC) time.</summary>
        public DateTimeOffset? ErrorDateTime { get; set; }
        /// <summary>The detailed description of what went wrong.</summary>
        public string ErrorDescription { get; set; }
        /// <summary>The recommended action to fix the corresponding error.</summary>
        public string RecommendedAction { get; set; }
        /// <summary>The unique id of user who initialize the connection.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPCConnectivityIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPCConnectivityIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceId", (o,n) => { (o as CloudPCConnectivityIssue).DeviceId = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as CloudPCConnectivityIssue).ErrorCode = n.GetStringValue(); } },
                {"errorDateTime", (o,n) => { (o as CloudPCConnectivityIssue).ErrorDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorDescription", (o,n) => { (o as CloudPCConnectivityIssue).ErrorDescription = n.GetStringValue(); } },
                {"recommendedAction", (o,n) => { (o as CloudPCConnectivityIssue).RecommendedAction = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as CloudPCConnectivityIssue).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("errorDateTime", ErrorDateTime);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteStringValue("userId", UserId);
        }
    }
}

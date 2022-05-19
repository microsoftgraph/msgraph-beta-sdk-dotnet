using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analyte connectivity issue entity.</summary>
    public class CloudPCConnectivityIssue : Entity, IParsable {
        /// <summary>The Intune DeviceId of the device the connection is associated with.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The error code of the connectivity issue.</summary>
        public string ErrorCode {
            get { return BackingStore?.Get<string>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>The time that the connection initiated. The time is shown in ISO 8601 format and Coordinated Universal Time (UTC) time.</summary>
        public DateTimeOffset? ErrorDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ErrorDateTime)); }
            set { BackingStore?.Set(nameof(ErrorDateTime), value); }
        }
        /// <summary>The detailed description of what went wrong.</summary>
        public string ErrorDescription {
            get { return BackingStore?.Get<string>(nameof(ErrorDescription)); }
            set { BackingStore?.Set(nameof(ErrorDescription), value); }
        }
        /// <summary>The recommended action to fix the corresponding error.</summary>
        public string RecommendedAction {
            get { return BackingStore?.Get<string>(nameof(RecommendedAction)); }
            set { BackingStore?.Set(nameof(RecommendedAction), value); }
        }
        /// <summary>The unique id of user who initialize the connection.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"errorDateTime", n => { ErrorDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorDescription", n => { ErrorDescription = n.GetStringValue(); } },
                {"recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
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

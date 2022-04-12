using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Notification : Entity, IParsable {
        /// <summary>Sets how long (in seconds) this notification content will stay in each platform&apos;s notification viewer. For example, when the notification is delivered to a Windows device, the value of this property is passed on to ToastNotification.ExpirationTime, which determines how long the toast notification will stay in the user&apos;s Windows Action Center.</summary>
        public int? DisplayTimeToLive { get; set; }
        /// <summary>Sets a UTC expiration date and time on a user notification using ISO 8601 format (for example, midnight UTC on Jan 1, 2019 would look like this: &apos;2019-01-01T00:00:00Z&apos;). When time is up, the notification is removed from the Microsoft Graph notification feed store completely and is no longer part of notification history. Max value is 30 days.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The name of the group that this notification belongs to. It is set by the developer for the purpose of grouping notifications together.</summary>
        public string GroupName { get; set; }
        /// <summary>The payload property</summary>
        public PayloadTypes Payload { get; set; }
        /// <summary>Indicates the priority of a raw user notification. Visual notifications are sent with high priority by default. Valid values are None, High and Low.</summary>
        public Microsoft.Graph.Beta.Models.Priority? Priority { get; set; }
        /// <summary>Represents the host name of the app to which the calling service wants to post the notification, for the given user. If targeting web endpoints (see targetPolicy.platformTypes), ensure that targetHostName is the same as the name used when creating a subscription on the client side within the application JSON property.</summary>
        public string TargetHostName { get; set; }
        /// <summary>Target policy object handles notification delivery policy for endpoint types that should be targeted (Windows, iOS, Android and WebPush) for the given user.</summary>
        public TargetPolicyEndpoints TargetPolicy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Notification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Notification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayTimeToLive", n => { DisplayTimeToLive = n.GetIntValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupName", n => { GroupName = n.GetStringValue(); } },
                {"payload", n => { Payload = n.GetObjectValue<PayloadTypes>(PayloadTypes.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetEnumValue<Priority>(); } },
                {"targetHostName", n => { TargetHostName = n.GetStringValue(); } },
                {"targetPolicy", n => { TargetPolicy = n.GetObjectValue<TargetPolicyEndpoints>(TargetPolicyEndpoints.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("displayTimeToLive", DisplayTimeToLive);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("groupName", GroupName);
            writer.WriteObjectValue<PayloadTypes>("payload", Payload);
            writer.WriteEnumValue<Priority>("priority", Priority);
            writer.WriteStringValue("targetHostName", TargetHostName);
            writer.WriteObjectValue<TargetPolicyEndpoints>("targetPolicy", TargetPolicy);
        }
    }
}

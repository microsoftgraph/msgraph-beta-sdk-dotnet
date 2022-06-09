using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleManagementPolicyNotificationRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>Indicates whether a default recipient will receive the notification email.</summary>
        public bool? IsDefaultRecipientsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsDefaultRecipientsEnabled)); }
            set { BackingStore?.Set(nameof(IsDefaultRecipientsEnabled), value); }
        }
        /// <summary>The level of notification. The possible values are None, Critical, All.</summary>
        public string NotificationLevel {
            get { return BackingStore?.Get<string>(nameof(NotificationLevel)); }
            set { BackingStore?.Set(nameof(NotificationLevel), value); }
        }
        /// <summary>The list of recipients of the email notifications.</summary>
        public List<string> NotificationRecipients {
            get { return BackingStore?.Get<List<string>>(nameof(NotificationRecipients)); }
            set { BackingStore?.Set(nameof(NotificationRecipients), value); }
        }
        /// <summary>The type of notification. Only Email is supported.</summary>
        public string NotificationType {
            get { return BackingStore?.Get<string>(nameof(NotificationType)); }
            set { BackingStore?.Set(nameof(NotificationType), value); }
        }
        /// <summary>The type of recipient of the notification. The possible values are Requestor, Approver, Admin.</summary>
        public string RecipientType {
            get { return BackingStore?.Get<string>(nameof(RecipientType)); }
            set { BackingStore?.Set(nameof(RecipientType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleManagementPolicyNotificationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyNotificationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefaultRecipientsEnabled", n => { IsDefaultRecipientsEnabled = n.GetBoolValue(); } },
                {"notificationLevel", n => { NotificationLevel = n.GetStringValue(); } },
                {"notificationRecipients", n => { NotificationRecipients = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationType", n => { NotificationType = n.GetStringValue(); } },
                {"recipientType", n => { RecipientType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefaultRecipientsEnabled", IsDefaultRecipientsEnabled);
            writer.WriteStringValue("notificationLevel", NotificationLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationRecipients", NotificationRecipients);
            writer.WriteStringValue("notificationType", NotificationType);
            writer.WriteStringValue("recipientType", RecipientType);
        }
    }
}

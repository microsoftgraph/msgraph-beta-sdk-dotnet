using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementComplianceActionItem : Entity, IParsable {
        /// <summary>What action to take. Possible values are: noAction, notification, block, retire, wipe, removeResourceAccessProfiles, pushNotification, remoteLock.</summary>
        public DeviceManagementComplianceActionType? ActionType { get; set; }
        /// <summary>Number of hours to wait till the action will be enforced. Valid values 0 to 8760</summary>
        public int? GracePeriodHours { get; set; }
        /// <summary>A list of group IDs to speicify who to CC this notification message to. This collection can contain a maximum of 100 elements.</summary>
        public List<string> NotificationMessageCCList { get; set; }
        /// <summary>What notification Message template to use</summary>
        public string NotificationTemplateId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionType", (o,n) => { (o as DeviceManagementComplianceActionItem).ActionType = n.GetEnumValue<DeviceManagementComplianceActionType>(); } },
                {"gracePeriodHours", (o,n) => { (o as DeviceManagementComplianceActionItem).GracePeriodHours = n.GetIntValue(); } },
                {"notificationMessageCCList", (o,n) => { (o as DeviceManagementComplianceActionItem).NotificationMessageCCList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationTemplateId", (o,n) => { (o as DeviceManagementComplianceActionItem).NotificationTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementComplianceActionType>("actionType", ActionType);
            writer.WriteIntValue("gracePeriodHours", GracePeriodHours);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationMessageCCList", NotificationMessageCCList);
            writer.WriteStringValue("notificationTemplateId", NotificationTemplateId);
        }
    }
}

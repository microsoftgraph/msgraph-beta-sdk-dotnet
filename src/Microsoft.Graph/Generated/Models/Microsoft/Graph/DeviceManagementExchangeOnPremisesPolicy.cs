using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementExchangeOnPremisesPolicy : Entity, IParsable {
        /// <summary>The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization</summary>
        public List<DeviceManagementExchangeAccessRule> AccessRules { get; set; }
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
        /// <summary>Default access state in Exchange. This rule applies globally to the entire Exchange organization. Possible values are: none, allow, block, quarantine.</summary>
        public DeviceManagementExchangeAccessLevel? DefaultAccessLevel { get; set; }
        /// <summary>The list of device classes known to Exchange</summary>
        public List<DeviceManagementExchangeDeviceClass> KnownDeviceClasses { get; set; }
        /// <summary>Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.</summary>
        public byte[] NotificationContent { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessRules", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).AccessRules = n.GetCollectionOfObjectValues<DeviceManagementExchangeAccessRule>().ToList(); } },
                {"conditionalAccessSettings", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(); } },
                {"defaultAccessLevel", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).DefaultAccessLevel = n.GetEnumValue<DeviceManagementExchangeAccessLevel>(); } },
                {"knownDeviceClasses", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).KnownDeviceClasses = n.GetCollectionOfObjectValues<DeviceManagementExchangeDeviceClass>().ToList(); } },
                {"notificationContent", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).NotificationContent = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeAccessRule>("accessRules", AccessRules);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteEnumValue<DeviceManagementExchangeAccessLevel>("defaultAccessLevel", DefaultAccessLevel);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeDeviceClass>("knownDeviceClasses", KnownDeviceClasses);
            writer.WriteByteArrayValue("notificationContent", NotificationContent);
        }
    }
}

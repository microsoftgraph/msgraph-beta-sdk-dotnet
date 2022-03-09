using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementExchangeOnPremisesPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementExchangeOnPremisesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessRules", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).AccessRules = n.GetCollectionOfObjectValues<DeviceManagementExchangeAccessRule>(DeviceManagementExchangeAccessRule.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessSettings", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"defaultAccessLevel", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).DefaultAccessLevel = n.GetEnumValue<DeviceManagementExchangeAccessLevel>(); } },
                {"knownDeviceClasses", (o,n) => { (o as DeviceManagementExchangeOnPremisesPolicy).KnownDeviceClasses = n.GetCollectionOfObjectValues<DeviceManagementExchangeDeviceClass>(DeviceManagementExchangeDeviceClass.CreateFromDiscriminatorValue).ToList(); } },
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

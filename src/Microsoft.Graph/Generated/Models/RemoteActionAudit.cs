using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RemoteActionAudit : Entity, IParsable {
        /// <summary>The action name. Possible values are: unknown, factoryReset, removeCompanyData, resetPasscode, remoteLock, enableLostMode, disableLostMode, locateDevice, rebootNow, recoverPasscode, cleanWindowsDevice, logoutSharedAppleDeviceActiveUser, quickScan, fullScan, windowsDefenderUpdateSignatures, factoryResetKeepEnrollmentData, updateDeviceAccount, automaticRedeployment, shutDown, rotateBitLockerKeys, rotateFileVaultKey, getFileVaultKey, setDeviceName, activateDeviceEsim.</summary>
        public RemoteAction? Action { get; set; }
        /// <summary>Action state. Possible values are: none, pending, canceled, active, done, failed, notSupported.</summary>
        public Microsoft.Graph.Beta.Models.ActionState? ActionState { get; set; }
        /// <summary>Intune device name.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>IMEI of the device.</summary>
        public string DeviceIMEI { get; set; }
        /// <summary>Upn of the device owner.</summary>
        public string DeviceOwnerUserPrincipalName { get; set; }
        /// <summary>User who initiated the device action, format is UPN.</summary>
        public string InitiatedByUserPrincipalName { get; set; }
        /// <summary>Action target.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Time when the action was issued, given in UTC.</summary>
        public DateTimeOffset? RequestDateTime { get; set; }
        /// <summary>[deprecated] Please use InitiatedByUserPrincipalName instead.</summary>
        public string UserName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RemoteActionAudit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteActionAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<RemoteAction>(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceIMEI", n => { DeviceIMEI = n.GetStringValue(); } },
                {"deviceOwnerUserPrincipalName", n => { DeviceOwnerUserPrincipalName = n.GetStringValue(); } },
                {"initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<RemoteAction>("action", Action);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceIMEI", DeviceIMEI);
            writer.WriteStringValue("deviceOwnerUserPrincipalName", DeviceOwnerUserPrincipalName);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteStringValue("userName", UserName);
        }
    }
}

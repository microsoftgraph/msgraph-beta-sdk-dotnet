using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Report of remote actions initiated on the devices belonging to a certain tenant.</summary>
    public class RemoteActionAudit : Entity, IParsable {
        /// <summary>Remote actions Intune supports.</summary>
        public RemoteAction? Action {
            get { return BackingStore?.Get<RemoteAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>The actionState property</summary>
        public Microsoft.Graph.Beta.Models.ActionState? ActionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionState?>("actionState"); }
            set { BackingStore?.Set("actionState", value); }
        }
        /// <summary>Intune device name.</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
        /// <summary>IMEI of the device.</summary>
        public string DeviceIMEI {
            get { return BackingStore?.Get<string>("deviceIMEI"); }
            set { BackingStore?.Set("deviceIMEI", value); }
        }
        /// <summary>Upn of the device owner.</summary>
        public string DeviceOwnerUserPrincipalName {
            get { return BackingStore?.Get<string>("deviceOwnerUserPrincipalName"); }
            set { BackingStore?.Set("deviceOwnerUserPrincipalName", value); }
        }
        /// <summary>User who initiated the device action, format is UPN.</summary>
        public string InitiatedByUserPrincipalName {
            get { return BackingStore?.Get<string>("initiatedByUserPrincipalName"); }
            set { BackingStore?.Set("initiatedByUserPrincipalName", value); }
        }
        /// <summary>Action target.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>Time when the action was issued, given in UTC.</summary>
        public DateTimeOffset? RequestDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestDateTime"); }
            set { BackingStore?.Set("requestDateTime", value); }
        }
        /// <summary>[deprecated] Please use InitiatedByUserPrincipalName instead.</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

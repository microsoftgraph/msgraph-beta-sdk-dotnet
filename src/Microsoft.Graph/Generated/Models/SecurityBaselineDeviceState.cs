using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The security baseline compliance state summary of the security baseline for a device.</summary>
    public class SecurityBaselineDeviceState : Entity, IParsable {
        /// <summary>Display name of the device</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceDisplayName), value); }
        }
        /// <summary>Last modified date time of the policy report</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportedDateTime)); }
            set { BackingStore?.Set(nameof(LastReportedDateTime), value); }
        }
        /// <summary>Intune device id</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>Security baseline compliance state. Possible values are: unknown, secure, notApplicable, notSecure, error, conflict.</summary>
        public SecurityBaselineComplianceState? State {
            get { return BackingStore?.Get<SecurityBaselineComplianceState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityBaselineDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteEnumValue<SecurityBaselineComplianceState>("state", State);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}

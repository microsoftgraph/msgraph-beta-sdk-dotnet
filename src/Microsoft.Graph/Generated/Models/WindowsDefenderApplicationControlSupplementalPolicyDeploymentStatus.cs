using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for the deployment state of a WindowsDefenderApplicationControl supplemental policy for a device.</summary>
    public class WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus : Entity, IParsable {
        /// <summary>Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyStatuses? DeploymentStatus {
            get { return BackingStore?.Get<WindowsDefenderApplicationControlSupplementalPolicyStatuses?>("deploymentStatus"); }
            set { BackingStore?.Set("deploymentStatus", value); }
        }
        /// <summary>Device ID.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>Device name.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>Last sync date time.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Windows OS Version Description.</summary>
        public string OsDescription {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
        /// <summary>Windows OS Version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The navigation link to the WindowsDefenderApplicationControl supplemental policy.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicy Policy {
            get { return BackingStore?.Get<WindowsDefenderApplicationControlSupplementalPolicy>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
        /// <summary>Human readable version of the WindowsDefenderApplicationControl supplemental policy.</summary>
        public string PolicyVersion {
            get { return BackingStore?.Get<string>("policyVersion"); }
            set { BackingStore?.Set("policyVersion", value); }
        }
        /// <summary>The name of the user of this device.</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deploymentStatus", n => { DeploymentStatus = n.GetEnumValue<WindowsDefenderApplicationControlSupplementalPolicyStatuses>(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"policy", n => { Policy = n.GetObjectValue<WindowsDefenderApplicationControlSupplementalPolicy>(WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue); } },
                {"policyVersion", n => { PolicyVersion = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsDefenderApplicationControlSupplementalPolicyStatuses>("deploymentStatus", DeploymentStatus);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteObjectValue<WindowsDefenderApplicationControlSupplementalPolicy>("policy", Policy);
            writer.WriteStringValue("policyVersion", PolicyVersion);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}

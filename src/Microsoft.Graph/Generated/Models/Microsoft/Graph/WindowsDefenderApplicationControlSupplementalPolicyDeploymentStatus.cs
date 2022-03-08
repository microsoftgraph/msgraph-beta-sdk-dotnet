using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus : Entity, IParsable {
        /// <summary>The deployment state of the policy. Possible values are: unknown, success, tokenError, notAuthorizedByToken, policyNotFound.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyStatuses? DeploymentStatus { get; set; }
        /// <summary>Device ID.</summary>
        public string DeviceId { get; set; }
        /// <summary>Device name.</summary>
        public string DeviceName { get; set; }
        /// <summary>Last sync date time.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Windows OS Version Description.</summary>
        public string OsDescription { get; set; }
        /// <summary>Windows OS Version.</summary>
        public string OsVersion { get; set; }
        /// <summary>The navigation link to the WindowsDefenderApplicationControl supplemental policy.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicy Policy { get; set; }
        /// <summary>Human readable version of the WindowsDefenderApplicationControl supplemental policy.</summary>
        public string PolicyVersion { get; set; }
        /// <summary>The name of the user of this device.</summary>
        public string UserName { get; set; }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deploymentStatus", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).DeploymentStatus = n.GetEnumValue<WindowsDefenderApplicationControlSupplementalPolicyStatuses>(); } },
                {"deviceId", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).DeviceName = n.GetStringValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"osDescription", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).OsVersion = n.GetStringValue(); } },
                {"policy", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).Policy = n.GetObjectValue<WindowsDefenderApplicationControlSupplementalPolicy>(WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue); } },
                {"policyVersion", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).PolicyVersion = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

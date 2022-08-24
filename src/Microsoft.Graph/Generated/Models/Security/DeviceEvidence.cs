using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class DeviceEvidence : AlertEvidence, IParsable {
        /// <summary>A unique identifier assigned to a device by Azure Active Directory (Azure AD) when device is Azure AD-joined.</summary>
        public string AzureAdDeviceId {
            get { return BackingStore?.Get<string>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
        /// <summary>State of the Defender AntiMalware engine. The possible values are: notReporting, disabled, notUpdated, updated, unknown, notSupported, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.DefenderAvStatus? DefenderAvStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DefenderAvStatus?>("defenderAvStatus"); }
            set { BackingStore?.Set("defenderAvStatus", value); }
        }
        /// <summary>The fully qualified domain name (FQDN) for the device.</summary>
        public string DeviceDnsName {
            get { return BackingStore?.Get<string>("deviceDnsName"); }
            set { BackingStore?.Set("deviceDnsName", value); }
        }
        /// <summary>The date and time when the device was first seen.</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The health state of the device.The possible values are: active, inactive, impairedCommunication, noSensorData, noSensorDataImpairedCommunication, unknown, unknownFutureValue.</summary>
        public DeviceHealthStatus? HealthStatus {
            get { return BackingStore?.Get<DeviceHealthStatus?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>Users that were logged on the machine during the time of the alert.</summary>
        public List<LoggedOnUser> LoggedOnUsers {
            get { return BackingStore?.Get<List<LoggedOnUser>>("loggedOnUsers"); }
            set { BackingStore?.Set("loggedOnUsers", value); }
        }
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
        public string MdeDeviceId {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
        /// <summary>The status of the machine onboarding to Microsoft Defender for Endpoint.The possible values are: insufficientInfo, onboarded, canBeOnboarded, unsupported, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.OnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.OnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>The build version for the operating system the device is running.</summary>
        public long? OsBuild {
            get { return BackingStore?.Get<long?>("osBuild"); }
            set { BackingStore?.Set("osBuild", value); }
        }
        /// <summary>The operating system platform the device is running.</summary>
        public string OsPlatform {
            get { return BackingStore?.Get<string>("osPlatform"); }
            set { BackingStore?.Set("osPlatform", value); }
        }
        /// <summary>The ID of the role-based access control (RBAC) device group.</summary>
        public int? RbacGroupId {
            get { return BackingStore?.Get<int?>("rbacGroupId"); }
            set { BackingStore?.Set("rbacGroupId", value); }
        }
        /// <summary>The name of the RBAC device group.</summary>
        public string RbacGroupName {
            get { return BackingStore?.Get<string>("rbacGroupName"); }
            set { BackingStore?.Set("rbacGroupName", value); }
        }
        /// <summary>Risk score as evaluated by Microsoft Defender for Endpoint. The possible values are: none, informational, low, medium, high, unknownFutureValue.</summary>
        public DeviceRiskScore? RiskScore {
            get { return BackingStore?.Get<DeviceRiskScore?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
        /// <summary>The version of the operating system platform.</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>Metadata of the virtual machine (VM) on which Microsoft Defender for Endpoint is running.</summary>
        public Microsoft.Graph.Beta.Models.Security.VmMetadata VmMetadata {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.VmMetadata>("vmMetadata"); }
            set { BackingStore?.Set("vmMetadata", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceEvidence and sets the default values.
        /// </summary>
        public DeviceEvidence() : base() {
            OdataType = "#microsoft.graph.security.deviceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                {"defenderAvStatus", n => { DefenderAvStatus = n.GetEnumValue<DefenderAvStatus>(); } },
                {"deviceDnsName", n => { DeviceDnsName = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<DeviceHealthStatus>(); } },
                {"loggedOnUsers", n => { LoggedOnUsers = n.GetCollectionOfObjectValues<LoggedOnUser>(LoggedOnUser.CreateFromDiscriminatorValue).ToList(); } },
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<OnboardingStatus>(); } },
                {"osBuild", n => { OsBuild = n.GetLongValue(); } },
                {"osPlatform", n => { OsPlatform = n.GetStringValue(); } },
                {"rbacGroupId", n => { RbacGroupId = n.GetIntValue(); } },
                {"rbacGroupName", n => { RbacGroupName = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetEnumValue<DeviceRiskScore>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"vmMetadata", n => { VmMetadata = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.VmMetadata>(Microsoft.Graph.Beta.Models.Security.VmMetadata.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteEnumValue<DefenderAvStatus>("defenderAvStatus", DefenderAvStatus);
            writer.WriteStringValue("deviceDnsName", DeviceDnsName);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteEnumValue<DeviceHealthStatus>("healthStatus", HealthStatus);
            writer.WriteCollectionOfObjectValues<LoggedOnUser>("loggedOnUsers", LoggedOnUsers);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteEnumValue<OnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteLongValue("osBuild", OsBuild);
            writer.WriteStringValue("osPlatform", OsPlatform);
            writer.WriteIntValue("rbacGroupId", RbacGroupId);
            writer.WriteStringValue("rbacGroupName", RbacGroupName);
            writer.WriteEnumValue<DeviceRiskScore>("riskScore", RiskScore);
            writer.WriteStringValue("version", Version);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.VmMetadata>("vmMetadata", VmMetadata);
        }
    }
}

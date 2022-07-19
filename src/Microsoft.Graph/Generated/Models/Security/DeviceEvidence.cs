using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class DeviceEvidence : AlertEvidence, IParsable {
        /// <summary>The azureAdDeviceId property</summary>
        public string AzureAdDeviceId {
            get { return BackingStore?.Get<string>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
        /// <summary>The defenderAvStatus property</summary>
        public Microsoft.Graph.Beta.Models.Security.DefenderAvStatus? DefenderAvStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DefenderAvStatus?>("defenderAvStatus"); }
            set { BackingStore?.Set("defenderAvStatus", value); }
        }
        /// <summary>The deviceDnsName property</summary>
        public string DeviceDnsName {
            get { return BackingStore?.Get<string>("deviceDnsName"); }
            set { BackingStore?.Set("deviceDnsName", value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The healthStatus property</summary>
        public DeviceHealthStatus? HealthStatus {
            get { return BackingStore?.Get<DeviceHealthStatus?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The loggedOnUsers property</summary>
        public List<LoggedOnUser> LoggedOnUsers {
            get { return BackingStore?.Get<List<LoggedOnUser>>("loggedOnUsers"); }
            set { BackingStore?.Set("loggedOnUsers", value); }
        }
        /// <summary>The mdeDeviceId property</summary>
        public string MdeDeviceId {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
        /// <summary>The onboardingStatus property</summary>
        public Microsoft.Graph.Beta.Models.Security.OnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.OnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>The osBuild property</summary>
        public long? OsBuild {
            get { return BackingStore?.Get<long?>("osBuild"); }
            set { BackingStore?.Set("osBuild", value); }
        }
        /// <summary>The osPlatform property</summary>
        public string OsPlatform {
            get { return BackingStore?.Get<string>("osPlatform"); }
            set { BackingStore?.Set("osPlatform", value); }
        }
        /// <summary>The rbacGroupId property</summary>
        public int? RbacGroupId {
            get { return BackingStore?.Get<int?>("rbacGroupId"); }
            set { BackingStore?.Set("rbacGroupId", value); }
        }
        /// <summary>The rbacGroupName property</summary>
        public string RbacGroupName {
            get { return BackingStore?.Get<string>("rbacGroupName"); }
            set { BackingStore?.Set("rbacGroupName", value); }
        }
        /// <summary>The riskScore property</summary>
        public DeviceRiskScore? RiskScore {
            get { return BackingStore?.Get<DeviceRiskScore?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
        /// <summary>The version property</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>The vmMetadata property</summary>
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

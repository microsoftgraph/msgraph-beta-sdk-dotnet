using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceConfiguration : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>The device mode applicability rule for this Policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleDeviceMode DeviceManagementApplicabilityRuleDeviceMode { get; set; }
        /// <summary>The OS edition applicability for this Policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsEdition DeviceManagementApplicabilityRuleOsEdition { get; set; }
        /// <summary>The OS version applicability rule for this Policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsVersion DeviceManagementApplicabilityRuleOsVersion { get; set; }
        /// <summary>Device Configuration Setting State Device Summary</summary>
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries { get; set; }
        /// <summary>Device configuration installation status by device.</summary>
        public List<DeviceConfigurationDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>Device Configuration devices status overview</summary>
        public DeviceConfigurationDeviceOverview DeviceStatusOverview { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>The list of group assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationGroupAssignment> GroupAssignments { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.</summary>
        public bool? SupportsScopeTags { get; set; }
        /// <summary>Device configuration installation status by user.</summary>
        public List<DeviceConfigurationUserStatus> UserStatuses { get; set; }
        /// <summary>Device Configuration users status overview</summary>
        public DeviceConfigurationUserOverview UserStatusOverview { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceConfiguration).Assignments = n.GetCollectionOfObjectValues<DeviceConfigurationAssignment>(DeviceConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceConfiguration).Description = n.GetStringValue(); } },
                {"deviceManagementApplicabilityRuleDeviceMode", (o,n) => { (o as DeviceConfiguration).DeviceManagementApplicabilityRuleDeviceMode = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleDeviceMode>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleDeviceMode.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsEdition", (o,n) => { (o as DeviceConfiguration).DeviceManagementApplicabilityRuleOsEdition = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsEdition>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsEdition.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsVersion", (o,n) => { (o as DeviceConfiguration).DeviceManagementApplicabilityRuleOsVersion = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsVersion>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsVersion.CreateFromDiscriminatorValue); } },
                {"deviceSettingStateSummaries", (o,n) => { (o as DeviceConfiguration).DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", (o,n) => { (o as DeviceConfiguration).DeviceStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationDeviceStatus>(DeviceConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", (o,n) => { (o as DeviceConfiguration).DeviceStatusOverview = n.GetObjectValue<DeviceConfigurationDeviceOverview>(DeviceConfigurationDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as DeviceConfiguration).DisplayName = n.GetStringValue(); } },
                {"groupAssignments", (o,n) => { (o as DeviceConfiguration).GroupAssignments = n.GetCollectionOfObjectValues<DeviceConfigurationGroupAssignment>(DeviceConfigurationGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceConfiguration).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsScopeTags", (o,n) => { (o as DeviceConfiguration).SupportsScopeTags = n.GetBoolValue(); } },
                {"userStatuses", (o,n) => { (o as DeviceConfiguration).UserStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationUserStatus>(DeviceConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", (o,n) => { (o as DeviceConfiguration).UserStatusOverview = n.GetObjectValue<DeviceConfigurationUserOverview>(DeviceConfigurationUserOverview.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as DeviceConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleDeviceMode>("deviceManagementApplicabilityRuleDeviceMode", DeviceManagementApplicabilityRuleDeviceMode);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsEdition>("deviceManagementApplicabilityRuleOsEdition", DeviceManagementApplicabilityRuleOsEdition);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagementApplicabilityRuleOsVersion>("deviceManagementApplicabilityRuleOsVersion", DeviceManagementApplicabilityRuleOsVersion);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceConfigurationDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("supportsScopeTags", SupportsScopeTags);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceConfigurationUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}

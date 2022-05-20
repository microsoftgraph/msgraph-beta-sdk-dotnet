using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Configuration.</summary>
    public class DeviceConfiguration : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceConfigurationAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The device mode applicability rule for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode DeviceManagementApplicabilityRuleDeviceMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>(nameof(DeviceManagementApplicabilityRuleDeviceMode)); }
            set { BackingStore?.Set(nameof(DeviceManagementApplicabilityRuleDeviceMode), value); }
        }
        /// <summary>The OS edition applicability for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition DeviceManagementApplicabilityRuleOsEdition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>(nameof(DeviceManagementApplicabilityRuleOsEdition)); }
            set { BackingStore?.Set(nameof(DeviceManagementApplicabilityRuleOsEdition), value); }
        }
        /// <summary>The OS version applicability rule for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion DeviceManagementApplicabilityRuleOsVersion {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>(nameof(DeviceManagementApplicabilityRuleOsVersion)); }
            set { BackingStore?.Set(nameof(DeviceManagementApplicabilityRuleOsVersion), value); }
        }
        /// <summary>Device Configuration Setting State Device Summary</summary>
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<SettingStateDeviceSummary>>(nameof(DeviceSettingStateSummaries)); }
            set { BackingStore?.Set(nameof(DeviceSettingStateSummaries), value); }
        }
        /// <summary>Device configuration installation status by device.</summary>
        public List<DeviceConfigurationDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<DeviceConfigurationDeviceStatus>>(nameof(DeviceStatuses)); }
            set { BackingStore?.Set(nameof(DeviceStatuses), value); }
        }
        /// <summary>Device Configuration devices status overview</summary>
        public DeviceConfigurationDeviceOverview DeviceStatusOverview {
            get { return BackingStore?.Get<DeviceConfigurationDeviceOverview>(nameof(DeviceStatusOverview)); }
            set { BackingStore?.Set(nameof(DeviceStatusOverview), value); }
        }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The list of group assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationGroupAssignment> GroupAssignments {
            get { return BackingStore?.Get<List<DeviceConfigurationGroupAssignment>>(nameof(GroupAssignments)); }
            set { BackingStore?.Set(nameof(GroupAssignments), value); }
        }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.</summary>
        public bool? SupportsScopeTags {
            get { return BackingStore?.Get<bool?>(nameof(SupportsScopeTags)); }
            set { BackingStore?.Set(nameof(SupportsScopeTags), value); }
        }
        /// <summary>Device configuration installation status by user.</summary>
        public List<DeviceConfigurationUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<DeviceConfigurationUserStatus>>(nameof(UserStatuses)); }
            set { BackingStore?.Set(nameof(UserStatuses), value); }
        }
        /// <summary>Device Configuration users status overview</summary>
        public DeviceConfigurationUserOverview UserStatusOverview {
            get { return BackingStore?.Get<DeviceConfigurationUserOverview>(nameof(UserStatusOverview)); }
            set { BackingStore?.Set(nameof(UserStatusOverview), value); }
        }
        /// <summary>Version of the device configuration.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceConfiguration" => new DeviceConfiguration(),
                _ => new DeviceConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceConfigurationAssignment>(DeviceConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceManagementApplicabilityRuleDeviceMode", n => { DeviceManagementApplicabilityRuleDeviceMode = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsEdition", n => { DeviceManagementApplicabilityRuleOsEdition = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsVersion", n => { DeviceManagementApplicabilityRuleOsVersion = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion.CreateFromDiscriminatorValue); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationDeviceStatus>(DeviceConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", n => { DeviceStatusOverview = n.GetObjectValue<DeviceConfigurationDeviceOverview>(DeviceConfigurationDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<DeviceConfigurationGroupAssignment>(DeviceConfigurationGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsScopeTags", n => { SupportsScopeTags = n.GetBoolValue(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationUserStatus>(DeviceConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", n => { UserStatusOverview = n.GetObjectValue<DeviceConfigurationUserOverview>(DeviceConfigurationUserOverview.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>("deviceManagementApplicabilityRuleDeviceMode", DeviceManagementApplicabilityRuleDeviceMode);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>("deviceManagementApplicabilityRuleOsEdition", DeviceManagementApplicabilityRuleOsEdition);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>("deviceManagementApplicabilityRuleOsVersion", DeviceManagementApplicabilityRuleOsVersion);
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

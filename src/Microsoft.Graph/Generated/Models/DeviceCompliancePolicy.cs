using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>This is the base class for Compliance policy. Compliance policies are platform specific and individual per-platform compliance policies inherit from here. </summary>
    public class DeviceCompliancePolicy : Entity, IParsable {
        /// <summary>The collection of assignments for this compliance policy.</summary>
        public List<DeviceCompliancePolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyAssignment>>(nameof(Assignments)); }
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
        /// <summary>Compliance Setting State Device Summary</summary>
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<SettingStateDeviceSummary>>(nameof(DeviceSettingStateSummaries)); }
            set { BackingStore?.Set(nameof(DeviceSettingStateSummaries), value); }
        }
        /// <summary>List of DeviceComplianceDeviceStatus.</summary>
        public List<DeviceComplianceDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceDeviceStatus>>(nameof(DeviceStatuses)); }
            set { BackingStore?.Set(nameof(DeviceStatuses), value); }
        }
        /// <summary>Device compliance devices status overview</summary>
        public DeviceComplianceDeviceOverview DeviceStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceDeviceOverview>(nameof(DeviceStatusOverview)); }
            set { BackingStore?.Set(nameof(DeviceStatusOverview), value); }
        }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
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
        /// <summary>The list of scheduled action for this rule</summary>
        public List<DeviceComplianceScheduledActionForRule> ScheduledActionsForRule {
            get { return BackingStore?.Get<List<DeviceComplianceScheduledActionForRule>>(nameof(ScheduledActionsForRule)); }
            set { BackingStore?.Set(nameof(ScheduledActionsForRule), value); }
        }
        /// <summary>List of DeviceComplianceUserStatus.</summary>
        public List<DeviceComplianceUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceUserStatus>>(nameof(UserStatuses)); }
            set { BackingStore?.Set(nameof(UserStatuses), value); }
        }
        /// <summary>Device compliance users status overview</summary>
        public DeviceComplianceUserOverview UserStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceUserOverview>(nameof(UserStatusOverview)); }
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
        public static new DeviceCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidCompliancePolicy" => new AndroidCompliancePolicy(),
                "#microsoft.graph.androidDeviceOwnerCompliancePolicy" => new AndroidDeviceOwnerCompliancePolicy(),
                "#microsoft.graph.androidForWorkCompliancePolicy" => new AndroidForWorkCompliancePolicy(),
                "#microsoft.graph.androidWorkProfileCompliancePolicy" => new AndroidWorkProfileCompliancePolicy(),
                "#microsoft.graph.aospDeviceOwnerCompliancePolicy" => new AospDeviceOwnerCompliancePolicy(),
                "#microsoft.graph.defaultDeviceCompliancePolicy" => new DefaultDeviceCompliancePolicy(),
                "#microsoft.graph.iosCompliancePolicy" => new IosCompliancePolicy(),
                "#microsoft.graph.macOSCompliancePolicy" => new MacOSCompliancePolicy(),
                "#microsoft.graph.windows10CompliancePolicy" => new Windows10CompliancePolicy(),
                "#microsoft.graph.windows10MobileCompliancePolicy" => new Windows10MobileCompliancePolicy(),
                "#microsoft.graph.windows81CompliancePolicy" => new Windows81CompliancePolicy(),
                "#microsoft.graph.windowsPhone81CompliancePolicy" => new WindowsPhone81CompliancePolicy(),
                _ => new DeviceCompliancePolicy(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceCompliancePolicyAssignment>(DeviceCompliancePolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<DeviceComplianceDeviceStatus>(DeviceComplianceDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", n => { DeviceStatusOverview = n.GetObjectValue<DeviceComplianceDeviceOverview>(DeviceComplianceDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scheduledActionsForRule", n => { ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>(DeviceComplianceScheduledActionForRule.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<DeviceComplianceUserStatus>(DeviceComplianceUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", n => { UserStatusOverview = n.GetObjectValue<DeviceComplianceUserOverview>(DeviceComplianceUserOverview.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceComplianceDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceComplianceDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteCollectionOfObjectValues<DeviceComplianceUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceComplianceUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}

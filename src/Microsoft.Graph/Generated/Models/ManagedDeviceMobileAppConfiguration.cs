using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedDeviceMobileAppConfiguration : Entity, IParsable {
        /// <summary>The list of group assignemenets for app configration.</summary>
        public List<ManagedDeviceMobileAppConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationAssignment>>(nameof(Assignments)); }
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
        /// <summary>List of ManagedDeviceMobileAppConfigurationDeviceStatus.</summary>
        public List<ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationDeviceStatus>>(nameof(DeviceStatuses)); }
            set { BackingStore?.Set(nameof(DeviceStatuses), value); }
        }
        /// <summary>App configuration device status summary.</summary>
        public ManagedDeviceMobileAppConfigurationDeviceSummary DeviceStatusSummary {
            get { return BackingStore?.Get<ManagedDeviceMobileAppConfigurationDeviceSummary>(nameof(DeviceStatusSummary)); }
            set { BackingStore?.Set(nameof(DeviceStatusSummary), value); }
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
        /// <summary>List of Scope Tags for this App configuration entity.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>the associated app.</summary>
        public List<string> TargetedMobileApps {
            get { return BackingStore?.Get<List<string>>(nameof(TargetedMobileApps)); }
            set { BackingStore?.Set(nameof(TargetedMobileApps), value); }
        }
        /// <summary>List of ManagedDeviceMobileAppConfigurationUserStatus.</summary>
        public List<ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationUserStatus>>(nameof(UserStatuses)); }
            set { BackingStore?.Set(nameof(UserStatuses), value); }
        }
        /// <summary>App configuration user status summary.</summary>
        public ManagedDeviceMobileAppConfigurationUserSummary UserStatusSummary {
            get { return BackingStore?.Get<ManagedDeviceMobileAppConfigurationUserSummary>(nameof(UserStatusSummary)); }
            set { BackingStore?.Set(nameof(UserStatusSummary), value); }
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
        public static new ManagedDeviceMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidForWorkMobileAppConfiguration" => new AndroidForWorkMobileAppConfiguration(),
                "#microsoft.graph.androidManagedStoreAppConfiguration" => new AndroidManagedStoreAppConfiguration(),
                "#microsoft.graph.iosMobileAppConfiguration" => new IosMobileAppConfiguration(),
                _ => new ManagedDeviceMobileAppConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationAssignment>(ManagedDeviceMobileAppConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>(ManagedDeviceMobileAppConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusSummary", n => { DeviceStatusSummary = n.GetObjectValue<ManagedDeviceMobileAppConfigurationDeviceSummary>(ManagedDeviceMobileAppConfigurationDeviceSummary.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>(ManagedDeviceMobileAppConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusSummary", n => { UserStatusSummary = n.GetObjectValue<ManagedDeviceMobileAppConfigurationUserSummary>(ManagedDeviceMobileAppConfigurationUserSummary.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<ManagedDeviceMobileAppConfigurationDeviceSummary>("deviceStatusSummary", DeviceStatusSummary);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<ManagedDeviceMobileAppConfigurationUserSummary>("userStatusSummary", UserStatusSummary);
            writer.WriteIntValue("version", Version);
        }
    }
}

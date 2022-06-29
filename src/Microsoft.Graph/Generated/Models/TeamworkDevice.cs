using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TeamworkDevice : Entity, IParsable {
        /// <summary>The activity properties that change based on the device usage.</summary>
        public TeamworkDeviceActivity Activity {
            get { return BackingStore?.Get<TeamworkDeviceActivity>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>The activity state of the device. The possible values are: unknown, busy, idle, unavailable, unknownFutureValue.</summary>
        public TeamworkDeviceActivityState? ActivityState {
            get { return BackingStore?.Get<TeamworkDeviceActivityState?>(nameof(ActivityState)); }
            set { BackingStore?.Set(nameof(ActivityState), value); }
        }
        /// <summary>The company asset tag assigned by the admin on the device.</summary>
        public string CompanyAssetTag {
            get { return BackingStore?.Get<string>(nameof(CompanyAssetTag)); }
            set { BackingStore?.Set(nameof(CompanyAssetTag), value); }
        }
        /// <summary>The configuration properties of the device.</summary>
        public TeamworkDeviceConfiguration Configuration {
            get { return BackingStore?.Get<TeamworkDeviceConfiguration>(nameof(Configuration)); }
            set { BackingStore?.Set(nameof(Configuration), value); }
        }
        /// <summary>Identity of the user who enrolled the device to the tenant.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The UTC date and time when the device was enrolled to the tenant.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The signed-in user on the device.</summary>
        public TeamworkUserIdentity CurrentUser {
            get { return BackingStore?.Get<TeamworkUserIdentity>(nameof(CurrentUser)); }
            set { BackingStore?.Set(nameof(CurrentUser), value); }
        }
        /// <summary>The type of device. The possible values are: unknown, ipPhone, teamsRoom, surfaceHub, collaborationBar, teamsDisplay, touchConsole, lowCostPhone, teamsPanel, sip, unknownFutureValue.</summary>
        public TeamworkDeviceType? DeviceType {
            get { return BackingStore?.Get<TeamworkDeviceType?>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>The hardwareDetail property</summary>
        public TeamworkHardwareDetail HardwareDetail {
            get { return BackingStore?.Get<TeamworkHardwareDetail>(nameof(HardwareDetail)); }
            set { BackingStore?.Set(nameof(HardwareDetail), value); }
        }
        /// <summary>The health properties of the device.</summary>
        public TeamworkDeviceHealth Health {
            get { return BackingStore?.Get<TeamworkDeviceHealth>(nameof(Health)); }
            set { BackingStore?.Set(nameof(Health), value); }
        }
        /// <summary>The health status of the device. The possible values are: unknown, offline, critical, nonUrgent, healthy, unknownFutureValue.</summary>
        public TeamworkDeviceHealthStatus? HealthStatus {
            get { return BackingStore?.Get<TeamworkDeviceHealthStatus?>(nameof(HealthStatus)); }
            set { BackingStore?.Set(nameof(HealthStatus), value); }
        }
        /// <summary>Identity of the user who last modified the device details.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The UTC date and time when the device detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The notes added by the admin to the device.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>The async operations on the device.</summary>
        public List<TeamworkDeviceOperation> Operations {
            get { return BackingStore?.Get<List<TeamworkDeviceOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<TeamworkDeviceActivity>(TeamworkDeviceActivity.CreateFromDiscriminatorValue); } },
                {"activityState", n => { ActivityState = n.GetEnumValue<TeamworkDeviceActivityState>(); } },
                {"companyAssetTag", n => { CompanyAssetTag = n.GetStringValue(); } },
                {"configuration", n => { Configuration = n.GetObjectValue<TeamworkDeviceConfiguration>(TeamworkDeviceConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentUser", n => { CurrentUser = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<TeamworkDeviceType>(); } },
                {"hardwareDetail", n => { HardwareDetail = n.GetObjectValue<TeamworkHardwareDetail>(TeamworkHardwareDetail.CreateFromDiscriminatorValue); } },
                {"health", n => { Health = n.GetObjectValue<TeamworkDeviceHealth>(TeamworkDeviceHealth.CreateFromDiscriminatorValue); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<TeamworkDeviceHealthStatus>(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<TeamworkDeviceOperation>(TeamworkDeviceOperation.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkDeviceActivity>("activity", Activity);
            writer.WriteEnumValue<TeamworkDeviceActivityState>("activityState", ActivityState);
            writer.WriteStringValue("companyAssetTag", CompanyAssetTag);
            writer.WriteObjectValue<TeamworkDeviceConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<TeamworkUserIdentity>("currentUser", CurrentUser);
            writer.WriteEnumValue<TeamworkDeviceType>("deviceType", DeviceType);
            writer.WriteObjectValue<TeamworkHardwareDetail>("hardwareDetail", HardwareDetail);
            writer.WriteObjectValue<TeamworkDeviceHealth>("health", Health);
            writer.WriteEnumValue<TeamworkDeviceHealthStatus>("healthStatus", HealthStatus);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notes", Notes);
            writer.WriteCollectionOfObjectValues<TeamworkDeviceOperation>("operations", Operations);
        }
    }
}

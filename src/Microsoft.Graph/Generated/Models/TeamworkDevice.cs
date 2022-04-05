using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDevice : Entity, IParsable {
        /// <summary>The activity properties that change based on the device usage.</summary>
        public TeamworkDeviceActivity Activity { get; set; }
        /// <summary>The activity state of the device. The possible values are: unknown, busy, idle, unavailable, unknownFutureValue.</summary>
        public TeamworkDeviceActivityState? ActivityState { get; set; }
        /// <summary>The company asset tag assigned by the admin on the device.</summary>
        public string CompanyAssetTag { get; set; }
        /// <summary>The configuration properties of the device.</summary>
        public TeamworkDeviceConfiguration Configuration { get; set; }
        /// <summary>Identity of the user who enrolled the device to the tenant.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The UTC date and time when the device was enrolled to the tenant.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The signed-in user on the device.</summary>
        public TeamworkUserIdentity CurrentUser { get; set; }
        /// <summary>The type of device. The possible values are: unknown, ipPhone, teamsRoom, surfaceHub, collaborationBar, teamsDisplay, touchConsole, lowCostPhone, teamsPanel, sip, unknownFutureValue.</summary>
        public TeamworkDeviceType? DeviceType { get; set; }
        /// <summary>The hardwareDetail property</summary>
        public TeamworkHardwareDetail HardwareDetail { get; set; }
        /// <summary>The health properties of the device.</summary>
        public TeamworkDeviceHealth Health { get; set; }
        /// <summary>The health status of the device. The possible values are: unknown, offline, critical, nonUrgent, healthy, unknownFutureValue.</summary>
        public TeamworkDeviceHealthStatus? HealthStatus { get; set; }
        /// <summary>Identity of the user who last modified the device details.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The UTC date and time when the device detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The notes added by the admin to the device.</summary>
        public string Notes { get; set; }
        /// <summary>The async operations on the device.</summary>
        public List<TeamworkDeviceOperation> Operations { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as TeamworkDevice).Activity = n.GetObjectValue<TeamworkDeviceActivity>(TeamworkDeviceActivity.CreateFromDiscriminatorValue); } },
                {"activityState", (o,n) => { (o as TeamworkDevice).ActivityState = n.GetEnumValue<TeamworkDeviceActivityState>(); } },
                {"companyAssetTag", (o,n) => { (o as TeamworkDevice).CompanyAssetTag = n.GetStringValue(); } },
                {"configuration", (o,n) => { (o as TeamworkDevice).Configuration = n.GetObjectValue<TeamworkDeviceConfiguration>(TeamworkDeviceConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", (o,n) => { (o as TeamworkDevice).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as TeamworkDevice).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentUser", (o,n) => { (o as TeamworkDevice).CurrentUser = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
                {"deviceType", (o,n) => { (o as TeamworkDevice).DeviceType = n.GetEnumValue<TeamworkDeviceType>(); } },
                {"hardwareDetail", (o,n) => { (o as TeamworkDevice).HardwareDetail = n.GetObjectValue<TeamworkHardwareDetail>(TeamworkHardwareDetail.CreateFromDiscriminatorValue); } },
                {"health", (o,n) => { (o as TeamworkDevice).Health = n.GetObjectValue<TeamworkDeviceHealth>(TeamworkDeviceHealth.CreateFromDiscriminatorValue); } },
                {"healthStatus", (o,n) => { (o as TeamworkDevice).HealthStatus = n.GetEnumValue<TeamworkDeviceHealthStatus>(); } },
                {"lastModifiedBy", (o,n) => { (o as TeamworkDevice).LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as TeamworkDevice).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", (o,n) => { (o as TeamworkDevice).Notes = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as TeamworkDevice).Operations = n.GetCollectionOfObjectValues<TeamworkDeviceOperation>(TeamworkDeviceOperation.CreateFromDiscriminatorValue).ToList(); } },
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

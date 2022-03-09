using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementPartner : Entity, IParsable {
        /// <summary>Partner display name</summary>
        public string DisplayName { get; set; }
        /// <summary>User groups that specifies whether enrollment is through partner.</summary>
        public List<DeviceManagementPartnerAssignment> GroupsRequiringPartnerEnrollment { get; set; }
        /// <summary>Whether device management partner is configured or not</summary>
        public bool? IsConfigured { get; set; }
        /// <summary>Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>Partner App type. Possible values are: unknown, singleTenantApp, multiTenantApp.</summary>
        public DeviceManagementPartnerAppType? PartnerAppType { get; set; }
        /// <summary>Partner state of this tenant. Possible values are: unknown, unavailable, enabled, terminated, rejected, unresponsive.</summary>
        public DeviceManagementPartnerTenantState? PartnerState { get; set; }
        /// <summary>Partner Single tenant App id</summary>
        public string SingleTenantAppId { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be marked as NonCompliant. This will become obselete soon.</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeMarkedAsNonCompliant { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be marked as NonCompliant</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be removed. This will become obselete soon.</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeRemoved { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be removed</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeRemovedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementPartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementPartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DeviceManagementPartner).DisplayName = n.GetStringValue(); } },
                {"groupsRequiringPartnerEnrollment", (o,n) => { (o as DeviceManagementPartner).GroupsRequiringPartnerEnrollment = n.GetCollectionOfObjectValues<DeviceManagementPartnerAssignment>(DeviceManagementPartnerAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"isConfigured", (o,n) => { (o as DeviceManagementPartner).IsConfigured = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", (o,n) => { (o as DeviceManagementPartner).LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerAppType", (o,n) => { (o as DeviceManagementPartner).PartnerAppType = n.GetEnumValue<DeviceManagementPartnerAppType>(); } },
                {"partnerState", (o,n) => { (o as DeviceManagementPartner).PartnerState = n.GetEnumValue<DeviceManagementPartnerTenantState>(); } },
                {"singleTenantAppId", (o,n) => { (o as DeviceManagementPartner).SingleTenantAppId = n.GetStringValue(); } },
                {"whenPartnerDevicesWillBeMarkedAsNonCompliant", (o,n) => { (o as DeviceManagementPartner).WhenPartnerDevicesWillBeMarkedAsNonCompliant = n.GetDateTimeOffsetValue(); } },
                {"whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime", (o,n) => { (o as DeviceManagementPartner).WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime = n.GetDateTimeOffsetValue(); } },
                {"whenPartnerDevicesWillBeRemoved", (o,n) => { (o as DeviceManagementPartner).WhenPartnerDevicesWillBeRemoved = n.GetDateTimeOffsetValue(); } },
                {"whenPartnerDevicesWillBeRemovedDateTime", (o,n) => { (o as DeviceManagementPartner).WhenPartnerDevicesWillBeRemovedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DeviceManagementPartnerAssignment>("groupsRequiringPartnerEnrollment", GroupsRequiringPartnerEnrollment);
            writer.WriteBoolValue("isConfigured", IsConfigured);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteEnumValue<DeviceManagementPartnerAppType>("partnerAppType", PartnerAppType);
            writer.WriteEnumValue<DeviceManagementPartnerTenantState>("partnerState", PartnerState);
            writer.WriteStringValue("singleTenantAppId", SingleTenantAppId);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeMarkedAsNonCompliant", WhenPartnerDevicesWillBeMarkedAsNonCompliant);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime", WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeRemoved", WhenPartnerDevicesWillBeRemoved);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeRemovedDateTime", WhenPartnerDevicesWillBeRemovedDateTime);
        }
    }
}

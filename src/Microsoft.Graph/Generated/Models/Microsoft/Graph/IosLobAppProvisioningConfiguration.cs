using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class IosLobAppProvisioningConfiguration : Entity, IParsable {
        /// <summary>The associated group assignments for IosLobAppProvisioningConfiguration.</summary>
        public List<IosLobAppProvisioningConfigurationAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>The list of device installation states for this mobile app configuration.</summary>
        public List<ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>Optional profile expiration date and time.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The associated group assignments.</summary>
        public List<MobileAppProvisioningConfigGroupAssignment> GroupAssignments { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
        public byte[] Payload { get; set; }
        /// <summary>Payload file name (.mobileprovision</summary>
        public string PayloadFileName { get; set; }
        /// <summary>List of Scope Tags for this iOS LOB app provisioning configuration entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The list of user installation states for this mobile app configuration.</summary>
        public List<ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosLobAppProvisioningConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosLobAppProvisioningConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as IosLobAppProvisioningConfiguration).Assignments = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>(IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as IosLobAppProvisioningConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as IosLobAppProvisioningConfiguration).Description = n.GetStringValue(); } },
                {"deviceStatuses", (o,n) => { (o as IosLobAppProvisioningConfiguration).DeviceStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>(ManagedDeviceMobileAppConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as IosLobAppProvisioningConfiguration).DisplayName = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as IosLobAppProvisioningConfiguration).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupAssignments", (o,n) => { (o as IosLobAppProvisioningConfiguration).GroupAssignments = n.GetCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>(MobileAppProvisioningConfigGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as IosLobAppProvisioningConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payload", (o,n) => { (o as IosLobAppProvisioningConfiguration).Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", (o,n) => { (o as IosLobAppProvisioningConfiguration).PayloadFileName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as IosLobAppProvisioningConfiguration).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userStatuses", (o,n) => { (o as IosLobAppProvisioningConfiguration).UserStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>(ManagedDeviceMobileAppConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"version", (o,n) => { (o as IosLobAppProvisioningConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteIntValue("version", Version);
        }
    }
}

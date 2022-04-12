using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsDriverUpdateProfile : Entity, IParsable {
        /// <summary>Driver update profile approval type. For example, manual or automatic approval. Possible values are: manual, automatic.</summary>
        public DriverUpdateProfileApprovalType? ApprovalType { get; set; }
        /// <summary>The list of group assignments of the profile.</summary>
        public List<WindowsDriverUpdateProfileAssignment> Assignments { get; set; }
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Deployment deferral settings in days, only applicable when ApprovalType is set to automatic approval.</summary>
        public int? DeploymentDeferralInDays { get; set; }
        /// <summary>The description of the profile which is specified by the user.</summary>
        public string Description { get; set; }
        /// <summary>Number of devices reporting for this profile</summary>
        public int? DeviceReporting { get; set; }
        /// <summary>The display name for the profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>Driver inventories for this profile.</summary>
        public List<WindowsDriverUpdateInventory> DriverInventories { get; set; }
        /// <summary>Driver inventory sync status for this profile.</summary>
        public WindowsDriverUpdateProfileInventorySyncStatus InventorySyncStatus { get; set; }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Number of new driver updates available for this profile.</summary>
        public int? NewUpdates { get; set; }
        /// <summary>List of Scope Tags for this Driver Update entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDriverUpdateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalType", n => { ApprovalType = n.GetEnumValue<DriverUpdateProfileApprovalType>(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<WindowsDriverUpdateProfileAssignment>(WindowsDriverUpdateProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentDeferralInDays", n => { DeploymentDeferralInDays = n.GetIntValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceReporting", n => { DeviceReporting = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"driverInventories", n => { DriverInventories = n.GetCollectionOfObjectValues<WindowsDriverUpdateInventory>(WindowsDriverUpdateInventory.CreateFromDiscriminatorValue).ToList(); } },
                {"inventorySyncStatus", n => { InventorySyncStatus = n.GetObjectValue<WindowsDriverUpdateProfileInventorySyncStatus>(WindowsDriverUpdateProfileInventorySyncStatus.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"newUpdates", n => { NewUpdates = n.GetIntValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DriverUpdateProfileApprovalType>("approvalType", ApprovalType);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("deploymentDeferralInDays", DeploymentDeferralInDays);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("deviceReporting", DeviceReporting);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateInventory>("driverInventories", DriverInventories);
            writer.WriteObjectValue<WindowsDriverUpdateProfileInventorySyncStatus>("inventorySyncStatus", InventorySyncStatus);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("newUpdates", NewUpdates);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}

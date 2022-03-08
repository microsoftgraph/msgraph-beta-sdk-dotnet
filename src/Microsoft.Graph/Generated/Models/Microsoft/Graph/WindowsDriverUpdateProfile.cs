using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"approvalType", (o,n) => { (o as WindowsDriverUpdateProfile).ApprovalType = n.GetEnumValue<DriverUpdateProfileApprovalType>(); } },
                {"assignments", (o,n) => { (o as WindowsDriverUpdateProfile).Assignments = n.GetCollectionOfObjectValues<WindowsDriverUpdateProfileAssignment>(WindowsDriverUpdateProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as WindowsDriverUpdateProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentDeferralInDays", (o,n) => { (o as WindowsDriverUpdateProfile).DeploymentDeferralInDays = n.GetIntValue(); } },
                {"description", (o,n) => { (o as WindowsDriverUpdateProfile).Description = n.GetStringValue(); } },
                {"deviceReporting", (o,n) => { (o as WindowsDriverUpdateProfile).DeviceReporting = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as WindowsDriverUpdateProfile).DisplayName = n.GetStringValue(); } },
                {"driverInventories", (o,n) => { (o as WindowsDriverUpdateProfile).DriverInventories = n.GetCollectionOfObjectValues<WindowsDriverUpdateInventory>(WindowsDriverUpdateInventory.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as WindowsDriverUpdateProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"newUpdates", (o,n) => { (o as WindowsDriverUpdateProfile).NewUpdates = n.GetIntValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as WindowsDriverUpdateProfile).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("newUpdates", NewUpdates);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}

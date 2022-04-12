using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementIntent : Entity, IParsable {
        /// <summary>Collection of assignments</summary>
        public List<DeviceManagementIntentAssignment> Assignments { get; set; }
        /// <summary>Collection of setting categories within the intent</summary>
        public List<DeviceManagementIntentSettingCategory> Categories { get; set; }
        /// <summary>The user given description</summary>
        public string Description { get; set; }
        /// <summary>Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent</summary>
        public List<DeviceManagementIntentDeviceSettingStateSummary> DeviceSettingStateSummaries { get; set; }
        /// <summary>Collection of states of all devices that the intent is applied to</summary>
        public List<DeviceManagementIntentDeviceState> DeviceStates { get; set; }
        /// <summary>A summary of device states and counts of devices that belong to corresponding state for all devices that the intent is applied to</summary>
        public DeviceManagementIntentDeviceStateSummary DeviceStateSummary { get; set; }
        /// <summary>The user given display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Signifies whether or not the intent is assigned to users</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>When the intent was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Collection of all settings to be applied</summary>
        public List<DeviceManagementSettingInstance> Settings { get; set; }
        /// <summary>The ID of the template this intent was created from (if any)</summary>
        public string TemplateId { get; set; }
        /// <summary>Collection of states of all users that the intent is applied to</summary>
        public List<DeviceManagementIntentUserState> UserStates { get; set; }
        /// <summary>A summary of user states and counts of users that belong to corresponding state for all users that the intent is applied to</summary>
        public DeviceManagementIntentUserStateSummary UserStateSummary { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementIntent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementIntentAssignment>(DeviceManagementIntentAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<DeviceManagementIntentSettingCategory>(DeviceManagementIntentSettingCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceSettingStateSummary>(DeviceManagementIntentDeviceSettingStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceState>(DeviceManagementIntentDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStateSummary", n => { DeviceStateSummary = n.GetObjectValue<DeviceManagementIntentDeviceStateSummary>(DeviceManagementIntentDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"userStates", n => { UserStates = n.GetCollectionOfObjectValues<DeviceManagementIntentUserState>(DeviceManagementIntentUserState.CreateFromDiscriminatorValue).ToList(); } },
                {"userStateSummary", n => { UserStateSummary = n.GetObjectValue<DeviceManagementIntentUserStateSummary>(DeviceManagementIntentUserStateSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntentAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntentSettingCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntentDeviceSettingStateSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntentDeviceState>("deviceStates", DeviceStates);
            writer.WriteObjectValue<DeviceManagementIntentDeviceStateSummary>("deviceStateSummary", DeviceStateSummary);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("settings", Settings);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntentUserState>("userStates", UserStates);
            writer.WriteObjectValue<DeviceManagementIntentUserStateSummary>("userStateSummary", UserStateSummary);
        }
    }
}

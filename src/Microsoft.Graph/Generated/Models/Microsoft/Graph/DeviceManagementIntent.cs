using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceManagementIntent).Assignments = n.GetCollectionOfObjectValues<DeviceManagementIntentAssignment>().ToList(); } },
                {"categories", (o,n) => { (o as DeviceManagementIntent).Categories = n.GetCollectionOfObjectValues<DeviceManagementIntentSettingCategory>().ToList(); } },
                {"description", (o,n) => { (o as DeviceManagementIntent).Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", (o,n) => { (o as DeviceManagementIntent).DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceSettingStateSummary>().ToList(); } },
                {"deviceStates", (o,n) => { (o as DeviceManagementIntent).DeviceStates = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceState>().ToList(); } },
                {"deviceStateSummary", (o,n) => { (o as DeviceManagementIntent).DeviceStateSummary = n.GetObjectValue<DeviceManagementIntentDeviceStateSummary>(); } },
                {"displayName", (o,n) => { (o as DeviceManagementIntent).DisplayName = n.GetStringValue(); } },
                {"isAssigned", (o,n) => { (o as DeviceManagementIntent).IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceManagementIntent).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceManagementIntent).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"settings", (o,n) => { (o as DeviceManagementIntent).Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>().ToList(); } },
                {"templateId", (o,n) => { (o as DeviceManagementIntent).TemplateId = n.GetStringValue(); } },
                {"userStates", (o,n) => { (o as DeviceManagementIntent).UserStates = n.GetCollectionOfObjectValues<DeviceManagementIntentUserState>().ToList(); } },
                {"userStateSummary", (o,n) => { (o as DeviceManagementIntent).UserStateSummary = n.GetObjectValue<DeviceManagementIntentUserStateSummary>(); } },
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

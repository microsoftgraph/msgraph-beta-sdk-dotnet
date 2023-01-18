using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents an intent to apply settings to a device
    /// </summary>
    public class DeviceManagementIntent : Entity, IParsable {
        /// <summary>Collection of assignments</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementIntentAssignment>? Assignments {
            get { return BackingStore?.Get<List<DeviceManagementIntentAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#else
        public List<DeviceManagementIntentAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceManagementIntentAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Collection of setting categories within the intent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementIntentSettingCategory>? Categories {
            get { return BackingStore?.Get<List<DeviceManagementIntentSettingCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#else
        public List<DeviceManagementIntentSettingCategory> Categories {
            get { return BackingStore?.Get<List<DeviceManagementIntentSettingCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The user given description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementIntentDeviceSettingStateSummary>? DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceManagementIntentDeviceSettingStateSummary>?>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#else
        public List<DeviceManagementIntentDeviceSettingStateSummary> DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceManagementIntentDeviceSettingStateSummary>>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#endif
        /// <summary>Collection of states of all devices that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementIntentDeviceState>? DeviceStates {
            get { return BackingStore?.Get<List<DeviceManagementIntentDeviceState>?>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#else
        public List<DeviceManagementIntentDeviceState> DeviceStates {
            get { return BackingStore?.Get<List<DeviceManagementIntentDeviceState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#endif
        /// <summary>A summary of device states and counts of devices that belong to corresponding state for all devices that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementIntentDeviceStateSummary? DeviceStateSummary {
            get { return BackingStore?.Get<DeviceManagementIntentDeviceStateSummary?>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#else
        public DeviceManagementIntentDeviceStateSummary DeviceStateSummary {
            get { return BackingStore?.Get<DeviceManagementIntentDeviceStateSummary>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#endif
        /// <summary>The user given display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Signifies whether or not the intent is assigned to users</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>When the intent was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Collection of all settings to be applied</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementSettingInstance>? Settings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#else
        public List<DeviceManagementSettingInstance> Settings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The ID of the template this intent was created from (if any)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TemplateId {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#else
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>Collection of states of all users that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementIntentUserState>? UserStates {
            get { return BackingStore?.Get<List<DeviceManagementIntentUserState>?>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#else
        public List<DeviceManagementIntentUserState> UserStates {
            get { return BackingStore?.Get<List<DeviceManagementIntentUserState>>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#endif
        /// <summary>A summary of user states and counts of users that belong to corresponding state for all users that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementIntentUserStateSummary? UserStateSummary {
            get { return BackingStore?.Get<DeviceManagementIntentUserStateSummary?>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#else
        public DeviceManagementIntentUserStateSummary UserStateSummary {
            get { return BackingStore?.Get<DeviceManagementIntentUserStateSummary>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementIntent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementIntentAssignment>(DeviceManagementIntentAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<DeviceManagementIntentSettingCategory>(DeviceManagementIntentSettingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceSettingStateSummary>(DeviceManagementIntentDeviceSettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<DeviceManagementIntentDeviceState>(DeviceManagementIntentDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStateSummary", n => { DeviceStateSummary = n.GetObjectValue<DeviceManagementIntentDeviceStateSummary>(DeviceManagementIntentDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"userStates", n => { UserStates = n.GetCollectionOfObjectValues<DeviceManagementIntentUserState>(DeviceManagementIntentUserState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userStateSummary", n => { UserStateSummary = n.GetObjectValue<DeviceManagementIntentUserStateSummary>(DeviceManagementIntentUserStateSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

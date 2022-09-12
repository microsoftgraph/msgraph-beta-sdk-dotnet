using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Violation of restricted apps configuration profile per device per user</summary>
    public class RestrictedAppsViolation : Entity, IParsable {
        /// <summary>Device configuration profile unique identifier, must be Guid</summary>
        public string DeviceConfigurationId {
            get { return BackingStore?.Get<string>("deviceConfigurationId"); }
            set { BackingStore?.Set("deviceConfigurationId", value); }
        }
        /// <summary>Device configuration profile name</summary>
        public string DeviceConfigurationName {
            get { return BackingStore?.Get<string>("deviceConfigurationName"); }
            set { BackingStore?.Set("deviceConfigurationName", value); }
        }
        /// <summary>Device name</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>Managed device unique identifier, must be Guid</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>Supported platform types for policies.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>List of violated restricted apps</summary>
        public List<ManagedDeviceReportedApp> RestrictedApps {
            get { return BackingStore?.Get<List<ManagedDeviceReportedApp>>("restrictedApps"); }
            set { BackingStore?.Set("restrictedApps", value); }
        }
        /// <summary>Restricted apps state</summary>
        public Microsoft.Graph.Beta.Models.RestrictedAppsState? RestrictedAppsState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RestrictedAppsState?>("restrictedAppsState"); }
            set { BackingStore?.Set("restrictedAppsState", value); }
        }
        /// <summary>User unique identifier, must be Guid</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>User name</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>
        /// Instantiates a new restrictedAppsViolation and sets the default values.
        /// </summary>
        public RestrictedAppsViolation() : base() {
            OdataType = "#microsoft.graph.restrictedAppsViolation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RestrictedAppsViolation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RestrictedAppsViolation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceConfigurationId", n => { DeviceConfigurationId = n.GetStringValue(); } },
                {"deviceConfigurationName", n => { DeviceConfigurationName = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"restrictedApps", n => { RestrictedApps = n.GetCollectionOfObjectValues<ManagedDeviceReportedApp>(ManagedDeviceReportedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"restrictedAppsState", n => { RestrictedAppsState = n.GetEnumValue<RestrictedAppsState>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceConfigurationId", DeviceConfigurationId);
            writer.WriteStringValue("deviceConfigurationName", DeviceConfigurationName);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteCollectionOfObjectValues<ManagedDeviceReportedApp>("restrictedApps", RestrictedApps);
            writer.WriteEnumValue<RestrictedAppsState>("restrictedAppsState", RestrictedAppsState);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RestrictedAppsViolation : Entity, IParsable {
        /// <summary>Device configuration profile unique identifier, must be Guid</summary>
        public string DeviceConfigurationId { get; set; }
        /// <summary>Device configuration profile name</summary>
        public string DeviceConfigurationName { get; set; }
        /// <summary>Device name</summary>
        public string DeviceName { get; set; }
        /// <summary>Managed device unique identifier, must be Guid</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Platform type. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, androidAOSP, all.</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>List of violated restricted apps</summary>
        public List<ManagedDeviceReportedApp> RestrictedApps { get; set; }
        /// <summary>Restricted apps state. Possible values are: prohibitedApps, notApprovedApps.</summary>
        public Microsoft.Graph.Beta.Models.RestrictedAppsState? RestrictedAppsState { get; set; }
        /// <summary>User unique identifier, must be Guid</summary>
        public string UserId { get; set; }
        /// <summary>User name</summary>
        public string UserName { get; set; }
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
                {"restrictedApps", n => { RestrictedApps = n.GetCollectionOfObjectValues<ManagedDeviceReportedApp>(ManagedDeviceReportedApp.CreateFromDiscriminatorValue).ToList(); } },
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

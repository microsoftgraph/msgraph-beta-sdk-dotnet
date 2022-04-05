using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics Work From Anywhere metrics devices summary.</summary>
    public class UserExperienceAnalyticsWorkFromAnywhereDevicesSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value of work from anywhere autopilot devices summary.</summary>
        public UserExperienceAnalyticsAutopilotDevicesSummary AutopilotDevicesSummary { get; set; }
        /// <summary>The user experience analytics work from anywhere Cloud Identity devices summary.</summary>
        public UserExperienceAnalyticsCloudIdentityDevicesSummary CloudIdentityDevicesSummary { get; set; }
        /// <summary>The user experience work from anywhere Cloud management devices summary.</summary>
        public UserExperienceAnalyticsCloudManagementDevicesSummary CloudManagementDevicesSummary { get; set; }
        /// <summary>Total number of co-managed devices. Valid values -2147483648 to 2147483647</summary>
        public int? CoManagedDevices { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesNotAutopilotRegistered { get; set; }
        /// <summary>The count of intune devices not autopilot profile assigned. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutAutopilotProfileAssigned { get; set; }
        /// <summary>The count of devices that are not cloud identity. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutCloudIdentity { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Valid values -2147483648 to 2147483647</summary>
        public int? IntuneDevices { get; set; }
        /// <summary>Total count of tenant attach devices. Valid values -2147483648 to 2147483647</summary>
        public int? TenantAttachDevices { get; set; }
        /// <summary>The total count of devices. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDevices { get; set; }
        /// <summary>The count of Windows 10 devices that have unsupported OS versions. Valid values -2147483648 to 2147483647</summary>
        public int? UnsupportedOSversionDevices { get; set; }
        /// <summary>The count of windows 10 devices. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10Devices { get; set; }
        /// <summary>The user experience analytics work from anywhere Windows 10 devices summary.</summary>
        public UserExperienceAnalyticsWindows10DevicesSummary Windows10DevicesSummary { get; set; }
        /// <summary>The count of windows 10 devices that are Intune and Comanaged. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10DevicesWithoutTenantAttach { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsWorkFromAnywhereDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsWorkFromAnywhereDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsWorkFromAnywhereDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"autopilotDevicesSummary", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).AutopilotDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsAutopilotDevicesSummary>(UserExperienceAnalyticsAutopilotDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudIdentityDevicesSummary", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).CloudIdentityDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudIdentityDevicesSummary>(UserExperienceAnalyticsCloudIdentityDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudManagementDevicesSummary", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).CloudManagementDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudManagementDevicesSummary>(UserExperienceAnalyticsCloudManagementDevicesSummary.CreateFromDiscriminatorValue); } },
                {"coManagedDevices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).CoManagedDevices = n.GetIntValue(); } },
                {"devicesNotAutopilotRegistered", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).DevicesNotAutopilotRegistered = n.GetIntValue(); } },
                {"devicesWithoutAutopilotProfileAssigned", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).DevicesWithoutAutopilotProfileAssigned = n.GetIntValue(); } },
                {"devicesWithoutCloudIdentity", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).DevicesWithoutCloudIdentity = n.GetIntValue(); } },
                {"intuneDevices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).IntuneDevices = n.GetIntValue(); } },
                {"tenantAttachDevices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).TenantAttachDevices = n.GetIntValue(); } },
                {"totalDevices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).TotalDevices = n.GetIntValue(); } },
                {"unsupportedOSversionDevices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).UnsupportedOSversionDevices = n.GetIntValue(); } },
                {"windows10Devices", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).Windows10Devices = n.GetIntValue(); } },
                {"windows10DevicesSummary", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).Windows10DevicesSummary = n.GetObjectValue<UserExperienceAnalyticsWindows10DevicesSummary>(UserExperienceAnalyticsWindows10DevicesSummary.CreateFromDiscriminatorValue); } },
                {"windows10DevicesWithoutTenantAttach", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevicesSummary).Windows10DevicesWithoutTenantAttach = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserExperienceAnalyticsAutopilotDevicesSummary>("autopilotDevicesSummary", AutopilotDevicesSummary);
            writer.WriteObjectValue<UserExperienceAnalyticsCloudIdentityDevicesSummary>("cloudIdentityDevicesSummary", CloudIdentityDevicesSummary);
            writer.WriteObjectValue<UserExperienceAnalyticsCloudManagementDevicesSummary>("cloudManagementDevicesSummary", CloudManagementDevicesSummary);
            writer.WriteIntValue("coManagedDevices", CoManagedDevices);
            writer.WriteIntValue("devicesNotAutopilotRegistered", DevicesNotAutopilotRegistered);
            writer.WriteIntValue("devicesWithoutAutopilotProfileAssigned", DevicesWithoutAutopilotProfileAssigned);
            writer.WriteIntValue("devicesWithoutCloudIdentity", DevicesWithoutCloudIdentity);
            writer.WriteIntValue("intuneDevices", IntuneDevices);
            writer.WriteIntValue("tenantAttachDevices", TenantAttachDevices);
            writer.WriteIntValue("totalDevices", TotalDevices);
            writer.WriteIntValue("unsupportedOSversionDevices", UnsupportedOSversionDevices);
            writer.WriteIntValue("windows10Devices", Windows10Devices);
            writer.WriteObjectValue<UserExperienceAnalyticsWindows10DevicesSummary>("windows10DevicesSummary", Windows10DevicesSummary);
            writer.WriteIntValue("windows10DevicesWithoutTenantAttach", Windows10DevicesWithoutTenantAttach);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

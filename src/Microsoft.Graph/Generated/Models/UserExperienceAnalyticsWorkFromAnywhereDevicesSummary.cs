using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics Work From Anywhere metrics devices summary.</summary>
    public class UserExperienceAnalyticsWorkFromAnywhereDevicesSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The value of work from anywhere autopilot devices summary.</summary>
        public UserExperienceAnalyticsAutopilotDevicesSummary AutopilotDevicesSummary {
            get { return BackingStore?.Get<UserExperienceAnalyticsAutopilotDevicesSummary>("autopilotDevicesSummary"); }
            set { BackingStore?.Set("autopilotDevicesSummary", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The user experience analytics work from anywhere Cloud Identity devices summary.</summary>
        public UserExperienceAnalyticsCloudIdentityDevicesSummary CloudIdentityDevicesSummary {
            get { return BackingStore?.Get<UserExperienceAnalyticsCloudIdentityDevicesSummary>("cloudIdentityDevicesSummary"); }
            set { BackingStore?.Set("cloudIdentityDevicesSummary", value); }
        }
        /// <summary>The user experience work from anywhere Cloud management devices summary.</summary>
        public UserExperienceAnalyticsCloudManagementDevicesSummary CloudManagementDevicesSummary {
            get { return BackingStore?.Get<UserExperienceAnalyticsCloudManagementDevicesSummary>("cloudManagementDevicesSummary"); }
            set { BackingStore?.Set("cloudManagementDevicesSummary", value); }
        }
        /// <summary>Total number of co-managed devices. Valid values -2147483648 to 2147483647</summary>
        public int? CoManagedDevices {
            get { return BackingStore?.Get<int?>("coManagedDevices"); }
            set { BackingStore?.Set("coManagedDevices", value); }
        }
        /// <summary>The count of intune devices that are not autopilot registerd. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesNotAutopilotRegistered {
            get { return BackingStore?.Get<int?>("devicesNotAutopilotRegistered"); }
            set { BackingStore?.Set("devicesNotAutopilotRegistered", value); }
        }
        /// <summary>The count of intune devices not autopilot profile assigned. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutAutopilotProfileAssigned {
            get { return BackingStore?.Get<int?>("devicesWithoutAutopilotProfileAssigned"); }
            set { BackingStore?.Set("devicesWithoutAutopilotProfileAssigned", value); }
        }
        /// <summary>The count of devices that are not cloud identity. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutCloudIdentity {
            get { return BackingStore?.Get<int?>("devicesWithoutCloudIdentity"); }
            set { BackingStore?.Set("devicesWithoutCloudIdentity", value); }
        }
        /// <summary>The count of intune devices that are not autopilot registerd. Valid values -2147483648 to 2147483647</summary>
        public int? IntuneDevices {
            get { return BackingStore?.Get<int?>("intuneDevices"); }
            set { BackingStore?.Set("intuneDevices", value); }
        }
        /// <summary>Total count of tenant attach devices. Valid values -2147483648 to 2147483647</summary>
        public int? TenantAttachDevices {
            get { return BackingStore?.Get<int?>("tenantAttachDevices"); }
            set { BackingStore?.Set("tenantAttachDevices", value); }
        }
        /// <summary>The total count of devices. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDevices {
            get { return BackingStore?.Get<int?>("totalDevices"); }
            set { BackingStore?.Set("totalDevices", value); }
        }
        /// <summary>The count of Windows 10 devices that have unsupported OS versions. Valid values -2147483648 to 2147483647</summary>
        public int? UnsupportedOSversionDevices {
            get { return BackingStore?.Get<int?>("unsupportedOSversionDevices"); }
            set { BackingStore?.Set("unsupportedOSversionDevices", value); }
        }
        /// <summary>The count of windows 10 devices. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10Devices {
            get { return BackingStore?.Get<int?>("windows10Devices"); }
            set { BackingStore?.Set("windows10Devices", value); }
        }
        /// <summary>The user experience analytics work from anywhere Windows 10 devices summary.</summary>
        public UserExperienceAnalyticsWindows10DevicesSummary Windows10DevicesSummary {
            get { return BackingStore?.Get<UserExperienceAnalyticsWindows10DevicesSummary>("windows10DevicesSummary"); }
            set { BackingStore?.Set("windows10DevicesSummary", value); }
        }
        /// <summary>The count of windows 10 devices that are Intune and Comanaged. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10DevicesWithoutTenantAttach {
            get { return BackingStore?.Get<int?>("windows10DevicesWithoutTenantAttach"); }
            set { BackingStore?.Set("windows10DevicesWithoutTenantAttach", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsWorkFromAnywhereDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsWorkFromAnywhereDevicesSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"autopilotDevicesSummary", n => { AutopilotDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsAutopilotDevicesSummary>(UserExperienceAnalyticsAutopilotDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudIdentityDevicesSummary", n => { CloudIdentityDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudIdentityDevicesSummary>(UserExperienceAnalyticsCloudIdentityDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudManagementDevicesSummary", n => { CloudManagementDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudManagementDevicesSummary>(UserExperienceAnalyticsCloudManagementDevicesSummary.CreateFromDiscriminatorValue); } },
                {"coManagedDevices", n => { CoManagedDevices = n.GetIntValue(); } },
                {"devicesNotAutopilotRegistered", n => { DevicesNotAutopilotRegistered = n.GetIntValue(); } },
                {"devicesWithoutAutopilotProfileAssigned", n => { DevicesWithoutAutopilotProfileAssigned = n.GetIntValue(); } },
                {"devicesWithoutCloudIdentity", n => { DevicesWithoutCloudIdentity = n.GetIntValue(); } },
                {"intuneDevices", n => { IntuneDevices = n.GetIntValue(); } },
                {"tenantAttachDevices", n => { TenantAttachDevices = n.GetIntValue(); } },
                {"totalDevices", n => { TotalDevices = n.GetIntValue(); } },
                {"unsupportedOSversionDevices", n => { UnsupportedOSversionDevices = n.GetIntValue(); } },
                {"windows10Devices", n => { Windows10Devices = n.GetIntValue(); } },
                {"windows10DevicesSummary", n => { Windows10DevicesSummary = n.GetObjectValue<UserExperienceAnalyticsWindows10DevicesSummary>(UserExperienceAnalyticsWindows10DevicesSummary.CreateFromDiscriminatorValue); } },
                {"windows10DevicesWithoutTenantAttach", n => { Windows10DevicesWithoutTenantAttach = n.GetIntValue(); } },
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

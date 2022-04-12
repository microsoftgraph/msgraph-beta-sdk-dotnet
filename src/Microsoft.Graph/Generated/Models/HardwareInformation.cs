using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Hardware information of a given device.</summary>
    public class HardwareInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of charge cycles the device’s current battery has gone through. Valid values 0 to 2147483647</summary>
        public int? BatteryChargeCycles { get; set; }
        /// <summary>The device’s current battery’s health percentage. Valid values 0 to 100</summary>
        public int? BatteryHealthPercentage { get; set; }
        /// <summary>The serial number of the device’s current battery</summary>
        public string BatterySerialNumber { get; set; }
        /// <summary>Cellular technology of the device</summary>
        public string CellularTechnology { get; set; }
        /// <summary>Returns the fully qualified domain name of the device (if any). If the device is not domain-joined, it returns an empty string.</summary>
        public string DeviceFullQualifiedDomainName { get; set; }
        /// <summary>Local System Authority (LSA) credential guard status. . Possible values are: running, rebootRequired, notLicensed, notConfigured, virtualizationBasedSecurityNotRunning.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardLocalSystemAuthorityCredentialGuardState? DeviceGuardLocalSystemAuthorityCredentialGuardState { get; set; }
        /// <summary>Virtualization-based security hardware requirement status. Possible values are: meetHardwareRequirements, secureBootRequired, dmaProtectionRequired, hyperVNotSupportedForGuestVM, hyperVNotAvailable.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityHardwareRequirementState? DeviceGuardVirtualizationBasedSecurityHardwareRequirementState { get; set; }
        /// <summary>Virtualization-based security status. . Possible values are: running, rebootRequired, require64BitArchitecture, notLicensed, notConfigured, doesNotMeetHardwareRequirements, other.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityState? DeviceGuardVirtualizationBasedSecurityState { get; set; }
        /// <summary>eSIM identifier</summary>
        public string EsimIdentifier { get; set; }
        /// <summary>Free storage space of the device.</summary>
        public long? FreeStorageSpace { get; set; }
        /// <summary>IMEI</summary>
        public string Imei { get; set; }
        /// <summary>IPAddressV4</summary>
        public string IpAddressV4 { get; set; }
        /// <summary>Encryption status of the device</summary>
        public bool? IsEncrypted { get; set; }
        /// <summary>Shared iPad</summary>
        public bool? IsSharedDevice { get; set; }
        /// <summary>Supervised mode of the device</summary>
        public bool? IsSupervised { get; set; }
        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer { get; set; }
        /// <summary>MEID</summary>
        public string Meid { get; set; }
        /// <summary>Model of the device</summary>
        public string Model { get; set; }
        /// <summary>String that specifies the OS edition.</summary>
        public string OperatingSystemEdition { get; set; }
        /// <summary>Operating system language of the device</summary>
        public string OperatingSystemLanguage { get; set; }
        /// <summary>Int that specifies the Windows Operating System ProductType. More details here https://go.microsoft.com/fwlink/?linkid=2126950. Valid values 0 to 2147483647</summary>
        public int? OperatingSystemProductType { get; set; }
        /// <summary>Operating System Build Number on Android device</summary>
        public string OsBuildNumber { get; set; }
        /// <summary>Phone number of the device</summary>
        public string PhoneNumber { get; set; }
        /// <summary>Serial number.</summary>
        public string SerialNumber { get; set; }
        /// <summary>All users on the shared Apple device</summary>
        public List<SharedAppleDeviceUser> SharedDeviceCachedUsers { get; set; }
        /// <summary>SubnetAddress</summary>
        public string SubnetAddress { get; set; }
        /// <summary>Subscriber carrier of the device</summary>
        public string SubscriberCarrier { get; set; }
        /// <summary>BIOS version as reported by SMBIOS</summary>
        public string SystemManagementBIOSVersion { get; set; }
        /// <summary>Total storage space of the device.</summary>
        public long? TotalStorageSpace { get; set; }
        /// <summary>The identifying information that uniquely names the TPM manufacturer</summary>
        public string TpmManufacturer { get; set; }
        /// <summary>String that specifies the specification version.</summary>
        public string TpmSpecificationVersion { get; set; }
        /// <summary>The version of the TPM, as specified by the manufacturer</summary>
        public string TpmVersion { get; set; }
        /// <summary>WiFi MAC address of the device</summary>
        public string WifiMac { get; set; }
        /// <summary>
        /// Instantiates a new hardwareInformation and sets the default values.
        /// </summary>
        public HardwareInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HardwareInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HardwareInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"batteryChargeCycles", n => { BatteryChargeCycles = n.GetIntValue(); } },
                {"batteryHealthPercentage", n => { BatteryHealthPercentage = n.GetIntValue(); } },
                {"batterySerialNumber", n => { BatterySerialNumber = n.GetStringValue(); } },
                {"cellularTechnology", n => { CellularTechnology = n.GetStringValue(); } },
                {"deviceFullQualifiedDomainName", n => { DeviceFullQualifiedDomainName = n.GetStringValue(); } },
                {"deviceGuardLocalSystemAuthorityCredentialGuardState", n => { DeviceGuardLocalSystemAuthorityCredentialGuardState = n.GetEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardState>(); } },
                {"deviceGuardVirtualizationBasedSecurityHardwareRequirementState", n => { DeviceGuardVirtualizationBasedSecurityHardwareRequirementState = n.GetEnumValue<DeviceGuardVirtualizationBasedSecurityHardwareRequirementState>(); } },
                {"deviceGuardVirtualizationBasedSecurityState", n => { DeviceGuardVirtualizationBasedSecurityState = n.GetEnumValue<DeviceGuardVirtualizationBasedSecurityState>(); } },
                {"esimIdentifier", n => { EsimIdentifier = n.GetStringValue(); } },
                {"freeStorageSpace", n => { FreeStorageSpace = n.GetLongValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"ipAddressV4", n => { IpAddressV4 = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSharedDevice", n => { IsSharedDevice = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"operatingSystemEdition", n => { OperatingSystemEdition = n.GetStringValue(); } },
                {"operatingSystemLanguage", n => { OperatingSystemLanguage = n.GetStringValue(); } },
                {"operatingSystemProductType", n => { OperatingSystemProductType = n.GetIntValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"sharedDeviceCachedUsers", n => { SharedDeviceCachedUsers = n.GetCollectionOfObjectValues<SharedAppleDeviceUser>(SharedAppleDeviceUser.CreateFromDiscriminatorValue).ToList(); } },
                {"subnetAddress", n => { SubnetAddress = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"systemManagementBIOSVersion", n => { SystemManagementBIOSVersion = n.GetStringValue(); } },
                {"totalStorageSpace", n => { TotalStorageSpace = n.GetLongValue(); } },
                {"tpmManufacturer", n => { TpmManufacturer = n.GetStringValue(); } },
                {"tpmSpecificationVersion", n => { TpmSpecificationVersion = n.GetStringValue(); } },
                {"tpmVersion", n => { TpmVersion = n.GetStringValue(); } },
                {"wifiMac", n => { WifiMac = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("batteryChargeCycles", BatteryChargeCycles);
            writer.WriteIntValue("batteryHealthPercentage", BatteryHealthPercentage);
            writer.WriteStringValue("batterySerialNumber", BatterySerialNumber);
            writer.WriteStringValue("cellularTechnology", CellularTechnology);
            writer.WriteStringValue("deviceFullQualifiedDomainName", DeviceFullQualifiedDomainName);
            writer.WriteEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardState>("deviceGuardLocalSystemAuthorityCredentialGuardState", DeviceGuardLocalSystemAuthorityCredentialGuardState);
            writer.WriteEnumValue<DeviceGuardVirtualizationBasedSecurityHardwareRequirementState>("deviceGuardVirtualizationBasedSecurityHardwareRequirementState", DeviceGuardVirtualizationBasedSecurityHardwareRequirementState);
            writer.WriteEnumValue<DeviceGuardVirtualizationBasedSecurityState>("deviceGuardVirtualizationBasedSecurityState", DeviceGuardVirtualizationBasedSecurityState);
            writer.WriteStringValue("esimIdentifier", EsimIdentifier);
            writer.WriteLongValue("freeStorageSpace", FreeStorageSpace);
            writer.WriteStringValue("imei", Imei);
            writer.WriteStringValue("ipAddressV4", IpAddressV4);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isSharedDevice", IsSharedDevice);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("meid", Meid);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("operatingSystemEdition", OperatingSystemEdition);
            writer.WriteStringValue("operatingSystemLanguage", OperatingSystemLanguage);
            writer.WriteIntValue("operatingSystemProductType", OperatingSystemProductType);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteCollectionOfObjectValues<SharedAppleDeviceUser>("sharedDeviceCachedUsers", SharedDeviceCachedUsers);
            writer.WriteStringValue("subnetAddress", SubnetAddress);
            writer.WriteStringValue("subscriberCarrier", SubscriberCarrier);
            writer.WriteStringValue("systemManagementBIOSVersion", SystemManagementBIOSVersion);
            writer.WriteLongValue("totalStorageSpace", TotalStorageSpace);
            writer.WriteStringValue("tpmManufacturer", TpmManufacturer);
            writer.WriteStringValue("tpmSpecificationVersion", TpmSpecificationVersion);
            writer.WriteStringValue("tpmVersion", TpmVersion);
            writer.WriteStringValue("wifiMac", WifiMac);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

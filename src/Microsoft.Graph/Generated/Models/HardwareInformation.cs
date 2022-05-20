using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Hardware information of a given device.</summary>
    public class HardwareInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of charge cycles the device’s current battery has gone through. Valid values 0 to 2147483647</summary>
        public int? BatteryChargeCycles {
            get { return BackingStore?.Get<int?>(nameof(BatteryChargeCycles)); }
            set { BackingStore?.Set(nameof(BatteryChargeCycles), value); }
        }
        /// <summary>The device’s current battery’s health percentage. Valid values 0 to 100</summary>
        public int? BatteryHealthPercentage {
            get { return BackingStore?.Get<int?>(nameof(BatteryHealthPercentage)); }
            set { BackingStore?.Set(nameof(BatteryHealthPercentage), value); }
        }
        /// <summary>The serial number of the device’s current battery</summary>
        public string BatterySerialNumber {
            get { return BackingStore?.Get<string>(nameof(BatterySerialNumber)); }
            set { BackingStore?.Set(nameof(BatterySerialNumber), value); }
        }
        /// <summary>Cellular technology of the device</summary>
        public string CellularTechnology {
            get { return BackingStore?.Get<string>(nameof(CellularTechnology)); }
            set { BackingStore?.Set(nameof(CellularTechnology), value); }
        }
        /// <summary>Returns the fully qualified domain name of the device (if any). If the device is not domain-joined, it returns an empty string.</summary>
        public string DeviceFullQualifiedDomainName {
            get { return BackingStore?.Get<string>(nameof(DeviceFullQualifiedDomainName)); }
            set { BackingStore?.Set(nameof(DeviceFullQualifiedDomainName), value); }
        }
        /// <summary>Local System Authority (LSA) credential guard status. . Possible values are: running, rebootRequired, notLicensed, notConfigured, virtualizationBasedSecurityNotRunning.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardLocalSystemAuthorityCredentialGuardState? DeviceGuardLocalSystemAuthorityCredentialGuardState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardLocalSystemAuthorityCredentialGuardState?>(nameof(DeviceGuardLocalSystemAuthorityCredentialGuardState)); }
            set { BackingStore?.Set(nameof(DeviceGuardLocalSystemAuthorityCredentialGuardState), value); }
        }
        /// <summary>Virtualization-based security hardware requirement status. Possible values are: meetHardwareRequirements, secureBootRequired, dmaProtectionRequired, hyperVNotSupportedForGuestVM, hyperVNotAvailable.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityHardwareRequirementState? DeviceGuardVirtualizationBasedSecurityHardwareRequirementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityHardwareRequirementState?>(nameof(DeviceGuardVirtualizationBasedSecurityHardwareRequirementState)); }
            set { BackingStore?.Set(nameof(DeviceGuardVirtualizationBasedSecurityHardwareRequirementState), value); }
        }
        /// <summary>Virtualization-based security status. . Possible values are: running, rebootRequired, require64BitArchitecture, notLicensed, notConfigured, doesNotMeetHardwareRequirements, other.</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityState? DeviceGuardVirtualizationBasedSecurityState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityState?>(nameof(DeviceGuardVirtualizationBasedSecurityState)); }
            set { BackingStore?.Set(nameof(DeviceGuardVirtualizationBasedSecurityState), value); }
        }
        /// <summary>eSIM identifier</summary>
        public string EsimIdentifier {
            get { return BackingStore?.Get<string>(nameof(EsimIdentifier)); }
            set { BackingStore?.Set(nameof(EsimIdentifier), value); }
        }
        /// <summary>Free storage space of the device.</summary>
        public long? FreeStorageSpace {
            get { return BackingStore?.Get<long?>(nameof(FreeStorageSpace)); }
            set { BackingStore?.Set(nameof(FreeStorageSpace), value); }
        }
        /// <summary>IMEI</summary>
        public string Imei {
            get { return BackingStore?.Get<string>(nameof(Imei)); }
            set { BackingStore?.Set(nameof(Imei), value); }
        }
        /// <summary>IPAddressV4</summary>
        public string IpAddressV4 {
            get { return BackingStore?.Get<string>(nameof(IpAddressV4)); }
            set { BackingStore?.Set(nameof(IpAddressV4), value); }
        }
        /// <summary>Encryption status of the device</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>(nameof(IsEncrypted)); }
            set { BackingStore?.Set(nameof(IsEncrypted), value); }
        }
        /// <summary>Shared iPad</summary>
        public bool? IsSharedDevice {
            get { return BackingStore?.Get<bool?>(nameof(IsSharedDevice)); }
            set { BackingStore?.Set(nameof(IsSharedDevice), value); }
        }
        /// <summary>Supervised mode of the device</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>(nameof(IsSupervised)); }
            set { BackingStore?.Set(nameof(IsSupervised), value); }
        }
        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>MEID</summary>
        public string Meid {
            get { return BackingStore?.Get<string>(nameof(Meid)); }
            set { BackingStore?.Set(nameof(Meid), value); }
        }
        /// <summary>Model of the device</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>String that specifies the OS edition.</summary>
        public string OperatingSystemEdition {
            get { return BackingStore?.Get<string>(nameof(OperatingSystemEdition)); }
            set { BackingStore?.Set(nameof(OperatingSystemEdition), value); }
        }
        /// <summary>Operating system language of the device</summary>
        public string OperatingSystemLanguage {
            get { return BackingStore?.Get<string>(nameof(OperatingSystemLanguage)); }
            set { BackingStore?.Set(nameof(OperatingSystemLanguage), value); }
        }
        /// <summary>Int that specifies the Windows Operating System ProductType. More details here https://go.microsoft.com/fwlink/?linkid=2126950. Valid values 0 to 2147483647</summary>
        public int? OperatingSystemProductType {
            get { return BackingStore?.Get<int?>(nameof(OperatingSystemProductType)); }
            set { BackingStore?.Set(nameof(OperatingSystemProductType), value); }
        }
        /// <summary>Operating System Build Number on Android device</summary>
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>(nameof(OsBuildNumber)); }
            set { BackingStore?.Set(nameof(OsBuildNumber), value); }
        }
        /// <summary>Phone number of the device</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>Serial number.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>All users on the shared Apple device</summary>
        public List<SharedAppleDeviceUser> SharedDeviceCachedUsers {
            get { return BackingStore?.Get<List<SharedAppleDeviceUser>>(nameof(SharedDeviceCachedUsers)); }
            set { BackingStore?.Set(nameof(SharedDeviceCachedUsers), value); }
        }
        /// <summary>SubnetAddress</summary>
        public string SubnetAddress {
            get { return BackingStore?.Get<string>(nameof(SubnetAddress)); }
            set { BackingStore?.Set(nameof(SubnetAddress), value); }
        }
        /// <summary>Subscriber carrier of the device</summary>
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>(nameof(SubscriberCarrier)); }
            set { BackingStore?.Set(nameof(SubscriberCarrier), value); }
        }
        /// <summary>BIOS version as reported by SMBIOS</summary>
        public string SystemManagementBIOSVersion {
            get { return BackingStore?.Get<string>(nameof(SystemManagementBIOSVersion)); }
            set { BackingStore?.Set(nameof(SystemManagementBIOSVersion), value); }
        }
        /// <summary>Total storage space of the device.</summary>
        public long? TotalStorageSpace {
            get { return BackingStore?.Get<long?>(nameof(TotalStorageSpace)); }
            set { BackingStore?.Set(nameof(TotalStorageSpace), value); }
        }
        /// <summary>The identifying information that uniquely names the TPM manufacturer</summary>
        public string TpmManufacturer {
            get { return BackingStore?.Get<string>(nameof(TpmManufacturer)); }
            set { BackingStore?.Set(nameof(TpmManufacturer), value); }
        }
        /// <summary>String that specifies the specification version.</summary>
        public string TpmSpecificationVersion {
            get { return BackingStore?.Get<string>(nameof(TpmSpecificationVersion)); }
            set { BackingStore?.Set(nameof(TpmSpecificationVersion), value); }
        }
        /// <summary>The version of the TPM, as specified by the manufacturer</summary>
        public string TpmVersion {
            get { return BackingStore?.Get<string>(nameof(TpmVersion)); }
            set { BackingStore?.Set(nameof(TpmVersion), value); }
        }
        /// <summary>WiFi MAC address of the device</summary>
        public string WifiMac {
            get { return BackingStore?.Get<string>(nameof(WifiMac)); }
            set { BackingStore?.Set(nameof(WifiMac), value); }
        }
        /// <summary>
        /// Instantiates a new hardwareInformation and sets the default values.
        /// </summary>
        public HardwareInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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

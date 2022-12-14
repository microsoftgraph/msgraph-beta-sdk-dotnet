using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Hardware information of a given device.
    /// </summary>
    public class HardwareInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of charge cycles the device’s current battery has gone through. Valid values 0 to 2147483647</summary>
        public int? BatteryChargeCycles {
            get { return BackingStore?.Get<int?>("batteryChargeCycles"); }
            set { BackingStore?.Set("batteryChargeCycles", value); }
        }
        /// <summary>The device’s current battery’s health percentage. Valid values 0 to 100</summary>
        public int? BatteryHealthPercentage {
            get { return BackingStore?.Get<int?>("batteryHealthPercentage"); }
            set { BackingStore?.Set("batteryHealthPercentage", value); }
        }
        /// <summary>The battery level, between 0.0 and 100, or null if the battery level cannot be determined. The update frequency of this property is per-checkin. Note this property is currently supported only on devices running iOS 5.0 and later, and is available only when Device Information access right is obtained. Valid values 0 to 100</summary>
        public double? BatteryLevelPercentage {
            get { return BackingStore?.Get<double?>("batteryLevelPercentage"); }
            set { BackingStore?.Set("batteryLevelPercentage", value); }
        }
        /// <summary>The serial number of the device’s current battery</summary>
        public string BatterySerialNumber {
            get { return BackingStore?.Get<string>("batterySerialNumber"); }
            set { BackingStore?.Set("batterySerialNumber", value); }
        }
        /// <summary>Cellular technology of the device</summary>
        public string CellularTechnology {
            get { return BackingStore?.Get<string>("cellularTechnology"); }
            set { BackingStore?.Set("cellularTechnology", value); }
        }
        /// <summary>Returns the fully qualified domain name of the device (if any). If the device is not domain-joined, it returns an empty string.</summary>
        public string DeviceFullQualifiedDomainName {
            get { return BackingStore?.Get<string>("deviceFullQualifiedDomainName"); }
            set { BackingStore?.Set("deviceFullQualifiedDomainName", value); }
        }
        /// <summary>The deviceGuardLocalSystemAuthorityCredentialGuardState property</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardLocalSystemAuthorityCredentialGuardState? DeviceGuardLocalSystemAuthorityCredentialGuardState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardLocalSystemAuthorityCredentialGuardState?>("deviceGuardLocalSystemAuthorityCredentialGuardState"); }
            set { BackingStore?.Set("deviceGuardLocalSystemAuthorityCredentialGuardState", value); }
        }
        /// <summary>The deviceGuardVirtualizationBasedSecurityHardwareRequirementState property</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityHardwareRequirementState? DeviceGuardVirtualizationBasedSecurityHardwareRequirementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityHardwareRequirementState?>("deviceGuardVirtualizationBasedSecurityHardwareRequirementState"); }
            set { BackingStore?.Set("deviceGuardVirtualizationBasedSecurityHardwareRequirementState", value); }
        }
        /// <summary>The deviceGuardVirtualizationBasedSecurityState property</summary>
        public Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityState? DeviceGuardVirtualizationBasedSecurityState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceGuardVirtualizationBasedSecurityState?>("deviceGuardVirtualizationBasedSecurityState"); }
            set { BackingStore?.Set("deviceGuardVirtualizationBasedSecurityState", value); }
        }
        /// <summary>A standard error code indicating the last error, or 0 indicating no error (default). The update frequency of this property is daily. Note this property is currently supported only for Windows based Device based subscription licensing. Valid values 0 to 2147483647</summary>
        public int? DeviceLicensingLastErrorCode {
            get { return BackingStore?.Get<int?>("deviceLicensingLastErrorCode"); }
            set { BackingStore?.Set("deviceLicensingLastErrorCode", value); }
        }
        /// <summary>Error text message as a descripition for deviceLicensingLastErrorCode. The update frequency of this property is daily. Note this property is currently supported only for Windows based Device based subscription licensing.</summary>
        public string DeviceLicensingLastErrorDescription {
            get { return BackingStore?.Get<string>("deviceLicensingLastErrorDescription"); }
            set { BackingStore?.Set("deviceLicensingLastErrorDescription", value); }
        }
        /// <summary>Indicates the device licensing status after Windows device based subscription has been enabled.</summary>
        public Microsoft.Graph.Beta.Models.DeviceLicensingStatus? DeviceLicensingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceLicensingStatus?>("deviceLicensingStatus"); }
            set { BackingStore?.Set("deviceLicensingStatus", value); }
        }
        /// <summary>eSIM identifier</summary>
        public string EsimIdentifier {
            get { return BackingStore?.Get<string>("esimIdentifier"); }
            set { BackingStore?.Set("esimIdentifier", value); }
        }
        /// <summary>Free storage space of the device.</summary>
        public long? FreeStorageSpace {
            get { return BackingStore?.Get<long?>("freeStorageSpace"); }
            set { BackingStore?.Set("freeStorageSpace", value); }
        }
        /// <summary>IMEI</summary>
        public string Imei {
            get { return BackingStore?.Get<string>("imei"); }
            set { BackingStore?.Set("imei", value); }
        }
        /// <summary>IPAddressV4</summary>
        public string IpAddressV4 {
            get { return BackingStore?.Get<string>("ipAddressV4"); }
            set { BackingStore?.Set("ipAddressV4", value); }
        }
        /// <summary>Encryption status of the device</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>("isEncrypted"); }
            set { BackingStore?.Set("isEncrypted", value); }
        }
        /// <summary>Shared iPad</summary>
        public bool? IsSharedDevice {
            get { return BackingStore?.Get<bool?>("isSharedDevice"); }
            set { BackingStore?.Set("isSharedDevice", value); }
        }
        /// <summary>Supervised mode of the device</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>("isSupervised"); }
            set { BackingStore?.Set("isSupervised", value); }
        }
        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>MEID</summary>
        public string Meid {
            get { return BackingStore?.Get<string>("meid"); }
            set { BackingStore?.Set("meid", value); }
        }
        /// <summary>Model of the device</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>String that specifies the OS edition.</summary>
        public string OperatingSystemEdition {
            get { return BackingStore?.Get<string>("operatingSystemEdition"); }
            set { BackingStore?.Set("operatingSystemEdition", value); }
        }
        /// <summary>Operating system language of the device</summary>
        public string OperatingSystemLanguage {
            get { return BackingStore?.Get<string>("operatingSystemLanguage"); }
            set { BackingStore?.Set("operatingSystemLanguage", value); }
        }
        /// <summary>Int that specifies the Windows Operating System ProductType. More details here https://go.microsoft.com/fwlink/?linkid=2126950. Valid values 0 to 2147483647</summary>
        public int? OperatingSystemProductType {
            get { return BackingStore?.Get<int?>("operatingSystemProductType"); }
            set { BackingStore?.Set("operatingSystemProductType", value); }
        }
        /// <summary>Operating System Build Number on Android device</summary>
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
        /// <summary>Phone number of the device</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
        /// <summary>The product name, e.g. iPad8,12 etc. The update frequency of this property is weekly. Note this property is currently supported only on iOS/MacOS devices, and is available only when Device Information access right is obtained.</summary>
        public string ProductName {
            get { return BackingStore?.Get<string>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
        /// <summary>The number of users currently on this device, or null (default) if the value of this property cannot be determined. The update frequency of this property is per-checkin. Note this property is currently supported only on devices running iOS 13.4 and later, and is available only when Device Information access right is obtained. Valid values 0 to 2147483647</summary>
        public int? ResidentUsersCount {
            get { return BackingStore?.Get<int?>("residentUsersCount"); }
            set { BackingStore?.Set("residentUsersCount", value); }
        }
        /// <summary>Serial number.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
        /// <summary>All users on the shared Apple device</summary>
        public List<SharedAppleDeviceUser> SharedDeviceCachedUsers {
            get { return BackingStore?.Get<List<SharedAppleDeviceUser>>("sharedDeviceCachedUsers"); }
            set { BackingStore?.Set("sharedDeviceCachedUsers", value); }
        }
        /// <summary>SubnetAddress</summary>
        public string SubnetAddress {
            get { return BackingStore?.Get<string>("subnetAddress"); }
            set { BackingStore?.Set("subnetAddress", value); }
        }
        /// <summary>Subscriber carrier of the device</summary>
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>("subscriberCarrier"); }
            set { BackingStore?.Set("subscriberCarrier", value); }
        }
        /// <summary>BIOS version as reported by SMBIOS</summary>
        public string SystemManagementBIOSVersion {
            get { return BackingStore?.Get<string>("systemManagementBIOSVersion"); }
            set { BackingStore?.Set("systemManagementBIOSVersion", value); }
        }
        /// <summary>Total storage space of the device.</summary>
        public long? TotalStorageSpace {
            get { return BackingStore?.Get<long?>("totalStorageSpace"); }
            set { BackingStore?.Set("totalStorageSpace", value); }
        }
        /// <summary>The identifying information that uniquely names the TPM manufacturer</summary>
        public string TpmManufacturer {
            get { return BackingStore?.Get<string>("tpmManufacturer"); }
            set { BackingStore?.Set("tpmManufacturer", value); }
        }
        /// <summary>String that specifies the specification version.</summary>
        public string TpmSpecificationVersion {
            get { return BackingStore?.Get<string>("tpmSpecificationVersion"); }
            set { BackingStore?.Set("tpmSpecificationVersion", value); }
        }
        /// <summary>The version of the TPM, as specified by the manufacturer</summary>
        public string TpmVersion {
            get { return BackingStore?.Get<string>("tpmVersion"); }
            set { BackingStore?.Set("tpmVersion", value); }
        }
        /// <summary>WiFi MAC address of the device</summary>
        public string WifiMac {
            get { return BackingStore?.Get<string>("wifiMac"); }
            set { BackingStore?.Set("wifiMac", value); }
        }
        /// <summary>A list of wired IPv4 addresses. The update frequency (the maximum delay for the change of property value to be synchronized from the device to the cloud storage) of this property is daily. Note this property is currently supported only on devices running on Windows.</summary>
        public List<string> WiredIPv4Addresses {
            get { return BackingStore?.Get<List<string>>("wiredIPv4Addresses"); }
            set { BackingStore?.Set("wiredIPv4Addresses", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"batteryLevelPercentage", n => { BatteryLevelPercentage = n.GetDoubleValue(); } },
                {"batterySerialNumber", n => { BatterySerialNumber = n.GetStringValue(); } },
                {"cellularTechnology", n => { CellularTechnology = n.GetStringValue(); } },
                {"deviceFullQualifiedDomainName", n => { DeviceFullQualifiedDomainName = n.GetStringValue(); } },
                {"deviceGuardLocalSystemAuthorityCredentialGuardState", n => { DeviceGuardLocalSystemAuthorityCredentialGuardState = n.GetEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardState>(); } },
                {"deviceGuardVirtualizationBasedSecurityHardwareRequirementState", n => { DeviceGuardVirtualizationBasedSecurityHardwareRequirementState = n.GetEnumValue<DeviceGuardVirtualizationBasedSecurityHardwareRequirementState>(); } },
                {"deviceGuardVirtualizationBasedSecurityState", n => { DeviceGuardVirtualizationBasedSecurityState = n.GetEnumValue<DeviceGuardVirtualizationBasedSecurityState>(); } },
                {"deviceLicensingLastErrorCode", n => { DeviceLicensingLastErrorCode = n.GetIntValue(); } },
                {"deviceLicensingLastErrorDescription", n => { DeviceLicensingLastErrorDescription = n.GetStringValue(); } },
                {"deviceLicensingStatus", n => { DeviceLicensingStatus = n.GetEnumValue<DeviceLicensingStatus>(); } },
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operatingSystemEdition", n => { OperatingSystemEdition = n.GetStringValue(); } },
                {"operatingSystemLanguage", n => { OperatingSystemLanguage = n.GetStringValue(); } },
                {"operatingSystemProductType", n => { OperatingSystemProductType = n.GetIntValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"residentUsersCount", n => { ResidentUsersCount = n.GetIntValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"sharedDeviceCachedUsers", n => { SharedDeviceCachedUsers = n.GetCollectionOfObjectValues<SharedAppleDeviceUser>(SharedAppleDeviceUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subnetAddress", n => { SubnetAddress = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"systemManagementBIOSVersion", n => { SystemManagementBIOSVersion = n.GetStringValue(); } },
                {"totalStorageSpace", n => { TotalStorageSpace = n.GetLongValue(); } },
                {"tpmManufacturer", n => { TpmManufacturer = n.GetStringValue(); } },
                {"tpmSpecificationVersion", n => { TpmSpecificationVersion = n.GetStringValue(); } },
                {"tpmVersion", n => { TpmVersion = n.GetStringValue(); } },
                {"wifiMac", n => { WifiMac = n.GetStringValue(); } },
                {"wiredIPv4Addresses", n => { WiredIPv4Addresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("batteryChargeCycles", BatteryChargeCycles);
            writer.WriteIntValue("batteryHealthPercentage", BatteryHealthPercentage);
            writer.WriteDoubleValue("batteryLevelPercentage", BatteryLevelPercentage);
            writer.WriteStringValue("batterySerialNumber", BatterySerialNumber);
            writer.WriteStringValue("cellularTechnology", CellularTechnology);
            writer.WriteStringValue("deviceFullQualifiedDomainName", DeviceFullQualifiedDomainName);
            writer.WriteEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardState>("deviceGuardLocalSystemAuthorityCredentialGuardState", DeviceGuardLocalSystemAuthorityCredentialGuardState);
            writer.WriteEnumValue<DeviceGuardVirtualizationBasedSecurityHardwareRequirementState>("deviceGuardVirtualizationBasedSecurityHardwareRequirementState", DeviceGuardVirtualizationBasedSecurityHardwareRequirementState);
            writer.WriteEnumValue<DeviceGuardVirtualizationBasedSecurityState>("deviceGuardVirtualizationBasedSecurityState", DeviceGuardVirtualizationBasedSecurityState);
            writer.WriteIntValue("deviceLicensingLastErrorCode", DeviceLicensingLastErrorCode);
            writer.WriteStringValue("deviceLicensingLastErrorDescription", DeviceLicensingLastErrorDescription);
            writer.WriteEnumValue<DeviceLicensingStatus>("deviceLicensingStatus", DeviceLicensingStatus);
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatingSystemEdition", OperatingSystemEdition);
            writer.WriteStringValue("operatingSystemLanguage", OperatingSystemLanguage);
            writer.WriteIntValue("operatingSystemProductType", OperatingSystemProductType);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteIntValue("residentUsersCount", ResidentUsersCount);
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
            writer.WriteCollectionOfPrimitiveValues<string>("wiredIPv4Addresses", WiredIPv4Addresses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

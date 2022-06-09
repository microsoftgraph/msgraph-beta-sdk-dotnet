using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not the user is allowed to enable unknown sources setting. When set to true, user is not allowed to enable unknown sources settings.</summary>
        public bool? AppsBlockInstallFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(AppsBlockInstallFromUnknownSources)); }
            set { BackingStore?.Set(nameof(AppsBlockInstallFromUnknownSources), value); }
        }
        /// <summary>Indicates whether or not to block a user from configuring bluetooth.</summary>
        public bool? BluetoothBlockConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockConfiguration)); }
            set { BackingStore?.Set(nameof(BluetoothBlockConfiguration), value); }
        }
        /// <summary>Indicates whether or not to disable the use of bluetooth. When set to true, bluetooth cannot be enabled on the device.</summary>
        public bool? BluetoothBlocked {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlocked)); }
            set { BackingStore?.Set(nameof(BluetoothBlocked), value); }
        }
        /// <summary>Indicates whether or not to disable the use of the camera.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CameraBlocked)); }
            set { BackingStore?.Set(nameof(CameraBlocked), value); }
        }
        /// <summary>Indicates whether or not the factory reset option in settings is disabled.</summary>
        public bool? FactoryResetBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FactoryResetBlocked)); }
            set { BackingStore?.Set(nameof(FactoryResetBlocked), value); }
        }
        /// <summary>Indicates the minimum length of the password required on the device. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>Indicates the minimum password quality required on the device. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Indicates the number of times a user can enter an incorrect password before the device is wiped. Valid values 4 to 11</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Indicates whether or not to disable the capability to take screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from enabling debugging features on the device.</summary>
        public bool? SecurityAllowDebuggingFeatures {
            get { return BackingStore?.Get<bool?>(nameof(SecurityAllowDebuggingFeatures)); }
            set { BackingStore?.Set(nameof(SecurityAllowDebuggingFeatures), value); }
        }
        /// <summary>Indicates whether or not to block external media.</summary>
        public bool? StorageBlockExternalMedia {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockExternalMedia)); }
            set { BackingStore?.Set(nameof(StorageBlockExternalMedia), value); }
        }
        /// <summary>Indicates whether or not to block USB file transfer.</summary>
        public bool? StorageBlockUsbFileTransfer {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockUsbFileTransfer)); }
            set { BackingStore?.Set(nameof(StorageBlockUsbFileTransfer), value); }
        }
        /// <summary>Indicates whether or not to block the user from editing the wifi connection settings.</summary>
        public bool? WifiBlockEditConfigurations {
            get { return BackingStore?.Get<bool?>(nameof(WifiBlockEditConfigurations)); }
            set { BackingStore?.Set(nameof(WifiBlockEditConfigurations), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AospDeviceOwnerDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AospDeviceOwnerDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appsBlockInstallFromUnknownSources", n => { AppsBlockInstallFromUnknownSources = n.GetBoolValue(); } },
                {"bluetoothBlockConfiguration", n => { BluetoothBlockConfiguration = n.GetBoolValue(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityAllowDebuggingFeatures", n => { SecurityAllowDebuggingFeatures = n.GetBoolValue(); } },
                {"storageBlockExternalMedia", n => { StorageBlockExternalMedia = n.GetBoolValue(); } },
                {"storageBlockUsbFileTransfer", n => { StorageBlockUsbFileTransfer = n.GetBoolValue(); } },
                {"wifiBlockEditConfigurations", n => { WifiBlockEditConfigurations = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appsBlockInstallFromUnknownSources", AppsBlockInstallFromUnknownSources);
            writer.WriteBoolValue("bluetoothBlockConfiguration", BluetoothBlockConfiguration);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityAllowDebuggingFeatures", SecurityAllowDebuggingFeatures);
            writer.WriteBoolValue("storageBlockExternalMedia", StorageBlockExternalMedia);
            writer.WriteBoolValue("storageBlockUsbFileTransfer", StorageBlockUsbFileTransfer);
            writer.WriteBoolValue("wifiBlockEditConfigurations", WifiBlockEditConfigurations);
        }
    }
}

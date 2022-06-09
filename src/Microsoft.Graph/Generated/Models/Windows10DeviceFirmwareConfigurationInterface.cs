using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10DeviceFirmwareConfigurationInterface : DeviceConfiguration, IParsable {
        /// <summary>Defines whether a user is allowed to enable Bluetooth. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Bluetooth {
            get { return BackingStore?.Get<Enablement?>(nameof(Bluetooth)); }
            set { BackingStore?.Set(nameof(Bluetooth), value); }
        }
        /// <summary>Defines whether a user is allowed to boot from built-in network adapters. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? BootFromBuiltInNetworkAdapters {
            get { return BackingStore?.Get<Enablement?>(nameof(BootFromBuiltInNetworkAdapters)); }
            set { BackingStore?.Set(nameof(BootFromBuiltInNetworkAdapters), value); }
        }
        /// <summary>Defines whether a user is allowed to boot from external media. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? BootFromExternalMedia {
            get { return BackingStore?.Get<Enablement?>(nameof(BootFromExternalMedia)); }
            set { BackingStore?.Set(nameof(BootFromExternalMedia), value); }
        }
        /// <summary>Defines whether built-in cameras are enabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Cameras {
            get { return BackingStore?.Get<Enablement?>(nameof(Cameras)); }
            set { BackingStore?.Set(nameof(Cameras), value); }
        }
        /// <summary>Defines the permission level granted to users to change UEFI settings. Possible values are: notConfiguredOnly, none.</summary>
        public Microsoft.Graph.Beta.Models.ChangeUefiSettingsPermission? ChangeUefiSettingsPermission {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChangeUefiSettingsPermission?>(nameof(ChangeUefiSettingsPermission)); }
            set { BackingStore?.Set(nameof(ChangeUefiSettingsPermission), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Front Camera. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? FrontCamera {
            get { return BackingStore?.Get<Enablement?>(nameof(FrontCamera)); }
            set { BackingStore?.Set(nameof(FrontCamera), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Infrared camera. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? InfraredCamera {
            get { return BackingStore?.Get<Enablement?>(nameof(InfraredCamera)); }
            set { BackingStore?.Set(nameof(InfraredCamera), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Microphone. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Microphone {
            get { return BackingStore?.Get<Enablement?>(nameof(Microphone)); }
            set { BackingStore?.Set(nameof(Microphone), value); }
        }
        /// <summary>Defines whether built-in microphones or speakers are enabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? MicrophonesAndSpeakers {
            get { return BackingStore?.Get<Enablement?>(nameof(MicrophonesAndSpeakers)); }
            set { BackingStore?.Set(nameof(MicrophonesAndSpeakers), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Near Field Communication. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? NearFieldCommunication {
            get { return BackingStore?.Get<Enablement?>(nameof(NearFieldCommunication)); }
            set { BackingStore?.Set(nameof(NearFieldCommunication), value); }
        }
        /// <summary>Defines whether built-in radios e.g. WIFI, NFC, Bluetooth, are enabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Radios {
            get { return BackingStore?.Get<Enablement?>(nameof(Radios)); }
            set { BackingStore?.Set(nameof(Radios), value); }
        }
        /// <summary>Defines whether a user is allowed to enable rear camera. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? RearCamera {
            get { return BackingStore?.Get<Enablement?>(nameof(RearCamera)); }
            set { BackingStore?.Set(nameof(RearCamera), value); }
        }
        /// <summary>Defines whether a user is allowed to enable SD Card Port. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SdCard {
            get { return BackingStore?.Get<Enablement?>(nameof(SdCard)); }
            set { BackingStore?.Set(nameof(SdCard), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Simultaneous MultiThreading. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SimultaneousMultiThreading {
            get { return BackingStore?.Get<Enablement?>(nameof(SimultaneousMultiThreading)); }
            set { BackingStore?.Set(nameof(SimultaneousMultiThreading), value); }
        }
        /// <summary>Defines whether a user is allowed to enable USB Type A Port. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? UsbTypeAPort {
            get { return BackingStore?.Get<Enablement?>(nameof(UsbTypeAPort)); }
            set { BackingStore?.Set(nameof(UsbTypeAPort), value); }
        }
        /// <summary>Defines whether CPU and IO virtualization is enabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? VirtualizationOfCpuAndIO {
            get { return BackingStore?.Get<Enablement?>(nameof(VirtualizationOfCpuAndIO)); }
            set { BackingStore?.Set(nameof(VirtualizationOfCpuAndIO), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Wake on LAN. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? WakeOnLAN {
            get { return BackingStore?.Get<Enablement?>(nameof(WakeOnLAN)); }
            set { BackingStore?.Set(nameof(WakeOnLAN), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Wake On Power. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? WakeOnPower {
            get { return BackingStore?.Get<Enablement?>(nameof(WakeOnPower)); }
            set { BackingStore?.Set(nameof(WakeOnPower), value); }
        }
        /// <summary>Defines whether a user is allowed to enable WiFi. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? WiFi {
            get { return BackingStore?.Get<Enablement?>(nameof(WiFi)); }
            set { BackingStore?.Set(nameof(WiFi), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Windows Platform Binary Table. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? WindowsPlatformBinaryTable {
            get { return BackingStore?.Get<Enablement?>(nameof(WindowsPlatformBinaryTable)); }
            set { BackingStore?.Set(nameof(WindowsPlatformBinaryTable), value); }
        }
        /// <summary>Defines whether a user is allowed to enable Wireless Wide Area Network. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? WirelessWideAreaNetwork {
            get { return BackingStore?.Get<Enablement?>(nameof(WirelessWideAreaNetwork)); }
            set { BackingStore?.Set(nameof(WirelessWideAreaNetwork), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10DeviceFirmwareConfigurationInterface CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10DeviceFirmwareConfigurationInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bluetooth", n => { Bluetooth = n.GetEnumValue<Enablement>(); } },
                {"bootFromBuiltInNetworkAdapters", n => { BootFromBuiltInNetworkAdapters = n.GetEnumValue<Enablement>(); } },
                {"bootFromExternalMedia", n => { BootFromExternalMedia = n.GetEnumValue<Enablement>(); } },
                {"cameras", n => { Cameras = n.GetEnumValue<Enablement>(); } },
                {"changeUefiSettingsPermission", n => { ChangeUefiSettingsPermission = n.GetEnumValue<ChangeUefiSettingsPermission>(); } },
                {"frontCamera", n => { FrontCamera = n.GetEnumValue<Enablement>(); } },
                {"infraredCamera", n => { InfraredCamera = n.GetEnumValue<Enablement>(); } },
                {"microphone", n => { Microphone = n.GetEnumValue<Enablement>(); } },
                {"microphonesAndSpeakers", n => { MicrophonesAndSpeakers = n.GetEnumValue<Enablement>(); } },
                {"nearFieldCommunication", n => { NearFieldCommunication = n.GetEnumValue<Enablement>(); } },
                {"radios", n => { Radios = n.GetEnumValue<Enablement>(); } },
                {"rearCamera", n => { RearCamera = n.GetEnumValue<Enablement>(); } },
                {"sdCard", n => { SdCard = n.GetEnumValue<Enablement>(); } },
                {"simultaneousMultiThreading", n => { SimultaneousMultiThreading = n.GetEnumValue<Enablement>(); } },
                {"usbTypeAPort", n => { UsbTypeAPort = n.GetEnumValue<Enablement>(); } },
                {"virtualizationOfCpuAndIO", n => { VirtualizationOfCpuAndIO = n.GetEnumValue<Enablement>(); } },
                {"wakeOnLAN", n => { WakeOnLAN = n.GetEnumValue<Enablement>(); } },
                {"wakeOnPower", n => { WakeOnPower = n.GetEnumValue<Enablement>(); } },
                {"wiFi", n => { WiFi = n.GetEnumValue<Enablement>(); } },
                {"windowsPlatformBinaryTable", n => { WindowsPlatformBinaryTable = n.GetEnumValue<Enablement>(); } },
                {"wirelessWideAreaNetwork", n => { WirelessWideAreaNetwork = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Enablement>("bluetooth", Bluetooth);
            writer.WriteEnumValue<Enablement>("bootFromBuiltInNetworkAdapters", BootFromBuiltInNetworkAdapters);
            writer.WriteEnumValue<Enablement>("bootFromExternalMedia", BootFromExternalMedia);
            writer.WriteEnumValue<Enablement>("cameras", Cameras);
            writer.WriteEnumValue<ChangeUefiSettingsPermission>("changeUefiSettingsPermission", ChangeUefiSettingsPermission);
            writer.WriteEnumValue<Enablement>("frontCamera", FrontCamera);
            writer.WriteEnumValue<Enablement>("infraredCamera", InfraredCamera);
            writer.WriteEnumValue<Enablement>("microphone", Microphone);
            writer.WriteEnumValue<Enablement>("microphonesAndSpeakers", MicrophonesAndSpeakers);
            writer.WriteEnumValue<Enablement>("nearFieldCommunication", NearFieldCommunication);
            writer.WriteEnumValue<Enablement>("radios", Radios);
            writer.WriteEnumValue<Enablement>("rearCamera", RearCamera);
            writer.WriteEnumValue<Enablement>("sdCard", SdCard);
            writer.WriteEnumValue<Enablement>("simultaneousMultiThreading", SimultaneousMultiThreading);
            writer.WriteEnumValue<Enablement>("usbTypeAPort", UsbTypeAPort);
            writer.WriteEnumValue<Enablement>("virtualizationOfCpuAndIO", VirtualizationOfCpuAndIO);
            writer.WriteEnumValue<Enablement>("wakeOnLAN", WakeOnLAN);
            writer.WriteEnumValue<Enablement>("wakeOnPower", WakeOnPower);
            writer.WriteEnumValue<Enablement>("wiFi", WiFi);
            writer.WriteEnumValue<Enablement>("windowsPlatformBinaryTable", WindowsPlatformBinaryTable);
            writer.WriteEnumValue<Enablement>("wirelessWideAreaNetwork", WirelessWideAreaNetwork);
        }
    }
}

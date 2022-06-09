using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents per-process privacy preferences.</summary>
    public class MacOSPrivacyAccessControlItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Allow the app or process to control the Mac via the Accessibility subsystem. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Accessibility {
            get { return BackingStore?.Get<Enablement?>(nameof(Accessibility)); }
            set { BackingStore?.Set(nameof(Accessibility), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Allow or block access to contact information managed by Contacts. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AddressBook {
            get { return BackingStore?.Get<Enablement?>(nameof(AddressBook)); }
            set { BackingStore?.Set(nameof(AddressBook), value); }
        }
        /// <summary>Allow or deny the app or process to send a restricted Apple event to another app or process. You will need to know the identifier, identifier type, and code requirement of the receiving app or process. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSAppleEventReceiver> AppleEventsAllowedReceivers {
            get { return BackingStore?.Get<List<MacOSAppleEventReceiver>>(nameof(AppleEventsAllowedReceivers)); }
            set { BackingStore?.Set(nameof(AppleEventsAllowedReceivers), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Block access to camera app.</summary>
        public bool? BlockCamera {
            get { return BackingStore?.Get<bool?>(nameof(BlockCamera)); }
            set { BackingStore?.Set(nameof(BlockCamera), value); }
        }
        /// <summary>Block the app or process from listening to events from input devices such as mouse, keyboard, and trackpad.Requires macOS 10.15 or later.</summary>
        public bool? BlockListenEvent {
            get { return BackingStore?.Get<bool?>(nameof(BlockListenEvent)); }
            set { BackingStore?.Set(nameof(BlockListenEvent), value); }
        }
        /// <summary>Block access to microphone.</summary>
        public bool? BlockMicrophone {
            get { return BackingStore?.Get<bool?>(nameof(BlockMicrophone)); }
            set { BackingStore?.Set(nameof(BlockMicrophone), value); }
        }
        /// <summary>Block app from capturing contents of system display. Requires macOS 10.15 or later.</summary>
        public bool? BlockScreenCapture {
            get { return BackingStore?.Get<bool?>(nameof(BlockScreenCapture)); }
            set { BackingStore?.Set(nameof(BlockScreenCapture), value); }
        }
        /// <summary>Allow or block access to event information managed by Calendar. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Calendar {
            get { return BackingStore?.Get<Enablement?>(nameof(Calendar)); }
            set { BackingStore?.Set(nameof(Calendar), value); }
        }
        /// <summary>Enter the code requirement, which can be obtained with the command &apos;codesign –display -r –&apos; in the Terminal app. Include everything after &apos;=&gt;&apos;.</summary>
        public string CodeRequirement {
            get { return BackingStore?.Get<string>(nameof(CodeRequirement)); }
            set { BackingStore?.Set(nameof(CodeRequirement), value); }
        }
        /// <summary>The display name of the app, process, or executable.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Allow the app or process to access files managed by another app’s file provider extension. Requires macOS 10.15 or later. . Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? FileProviderPresence {
            get { return BackingStore?.Get<Enablement?>(nameof(FileProviderPresence)); }
            set { BackingStore?.Set(nameof(FileProviderPresence), value); }
        }
        /// <summary>The bundle ID or path of the app, process, or executable.</summary>
        public string Identifier {
            get { return BackingStore?.Get<string>(nameof(Identifier)); }
            set { BackingStore?.Set(nameof(Identifier), value); }
        }
        /// <summary>A bundle ID is used to identify an app. A path is used to identify a process or executable. Possible values are: bundleID, path.</summary>
        public MacOSProcessIdentifierType? IdentifierType {
            get { return BackingStore?.Get<MacOSProcessIdentifierType?>(nameof(IdentifierType)); }
            set { BackingStore?.Set(nameof(IdentifierType), value); }
        }
        /// <summary>Allow or block access to music and the media library. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? MediaLibrary {
            get { return BackingStore?.Get<Enablement?>(nameof(MediaLibrary)); }
            set { BackingStore?.Set(nameof(MediaLibrary), value); }
        }
        /// <summary>Allow or block access to images managed by Photos. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Photos {
            get { return BackingStore?.Get<Enablement?>(nameof(Photos)); }
            set { BackingStore?.Set(nameof(Photos), value); }
        }
        /// <summary>Control access to CoreGraphics APIs, which are used to send CGEvents to the system event stream. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? PostEvent {
            get { return BackingStore?.Get<Enablement?>(nameof(PostEvent)); }
            set { BackingStore?.Set(nameof(PostEvent), value); }
        }
        /// <summary>Allow or block access to information managed by Reminders. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? Reminders {
            get { return BackingStore?.Get<Enablement?>(nameof(Reminders)); }
            set { BackingStore?.Set(nameof(Reminders), value); }
        }
        /// <summary>Allow or block access to system speech recognition facility. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SpeechRecognition {
            get { return BackingStore?.Get<Enablement?>(nameof(SpeechRecognition)); }
            set { BackingStore?.Set(nameof(SpeechRecognition), value); }
        }
        /// <summary>Statically validates the code requirement. Use this setting if the process invalidates its dynamic code signature.</summary>
        public bool? StaticCodeValidation {
            get { return BackingStore?.Get<bool?>(nameof(StaticCodeValidation)); }
            set { BackingStore?.Set(nameof(StaticCodeValidation), value); }
        }
        /// <summary>Control access to all protected files on a device. Files might be in locations such as emails, messages, apps, and administrative settings. Apply this setting with caution. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyAllFiles {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyAllFiles)); }
            set { BackingStore?.Set(nameof(SystemPolicyAllFiles), value); }
        }
        /// <summary>Allow or block access to Desktop folder. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyDesktopFolder {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyDesktopFolder)); }
            set { BackingStore?.Set(nameof(SystemPolicyDesktopFolder), value); }
        }
        /// <summary>Allow or block access to Documents folder. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyDocumentsFolder {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyDocumentsFolder)); }
            set { BackingStore?.Set(nameof(SystemPolicyDocumentsFolder), value); }
        }
        /// <summary>Allow or block access to Downloads folder. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyDownloadsFolder {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyDownloadsFolder)); }
            set { BackingStore?.Set(nameof(SystemPolicyDownloadsFolder), value); }
        }
        /// <summary>Allow or block access to network volumes. Requires macOS 10.15 or later. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyNetworkVolumes {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyNetworkVolumes)); }
            set { BackingStore?.Set(nameof(SystemPolicyNetworkVolumes), value); }
        }
        /// <summary>Control access to removable  volumes on the device, such as an external hard drive. Requires macOS 10.15 or later. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicyRemovableVolumes {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicyRemovableVolumes)); }
            set { BackingStore?.Set(nameof(SystemPolicyRemovableVolumes), value); }
        }
        /// <summary>Allow app or process to access files used in system administration. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SystemPolicySystemAdminFiles {
            get { return BackingStore?.Get<Enablement?>(nameof(SystemPolicySystemAdminFiles)); }
            set { BackingStore?.Set(nameof(SystemPolicySystemAdminFiles), value); }
        }
        /// <summary>
        /// Instantiates a new macOSPrivacyAccessControlItem and sets the default values.
        /// </summary>
        public MacOSPrivacyAccessControlItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSPrivacyAccessControlItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSPrivacyAccessControlItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessibility", n => { Accessibility = n.GetEnumValue<Enablement>(); } },
                {"addressBook", n => { AddressBook = n.GetEnumValue<Enablement>(); } },
                {"appleEventsAllowedReceivers", n => { AppleEventsAllowedReceivers = n.GetCollectionOfObjectValues<MacOSAppleEventReceiver>(MacOSAppleEventReceiver.CreateFromDiscriminatorValue).ToList(); } },
                {"blockCamera", n => { BlockCamera = n.GetBoolValue(); } },
                {"blockListenEvent", n => { BlockListenEvent = n.GetBoolValue(); } },
                {"blockMicrophone", n => { BlockMicrophone = n.GetBoolValue(); } },
                {"blockScreenCapture", n => { BlockScreenCapture = n.GetBoolValue(); } },
                {"calendar", n => { Calendar = n.GetEnumValue<Enablement>(); } },
                {"codeRequirement", n => { CodeRequirement = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fileProviderPresence", n => { FileProviderPresence = n.GetEnumValue<Enablement>(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"identifierType", n => { IdentifierType = n.GetEnumValue<MacOSProcessIdentifierType>(); } },
                {"mediaLibrary", n => { MediaLibrary = n.GetEnumValue<Enablement>(); } },
                {"photos", n => { Photos = n.GetEnumValue<Enablement>(); } },
                {"postEvent", n => { PostEvent = n.GetEnumValue<Enablement>(); } },
                {"reminders", n => { Reminders = n.GetEnumValue<Enablement>(); } },
                {"speechRecognition", n => { SpeechRecognition = n.GetEnumValue<Enablement>(); } },
                {"staticCodeValidation", n => { StaticCodeValidation = n.GetBoolValue(); } },
                {"systemPolicyAllFiles", n => { SystemPolicyAllFiles = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDesktopFolder", n => { SystemPolicyDesktopFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDocumentsFolder", n => { SystemPolicyDocumentsFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDownloadsFolder", n => { SystemPolicyDownloadsFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyNetworkVolumes", n => { SystemPolicyNetworkVolumes = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyRemovableVolumes", n => { SystemPolicyRemovableVolumes = n.GetEnumValue<Enablement>(); } },
                {"systemPolicySystemAdminFiles", n => { SystemPolicySystemAdminFiles = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Enablement>("accessibility", Accessibility);
            writer.WriteEnumValue<Enablement>("addressBook", AddressBook);
            writer.WriteCollectionOfObjectValues<MacOSAppleEventReceiver>("appleEventsAllowedReceivers", AppleEventsAllowedReceivers);
            writer.WriteBoolValue("blockCamera", BlockCamera);
            writer.WriteBoolValue("blockListenEvent", BlockListenEvent);
            writer.WriteBoolValue("blockMicrophone", BlockMicrophone);
            writer.WriteBoolValue("blockScreenCapture", BlockScreenCapture);
            writer.WriteEnumValue<Enablement>("calendar", Calendar);
            writer.WriteStringValue("codeRequirement", CodeRequirement);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Enablement>("fileProviderPresence", FileProviderPresence);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<MacOSProcessIdentifierType>("identifierType", IdentifierType);
            writer.WriteEnumValue<Enablement>("mediaLibrary", MediaLibrary);
            writer.WriteEnumValue<Enablement>("photos", Photos);
            writer.WriteEnumValue<Enablement>("postEvent", PostEvent);
            writer.WriteEnumValue<Enablement>("reminders", Reminders);
            writer.WriteEnumValue<Enablement>("speechRecognition", SpeechRecognition);
            writer.WriteBoolValue("staticCodeValidation", StaticCodeValidation);
            writer.WriteEnumValue<Enablement>("systemPolicyAllFiles", SystemPolicyAllFiles);
            writer.WriteEnumValue<Enablement>("systemPolicyDesktopFolder", SystemPolicyDesktopFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyDocumentsFolder", SystemPolicyDocumentsFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyDownloadsFolder", SystemPolicyDownloadsFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyNetworkVolumes", SystemPolicyNetworkVolumes);
            writer.WriteEnumValue<Enablement>("systemPolicyRemovableVolumes", SystemPolicyRemovableVolumes);
            writer.WriteEnumValue<Enablement>("systemPolicySystemAdminFiles", SystemPolicySystemAdminFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

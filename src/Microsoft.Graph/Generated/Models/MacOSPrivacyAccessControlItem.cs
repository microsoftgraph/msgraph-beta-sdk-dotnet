// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represents per-process privacy preferences.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSPrivacyAccessControlItem : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? Accessibility
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("accessibility"); }
            set { BackingStore?.Set("accessibility", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? AddressBook
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("addressBook"); }
            set { BackingStore?.Set("addressBook", value); }
        }
        /// <summary>Allow or deny the app or process to send a restricted Apple event to another app or process. You will need to know the identifier, identifier type, and code requirement of the receiving app or process. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver>? AppleEventsAllowedReceivers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver>?>("appleEventsAllowedReceivers"); }
            set { BackingStore?.Set("appleEventsAllowedReceivers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver> AppleEventsAllowedReceivers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver>>("appleEventsAllowedReceivers"); }
            set { BackingStore?.Set("appleEventsAllowedReceivers", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Block access to camera app.</summary>
        public bool? BlockCamera
        {
            get { return BackingStore?.Get<bool?>("blockCamera"); }
            set { BackingStore?.Set("blockCamera", value); }
        }
        /// <summary>Block the app or process from listening to events from input devices such as mouse, keyboard, and trackpad.Requires macOS 10.15 or later.</summary>
        public bool? BlockListenEvent
        {
            get { return BackingStore?.Get<bool?>("blockListenEvent"); }
            set { BackingStore?.Set("blockListenEvent", value); }
        }
        /// <summary>Block access to microphone.</summary>
        public bool? BlockMicrophone
        {
            get { return BackingStore?.Get<bool?>("blockMicrophone"); }
            set { BackingStore?.Set("blockMicrophone", value); }
        }
        /// <summary>Block app from capturing contents of system display. Requires macOS 10.15 or later.</summary>
        public bool? BlockScreenCapture
        {
            get { return BackingStore?.Get<bool?>("blockScreenCapture"); }
            set { BackingStore?.Set("blockScreenCapture", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? Calendar
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
        /// <summary>Enter the code requirement, which can be obtained with the command &apos;codesign –display -r –&apos; in the Terminal app. Include everything after &apos;=&gt;&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodeRequirement
        {
            get { return BackingStore?.Get<string?>("codeRequirement"); }
            set { BackingStore?.Set("codeRequirement", value); }
        }
#nullable restore
#else
        public string CodeRequirement
        {
            get { return BackingStore?.Get<string>("codeRequirement"); }
            set { BackingStore?.Set("codeRequirement", value); }
        }
#endif
        /// <summary>The display name of the app, process, or executable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? FileProviderPresence
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("fileProviderPresence"); }
            set { BackingStore?.Set("fileProviderPresence", value); }
        }
        /// <summary>The bundle ID or path of the app, process, or executable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier
        {
            get { return BackingStore?.Get<string?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#nullable restore
#else
        public string Identifier
        {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#endif
        /// <summary>Process identifier types for MacOS Privacy Preferences</summary>
        public global::Microsoft.Graph.Beta.Models.MacOSProcessIdentifierType? IdentifierType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSProcessIdentifierType?>("identifierType"); }
            set { BackingStore?.Set("identifierType", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? MediaLibrary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("mediaLibrary"); }
            set { BackingStore?.Set("mediaLibrary", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? Photos
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("photos"); }
            set { BackingStore?.Set("photos", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? PostEvent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("postEvent"); }
            set { BackingStore?.Set("postEvent", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? Reminders
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SpeechRecognition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("speechRecognition"); }
            set { BackingStore?.Set("speechRecognition", value); }
        }
        /// <summary>Statically validates the code requirement. Use this setting if the process invalidates its dynamic code signature.</summary>
        public bool? StaticCodeValidation
        {
            get { return BackingStore?.Get<bool?>("staticCodeValidation"); }
            set { BackingStore?.Set("staticCodeValidation", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyAllFiles
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyAllFiles"); }
            set { BackingStore?.Set("systemPolicyAllFiles", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyDesktopFolder
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyDesktopFolder"); }
            set { BackingStore?.Set("systemPolicyDesktopFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyDocumentsFolder
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyDocumentsFolder"); }
            set { BackingStore?.Set("systemPolicyDocumentsFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyDownloadsFolder
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyDownloadsFolder"); }
            set { BackingStore?.Set("systemPolicyDownloadsFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyNetworkVolumes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyNetworkVolumes"); }
            set { BackingStore?.Set("systemPolicyNetworkVolumes", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicyRemovableVolumes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicyRemovableVolumes"); }
            set { BackingStore?.Set("systemPolicyRemovableVolumes", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? SystemPolicySystemAdminFiles
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("systemPolicySystemAdminFiles"); }
            set { BackingStore?.Set("systemPolicySystemAdminFiles", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MacOSPrivacyAccessControlItem"/> and sets the default values.
        /// </summary>
        public MacOSPrivacyAccessControlItem()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MacOSPrivacyAccessControlItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MacOSPrivacyAccessControlItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MacOSPrivacyAccessControlItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "addressBook", n => { AddressBook = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "appleEventsAllowedReceivers", n => { AppleEventsAllowedReceivers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver>(global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver.CreateFromDiscriminatorValue)?.AsList(); } },
                { "blockCamera", n => { BlockCamera = n.GetBoolValue(); } },
                { "blockListenEvent", n => { BlockListenEvent = n.GetBoolValue(); } },
                { "blockMicrophone", n => { BlockMicrophone = n.GetBoolValue(); } },
                { "blockScreenCapture", n => { BlockScreenCapture = n.GetBoolValue(); } },
                { "calendar", n => { Calendar = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "codeRequirement", n => { CodeRequirement = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fileProviderPresence", n => { FileProviderPresence = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "identifier", n => { Identifier = n.GetStringValue(); } },
                { "identifierType", n => { IdentifierType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MacOSProcessIdentifierType>(); } },
                { "mediaLibrary", n => { MediaLibrary = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "photos", n => { Photos = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "postEvent", n => { PostEvent = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "reminders", n => { Reminders = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "speechRecognition", n => { SpeechRecognition = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "staticCodeValidation", n => { StaticCodeValidation = n.GetBoolValue(); } },
                { "systemPolicyAllFiles", n => { SystemPolicyAllFiles = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicyDesktopFolder", n => { SystemPolicyDesktopFolder = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicyDocumentsFolder", n => { SystemPolicyDocumentsFolder = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicyDownloadsFolder", n => { SystemPolicyDownloadsFolder = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicyNetworkVolumes", n => { SystemPolicyNetworkVolumes = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicyRemovableVolumes", n => { SystemPolicyRemovableVolumes = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "systemPolicySystemAdminFiles", n => { SystemPolicySystemAdminFiles = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("accessibility", Accessibility);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("addressBook", AddressBook);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MacOSAppleEventReceiver>("appleEventsAllowedReceivers", AppleEventsAllowedReceivers);
            writer.WriteBoolValue("blockCamera", BlockCamera);
            writer.WriteBoolValue("blockListenEvent", BlockListenEvent);
            writer.WriteBoolValue("blockMicrophone", BlockMicrophone);
            writer.WriteBoolValue("blockScreenCapture", BlockScreenCapture);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("calendar", Calendar);
            writer.WriteStringValue("codeRequirement", CodeRequirement);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("fileProviderPresence", FileProviderPresence);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MacOSProcessIdentifierType>("identifierType", IdentifierType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("mediaLibrary", MediaLibrary);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("photos", Photos);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("postEvent", PostEvent);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("reminders", Reminders);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("speechRecognition", SpeechRecognition);
            writer.WriteBoolValue("staticCodeValidation", StaticCodeValidation);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyAllFiles", SystemPolicyAllFiles);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyDesktopFolder", SystemPolicyDesktopFolder);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyDocumentsFolder", SystemPolicyDocumentsFolder);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyDownloadsFolder", SystemPolicyDownloadsFolder);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyNetworkVolumes", SystemPolicyNetworkVolumes);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicyRemovableVolumes", SystemPolicyRemovableVolumes);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("systemPolicySystemAdminFiles", SystemPolicySystemAdminFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

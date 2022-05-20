using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Out of box experience setting</summary>
    public class OutOfBoxExperienceSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>AAD join authentication type. Possible values are: singleUser, shared.</summary>
        public WindowsDeviceUsageType? DeviceUsageType {
            get { return BackingStore?.Get<WindowsDeviceUsageType?>(nameof(DeviceUsageType)); }
            set { BackingStore?.Set(nameof(DeviceUsageType), value); }
        }
        /// <summary>If set to true, then the user can&apos;t start over with different account, on company sign-in</summary>
        public bool? HideEscapeLink {
            get { return BackingStore?.Get<bool?>(nameof(HideEscapeLink)); }
            set { BackingStore?.Set(nameof(HideEscapeLink), value); }
        }
        /// <summary>Show or hide EULA to user</summary>
        public bool? HideEULA {
            get { return BackingStore?.Get<bool?>(nameof(HideEULA)); }
            set { BackingStore?.Set(nameof(HideEULA), value); }
        }
        /// <summary>Show or hide privacy settings to user</summary>
        public bool? HidePrivacySettings {
            get { return BackingStore?.Get<bool?>(nameof(HidePrivacySettings)); }
            set { BackingStore?.Set(nameof(HidePrivacySettings), value); }
        }
        /// <summary>If set, then skip the keyboard selection page if Language and Region are set</summary>
        public bool? SkipKeyboardSelectionPage {
            get { return BackingStore?.Get<bool?>(nameof(SkipKeyboardSelectionPage)); }
            set { BackingStore?.Set(nameof(SkipKeyboardSelectionPage), value); }
        }
        /// <summary>Type of user. Possible values are: administrator, standard.</summary>
        public WindowsUserType? UserType {
            get { return BackingStore?.Get<WindowsUserType?>(nameof(UserType)); }
            set { BackingStore?.Set(nameof(UserType), value); }
        }
        /// <summary>
        /// Instantiates a new outOfBoxExperienceSettings and sets the default values.
        /// </summary>
        public OutOfBoxExperienceSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OutOfBoxExperienceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutOfBoxExperienceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceUsageType", n => { DeviceUsageType = n.GetEnumValue<WindowsDeviceUsageType>(); } },
                {"hideEscapeLink", n => { HideEscapeLink = n.GetBoolValue(); } },
                {"hideEULA", n => { HideEULA = n.GetBoolValue(); } },
                {"hidePrivacySettings", n => { HidePrivacySettings = n.GetBoolValue(); } },
                {"skipKeyboardSelectionPage", n => { SkipKeyboardSelectionPage = n.GetBoolValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<WindowsUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsDeviceUsageType>("deviceUsageType", DeviceUsageType);
            writer.WriteBoolValue("hideEscapeLink", HideEscapeLink);
            writer.WriteBoolValue("hideEULA", HideEULA);
            writer.WriteBoolValue("hidePrivacySettings", HidePrivacySettings);
            writer.WriteBoolValue("skipKeyboardSelectionPage", SkipKeyboardSelectionPage);
            writer.WriteEnumValue<WindowsUserType>("userType", UserType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

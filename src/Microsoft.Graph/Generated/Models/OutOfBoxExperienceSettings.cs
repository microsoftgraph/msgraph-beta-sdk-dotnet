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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceUsageType property</summary>
        public WindowsDeviceUsageType? DeviceUsageType {
            get { return BackingStore?.Get<WindowsDeviceUsageType?>("deviceUsageType"); }
            set { BackingStore?.Set("deviceUsageType", value); }
        }
        /// <summary>If set to true, then the user can&apos;t start over with different account, on company sign-in</summary>
        public bool? HideEscapeLink {
            get { return BackingStore?.Get<bool?>("hideEscapeLink"); }
            set { BackingStore?.Set("hideEscapeLink", value); }
        }
        /// <summary>Show or hide EULA to user</summary>
        public bool? HideEULA {
            get { return BackingStore?.Get<bool?>("hideEULA"); }
            set { BackingStore?.Set("hideEULA", value); }
        }
        /// <summary>Show or hide privacy settings to user</summary>
        public bool? HidePrivacySettings {
            get { return BackingStore?.Get<bool?>("hidePrivacySettings"); }
            set { BackingStore?.Set("hidePrivacySettings", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>If set, then skip the keyboard selection page if Language and Region are set</summary>
        public bool? SkipKeyboardSelectionPage {
            get { return BackingStore?.Get<bool?>("skipKeyboardSelectionPage"); }
            set { BackingStore?.Set("skipKeyboardSelectionPage", value); }
        }
        /// <summary>The userType property</summary>
        public WindowsUserType? UserType {
            get { return BackingStore?.Get<WindowsUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skipKeyboardSelectionPage", n => { SkipKeyboardSelectionPage = n.GetBoolValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<WindowsUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsDeviceUsageType>("deviceUsageType", DeviceUsageType);
            writer.WriteBoolValue("hideEscapeLink", HideEscapeLink);
            writer.WriteBoolValue("hideEULA", HideEULA);
            writer.WriteBoolValue("hidePrivacySettings", HidePrivacySettings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("skipKeyboardSelectionPage", SkipKeyboardSelectionPage);
            writer.WriteEnumValue<WindowsUserType>("userType", UserType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

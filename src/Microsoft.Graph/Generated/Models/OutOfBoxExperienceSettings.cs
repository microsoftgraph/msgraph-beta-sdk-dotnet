using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Out of box experience setting</summary>
    public class OutOfBoxExperienceSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>AAD join authentication type. Possible values are: singleUser, shared.</summary>
        public WindowsDeviceUsageType? DeviceUsageType { get; set; }
        /// <summary>If set to true, then the user can&apos;t start over with different account, on company sign-in</summary>
        public bool? HideEscapeLink { get; set; }
        /// <summary>Show or hide EULA to user</summary>
        public bool? HideEULA { get; set; }
        /// <summary>Show or hide privacy settings to user</summary>
        public bool? HidePrivacySettings { get; set; }
        /// <summary>If set, then skip the keyboard selection page if Language and Region are set</summary>
        public bool? SkipKeyboardSelectionPage { get; set; }
        /// <summary>Type of user. Possible values are: administrator, standard.</summary>
        public WindowsUserType? UserType { get; set; }
        /// <summary>
        /// Instantiates a new outOfBoxExperienceSettings and sets the default values.
        /// </summary>
        public OutOfBoxExperienceSettings() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceUsageType", (o,n) => { (o as OutOfBoxExperienceSettings).DeviceUsageType = n.GetEnumValue<WindowsDeviceUsageType>(); } },
                {"hideEscapeLink", (o,n) => { (o as OutOfBoxExperienceSettings).HideEscapeLink = n.GetBoolValue(); } },
                {"hideEULA", (o,n) => { (o as OutOfBoxExperienceSettings).HideEULA = n.GetBoolValue(); } },
                {"hidePrivacySettings", (o,n) => { (o as OutOfBoxExperienceSettings).HidePrivacySettings = n.GetBoolValue(); } },
                {"skipKeyboardSelectionPage", (o,n) => { (o as OutOfBoxExperienceSettings).SkipKeyboardSelectionPage = n.GetBoolValue(); } },
                {"userType", (o,n) => { (o as OutOfBoxExperienceSettings).UserType = n.GetEnumValue<WindowsUserType>(); } },
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

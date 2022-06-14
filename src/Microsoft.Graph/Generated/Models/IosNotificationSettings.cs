using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An item describing notification setting.</summary>
    public class IosNotificationSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Indicates the type of alert for notifications for this app. Possible values are: deviceDefault, banner, modal, none.</summary>
        public IosNotificationAlertType? AlertType {
            get { return BackingStore?.Get<IosNotificationAlertType?>(nameof(AlertType)); }
            set { BackingStore?.Set(nameof(AlertType), value); }
        }
        /// <summary>Application name to be associated with the bundleID.</summary>
        public string AppName {
            get { return BackingStore?.Get<string>(nameof(AppName)); }
            set { BackingStore?.Set(nameof(AppName), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether badges are allowed for this app.</summary>
        public bool? BadgesEnabled {
            get { return BackingStore?.Get<bool?>(nameof(BadgesEnabled)); }
            set { BackingStore?.Set(nameof(BadgesEnabled), value); }
        }
        /// <summary>Bundle id of app to which to apply these notification settings.</summary>
        public string BundleID {
            get { return BackingStore?.Get<string>(nameof(BundleID)); }
            set { BackingStore?.Set(nameof(BundleID), value); }
        }
        /// <summary>Indicates whether notifications are allowed for this app.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>(nameof(Enabled)); }
            set { BackingStore?.Set(nameof(Enabled), value); }
        }
        /// <summary>Overrides the notification preview policy set by the user on an iOS device. Possible values are: notConfigured, alwaysShow, hideWhenLocked, neverShow.</summary>
        public IosNotificationPreviewVisibility? PreviewVisibility {
            get { return BackingStore?.Get<IosNotificationPreviewVisibility?>(nameof(PreviewVisibility)); }
            set { BackingStore?.Set(nameof(PreviewVisibility), value); }
        }
        /// <summary>Publisher to be associated with the bundleID.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>Indicates whether notifications can be shown in notification center.</summary>
        public bool? ShowInNotificationCenter {
            get { return BackingStore?.Get<bool?>(nameof(ShowInNotificationCenter)); }
            set { BackingStore?.Set(nameof(ShowInNotificationCenter), value); }
        }
        /// <summary>Indicates whether notifications can be shown on the lock screen.</summary>
        public bool? ShowOnLockScreen {
            get { return BackingStore?.Get<bool?>(nameof(ShowOnLockScreen)); }
            set { BackingStore?.Set(nameof(ShowOnLockScreen), value); }
        }
        /// <summary>Indicates whether sounds are allowed for this app.</summary>
        public bool? SoundsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SoundsEnabled)); }
            set { BackingStore?.Set(nameof(SoundsEnabled), value); }
        }
        /// <summary>
        /// Instantiates a new iosNotificationSettings and sets the default values.
        /// </summary>
        public IosNotificationSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosNotificationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosNotificationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertType", n => { AlertType = n.GetEnumValue<IosNotificationAlertType>(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"badgesEnabled", n => { BadgesEnabled = n.GetBoolValue(); } },
                {"bundleID", n => { BundleID = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"previewVisibility", n => { PreviewVisibility = n.GetEnumValue<IosNotificationPreviewVisibility>(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"showInNotificationCenter", n => { ShowInNotificationCenter = n.GetBoolValue(); } },
                {"showOnLockScreen", n => { ShowOnLockScreen = n.GetBoolValue(); } },
                {"soundsEnabled", n => { SoundsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<IosNotificationAlertType>("alertType", AlertType);
            writer.WriteStringValue("appName", AppName);
            writer.WriteBoolValue("badgesEnabled", BadgesEnabled);
            writer.WriteStringValue("bundleID", BundleID);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<IosNotificationPreviewVisibility>("previewVisibility", PreviewVisibility);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteBoolValue("showInNotificationCenter", ShowInNotificationCenter);
            writer.WriteBoolValue("showOnLockScreen", ShowOnLockScreen);
            writer.WriteBoolValue("soundsEnabled", SoundsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

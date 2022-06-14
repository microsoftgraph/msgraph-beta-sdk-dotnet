using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase, IParsable {
        /// <summary>Asset tag information for the device, displayed on the login window and lock screen.</summary>
        public string AssetTagTemplate {
            get { return BackingStore?.Get<string>(nameof(AssetTagTemplate)); }
            set { BackingStore?.Set(nameof(AssetTagTemplate), value); }
        }
        /// <summary>Gets or sets iOS Web Content Filter settings, supervised mode only</summary>
        public IosWebContentFilterBase ContentFilterSettings {
            get { return BackingStore?.Get<IosWebContentFilterBase>(nameof(ContentFilterSettings)); }
            set { BackingStore?.Set(nameof(ContentFilterSettings), value); }
        }
        /// <summary>A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.</summary>
        public List<IosHomeScreenItem> HomeScreenDockIcons {
            get { return BackingStore?.Get<List<IosHomeScreenItem>>(nameof(HomeScreenDockIcons)); }
            set { BackingStore?.Set(nameof(HomeScreenDockIcons), value); }
        }
        /// <summary>Gets or sets the number of rows to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridWidth must be configured as well.</summary>
        public int? HomeScreenGridHeight {
            get { return BackingStore?.Get<int?>(nameof(HomeScreenGridHeight)); }
            set { BackingStore?.Set(nameof(HomeScreenGridHeight), value); }
        }
        /// <summary>Gets or sets the number of columns to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridHeight must be configured as well.</summary>
        public int? HomeScreenGridWidth {
            get { return BackingStore?.Get<int?>(nameof(HomeScreenGridWidth)); }
            set { BackingStore?.Set(nameof(HomeScreenGridWidth), value); }
        }
        /// <summary>A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.</summary>
        public List<IosHomeScreenPage> HomeScreenPages {
            get { return BackingStore?.Get<List<IosHomeScreenPage>>(nameof(HomeScreenPages)); }
            set { BackingStore?.Set(nameof(HomeScreenPages), value); }
        }
        /// <summary>Identity Certificate for the renewal of Kerberos ticket used in single sign-on settings.</summary>
        public IosCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<IosCertificateProfileBase>(nameof(IdentityCertificateForClientAuthentication)); }
            set { BackingStore?.Set(nameof(IdentityCertificateForClientAuthentication), value); }
        }
        /// <summary>Gets or sets a single sign-on extension profile.</summary>
        public Microsoft.Graph.Beta.Models.IosSingleSignOnExtension IosSingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>(nameof(IosSingleSignOnExtension)); }
            set { BackingStore?.Set(nameof(IosSingleSignOnExtension), value); }
        }
        /// <summary>A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.</summary>
        public string LockScreenFootnote {
            get { return BackingStore?.Get<string>(nameof(LockScreenFootnote)); }
            set { BackingStore?.Set(nameof(LockScreenFootnote), value); }
        }
        /// <summary>Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.</summary>
        public List<IosNotificationSettings> NotificationSettings {
            get { return BackingStore?.Get<List<IosNotificationSettings>>(nameof(NotificationSettings)); }
            set { BackingStore?.Set(nameof(NotificationSettings), value); }
        }
        /// <summary>Gets or sets a single sign-on extension profile. Deprecated: use IOSSingleSignOnExtension instead.</summary>
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension SingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension>(nameof(SingleSignOnExtension)); }
            set { BackingStore?.Set(nameof(SingleSignOnExtension), value); }
        }
        /// <summary>PKINIT Certificate for the authentication with single sign-on extension settings.</summary>
        public IosCertificateProfileBase SingleSignOnExtensionPkinitCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase>(nameof(SingleSignOnExtensionPkinitCertificate)); }
            set { BackingStore?.Set(nameof(SingleSignOnExtensionPkinitCertificate), value); }
        }
        /// <summary>The Kerberos login settings that enable apps on receiving devices to authenticate smoothly.</summary>
        public IosSingleSignOnSettings SingleSignOnSettings {
            get { return BackingStore?.Get<IosSingleSignOnSettings>(nameof(SingleSignOnSettings)); }
            set { BackingStore?.Set(nameof(SingleSignOnSettings), value); }
        }
        /// <summary>A wallpaper display location specifier. Possible values are: notConfigured, lockScreen, homeScreen, lockAndHomeScreens.</summary>
        public IosWallpaperDisplayLocation? WallpaperDisplayLocation {
            get { return BackingStore?.Get<IosWallpaperDisplayLocation?>(nameof(WallpaperDisplayLocation)); }
            set { BackingStore?.Set(nameof(WallpaperDisplayLocation), value); }
        }
        /// <summary>A wallpaper image must be in either PNG or JPEG format. It requires a supervised device with iOS 8 or later version.</summary>
        public MimeContent WallpaperImage {
            get { return BackingStore?.Get<MimeContent>(nameof(WallpaperImage)); }
            set { BackingStore?.Set(nameof(WallpaperImage), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosDeviceFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosDeviceFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assetTagTemplate", n => { AssetTagTemplate = n.GetStringValue(); } },
                {"contentFilterSettings", n => { ContentFilterSettings = n.GetObjectValue<IosWebContentFilterBase>(IosWebContentFilterBase.CreateFromDiscriminatorValue); } },
                {"homeScreenDockIcons", n => { HomeScreenDockIcons = n.GetCollectionOfObjectValues<IosHomeScreenItem>(IosHomeScreenItem.CreateFromDiscriminatorValue).ToList(); } },
                {"homeScreenGridHeight", n => { HomeScreenGridHeight = n.GetIntValue(); } },
                {"homeScreenGridWidth", n => { HomeScreenGridWidth = n.GetIntValue(); } },
                {"homeScreenPages", n => { HomeScreenPages = n.GetCollectionOfObjectValues<IosHomeScreenPage>(IosHomeScreenPage.CreateFromDiscriminatorValue).ToList(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"iosSingleSignOnExtension", n => { IosSingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>(Microsoft.Graph.Beta.Models.IosSingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"lockScreenFootnote", n => { LockScreenFootnote = n.GetStringValue(); } },
                {"notificationSettings", n => { NotificationSettings = n.GetCollectionOfObjectValues<IosNotificationSettings>(IosNotificationSettings.CreateFromDiscriminatorValue).ToList(); } },
                {"singleSignOnExtension", n => { SingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>(Microsoft.Graph.Beta.Models.SingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"singleSignOnExtensionPkinitCertificate", n => { SingleSignOnExtensionPkinitCertificate = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"singleSignOnSettings", n => { SingleSignOnSettings = n.GetObjectValue<IosSingleSignOnSettings>(IosSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                {"wallpaperDisplayLocation", n => { WallpaperDisplayLocation = n.GetEnumValue<IosWallpaperDisplayLocation>(); } },
                {"wallpaperImage", n => { WallpaperImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assetTagTemplate", AssetTagTemplate);
            writer.WriteObjectValue<IosWebContentFilterBase>("contentFilterSettings", ContentFilterSettings);
            writer.WriteCollectionOfObjectValues<IosHomeScreenItem>("homeScreenDockIcons", HomeScreenDockIcons);
            writer.WriteIntValue("homeScreenGridHeight", HomeScreenGridHeight);
            writer.WriteIntValue("homeScreenGridWidth", HomeScreenGridWidth);
            writer.WriteCollectionOfObjectValues<IosHomeScreenPage>("homeScreenPages", HomeScreenPages);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>("iosSingleSignOnExtension", IosSingleSignOnExtension);
            writer.WriteStringValue("lockScreenFootnote", LockScreenFootnote);
            writer.WriteCollectionOfObjectValues<IosNotificationSettings>("notificationSettings", NotificationSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension", SingleSignOnExtension);
            writer.WriteObjectValue<IosCertificateProfileBase>("singleSignOnExtensionPkinitCertificate", SingleSignOnExtensionPkinitCertificate);
            writer.WriteObjectValue<IosSingleSignOnSettings>("singleSignOnSettings", SingleSignOnSettings);
            writer.WriteEnumValue<IosWallpaperDisplayLocation>("wallpaperDisplayLocation", WallpaperDisplayLocation);
            writer.WriteObjectValue<MimeContent>("wallpaperImage", WallpaperImage);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedStoreApp : MobileApp, IParsable {
        /// <summary>The Identity Name.</summary>
        public string AppIdentifier {
            get { return BackingStore?.Get<string>(nameof(AppIdentifier)); }
            set { BackingStore?.Set(nameof(AppIdentifier), value); }
        }
        /// <summary>The Play for Work Store app URL.</summary>
        public string AppStoreUrl {
            get { return BackingStore?.Get<string>(nameof(AppStoreUrl)); }
            set { BackingStore?.Set(nameof(AppStoreUrl), value); }
        }
        /// <summary>The tracks that are visible to this enterprise.</summary>
        public List<AndroidManagedStoreAppTrack> AppTracks {
            get { return BackingStore?.Get<List<AndroidManagedStoreAppTrack>>(nameof(AppTracks)); }
            set { BackingStore?.Set(nameof(AppTracks), value); }
        }
        /// <summary>Indicates whether the app is only available to a given enterprise&apos;s users.</summary>
        public bool? IsPrivate {
            get { return BackingStore?.Get<bool?>(nameof(IsPrivate)); }
            set { BackingStore?.Set(nameof(IsPrivate), value); }
        }
        /// <summary>Indicates whether the app is a preinstalled system app.</summary>
        public bool? IsSystemApp {
            get { return BackingStore?.Get<bool?>(nameof(IsSystemApp)); }
            set { BackingStore?.Set(nameof(IsSystemApp), value); }
        }
        /// <summary>The package identifier.</summary>
        public string PackageId {
            get { return BackingStore?.Get<string>(nameof(PackageId)); }
            set { BackingStore?.Set(nameof(PackageId), value); }
        }
        /// <summary>Whether this app supports OEMConfig policy.</summary>
        public bool? SupportsOemConfig {
            get { return BackingStore?.Get<bool?>(nameof(SupportsOemConfig)); }
            set { BackingStore?.Set(nameof(SupportsOemConfig), value); }
        }
        /// <summary>The total number of VPP licenses.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(TotalLicenseCount)); }
            set { BackingStore?.Set(nameof(TotalLicenseCount), value); }
        }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(UsedLicenseCount)); }
            set { BackingStore?.Set(nameof(UsedLicenseCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidManagedStoreApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appIdentifier", n => { AppIdentifier = n.GetStringValue(); } },
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"appTracks", n => { AppTracks = n.GetCollectionOfObjectValues<AndroidManagedStoreAppTrack>(AndroidManagedStoreAppTrack.CreateFromDiscriminatorValue).ToList(); } },
                {"isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                {"isSystemApp", n => { IsSystemApp = n.GetBoolValue(); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
                {"supportsOemConfig", n => { SupportsOemConfig = n.GetBoolValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appIdentifier", AppIdentifier);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteCollectionOfObjectValues<AndroidManagedStoreAppTrack>("appTracks", AppTracks);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteBoolValue("isSystemApp", IsSystemApp);
            writer.WriteStringValue("packageId", PackageId);
            writer.WriteBoolValue("supportsOemConfig", SupportsOemConfig);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
        }
    }
}

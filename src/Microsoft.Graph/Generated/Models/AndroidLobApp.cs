using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidLobApp : MobileLobApp, IParsable {
        /// <summary>The Identity Name.</summary>
        public string IdentityName {
            get { return BackingStore?.Get<string>(nameof(IdentityName)); }
            set { BackingStore?.Set(nameof(IdentityName), value); }
        }
        /// <summary>The identity version.</summary>
        public string IdentityVersion {
            get { return BackingStore?.Get<string>(nameof(IdentityVersion)); }
            set { BackingStore?.Set(nameof(IdentityVersion), value); }
        }
        /// <summary>The value for the minimum applicable operating system.</summary>
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<AndroidMinimumOperatingSystem>(nameof(MinimumSupportedOperatingSystem)); }
            set { BackingStore?.Set(nameof(MinimumSupportedOperatingSystem), value); }
        }
        /// <summary>The package identifier.</summary>
        public string PackageId {
            get { return BackingStore?.Get<string>(nameof(PackageId)); }
            set { BackingStore?.Set(nameof(PackageId), value); }
        }
        /// <summary>The version code of Android Line of Business (LoB) app.</summary>
        public string VersionCode {
            get { return BackingStore?.Get<string>(nameof(VersionCode)); }
            set { BackingStore?.Set(nameof(VersionCode), value); }
        }
        /// <summary>The version name of Android Line of Business (LoB) app.</summary>
        public string VersionName {
            get { return BackingStore?.Get<string>(nameof(VersionName)); }
            set { BackingStore?.Set(nameof(VersionName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<AndroidMinimumOperatingSystem>(AndroidMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
                {"versionCode", n => { VersionCode = n.GetStringValue(); } },
                {"versionName", n => { VersionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<AndroidMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("packageId", PackageId);
            writer.WriteStringValue("versionCode", VersionCode);
            writer.WriteStringValue("versionName", VersionName);
        }
    }
}

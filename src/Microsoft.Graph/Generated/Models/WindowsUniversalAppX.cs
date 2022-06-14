using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsUniversalAppX : MobileLobApp, IParsable {
        /// <summary>The Windows architecture(s) for which this app can run on. Possible values are: none, x86, x64, arm, neutral, arm64.</summary>
        public WindowsArchitecture? ApplicableArchitectures {
            get { return BackingStore?.Get<WindowsArchitecture?>(nameof(ApplicableArchitectures)); }
            set { BackingStore?.Set(nameof(ApplicableArchitectures), value); }
        }
        /// <summary>The Windows device type(s) for which this app can run on. Possible values are: none, desktop, mobile, holographic, team.</summary>
        public WindowsDeviceType? ApplicableDeviceTypes {
            get { return BackingStore?.Get<WindowsDeviceType?>(nameof(ApplicableDeviceTypes)); }
            set { BackingStore?.Set(nameof(ApplicableDeviceTypes), value); }
        }
        /// <summary>The collection of contained apps in the committed mobileAppContent of a windowsUniversalAppX app.</summary>
        public List<MobileContainedApp> CommittedContainedApps {
            get { return BackingStore?.Get<List<MobileContainedApp>>(nameof(CommittedContainedApps)); }
            set { BackingStore?.Set(nameof(CommittedContainedApps), value); }
        }
        /// <summary>The Identity Name.</summary>
        public string IdentityName {
            get { return BackingStore?.Get<string>(nameof(IdentityName)); }
            set { BackingStore?.Set(nameof(IdentityName), value); }
        }
        /// <summary>The Identity Publisher Hash.</summary>
        public string IdentityPublisherHash {
            get { return BackingStore?.Get<string>(nameof(IdentityPublisherHash)); }
            set { BackingStore?.Set(nameof(IdentityPublisherHash), value); }
        }
        /// <summary>The Identity Resource Identifier.</summary>
        public string IdentityResourceIdentifier {
            get { return BackingStore?.Get<string>(nameof(IdentityResourceIdentifier)); }
            set { BackingStore?.Set(nameof(IdentityResourceIdentifier), value); }
        }
        /// <summary>The identity version.</summary>
        public string IdentityVersion {
            get { return BackingStore?.Get<string>(nameof(IdentityVersion)); }
            set { BackingStore?.Set(nameof(IdentityVersion), value); }
        }
        /// <summary>Whether or not the app is a bundle.</summary>
        public bool? IsBundle {
            get { return BackingStore?.Get<bool?>(nameof(IsBundle)); }
            set { BackingStore?.Set(nameof(IsBundle), value); }
        }
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>(nameof(MinimumSupportedOperatingSystem)); }
            set { BackingStore?.Set(nameof(MinimumSupportedOperatingSystem), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUniversalAppX CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUniversalAppX();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<WindowsArchitecture>(); } },
                {"applicableDeviceTypes", n => { ApplicableDeviceTypes = n.GetEnumValue<WindowsDeviceType>(); } },
                {"committedContainedApps", n => { CommittedContainedApps = n.GetCollectionOfObjectValues<MobileContainedApp>(MobileContainedApp.CreateFromDiscriminatorValue).ToList(); } },
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityPublisherHash", n => { IdentityPublisherHash = n.GetStringValue(); } },
                {"identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"isBundle", n => { IsBundle = n.GetBoolValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteEnumValue<WindowsDeviceType>("applicableDeviceTypes", ApplicableDeviceTypes);
            writer.WriteCollectionOfObjectValues<MobileContainedApp>("committedContainedApps", CommittedContainedApps);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisherHash", IdentityPublisherHash);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteBoolValue("isBundle", IsBundle);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
        }
    }
}

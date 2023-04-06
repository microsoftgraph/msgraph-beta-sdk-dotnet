using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSDmgApp : MobileLobApp, IParsable {
        /// <summary>A value indicating whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for apps that use a self-update feature. Set this to false to install the app when it is not already installed on the device, or if the deploying app&apos;s version number does not match the version that&apos;s already installed on the device.</summary>
        public bool? IgnoreVersionDetection {
            get { return BackingStore?.Get<bool?>("ignoreVersionDetection"); }
            set { BackingStore?.Set("ignoreVersionDetection", value); }
        }
        /// <summary>The list of apps expected to be installed by the DMG.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSIncludedApp>? IncludedApps {
            get { return BackingStore?.Get<List<MacOSIncludedApp>?>("includedApps"); }
            set { BackingStore?.Set("includedApps", value); }
        }
#nullable restore
#else
        public List<MacOSIncludedApp> IncludedApps {
            get { return BackingStore?.Get<List<MacOSIncludedApp>>("includedApps"); }
            set { BackingStore?.Set("includedApps", value); }
        }
#endif
        /// <summary>The value for the minimum applicable operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<MacOSMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The primary CFBundleIdentifier of the DMG.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleId {
            get { return BackingStore?.Get<string?>("primaryBundleId"); }
            set { BackingStore?.Set("primaryBundleId", value); }
        }
#nullable restore
#else
        public string PrimaryBundleId {
            get { return BackingStore?.Get<string>("primaryBundleId"); }
            set { BackingStore?.Set("primaryBundleId", value); }
        }
#endif
        /// <summary>The primary CFBundleVersion of the DMG.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleVersion {
            get { return BackingStore?.Get<string?>("primaryBundleVersion"); }
            set { BackingStore?.Set("primaryBundleVersion", value); }
        }
#nullable restore
#else
        public string PrimaryBundleVersion {
            get { return BackingStore?.Get<string>("primaryBundleVersion"); }
            set { BackingStore?.Set("primaryBundleVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new MacOSDmgApp and sets the default values.
        /// </summary>
        public MacOSDmgApp() : base() {
            OdataType = "#microsoft.graph.macOSDmgApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSDmgApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSDmgApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                {"includedApps", n => { IncludedApps = n.GetCollectionOfObjectValues<MacOSIncludedApp>(MacOSIncludedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<MacOSMinimumOperatingSystem>(MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"primaryBundleId", n => { PrimaryBundleId = n.GetStringValue(); } },
                {"primaryBundleVersion", n => { PrimaryBundleVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteCollectionOfObjectValues<MacOSIncludedApp>("includedApps", IncludedApps);
            writer.WriteObjectValue<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("primaryBundleId", PrimaryBundleId);
            writer.WriteStringValue("primaryBundleVersion", PrimaryBundleVersion);
        }
    }
}

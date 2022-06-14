using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for the package information for a Windows line of business app.</summary>
    public class WindowsPackageInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The Windows architecture for which this app can run on. Possible values are: none, x86, x64, arm, neutral, arm64.</summary>
        public WindowsArchitecture? ApplicableArchitecture {
            get { return BackingStore?.Get<WindowsArchitecture?>(nameof(ApplicableArchitecture)); }
            set { BackingStore?.Set(nameof(ApplicableArchitecture), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Display Name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The Identity Name.</summary>
        public string IdentityName {
            get { return BackingStore?.Get<string>(nameof(IdentityName)); }
            set { BackingStore?.Set(nameof(IdentityName), value); }
        }
        /// <summary>The Identity Publisher.</summary>
        public string IdentityPublisher {
            get { return BackingStore?.Get<string>(nameof(IdentityPublisher)); }
            set { BackingStore?.Set(nameof(IdentityPublisher), value); }
        }
        /// <summary>The Identity Resource Identifier.</summary>
        public string IdentityResourceIdentifier {
            get { return BackingStore?.Get<string>(nameof(IdentityResourceIdentifier)); }
            set { BackingStore?.Set(nameof(IdentityResourceIdentifier), value); }
        }
        /// <summary>The Identity Version.</summary>
        public string IdentityVersion {
            get { return BackingStore?.Get<string>(nameof(IdentityVersion)); }
            set { BackingStore?.Set(nameof(IdentityVersion), value); }
        }
        /// <summary>The value for the minimum applicable operating system.</summary>
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>(nameof(MinimumSupportedOperatingSystem)); }
            set { BackingStore?.Set(nameof(MinimumSupportedOperatingSystem), value); }
        }
        /// <summary>
        /// Instantiates a new windowsPackageInformation and sets the default values.
        /// </summary>
        public WindowsPackageInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsPackageInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPackageInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicableArchitecture", n => { ApplicableArchitecture = n.GetEnumValue<WindowsArchitecture>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityPublisher", n => { IdentityPublisher = n.GetStringValue(); } },
                {"identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsArchitecture>("applicableArchitecture", ApplicableArchitecture);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisher", IdentityPublisher);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

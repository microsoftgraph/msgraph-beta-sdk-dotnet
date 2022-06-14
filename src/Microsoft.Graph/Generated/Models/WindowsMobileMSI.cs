using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsMobileMSI : MobileLobApp, IParsable {
        /// <summary>The command line.</summary>
        public string CommandLine {
            get { return BackingStore?.Get<string>(nameof(CommandLine)); }
            set { BackingStore?.Set(nameof(CommandLine), value); }
        }
        /// <summary>The identity version.</summary>
        public string IdentityVersion {
            get { return BackingStore?.Get<string>(nameof(IdentityVersion)); }
            set { BackingStore?.Set(nameof(IdentityVersion), value); }
        }
        /// <summary>A boolean to control whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection {
            get { return BackingStore?.Get<bool?>(nameof(IgnoreVersionDetection)); }
            set { BackingStore?.Set(nameof(IgnoreVersionDetection), value); }
        }
        /// <summary>The product code.</summary>
        public string ProductCode {
            get { return BackingStore?.Get<string>(nameof(ProductCode)); }
            set { BackingStore?.Set(nameof(ProductCode), value); }
        }
        /// <summary>The product version of Windows Mobile MSI Line of Business (LoB) app.</summary>
        public string ProductVersion {
            get { return BackingStore?.Get<string>(nameof(ProductVersion)); }
            set { BackingStore?.Set(nameof(ProductVersion), value); }
        }
        /// <summary>Indicates whether to install a dual-mode MSI in the device context. If true, app will be installed for all users. If false, app will be installed per-user. If null, service will use the MSI package&apos;s default install context. In case of dual-mode MSI, this default will be per-user.  Cannot be set for non-dual-mode apps.  Cannot be changed after initial creation of the application.</summary>
        public bool? UseDeviceContext {
            get { return BackingStore?.Get<bool?>(nameof(UseDeviceContext)); }
            set { BackingStore?.Set(nameof(UseDeviceContext), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsMobileMSI CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMobileMSI();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"commandLine", n => { CommandLine = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"useDeviceContext", n => { UseDeviceContext = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteBoolValue("useDeviceContext", UseDeviceContext);
        }
    }
}

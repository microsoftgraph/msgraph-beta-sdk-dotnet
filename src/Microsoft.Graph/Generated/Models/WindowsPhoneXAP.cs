using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhoneXAP : MobileLobApp, IParsable {
        /// <summary>The identity version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityVersion {
            get { return BackingStore?.Get<string?>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#nullable restore
#else
        public string IdentityVersion {
            get { return BackingStore?.Get<string>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#endif
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The Product Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductIdentifier {
            get { return BackingStore?.Get<string?>("productIdentifier"); }
            set { BackingStore?.Set("productIdentifier", value); }
        }
#nullable restore
#else
        public string ProductIdentifier {
            get { return BackingStore?.Get<string>("productIdentifier"); }
            set { BackingStore?.Set("productIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsPhoneXAP and sets the default values.
        /// </summary>
        public WindowsPhoneXAP() : base() {
            OdataType = "#microsoft.graph.windowsPhoneXAP";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhoneXAP CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhoneXAP();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"productIdentifier", n => { ProductIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("productIdentifier", ProductIdentifier);
        }
    }
}

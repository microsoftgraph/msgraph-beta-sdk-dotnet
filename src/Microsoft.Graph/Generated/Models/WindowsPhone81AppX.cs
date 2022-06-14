using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81AppX : MobileLobApp, IParsable {
        /// <summary>The Windows architecture(s) for which this app can run on. Possible values are: none, x86, x64, arm, neutral, arm64.</summary>
        public WindowsArchitecture? ApplicableArchitectures {
            get { return BackingStore?.Get<WindowsArchitecture?>(nameof(ApplicableArchitectures)); }
            set { BackingStore?.Set(nameof(ApplicableArchitectures), value); }
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
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>(nameof(MinimumSupportedOperatingSystem)); }
            set { BackingStore?.Set(nameof(MinimumSupportedOperatingSystem), value); }
        }
        /// <summary>The Phone Product Identifier.</summary>
        public string PhoneProductIdentifier {
            get { return BackingStore?.Get<string>(nameof(PhoneProductIdentifier)); }
            set { BackingStore?.Set(nameof(PhoneProductIdentifier), value); }
        }
        /// <summary>The Phone Publisher Id.</summary>
        public string PhonePublisherId {
            get { return BackingStore?.Get<string>(nameof(PhonePublisherId)); }
            set { BackingStore?.Set(nameof(PhonePublisherId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhone81AppX CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsPhone81AppXBundle" => new WindowsPhone81AppXBundle(),
                _ => new WindowsPhone81AppX(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<WindowsArchitecture>(); } },
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityPublisherHash", n => { IdentityPublisherHash = n.GetStringValue(); } },
                {"identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"phoneProductIdentifier", n => { PhoneProductIdentifier = n.GetStringValue(); } },
                {"phonePublisherId", n => { PhonePublisherId = n.GetStringValue(); } },
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
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisherHash", IdentityPublisherHash);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("phoneProductIdentifier", PhoneProductIdentifier);
            writer.WriteStringValue("phonePublisherId", PhonePublisherId);
        }
    }
}

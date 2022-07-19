using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosAzureAdSingleSignOnExtension : IosSingleSignOnExtension, IParsable {
        /// <summary>An optional list of additional bundle IDs allowed to use the AAD extension for single sign-on.</summary>
        public List<string> BundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>>("bundleIdAccessControlList"); }
            set { BackingStore?.Set("bundleIdAccessControlList", value); }
        }
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
        public List<KeyTypedValuePair> Configurations {
            get { return BackingStore?.Get<List<KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
        /// <summary>Enables or disables shared device mode.</summary>
        public bool? EnableSharedDeviceMode {
            get { return BackingStore?.Get<bool?>("enableSharedDeviceMode"); }
            set { BackingStore?.Set("enableSharedDeviceMode", value); }
        }
        /// <summary>
        /// Instantiates a new IosAzureAdSingleSignOnExtension and sets the default values.
        /// </summary>
        public IosAzureAdSingleSignOnExtension() : base() {
            OdataType = "#microsoft.graph.iosAzureAdSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosAzureAdSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAzureAdSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bundleIdAccessControlList", n => { BundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"configurations", n => { Configurations = n.GetCollectionOfObjectValues<KeyTypedValuePair>(KeyTypedValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"enableSharedDeviceMode", n => { EnableSharedDeviceMode = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("bundleIdAccessControlList", BundleIdAccessControlList);
            writer.WriteCollectionOfObjectValues<KeyTypedValuePair>("configurations", Configurations);
            writer.WriteBoolValue("enableSharedDeviceMode", EnableSharedDeviceMode);
        }
    }
}

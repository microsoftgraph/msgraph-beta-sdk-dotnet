using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties and inherited properties for Windows Phone 8.1 AppX Bundle Line Of Business apps. Inherits from graph.windowsPhone81AppX (which is also to be deprecated at the same time). Will be deprecated in February 2023.
    /// </summary>
    public class WindowsPhone81AppXBundle : WindowsPhone81AppX, IParsable {
        /// <summary>The list of AppX Package Information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsPackageInformation>? AppXPackageInformationList {
            get { return BackingStore?.Get<List<WindowsPackageInformation>?>("appXPackageInformationList"); }
            set { BackingStore?.Set("appXPackageInformationList", value); }
        }
#nullable restore
#else
        public List<WindowsPackageInformation> AppXPackageInformationList {
            get { return BackingStore?.Get<List<WindowsPackageInformation>>("appXPackageInformationList"); }
            set { BackingStore?.Set("appXPackageInformationList", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsPhone81AppXBundle and sets the default values.
        /// </summary>
        public WindowsPhone81AppXBundle() : base() {
            OdataType = "#microsoft.graph.windowsPhone81AppXBundle";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81AppXBundle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81AppXBundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appXPackageInformationList", n => { AppXPackageInformationList = n.GetCollectionOfObjectValues<WindowsPackageInformation>(WindowsPackageInformation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsPackageInformation>("appXPackageInformationList", AppXPackageInformationList);
        }
    }
}

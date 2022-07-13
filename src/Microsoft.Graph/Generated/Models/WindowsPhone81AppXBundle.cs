using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81AppXBundle : WindowsPhone81AppX, IParsable {
        /// <summary>The list of AppX Package Information.</summary>
        public List<WindowsPackageInformation> AppXPackageInformationList {
            get { return BackingStore?.Get<List<WindowsPackageInformation>>("appXPackageInformationList"); }
            set { BackingStore?.Set("appXPackageInformationList", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhone81AppXBundle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81AppXBundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appXPackageInformationList", n => { AppXPackageInformationList = n.GetCollectionOfObjectValues<WindowsPackageInformation>(WindowsPackageInformation.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsPackageInformation>("appXPackageInformationList", AppXPackageInformationList);
        }
    }
}

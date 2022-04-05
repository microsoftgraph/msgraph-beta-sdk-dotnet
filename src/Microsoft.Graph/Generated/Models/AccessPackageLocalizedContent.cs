using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageLocalizedContent : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fallback string, which is used when a requested localization is not available. Required.</summary>
        public string DefaultText { get; set; }
        /// <summary>Content represented in a format for a specific locale.</summary>
        public List<AccessPackageLocalizedText> LocalizedTexts { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageLocalizedContent and sets the default values.
        /// </summary>
        public AccessPackageLocalizedContent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageLocalizedContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageLocalizedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultText", (o,n) => { (o as AccessPackageLocalizedContent).DefaultText = n.GetStringValue(); } },
                {"localizedTexts", (o,n) => { (o as AccessPackageLocalizedContent).LocalizedTexts = n.GetCollectionOfObjectValues<AccessPackageLocalizedText>(AccessPackageLocalizedText.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultText", DefaultText);
            writer.WriteCollectionOfObjectValues<AccessPackageLocalizedText>("localizedTexts", LocalizedTexts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

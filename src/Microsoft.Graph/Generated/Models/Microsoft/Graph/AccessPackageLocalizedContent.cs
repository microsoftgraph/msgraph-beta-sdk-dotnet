using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageLocalizedContent : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultText", (o,n) => { (o as AccessPackageLocalizedContent).DefaultText = n.GetStringValue(); } },
                {"localizedTexts", (o,n) => { (o as AccessPackageLocalizedContent).LocalizedTexts = n.GetCollectionOfObjectValues<AccessPackageLocalizedText>().ToList(); } },
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

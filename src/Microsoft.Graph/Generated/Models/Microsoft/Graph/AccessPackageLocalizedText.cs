using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageLocalizedText : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ISO code for the intended language. Required.</summary>
        public string LanguageCode { get; set; }
        /// <summary>The text in the specific language. Required.</summary>
        public string Text { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageLocalizedText and sets the default values.
        /// </summary>
        public AccessPackageLocalizedText() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"languageCode", (o,n) => { (o as AccessPackageLocalizedText).LanguageCode = n.GetStringValue(); } },
                {"text", (o,n) => { (o as AccessPackageLocalizedText).Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("languageCode", LanguageCode);
            writer.WriteStringValue("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

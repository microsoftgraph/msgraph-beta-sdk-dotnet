using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TranslationLanguageOverride : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The language to apply the override.Returned by default. Not nullable.</summary>
        public string LanguageTag { get; set; }
        /// <summary>The translation override behavior for the language, if any.Returned by default. Not nullable.</summary>
        public TranslationBehavior? TranslationBehavior { get; set; }
        /// <summary>
        /// Instantiates a new translationLanguageOverride and sets the default values.
        /// </summary>
        public TranslationLanguageOverride() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"languageTag", (o,n) => { (o as TranslationLanguageOverride).LanguageTag = n.GetStringValue(); } },
                {"translationBehavior", (o,n) => { (o as TranslationLanguageOverride).TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteEnumValue<TranslationBehavior>("translationBehavior", TranslationBehavior);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

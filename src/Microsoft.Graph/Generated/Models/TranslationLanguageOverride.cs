using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TranslationLanguageOverride : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The language to apply the override.Returned by default. Not nullable.</summary>
        public string LanguageTag { get; set; }
        /// <summary>The translation override behavior for the language, if any.Returned by default. Not nullable.</summary>
        public Microsoft.Graph.Beta.Models.TranslationBehavior? TranslationBehavior { get; set; }
        /// <summary>
        /// Instantiates a new translationLanguageOverride and sets the default values.
        /// </summary>
        public TranslationLanguageOverride() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TranslationLanguageOverride CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslationLanguageOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"translationBehavior", n => { TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
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

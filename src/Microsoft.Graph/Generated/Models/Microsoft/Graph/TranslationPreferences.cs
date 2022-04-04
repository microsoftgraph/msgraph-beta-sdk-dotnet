using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TranslationPreferences : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Translation override behavior for languages, if any.Returned by default.</summary>
        public List<TranslationLanguageOverride> LanguageOverrides { get; set; }
        /// <summary>The user&apos;s preferred translation behavior.Returned by default. Not nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TranslationBehavior? TranslationBehavior { get; set; }
        /// <summary>The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings, and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include the language code without any country or region association. For example, it would specify &apos;fr&apos; for the neutral French culture, but not &apos;fr-FR&apos; for the French culture in France. Returned by default. Read only.</summary>
        public List<string> UntranslatedLanguages { get; set; }
        /// <summary>
        /// Instantiates a new translationPreferences and sets the default values.
        /// </summary>
        public TranslationPreferences() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TranslationPreferences CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslationPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"languageOverrides", (o,n) => { (o as TranslationPreferences).LanguageOverrides = n.GetCollectionOfObjectValues<TranslationLanguageOverride>(TranslationLanguageOverride.CreateFromDiscriminatorValue).ToList(); } },
                {"translationBehavior", (o,n) => { (o as TranslationPreferences).TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
                {"untranslatedLanguages", (o,n) => { (o as TranslationPreferences).UntranslatedLanguages = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TranslationLanguageOverride>("languageOverrides", LanguageOverrides);
            writer.WriteEnumValue<TranslationBehavior>("translationBehavior", TranslationBehavior);
            writer.WriteCollectionOfPrimitiveValues<string>("untranslatedLanguages", UntranslatedLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

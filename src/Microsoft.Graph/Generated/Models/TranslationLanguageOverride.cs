using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TranslationLanguageOverride : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The language to apply the override.Returned by default. Not nullable.</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>(nameof(LanguageTag)); }
            set { BackingStore?.Set(nameof(LanguageTag), value); }
        }
        /// <summary>The translation override behavior for the language, if any.Returned by default. Not nullable.</summary>
        public Microsoft.Graph.Beta.Models.TranslationBehavior? TranslationBehavior {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TranslationBehavior?>(nameof(TranslationBehavior)); }
            set { BackingStore?.Set(nameof(TranslationBehavior), value); }
        }
        /// <summary>
        /// Instantiates a new translationLanguageOverride and sets the default values.
        /// </summary>
        public TranslationLanguageOverride() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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

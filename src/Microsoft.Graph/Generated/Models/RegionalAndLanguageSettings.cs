using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RegionalAndLanguageSettings : Entity, IParsable {
        /// <summary>Prioritized list of languages the user reads and authors in.Returned by default. Not nullable.</summary>
        public List<LocaleInfo> AuthoringLanguages { get; set; }
        /// <summary>The  user&apos;s preferred user interface language (menus, buttons, ribbons, warning messages) for Microsoft web applications.Returned by default. Not nullable.</summary>
        public LocaleInfo DefaultDisplayLanguage { get; set; }
        /// <summary>The locale that drives the default date, time, and calendar formatting.Returned by default.</summary>
        public LocaleInfo DefaultRegionalFormat { get; set; }
        /// <summary>The language a user expected to use as input for text to speech scenarios.Returned by default.</summary>
        public LocaleInfo DefaultSpeechInputLanguage { get; set; }
        /// <summary>The language a user expects to have documents, emails, and messages translated into.Returned by default.</summary>
        public LocaleInfo DefaultTranslationLanguage { get; set; }
        /// <summary>Allows a user to override their defaultRegionalFormat with field specific formats.Returned by default.</summary>
        public Microsoft.Graph.Beta.Models.RegionalFormatOverrides RegionalFormatOverrides { get; set; }
        /// <summary>The user&apos;s preferred settings when consuming translated documents, emails, messages, and websites.Returned by default. Not nullable.</summary>
        public Microsoft.Graph.Beta.Models.TranslationPreferences TranslationPreferences { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RegionalAndLanguageSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegionalAndLanguageSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authoringLanguages", n => { AuthoringLanguages = n.GetCollectionOfObjectValues<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultDisplayLanguage", n => { DefaultDisplayLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultRegionalFormat", n => { DefaultRegionalFormat = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultSpeechInputLanguage", n => { DefaultSpeechInputLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultTranslationLanguage", n => { DefaultTranslationLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"regionalFormatOverrides", n => { RegionalFormatOverrides = n.GetObjectValue<Microsoft.Graph.Beta.Models.RegionalFormatOverrides>(Microsoft.Graph.Beta.Models.RegionalFormatOverrides.CreateFromDiscriminatorValue); } },
                {"translationPreferences", n => { TranslationPreferences = n.GetObjectValue<Microsoft.Graph.Beta.Models.TranslationPreferences>(Microsoft.Graph.Beta.Models.TranslationPreferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<LocaleInfo>("authoringLanguages", AuthoringLanguages);
            writer.WriteObjectValue<LocaleInfo>("defaultDisplayLanguage", DefaultDisplayLanguage);
            writer.WriteObjectValue<LocaleInfo>("defaultRegionalFormat", DefaultRegionalFormat);
            writer.WriteObjectValue<LocaleInfo>("defaultSpeechInputLanguage", DefaultSpeechInputLanguage);
            writer.WriteObjectValue<LocaleInfo>("defaultTranslationLanguage", DefaultTranslationLanguage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RegionalFormatOverrides>("regionalFormatOverrides", RegionalFormatOverrides);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TranslationPreferences>("translationPreferences", TranslationPreferences);
        }
    }
}

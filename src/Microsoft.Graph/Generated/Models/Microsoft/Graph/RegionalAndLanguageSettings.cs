using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RegionalAndLanguageSettings : Entity, IParsable {
        /// <summary>Prioritized list of languages the user reads and authors in.Returned by default. Not nullable.</summary>
        public List<LocaleInfo> AuthoringLanguages { get; set; }
        /// <summary>The  user's preferred user interface language (menus, buttons, ribbons, warning messages) for Microsoft web applications.Returned by default. Not nullable.</summary>
        public LocaleInfo DefaultDisplayLanguage { get; set; }
        /// <summary>The locale that drives the default date, time, and calendar formatting.Returned by default.</summary>
        public LocaleInfo DefaultRegionalFormat { get; set; }
        /// <summary>The language a user expected to use as input for text to speech scenarios.Returned by default.</summary>
        public LocaleInfo DefaultSpeechInputLanguage { get; set; }
        /// <summary>The language a user expects to have documents, emails, and messages translated into.Returned by default.</summary>
        public LocaleInfo DefaultTranslationLanguage { get; set; }
        /// <summary>Allows a user to override their defaultRegionalFormat with field specific formats.Returned by default.</summary>
        public RegionalFormatOverrides RegionalFormatOverrides { get; set; }
        /// <summary>The user's preferred settings when consuming translated documents, emails, messages, and websites.Returned by default. Not nullable.</summary>
        public TranslationPreferences TranslationPreferences { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authoringLanguages", (o,n) => { (o as RegionalAndLanguageSettings).AuthoringLanguages = n.GetCollectionOfObjectValues<LocaleInfo>().ToList(); } },
                {"defaultDisplayLanguage", (o,n) => { (o as RegionalAndLanguageSettings).DefaultDisplayLanguage = n.GetObjectValue<LocaleInfo>(); } },
                {"defaultRegionalFormat", (o,n) => { (o as RegionalAndLanguageSettings).DefaultRegionalFormat = n.GetObjectValue<LocaleInfo>(); } },
                {"defaultSpeechInputLanguage", (o,n) => { (o as RegionalAndLanguageSettings).DefaultSpeechInputLanguage = n.GetObjectValue<LocaleInfo>(); } },
                {"defaultTranslationLanguage", (o,n) => { (o as RegionalAndLanguageSettings).DefaultTranslationLanguage = n.GetObjectValue<LocaleInfo>(); } },
                {"regionalFormatOverrides", (o,n) => { (o as RegionalAndLanguageSettings).RegionalFormatOverrides = n.GetObjectValue<RegionalFormatOverrides>(); } },
                {"translationPreferences", (o,n) => { (o as RegionalAndLanguageSettings).TranslationPreferences = n.GetObjectValue<TranslationPreferences>(); } },
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
            writer.WriteObjectValue<RegionalFormatOverrides>("regionalFormatOverrides", RegionalFormatOverrides);
            writer.WriteObjectValue<TranslationPreferences>("translationPreferences", TranslationPreferences);
        }
    }
}

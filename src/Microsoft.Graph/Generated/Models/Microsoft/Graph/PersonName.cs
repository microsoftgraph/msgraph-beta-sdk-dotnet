using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class PersonName : ItemFacet, IParsable {
        /// <summary>Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.</summary>
        public string DisplayName { get; set; }
        /// <summary>First name of the user.</summary>
        public string First { get; set; }
        /// <summary>Initials of the user.</summary>
        public string Initials { get; set; }
        /// <summary>Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.</summary>
        public string LanguageTag { get; set; }
        /// <summary>Last name of the user.</summary>
        public string Last { get; set; }
        /// <summary>Maiden name of the user.</summary>
        public string Maiden { get; set; }
        /// <summary>Middle name of the user.</summary>
        public string Middle { get; set; }
        /// <summary>Nickname of the user.</summary>
        public string Nickname { get; set; }
        /// <summary>Guidance on how to pronounce the users name.</summary>
        public PersonNamePronounciation Pronunciation { get; set; }
        /// <summary>Designators used after the users name (eg: PhD.)</summary>
        public string Suffix { get; set; }
        /// <summary>Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)</summary>
        public string Title { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PersonName CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonName();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as PersonName).DisplayName = n.GetStringValue(); } },
                {"first", (o,n) => { (o as PersonName).First = n.GetStringValue(); } },
                {"initials", (o,n) => { (o as PersonName).Initials = n.GetStringValue(); } },
                {"languageTag", (o,n) => { (o as PersonName).LanguageTag = n.GetStringValue(); } },
                {"last", (o,n) => { (o as PersonName).Last = n.GetStringValue(); } },
                {"maiden", (o,n) => { (o as PersonName).Maiden = n.GetStringValue(); } },
                {"middle", (o,n) => { (o as PersonName).Middle = n.GetStringValue(); } },
                {"nickname", (o,n) => { (o as PersonName).Nickname = n.GetStringValue(); } },
                {"pronunciation", (o,n) => { (o as PersonName).Pronunciation = n.GetObjectValue<PersonNamePronounciation>(PersonNamePronounciation.CreateFromDiscriminatorValue); } },
                {"suffix", (o,n) => { (o as PersonName).Suffix = n.GetStringValue(); } },
                {"title", (o,n) => { (o as PersonName).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("maiden", Maiden);
            writer.WriteStringValue("middle", Middle);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteObjectValue<PersonNamePronounciation>("pronunciation", Pronunciation);
            writer.WriteStringValue("suffix", Suffix);
            writer.WriteStringValue("title", Title);
        }
    }
}

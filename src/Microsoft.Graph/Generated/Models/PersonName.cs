using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"first", n => { First = n.GetStringValue(); } },
                {"initials", n => { Initials = n.GetStringValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"last", n => { Last = n.GetStringValue(); } },
                {"maiden", n => { Maiden = n.GetStringValue(); } },
                {"middle", n => { Middle = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"pronunciation", n => { Pronunciation = n.GetObjectValue<PersonNamePronounciation>(PersonNamePronounciation.CreateFromDiscriminatorValue); } },
                {"suffix", n => { Suffix = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
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

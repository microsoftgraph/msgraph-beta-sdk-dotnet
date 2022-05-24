using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class PersonName : ItemFacet, IParsable {
        /// <summary>Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>First name of the user.</summary>
        public string First {
            get { return BackingStore?.Get<string>(nameof(First)); }
            set { BackingStore?.Set(nameof(First), value); }
        }
        /// <summary>Initials of the user.</summary>
        public string Initials {
            get { return BackingStore?.Get<string>(nameof(Initials)); }
            set { BackingStore?.Set(nameof(Initials), value); }
        }
        /// <summary>Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>(nameof(LanguageTag)); }
            set { BackingStore?.Set(nameof(LanguageTag), value); }
        }
        /// <summary>Last name of the user.</summary>
        public string Last {
            get { return BackingStore?.Get<string>(nameof(Last)); }
            set { BackingStore?.Set(nameof(Last), value); }
        }
        /// <summary>Maiden name of the user.</summary>
        public string Maiden {
            get { return BackingStore?.Get<string>(nameof(Maiden)); }
            set { BackingStore?.Set(nameof(Maiden), value); }
        }
        /// <summary>Middle name of the user.</summary>
        public string Middle {
            get { return BackingStore?.Get<string>(nameof(Middle)); }
            set { BackingStore?.Set(nameof(Middle), value); }
        }
        /// <summary>Nickname of the user.</summary>
        public string Nickname {
            get { return BackingStore?.Get<string>(nameof(Nickname)); }
            set { BackingStore?.Set(nameof(Nickname), value); }
        }
        /// <summary>Guidance on how to pronounce the users name.</summary>
        public PersonNamePronounciation Pronunciation {
            get { return BackingStore?.Get<PersonNamePronounciation>(nameof(Pronunciation)); }
            set { BackingStore?.Set(nameof(Pronunciation), value); }
        }
        /// <summary>Designators used after the users name (eg: PhD.)</summary>
        public string Suffix {
            get { return BackingStore?.Get<string>(nameof(Suffix)); }
            set { BackingStore?.Set(nameof(Suffix), value); }
        }
        /// <summary>Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
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

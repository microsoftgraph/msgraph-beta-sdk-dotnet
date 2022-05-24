using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TermStore {
    /// <summary>Casts the previous resource to user.</summary>
    public class Store : Entity, IParsable {
        /// <summary>Default language of the term store.</summary>
        public string DefaultLanguageTag {
            get { return BackingStore?.Get<string>(nameof(DefaultLanguageTag)); }
            set { BackingStore?.Set(nameof(DefaultLanguageTag), value); }
        }
        /// <summary>Collection of all groups available in the term store.</summary>
        public List<Group> Groups {
            get { return BackingStore?.Get<List<Group>>(nameof(Groups)); }
            set { BackingStore?.Set(nameof(Groups), value); }
        }
        /// <summary>List of languages for the term store.</summary>
        public List<string> LanguageTags {
            get { return BackingStore?.Get<List<string>>(nameof(LanguageTags)); }
            set { BackingStore?.Set(nameof(LanguageTags), value); }
        }
        /// <summary>Collection of all sets available in the term store.</summary>
        public List<Set> Sets {
            get { return BackingStore?.Get<List<Set>>(nameof(Sets)); }
            set { BackingStore?.Set(nameof(Sets), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Store CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Store();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultLanguageTag", n => { DefaultLanguageTag = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue).ToList(); } },
                {"languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sets", n => { Sets = n.GetCollectionOfObjectValues<Set>(Set.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultLanguageTag", DefaultLanguageTag);
            writer.WriteCollectionOfObjectValues<Group>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfObjectValues<Set>("sets", Sets);
        }
    }
}

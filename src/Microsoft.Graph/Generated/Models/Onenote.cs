using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Onenote : Entity, IParsable {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
        public List<Notebook> Notebooks {
            get { return BackingStore?.Get<List<Notebook>>(nameof(Notebooks)); }
            set { BackingStore?.Set(nameof(Notebooks), value); }
        }
        /// <summary>The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
        public List<OnenoteOperation> Operations {
            get { return BackingStore?.Get<List<OnenoteOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<OnenotePage> Pages {
            get { return BackingStore?.Get<List<OnenotePage>>(nameof(Pages)); }
            set { BackingStore?.Set(nameof(Pages), value); }
        }
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
        public List<OnenoteResource> Resources {
            get { return BackingStore?.Get<List<OnenoteResource>>(nameof(Resources)); }
            set { BackingStore?.Set(nameof(Resources), value); }
        }
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<SectionGroup> SectionGroups {
            get { return BackingStore?.Get<List<SectionGroup>>(nameof(SectionGroups)); }
            set { BackingStore?.Set(nameof(SectionGroups), value); }
        }
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<OnenoteSection> Sections {
            get { return BackingStore?.Get<List<OnenoteSection>>(nameof(Sections)); }
            set { BackingStore?.Set(nameof(Sections), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Onenote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Onenote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"notebooks", n => { Notebooks = n.GetCollectionOfObjectValues<Notebook>(Notebook.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<OnenoteOperation>(OnenoteOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<OnenotePage>(OnenotePage.CreateFromDiscriminatorValue).ToList(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<OnenoteResource>(OnenoteResource.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Notebook>("notebooks", Notebooks);
            writer.WriteCollectionOfObjectValues<OnenoteOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<OnenotePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<OnenoteResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
        }
    }
}

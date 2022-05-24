using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Notebook : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>Indicates whether this is the user&apos;s default notebook. Read-only.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>(nameof(IsShared)); }
            set { BackingStore?.Set(nameof(IsShared), value); }
        }
        /// <summary>Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote native client if it&apos;s installed. The oneNoteWebURL link opens the notebook in OneNote on the web.</summary>
        public NotebookLinks Links {
            get { return BackingStore?.Get<NotebookLinks>(nameof(Links)); }
            set { BackingStore?.Set(nameof(Links), value); }
        }
        /// <summary>The section groups in the notebook. Read-only. Nullable.</summary>
        public List<SectionGroup> SectionGroups {
            get { return BackingStore?.Get<List<SectionGroup>>(nameof(SectionGroups)); }
            set { BackingStore?.Set(nameof(SectionGroups), value); }
        }
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.</summary>
        public string SectionGroupsUrl {
            get { return BackingStore?.Get<string>(nameof(SectionGroupsUrl)); }
            set { BackingStore?.Set(nameof(SectionGroupsUrl), value); }
        }
        /// <summary>The sections in the notebook. Read-only. Nullable.</summary>
        public List<OnenoteSection> Sections {
            get { return BackingStore?.Get<List<OnenoteSection>>(nameof(Sections)); }
            set { BackingStore?.Set(nameof(Sections), value); }
        }
        /// <summary>The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.</summary>
        public string SectionsUrl {
            get { return BackingStore?.Get<string>(nameof(SectionsUrl)); }
            set { BackingStore?.Set(nameof(SectionsUrl), value); }
        }
        /// <summary>Possible values are: Owner, Contributor, Reader, None. Owner represents owner-level access to the notebook. Contributor represents read/write access to the notebook. Reader represents read-only access to the notebook. Read-only.</summary>
        public OnenoteUserRole? UserRole {
            get { return BackingStore?.Get<OnenoteUserRole?>(nameof(UserRole)); }
            set { BackingStore?.Set(nameof(UserRole), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Notebook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Notebook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"links", n => { Links = n.GetObjectValue<NotebookLinks>(NotebookLinks.CreateFromDiscriminatorValue); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                {"userRole", n => { UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteObjectValue<NotebookLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
        }
    }
}

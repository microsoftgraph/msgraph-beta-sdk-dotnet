using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CopyNotebookModel : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The createdBy property</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The createdByIdentity property</summary>
        public IdentitySet CreatedByIdentity {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedByIdentity)); }
            set { BackingStore?.Set(nameof(CreatedByIdentity), value); }
        }
        /// <summary>The createdTime property</summary>
        public DateTimeOffset? CreatedTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedTime)); }
            set { BackingStore?.Set(nameof(CreatedTime), value); }
        }
        /// <summary>The id property</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>The isShared property</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>(nameof(IsShared)); }
            set { BackingStore?.Set(nameof(IsShared), value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public string LastModifiedBy {
            get { return BackingStore?.Get<string>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The lastModifiedByIdentity property</summary>
        public IdentitySet LastModifiedByIdentity {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedByIdentity)); }
            set { BackingStore?.Set(nameof(LastModifiedByIdentity), value); }
        }
        /// <summary>The lastModifiedTime property</summary>
        public DateTimeOffset? LastModifiedTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedTime)); }
            set { BackingStore?.Set(nameof(LastModifiedTime), value); }
        }
        /// <summary>The links property</summary>
        public NotebookLinks Links {
            get { return BackingStore?.Get<NotebookLinks>(nameof(Links)); }
            set { BackingStore?.Set(nameof(Links), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The sectionGroupsUrl property</summary>
        public string SectionGroupsUrl {
            get { return BackingStore?.Get<string>(nameof(SectionGroupsUrl)); }
            set { BackingStore?.Set(nameof(SectionGroupsUrl), value); }
        }
        /// <summary>The sectionsUrl property</summary>
        public string SectionsUrl {
            get { return BackingStore?.Get<string>(nameof(SectionsUrl)); }
            set { BackingStore?.Set(nameof(SectionsUrl), value); }
        }
        /// <summary>The self property</summary>
        public string Self {
            get { return BackingStore?.Get<string>(nameof(Self)); }
            set { BackingStore?.Set(nameof(Self), value); }
        }
        /// <summary>The userRole property</summary>
        public OnenoteUserRole? UserRole {
            get { return BackingStore?.Get<OnenoteUserRole?>(nameof(UserRole)); }
            set { BackingStore?.Set(nameof(UserRole), value); }
        }
        /// <summary>
        /// Instantiates a new CopyNotebookModel and sets the default values.
        /// </summary>
        public CopyNotebookModel() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyNotebookModel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyNotebookModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdByIdentity", n => { CreatedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdTime", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedByIdentity", n => { LastModifiedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedTime", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"links", n => { Links = n.GetObjectValue<NotebookLinks>(NotebookLinks.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"userRole", n => { UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteObjectValue<IdentitySet>("createdByIdentity", CreatedByIdentity);
            writer.WriteDateTimeOffsetValue("createdTime", CreatedTime);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<IdentitySet>("lastModifiedByIdentity", LastModifiedByIdentity);
            writer.WriteDateTimeOffsetValue("lastModifiedTime", LastModifiedTime);
            writer.WriteObjectValue<NotebookLinks>("links", Links);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteStringValue("self", Self);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

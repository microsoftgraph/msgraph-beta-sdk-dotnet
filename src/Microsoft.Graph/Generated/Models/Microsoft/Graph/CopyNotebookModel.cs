using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CopyNotebookModel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdBy property</summary>
        public string CreatedBy { get; set; }
        /// <summary>The createdByIdentity property</summary>
        public IdentitySet CreatedByIdentity { get; set; }
        /// <summary>The createdTime property</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The isShared property</summary>
        public bool? IsShared { get; set; }
        /// <summary>The lastModifiedBy property</summary>
        public string LastModifiedBy { get; set; }
        /// <summary>The lastModifiedByIdentity property</summary>
        public IdentitySet LastModifiedByIdentity { get; set; }
        /// <summary>The lastModifiedTime property</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The links property</summary>
        public NotebookLinks Links { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The sectionGroupsUrl property</summary>
        public string SectionGroupsUrl { get; set; }
        /// <summary>The sectionsUrl property</summary>
        public string SectionsUrl { get; set; }
        /// <summary>The self property</summary>
        public string Self { get; set; }
        /// <summary>The userRole property</summary>
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new CopyNotebookModel and sets the default values.
        /// </summary>
        public CopyNotebookModel() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"createdBy", (o,n) => { (o as CopyNotebookModel).CreatedBy = n.GetStringValue(); } },
                {"createdByIdentity", (o,n) => { (o as CopyNotebookModel).CreatedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdTime", (o,n) => { (o as CopyNotebookModel).CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"id", (o,n) => { (o as CopyNotebookModel).Id = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as CopyNotebookModel).IsDefault = n.GetBoolValue(); } },
                {"isShared", (o,n) => { (o as CopyNotebookModel).IsShared = n.GetBoolValue(); } },
                {"lastModifiedBy", (o,n) => { (o as CopyNotebookModel).LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedByIdentity", (o,n) => { (o as CopyNotebookModel).LastModifiedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedTime", (o,n) => { (o as CopyNotebookModel).LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"links", (o,n) => { (o as CopyNotebookModel).Links = n.GetObjectValue<NotebookLinks>(NotebookLinks.CreateFromDiscriminatorValue); } },
                {"name", (o,n) => { (o as CopyNotebookModel).Name = n.GetStringValue(); } },
                {"sectionGroupsUrl", (o,n) => { (o as CopyNotebookModel).SectionGroupsUrl = n.GetStringValue(); } },
                {"sectionsUrl", (o,n) => { (o as CopyNotebookModel).SectionsUrl = n.GetStringValue(); } },
                {"self", (o,n) => { (o as CopyNotebookModel).Self = n.GetStringValue(); } },
                {"userRole", (o,n) => { (o as CopyNotebookModel).UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
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

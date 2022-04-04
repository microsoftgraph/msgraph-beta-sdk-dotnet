using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class Tag : Entity, IParsable {
        /// <summary>Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.ChildSelectability? ChildSelectability { get; set; }
        /// <summary>Returns the tags that are a child of a tag.</summary>
        public List<Tag> ChildTags { get; set; }
        /// <summary>The user who created the tag.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.IdentitySet CreatedBy { get; set; }
        /// <summary>The description for the tag.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the tag.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time the tag was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Returns the parent tag of the specified tag.</summary>
        public Tag Parent { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Tag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Tag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"childSelectability", (o,n) => { (o as Tag).ChildSelectability = n.GetEnumValue<ChildSelectability>(); } },
                {"childTags", (o,n) => { (o as Tag).ChildTags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", (o,n) => { (o as Tag).CreatedBy = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.IdentitySet>(MicrosoftGraphSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as Tag).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Tag).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Tag).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parent", (o,n) => { (o as Tag).Parent = n.GetObjectValue<Tag>(Tag.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChildSelectability>("childSelectability", ChildSelectability);
            writer.WriteCollectionOfObjectValues<Tag>("childTags", ChildTags);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Tag>("parent", Parent);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Tag : Entity, IParsable {
        /// <summary>Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.ChildSelectability? ChildSelectability {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.ChildSelectability?>(nameof(ChildSelectability)); }
            set { BackingStore?.Set(nameof(ChildSelectability), value); }
        }
        /// <summary>Returns the tags that are a child of a tag.</summary>
        public List<Tag> ChildTags {
            get { return BackingStore?.Get<List<Tag>>(nameof(ChildTags)); }
            set { BackingStore?.Set(nameof(ChildTags), value); }
        }
        /// <summary>The user who created the tag.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The description for the tag.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Display name of the tag.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date and time the tag was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Returns the parent tag of the specified tag.</summary>
        public Tag Parent {
            get { return BackingStore?.Get<Tag>(nameof(Parent)); }
            set { BackingStore?.Set(nameof(Parent), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childSelectability", n => { ChildSelectability = n.GetEnumValue<ChildSelectability>(); } },
                {"childTags", n => { ChildTags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<Tag>(Tag.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Tag>("parent", Parent);
        }
    }
}

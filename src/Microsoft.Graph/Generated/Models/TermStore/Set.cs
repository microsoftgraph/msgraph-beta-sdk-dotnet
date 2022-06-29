using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TermStore {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Set : Entity, IParsable {
        /// <summary>Children terms of set in term [store].</summary>
        public List<Term> Children {
            get { return BackingStore?.Get<List<Term>>(nameof(Children)); }
            set { BackingStore?.Set(nameof(Children), value); }
        }
        /// <summary>Date and time of set creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Description giving details on the term usage.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Name of the set for each languageTag.</summary>
        public List<LocalizedName> LocalizedNames {
            get { return BackingStore?.Get<List<LocalizedName>>(nameof(LocalizedNames)); }
            set { BackingStore?.Set(nameof(LocalizedNames), value); }
        }
        /// <summary>The parentGroup property</summary>
        public Group ParentGroup {
            get { return BackingStore?.Get<Group>(nameof(ParentGroup)); }
            set { BackingStore?.Set(nameof(ParentGroup), value); }
        }
        /// <summary>Custom properties for the set.</summary>
        public List<Microsoft.Graph.Beta.Models.KeyValue> Properties {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>>(nameof(Properties)); }
            set { BackingStore?.Set(nameof(Properties), value); }
        }
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
        public List<Relation> Relations {
            get { return BackingStore?.Get<List<Relation>>(nameof(Relations)); }
            set { BackingStore?.Set(nameof(Relations), value); }
        }
        /// <summary>All the terms under the set.</summary>
        public List<Term> Terms {
            get { return BackingStore?.Get<List<Term>>(nameof(Terms)); }
            set { BackingStore?.Set(nameof(Terms), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Set CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Set();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"children", n => { Children = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"localizedNames", n => { LocalizedNames = n.GetCollectionOfObjectValues<LocalizedName>(LocalizedName.CreateFromDiscriminatorValue).ToList(); } },
                {"parentGroup", n => { ParentGroup = n.GetObjectValue<Group>(Group.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>(Microsoft.Graph.Beta.Models.KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"relations", n => { Relations = n.GetCollectionOfObjectValues<Relation>(Relation.CreateFromDiscriminatorValue).ToList(); } },
                {"terms", n => { Terms = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<LocalizedName>("localizedNames", LocalizedNames);
            writer.WriteObjectValue<Group>("parentGroup", ParentGroup);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<Relation>("relations", Relations);
            writer.WriteCollectionOfObjectValues<Term>("terms", Terms);
        }
    }
}

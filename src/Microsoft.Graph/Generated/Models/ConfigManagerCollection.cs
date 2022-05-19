using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A ConfigManager defined collection of devices or users.</summary>
    public class ConfigManagerCollection : Entity, IParsable {
        /// <summary>The collection identifier in SCCM.</summary>
        public string CollectionIdentifier {
            get { return BackingStore?.Get<string>(nameof(CollectionIdentifier)); }
            set { BackingStore?.Set(nameof(CollectionIdentifier), value); }
        }
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The DisplayName.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The Hierarchy Identifier.</summary>
        public string HierarchyIdentifier {
            get { return BackingStore?.Get<string>(nameof(HierarchyIdentifier)); }
            set { BackingStore?.Set(nameof(HierarchyIdentifier), value); }
        }
        /// <summary>The HierarchyName.</summary>
        public string HierarchyName {
            get { return BackingStore?.Get<string>(nameof(HierarchyName)); }
            set { BackingStore?.Set(nameof(HierarchyName), value); }
        }
        /// <summary>The last modified date.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConfigManagerCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigManagerCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"collectionIdentifier", n => { CollectionIdentifier = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hierarchyIdentifier", n => { HierarchyIdentifier = n.GetStringValue(); } },
                {"hierarchyName", n => { HierarchyName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("collectionIdentifier", CollectionIdentifier);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("hierarchyIdentifier", HierarchyIdentifier);
            writer.WriteStringValue("hierarchyName", HierarchyName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}

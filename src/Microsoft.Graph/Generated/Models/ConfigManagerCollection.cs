using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConfigManagerCollection : Entity, IParsable {
        /// <summary>The collection identifier in SCCM.</summary>
        public string CollectionIdentifier {
            get { return BackingStore?.Get<string>("collectionIdentifier"); }
            set { BackingStore?.Set("collectionIdentifier", value); }
        }
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The DisplayName.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The Hierarchy Identifier.</summary>
        public string HierarchyIdentifier {
            get { return BackingStore?.Get<string>("hierarchyIdentifier"); }
            set { BackingStore?.Set("hierarchyIdentifier", value); }
        }
        /// <summary>The HierarchyName.</summary>
        public string HierarchyName {
            get { return BackingStore?.Get<string>("hierarchyName"); }
            set { BackingStore?.Set("hierarchyName", value); }
        }
        /// <summary>The last modified date.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new ConfigManagerCollection and sets the default values.
        /// </summary>
        public ConfigManagerCollection() : base() {
            OdataType = "#microsoft.graph.configManagerCollection";
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

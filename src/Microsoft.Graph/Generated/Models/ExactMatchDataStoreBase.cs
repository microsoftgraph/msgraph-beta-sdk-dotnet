using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ExactMatchDataStoreBase : Entity, IParsable {
        /// <summary>The columns property</summary>
        public List<ExactDataMatchStoreColumn> Columns {
            get { return BackingStore?.Get<List<ExactDataMatchStoreColumn>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
        /// <summary>The dataLastUpdatedDateTime property</summary>
        public DateTimeOffset? DataLastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dataLastUpdatedDateTime"); }
            set { BackingStore?.Set("dataLastUpdatedDateTime", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>
        /// Instantiates a new exactMatchDataStoreBase and sets the default values.
        /// </summary>
        public ExactMatchDataStoreBase() : base() {
            OdataType = "#microsoft.graph.exactMatchDataStoreBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchDataStoreBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.exactMatchDataStore" => new ExactMatchDataStore(),
                _ => new ExactMatchDataStoreBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ExactDataMatchStoreColumn>(ExactDataMatchStoreColumn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dataLastUpdatedDateTime", n => { DataLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ExactDataMatchStoreColumn>("columns", Columns);
            writer.WriteDateTimeOffsetValue("dataLastUpdatedDateTime", DataLastUpdatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ExactMatchDataStoreBase : Entity, IParsable {
        public List<ExactDataMatchStoreColumn> Columns { get; set; }
        public DateTimeOffset? DataLastUpdatedDateTime { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchDataStoreBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchDataStoreBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"columns", (o,n) => { (o as ExactMatchDataStoreBase).Columns = n.GetCollectionOfObjectValues<ExactDataMatchStoreColumn>(ExactDataMatchStoreColumn.CreateFromDiscriminatorValue).ToList(); } },
                {"dataLastUpdatedDateTime", (o,n) => { (o as ExactMatchDataStoreBase).DataLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ExactMatchDataStoreBase).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ExactMatchDataStoreBase).DisplayName = n.GetStringValue(); } },
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

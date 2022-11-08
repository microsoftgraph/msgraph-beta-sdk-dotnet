using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchLookupJob : ExactMatchJobBase, IParsable {
        /// <summary>The matchingRows property</summary>
        public List<LookupResultRow> MatchingRows {
            get { return BackingStore?.Get<List<LookupResultRow>>("matchingRows"); }
            set { BackingStore?.Set("matchingRows", value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new ExactMatchLookupJob and sets the default values.
        /// </summary>
        public ExactMatchLookupJob() : base() {
            OdataType = "#microsoft.graph.exactMatchLookupJob";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExactMatchLookupJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchLookupJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"matchingRows", n => { MatchingRows = n.GetCollectionOfObjectValues<LookupResultRow>(LookupResultRow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<LookupResultRow>("matchingRows", MatchingRows);
            writer.WriteStringValue("state", State);
        }
    }
}

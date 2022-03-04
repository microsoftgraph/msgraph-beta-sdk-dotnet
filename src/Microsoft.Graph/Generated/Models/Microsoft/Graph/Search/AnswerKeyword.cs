using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Search {
    public class AnswerKeyword : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of keywords used to trigger the search answer.</summary>
        public List<string> Keywords { get; set; }
        /// <summary>If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.</summary>
        public bool? MatchSimilarKeywords { get; set; }
        /// <summary>Unique keywords that will guarantee the search answer is triggered.</summary>
        public List<string> ReservedKeywords { get; set; }
        /// <summary>
        /// Instantiates a new answerKeyword and sets the default values.
        /// </summary>
        public AnswerKeyword() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AnswerKeyword CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerKeyword();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keywords", (o,n) => { (o as AnswerKeyword).Keywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"matchSimilarKeywords", (o,n) => { (o as AnswerKeyword).MatchSimilarKeywords = n.GetBoolValue(); } },
                {"reservedKeywords", (o,n) => { (o as AnswerKeyword).ReservedKeywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteBoolValue("matchSimilarKeywords", MatchSimilarKeywords);
            writer.WriteCollectionOfPrimitiveValues<string>("reservedKeywords", ReservedKeywords);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

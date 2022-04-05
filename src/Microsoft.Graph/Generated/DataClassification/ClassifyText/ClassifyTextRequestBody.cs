using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DataClassification.ClassifyText {
    /// <summary>Provides operations to call the classifyText method.</summary>
    public class ClassifyTextRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fileExtension property</summary>
        public string FileExtension { get; set; }
        /// <summary>The matchTolerancesToInclude property</summary>
        public MlClassificationMatchTolerance? MatchTolerancesToInclude { get; set; }
        /// <summary>The scopesToRun property</summary>
        public SensitiveTypeScope? ScopesToRun { get; set; }
        /// <summary>The sensitiveTypeIds property</summary>
        public List<string> SensitiveTypeIds { get; set; }
        /// <summary>The text property</summary>
        public string Text { get; set; }
        /// <summary>
        /// Instantiates a new classifyTextRequestBody and sets the default values.
        /// </summary>
        public ClassifyTextRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassifyTextRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassifyTextRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fileExtension", (o,n) => { (o as ClassifyTextRequestBody).FileExtension = n.GetStringValue(); } },
                {"matchTolerancesToInclude", (o,n) => { (o as ClassifyTextRequestBody).MatchTolerancesToInclude = n.GetEnumValue<MlClassificationMatchTolerance>(); } },
                {"scopesToRun", (o,n) => { (o as ClassifyTextRequestBody).ScopesToRun = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeIds", (o,n) => { (o as ClassifyTextRequestBody).SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"text", (o,n) => { (o as ClassifyTextRequestBody).Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fileExtension", FileExtension);
            writer.WriteEnumValue<MlClassificationMatchTolerance>("matchTolerancesToInclude", MatchTolerancesToInclude);
            writer.WriteEnumValue<SensitiveTypeScope>("scopesToRun", ScopesToRun);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
            writer.WriteStringValue("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

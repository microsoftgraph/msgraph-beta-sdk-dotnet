using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchSession : ExactMatchSessionBase, IParsable {
        /// <summary>The checksum property</summary>
        public string Checksum { get; set; }
        /// <summary>The dataUploadURI property</summary>
        public string DataUploadURI { get; set; }
        /// <summary>The fields property</summary>
        public List<string> Fields { get; set; }
        /// <summary>The fileName property</summary>
        public string FileName { get; set; }
        /// <summary>The rowsPerBlock property</summary>
        public int? RowsPerBlock { get; set; }
        /// <summary>The salt property</summary>
        public string Salt { get; set; }
        /// <summary>The uploadAgent property</summary>
        public ExactMatchUploadAgent UploadAgent { get; set; }
        /// <summary>The uploadAgentId property</summary>
        public string UploadAgentId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchSession CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"checksum", (o,n) => { (o as ExactMatchSession).Checksum = n.GetStringValue(); } },
                {"dataUploadURI", (o,n) => { (o as ExactMatchSession).DataUploadURI = n.GetStringValue(); } },
                {"fields", (o,n) => { (o as ExactMatchSession).Fields = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fileName", (o,n) => { (o as ExactMatchSession).FileName = n.GetStringValue(); } },
                {"rowsPerBlock", (o,n) => { (o as ExactMatchSession).RowsPerBlock = n.GetIntValue(); } },
                {"salt", (o,n) => { (o as ExactMatchSession).Salt = n.GetStringValue(); } },
                {"uploadAgent", (o,n) => { (o as ExactMatchSession).UploadAgent = n.GetObjectValue<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue); } },
                {"uploadAgentId", (o,n) => { (o as ExactMatchSession).UploadAgentId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("checksum", Checksum);
            writer.WriteStringValue("dataUploadURI", DataUploadURI);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteIntValue("rowsPerBlock", RowsPerBlock);
            writer.WriteStringValue("salt", Salt);
            writer.WriteObjectValue<ExactMatchUploadAgent>("uploadAgent", UploadAgent);
            writer.WriteStringValue("uploadAgentId", UploadAgentId);
        }
    }
}

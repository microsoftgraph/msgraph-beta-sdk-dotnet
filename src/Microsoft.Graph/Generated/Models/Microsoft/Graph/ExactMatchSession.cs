using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ExactMatchSession : ExactMatchSessionBase, IParsable {
        public string Checksum { get; set; }
        public string DataUploadURI { get; set; }
        public List<string> Fields { get; set; }
        public string FileName { get; set; }
        public int? RowsPerBlock { get; set; }
        public string Salt { get; set; }
        public ExactMatchUploadAgent UploadAgent { get; set; }
        public string UploadAgentId { get; set; }
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
                {"uploadAgent", (o,n) => { (o as ExactMatchSession).UploadAgent = n.GetObjectValue<ExactMatchUploadAgent>(); } },
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

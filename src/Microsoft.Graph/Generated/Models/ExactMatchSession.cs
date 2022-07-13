using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchSession : ExactMatchSessionBase, IParsable {
        /// <summary>The checksum property</summary>
        public string Checksum {
            get { return BackingStore?.Get<string>("checksum"); }
            set { BackingStore?.Set("checksum", value); }
        }
        /// <summary>The dataUploadURI property</summary>
        public string DataUploadURI {
            get { return BackingStore?.Get<string>("dataUploadURI"); }
            set { BackingStore?.Set("dataUploadURI", value); }
        }
        /// <summary>The fields property</summary>
        public List<string> Fields {
            get { return BackingStore?.Get<List<string>>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
        /// <summary>The fileName property</summary>
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
        /// <summary>The rowsPerBlock property</summary>
        public int? RowsPerBlock {
            get { return BackingStore?.Get<int?>("rowsPerBlock"); }
            set { BackingStore?.Set("rowsPerBlock", value); }
        }
        /// <summary>The salt property</summary>
        public string Salt {
            get { return BackingStore?.Get<string>("salt"); }
            set { BackingStore?.Set("salt", value); }
        }
        /// <summary>The uploadAgent property</summary>
        public ExactMatchUploadAgent UploadAgent {
            get { return BackingStore?.Get<ExactMatchUploadAgent>("uploadAgent"); }
            set { BackingStore?.Set("uploadAgent", value); }
        }
        /// <summary>The uploadAgentId property</summary>
        public string UploadAgentId {
            get { return BackingStore?.Get<string>("uploadAgentId"); }
            set { BackingStore?.Set("uploadAgentId", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"checksum", n => { Checksum = n.GetStringValue(); } },
                {"dataUploadURI", n => { DataUploadURI = n.GetStringValue(); } },
                {"fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"rowsPerBlock", n => { RowsPerBlock = n.GetIntValue(); } },
                {"salt", n => { Salt = n.GetStringValue(); } },
                {"uploadAgent", n => { UploadAgent = n.GetObjectValue<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue); } },
                {"uploadAgentId", n => { UploadAgentId = n.GetStringValue(); } },
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

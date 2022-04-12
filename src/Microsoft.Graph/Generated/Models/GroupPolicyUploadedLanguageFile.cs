using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The entity represents an ADML (Administrative Template language) XML file uploaded by Administrator.</summary>
    public class GroupPolicyUploadedLanguageFile : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contents of the uploaded ADML file.</summary>
        public byte[] Content { get; set; }
        /// <summary>The file name of the uploaded ADML file.</summary>
        public string FileName { get; set; }
        /// <summary>Key of the entity.</summary>
        public string Id { get; set; }
        /// <summary>The language code of the uploaded ADML file.</summary>
        public string LanguageCode { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new groupPolicyUploadedLanguageFile and sets the default values.
        /// </summary>
        public GroupPolicyUploadedLanguageFile() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GroupPolicyUploadedLanguageFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyUploadedLanguageFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"languageCode", n => { LanguageCode = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("languageCode", LanguageCode);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

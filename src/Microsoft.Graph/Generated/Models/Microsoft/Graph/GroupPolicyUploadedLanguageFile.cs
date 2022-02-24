using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyUploadedLanguageFile : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"content", (o,n) => { (o as GroupPolicyUploadedLanguageFile).Content = n.GetByteArrayValue(); } },
                {"fileName", (o,n) => { (o as GroupPolicyUploadedLanguageFile).FileName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as GroupPolicyUploadedLanguageFile).Id = n.GetStringValue(); } },
                {"languageCode", (o,n) => { (o as GroupPolicyUploadedLanguageFile).LanguageCode = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyUploadedLanguageFile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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

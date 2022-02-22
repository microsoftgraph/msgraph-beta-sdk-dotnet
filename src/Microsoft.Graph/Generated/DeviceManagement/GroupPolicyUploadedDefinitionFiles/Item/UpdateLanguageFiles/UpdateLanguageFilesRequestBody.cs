using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.GroupPolicyUploadedDefinitionFiles.Item.UpdateLanguageFiles {
    public class UpdateLanguageFilesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles { get; set; }
        /// <summary>
        /// Instantiates a new updateLanguageFilesRequestBody and sets the default values.
        /// </summary>
        public UpdateLanguageFilesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupPolicyUploadedLanguageFiles", (o,n) => { (o as UpdateLanguageFilesRequestBody).GroupPolicyUploadedLanguageFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>("groupPolicyUploadedLanguageFiles", GroupPolicyUploadedLanguageFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

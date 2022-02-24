using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyUploadedDefinitionFile : GroupPolicyDefinitionFile, IParsable {
        /// <summary>The contents of the uploaded ADMX file.</summary>
        public byte[] Content { get; set; }
        /// <summary>The default language of the uploaded ADMX file.</summary>
        public string DefaultLanguageCode { get; set; }
        /// <summary>The list of operations on the uploaded ADMX file.</summary>
        public List<GroupPolicyOperation> GroupPolicyOperations { get; set; }
        /// <summary>The list of ADML files associated with the uploaded ADMX file.</summary>
        public List<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles { get; set; }
        /// <summary>The upload status of the uploaded ADMX file. Possible values are: none, uploadInProgress, available, assigned, removalInProgress, uploadFailed, removalFailed.</summary>
        public GroupPolicyUploadedDefinitionFileStatus? Status { get; set; }
        /// <summary>The uploaded time of the uploaded ADMX file.</summary>
        public DateTimeOffset? UploadDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).Content = n.GetByteArrayValue(); } },
                {"defaultLanguageCode", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).DefaultLanguageCode = n.GetStringValue(); } },
                {"groupPolicyOperations", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).GroupPolicyOperations = n.GetCollectionOfObjectValues<GroupPolicyOperation>().ToList(); } },
                {"groupPolicyUploadedLanguageFiles", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).GroupPolicyUploadedLanguageFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>().ToList(); } },
                {"status", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).Status = n.GetEnumValue<GroupPolicyUploadedDefinitionFileStatus>(); } },
                {"uploadDateTime", (o,n) => { (o as GroupPolicyUploadedDefinitionFile).UploadDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("defaultLanguageCode", DefaultLanguageCode);
            writer.WriteCollectionOfObjectValues<GroupPolicyOperation>("groupPolicyOperations", GroupPolicyOperations);
            writer.WriteCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>("groupPolicyUploadedLanguageFiles", GroupPolicyUploadedLanguageFiles);
            writer.WriteEnumValue<GroupPolicyUploadedDefinitionFileStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("uploadDateTime", UploadDateTime);
        }
    }
}

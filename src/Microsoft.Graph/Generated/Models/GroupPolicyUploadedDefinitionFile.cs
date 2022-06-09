using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyUploadedDefinitionFile : GroupPolicyDefinitionFile, IParsable {
        /// <summary>The contents of the uploaded ADMX file.</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>(nameof(Content)); }
            set { BackingStore?.Set(nameof(Content), value); }
        }
        /// <summary>The default language of the uploaded ADMX file.</summary>
        public string DefaultLanguageCode {
            get { return BackingStore?.Get<string>(nameof(DefaultLanguageCode)); }
            set { BackingStore?.Set(nameof(DefaultLanguageCode), value); }
        }
        /// <summary>The list of operations on the uploaded ADMX file.</summary>
        public List<GroupPolicyOperation> GroupPolicyOperations {
            get { return BackingStore?.Get<List<GroupPolicyOperation>>(nameof(GroupPolicyOperations)); }
            set { BackingStore?.Set(nameof(GroupPolicyOperations), value); }
        }
        /// <summary>The list of ADML files associated with the uploaded ADMX file.</summary>
        public List<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles {
            get { return BackingStore?.Get<List<GroupPolicyUploadedLanguageFile>>(nameof(GroupPolicyUploadedLanguageFiles)); }
            set { BackingStore?.Set(nameof(GroupPolicyUploadedLanguageFiles), value); }
        }
        /// <summary>The upload status of the uploaded ADMX file. Possible values are: none, uploadInProgress, available, assigned, removalInProgress, uploadFailed, removalFailed.</summary>
        public GroupPolicyUploadedDefinitionFileStatus? Status {
            get { return BackingStore?.Get<GroupPolicyUploadedDefinitionFileStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The uploaded time of the uploaded ADMX file.</summary>
        public DateTimeOffset? UploadDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(UploadDateTime)); }
            set { BackingStore?.Set(nameof(UploadDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyUploadedDefinitionFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyUploadedDefinitionFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"defaultLanguageCode", n => { DefaultLanguageCode = n.GetStringValue(); } },
                {"groupPolicyOperations", n => { GroupPolicyOperations = n.GetCollectionOfObjectValues<GroupPolicyOperation>(GroupPolicyOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyUploadedLanguageFiles", n => { GroupPolicyUploadedLanguageFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>(GroupPolicyUploadedLanguageFile.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<GroupPolicyUploadedDefinitionFileStatus>(); } },
                {"uploadDateTime", n => { UploadDateTime = n.GetDateTimeOffsetValue(); } },
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

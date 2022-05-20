using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DataClassification.ClassifyText {
    /// <summary>Provides operations to call the classifyText method.</summary>
    public class ClassifyTextPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fileExtension property</summary>
        public string FileExtension {
            get { return BackingStore?.Get<string>(nameof(FileExtension)); }
            set { BackingStore?.Set(nameof(FileExtension), value); }
        }
        /// <summary>The matchTolerancesToInclude property</summary>
        public MlClassificationMatchTolerance? MatchTolerancesToInclude {
            get { return BackingStore?.Get<MlClassificationMatchTolerance?>(nameof(MatchTolerancesToInclude)); }
            set { BackingStore?.Set(nameof(MatchTolerancesToInclude), value); }
        }
        /// <summary>The scopesToRun property</summary>
        public SensitiveTypeScope? ScopesToRun {
            get { return BackingStore?.Get<SensitiveTypeScope?>(nameof(ScopesToRun)); }
            set { BackingStore?.Set(nameof(ScopesToRun), value); }
        }
        /// <summary>The sensitiveTypeIds property</summary>
        public List<string> SensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>(nameof(SensitiveTypeIds)); }
            set { BackingStore?.Set(nameof(SensitiveTypeIds), value); }
        }
        /// <summary>The text property</summary>
        public string Text {
            get { return BackingStore?.Get<string>(nameof(Text)); }
            set { BackingStore?.Set(nameof(Text), value); }
        }
        /// <summary>
        /// Instantiates a new classifyTextPostRequestBody and sets the default values.
        /// </summary>
        public ClassifyTextPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassifyTextPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassifyTextPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fileExtension", n => { FileExtension = n.GetStringValue(); } },
                {"matchTolerancesToInclude", n => { MatchTolerancesToInclude = n.GetEnumValue<MlClassificationMatchTolerance>(); } },
                {"scopesToRun", n => { ScopesToRun = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"text", n => { Text = n.GetStringValue(); } },
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

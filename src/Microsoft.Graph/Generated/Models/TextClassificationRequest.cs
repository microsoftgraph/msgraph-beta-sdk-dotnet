using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TextClassificationRequest : Entity, IParsable {
        /// <summary>The fileExtension property</summary>
        public string FileExtension {
            get { return BackingStore?.Get<string>("fileExtension"); }
            set { BackingStore?.Set("fileExtension", value); }
        }
        /// <summary>The matchTolerancesToInclude property</summary>
        public MlClassificationMatchTolerance? MatchTolerancesToInclude {
            get { return BackingStore?.Get<MlClassificationMatchTolerance?>("matchTolerancesToInclude"); }
            set { BackingStore?.Set("matchTolerancesToInclude", value); }
        }
        /// <summary>The scopesToRun property</summary>
        public SensitiveTypeScope? ScopesToRun {
            get { return BackingStore?.Get<SensitiveTypeScope?>("scopesToRun"); }
            set { BackingStore?.Set("scopesToRun", value); }
        }
        /// <summary>The sensitiveTypeIds property</summary>
        public List<string> SensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>("sensitiveTypeIds"); }
            set { BackingStore?.Set("sensitiveTypeIds", value); }
        }
        /// <summary>The text property</summary>
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TextClassificationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TextClassificationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fileExtension", n => { FileExtension = n.GetStringValue(); } },
                {"matchTolerancesToInclude", n => { MatchTolerancesToInclude = n.GetEnumValue<MlClassificationMatchTolerance>(); } },
                {"scopesToRun", n => { ScopesToRun = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"text", n => { Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fileExtension", FileExtension);
            writer.WriteEnumValue<MlClassificationMatchTolerance>("matchTolerancesToInclude", MatchTolerancesToInclude);
            writer.WriteEnumValue<SensitiveTypeScope>("scopesToRun", ScopesToRun);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
            writer.WriteStringValue("text", Text);
        }
    }
}

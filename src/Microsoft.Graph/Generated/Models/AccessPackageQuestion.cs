using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageQuestion : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the question.</summary>
        public string Id { get; set; }
        /// <summary>Specifies whether the requestor is allowed to edit answers to questions.</summary>
        public bool? IsAnswerEditable { get; set; }
        /// <summary>Whether the requestor is required to supply an answer or not.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>Relative position of this question when displaying a list of questions to the requestor.</summary>
        public int? Sequence { get; set; }
        /// <summary>The text of the question to show to the requestor.</summary>
        public AccessPackageLocalizedContent Text { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageQuestion and sets the default values.
        /// </summary>
        public AccessPackageQuestion() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"id", n => { Id = n.GetStringValue(); } },
                {"isAnswerEditable", n => { IsAnswerEditable = n.GetBoolValue(); } },
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
                {"text", n => { Text = n.GetObjectValue<AccessPackageLocalizedContent>(AccessPackageLocalizedContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isAnswerEditable", IsAnswerEditable);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteObjectValue<AccessPackageLocalizedContent>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

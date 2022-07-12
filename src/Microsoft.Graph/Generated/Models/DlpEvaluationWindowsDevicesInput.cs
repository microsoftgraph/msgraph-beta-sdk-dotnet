using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpEvaluationWindowsDevicesInput : DlpEvaluationInput, IParsable {
        /// <summary>The contentProperties property</summary>
        public Microsoft.Graph.Beta.Models.ContentProperties ContentProperties {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContentProperties>("contentProperties"); }
            set { BackingStore?.Set("contentProperties", value); }
        }
        /// <summary>The sharedBy property</summary>
        public string SharedBy {
            get { return BackingStore?.Get<string>("sharedBy"); }
            set { BackingStore?.Set("sharedBy", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DlpEvaluationWindowsDevicesInput CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpEvaluationWindowsDevicesInput();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentProperties", n => { ContentProperties = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContentProperties>(Microsoft.Graph.Beta.Models.ContentProperties.CreateFromDiscriminatorValue); } },
                {"sharedBy", n => { SharedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContentProperties>("contentProperties", ContentProperties);
            writer.WriteStringValue("sharedBy", SharedBy);
        }
    }
}

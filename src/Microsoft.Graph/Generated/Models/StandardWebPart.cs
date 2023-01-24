using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StandardWebPart : WebPart, IParsable {
        /// <summary>Data of the webPart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebPartData? Data {
            get { return BackingStore?.Get<WebPartData?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public WebPartData Data {
            get { return BackingStore?.Get<WebPartData>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>A Guid which indicates the type of the webParts</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebPartType {
            get { return BackingStore?.Get<string?>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#nullable restore
#else
        public string WebPartType {
            get { return BackingStore?.Get<string>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new StandardWebPart and sets the default values.
        /// </summary>
        public StandardWebPart() : base() {
            OdataType = "#microsoft.graph.standardWebPart";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new StandardWebPart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StandardWebPart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"data", n => { Data = n.GetObjectValue<WebPartData>(WebPartData.CreateFromDiscriminatorValue); } },
                {"webPartType", n => { WebPartType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WebPartData>("data", Data);
            writer.WriteStringValue("webPartType", WebPartType);
        }
    }
}

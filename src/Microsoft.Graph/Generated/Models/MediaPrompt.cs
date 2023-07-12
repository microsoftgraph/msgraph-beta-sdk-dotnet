using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MediaPrompt : Prompt, IParsable {
        /// <summary>The loop property</summary>
        public int? Loop {
            get { return BackingStore?.Get<int?>("loop"); }
            set { BackingStore?.Set("loop", value); }
        }
        /// <summary>The mediaInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MediaInfo? MediaInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaInfo?>("mediaInfo"); }
            set { BackingStore?.Set("mediaInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MediaInfo MediaInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaInfo>("mediaInfo"); }
            set { BackingStore?.Set("mediaInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new mediaPrompt and sets the default values.
        /// </summary>
        public MediaPrompt() : base() {
            OdataType = "#microsoft.graph.mediaPrompt";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MediaPrompt CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaPrompt();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"loop", n => { Loop = n.GetIntValue(); } },
                {"mediaInfo", n => { MediaInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaInfo>(Microsoft.Graph.Beta.Models.MediaInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("loop", Loop);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaInfo>("mediaInfo", MediaInfo);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EmailContentThreatSubmission : EmailThreatSubmission, IParsable {
        /// <summary>Base64 encoded file content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileContent {
            get { return BackingStore?.Get<string?>("fileContent"); }
            set { BackingStore?.Set("fileContent", value); }
        }
#nullable restore
#else
        public string FileContent {
            get { return BackingStore?.Get<string>("fileContent"); }
            set { BackingStore?.Set("fileContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new emailContentThreatSubmission and sets the default values.
        /// </summary>
        public EmailContentThreatSubmission() : base() {
            OdataType = "#microsoft.graph.security.emailContentThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailContentThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailContentThreatSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fileContent", n => { FileContent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fileContent", FileContent);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class ValidateOperation : LongRunningOperation, IParsable {
        /// <summary>Set of errors discovered through validation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PublicError>? Errors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublicError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PublicError> Errors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublicError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>Set of warnings discovered through validation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PublicError>? Warnings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublicError>?>("warnings"); }
            set { BackingStore?.Set("warnings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PublicError> Warnings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublicError>>("warnings"); }
            set { BackingStore?.Set("warnings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ValidateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.industryData.fileValidateOperation" => new FileValidateOperation(),
                _ => new ValidateOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"warnings", n => { Warnings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}

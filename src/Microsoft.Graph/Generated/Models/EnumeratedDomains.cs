using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EnumeratedDomains : ValidatingDomains, IParsable {
        /// <summary>The domainNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DomainNames {
            get { return BackingStore?.Get<List<string>?>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#nullable restore
#else
        public List<string> DomainNames {
            get { return BackingStore?.Get<List<string>>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new enumeratedDomains and sets the default values.
        /// </summary>
        public EnumeratedDomains() : base() {
            OdataType = "#microsoft.graph.enumeratedDomains";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EnumeratedDomains CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnumeratedDomains();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"domainNames", n => { DomainNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("domainNames", DomainNames);
        }
    }
}

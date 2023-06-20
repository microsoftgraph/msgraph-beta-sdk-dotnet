using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class M365ForwardingRule : ForwardingRule, IParsable {
        /// <summary>The category property</summary>
        public ForwardingCategory? Category {
            get { return BackingStore?.Get<ForwardingCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The ports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ports {
            get { return BackingStore?.Get<List<string>?>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#nullable restore
#else
        public List<string> Ports {
            get { return BackingStore?.Get<List<string>>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#endif
        /// <summary>The protocol property</summary>
        public NetworkingProtocol? Protocol {
            get { return BackingStore?.Get<NetworkingProtocol?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
        /// <summary>
        /// Instantiates a new M365ForwardingRule and sets the default values.
        /// </summary>
        public M365ForwardingRule() : base() {
            OdataType = "#microsoft.graph.networkaccess.m365ForwardingRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new M365ForwardingRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new M365ForwardingRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<ForwardingCategory>(); } },
                {"ports", n => { Ports = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<NetworkingProtocol>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ForwardingCategory>("category", Category);
            writer.WriteCollectionOfPrimitiveValues<string>("ports", Ports);
            writer.WriteEnumValue<NetworkingProtocol>("protocol", Protocol);
        }
    }
}

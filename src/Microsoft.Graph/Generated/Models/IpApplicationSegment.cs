using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IpApplicationSegment : ApplicationSegment, IParsable {
        /// <summary>The destinationHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationHost {
            get { return BackingStore?.Get<string?>("destinationHost"); }
            set { BackingStore?.Set("destinationHost", value); }
        }
#nullable restore
#else
        public string DestinationHost {
            get { return BackingStore?.Get<string>("destinationHost"); }
            set { BackingStore?.Set("destinationHost", value); }
        }
#endif
        /// <summary>The port property</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
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
        /// <summary>
        /// Instantiates a new IpApplicationSegment and sets the default values.
        /// </summary>
        public IpApplicationSegment() : base() {
            OdataType = "#microsoft.graph.ipApplicationSegment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpApplicationSegment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpApplicationSegment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"destinationHost", n => { DestinationHost = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"ports", n => { Ports = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("destinationHost", DestinationHost);
            writer.WriteIntValue("port", Port);
            writer.WriteCollectionOfPrimitiveValues<string>("ports", Ports);
        }
    }
}

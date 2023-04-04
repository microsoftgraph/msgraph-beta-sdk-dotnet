using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IosWebContentFilterAutoFilter : IosWebContentFilterBase, IParsable {
        /// <summary>Additional URLs allowed for access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedUrls {
            get { return BackingStore?.Get<List<string>?>("allowedUrls"); }
            set { BackingStore?.Set("allowedUrls", value); }
        }
#nullable restore
#else
        public List<string> AllowedUrls {
            get { return BackingStore?.Get<List<string>>("allowedUrls"); }
            set { BackingStore?.Set("allowedUrls", value); }
        }
#endif
        /// <summary>Additional URLs blocked for access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BlockedUrls {
            get { return BackingStore?.Get<List<string>?>("blockedUrls"); }
            set { BackingStore?.Set("blockedUrls", value); }
        }
#nullable restore
#else
        public List<string> BlockedUrls {
            get { return BackingStore?.Get<List<string>>("blockedUrls"); }
            set { BackingStore?.Set("blockedUrls", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IosWebContentFilterAutoFilter and sets the default values.
        /// </summary>
        public IosWebContentFilterAutoFilter() : base() {
            OdataType = "#microsoft.graph.iosWebContentFilterAutoFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosWebContentFilterAutoFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosWebContentFilterAutoFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedUrls", n => { AllowedUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"blockedUrls", n => { BlockedUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedUrls", AllowedUrls);
            writer.WriteCollectionOfPrimitiveValues<string>("blockedUrls", BlockedUrls);
        }
    }
}

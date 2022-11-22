using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WebApplicationSegment : ApplicationSegment, IParsable {
        /// <summary>The alternateUrl property</summary>
        public string AlternateUrl {
            get { return BackingStore?.Get<string>("alternateUrl"); }
            set { BackingStore?.Set("alternateUrl", value); }
        }
        /// <summary>The corsConfigurations property</summary>
        public List<CorsConfiguration_v2> CorsConfigurations {
            get { return BackingStore?.Get<List<CorsConfiguration_v2>>("corsConfigurations"); }
            set { BackingStore?.Set("corsConfigurations", value); }
        }
        /// <summary>The externalUrl property</summary>
        public string ExternalUrl {
            get { return BackingStore?.Get<string>("externalUrl"); }
            set { BackingStore?.Set("externalUrl", value); }
        }
        /// <summary>The internalUrl property</summary>
        public string InternalUrl {
            get { return BackingStore?.Get<string>("internalUrl"); }
            set { BackingStore?.Set("internalUrl", value); }
        }
        /// <summary>
        /// Instantiates a new WebApplicationSegment and sets the default values.
        /// </summary>
        public WebApplicationSegment() : base() {
            OdataType = "#microsoft.graph.webApplicationSegment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WebApplicationSegment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebApplicationSegment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alternateUrl", n => { AlternateUrl = n.GetStringValue(); } },
                {"corsConfigurations", n => { CorsConfigurations = n.GetCollectionOfObjectValues<CorsConfiguration_v2>(CorsConfiguration_v2.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalUrl", n => { ExternalUrl = n.GetStringValue(); } },
                {"internalUrl", n => { InternalUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("alternateUrl", AlternateUrl);
            writer.WriteCollectionOfObjectValues<CorsConfiguration_v2>("corsConfigurations", CorsConfigurations);
            writer.WriteStringValue("externalUrl", ExternalUrl);
            writer.WriteStringValue("internalUrl", InternalUrl);
        }
    }
}

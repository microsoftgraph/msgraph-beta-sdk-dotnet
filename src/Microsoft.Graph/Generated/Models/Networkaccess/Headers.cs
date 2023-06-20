using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class Headers : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin {
            get { return BackingStore?.Get<string?>("origin"); }
            set { BackingStore?.Set("origin", value); }
        }
#nullable restore
#else
        public string Origin {
            get { return BackingStore?.Get<string>("origin"); }
            set { BackingStore?.Set("origin", value); }
        }
#endif
        /// <summary>The referrer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Referrer {
            get { return BackingStore?.Get<string?>("referrer"); }
            set { BackingStore?.Set("referrer", value); }
        }
#nullable restore
#else
        public string Referrer {
            get { return BackingStore?.Get<string>("referrer"); }
            set { BackingStore?.Set("referrer", value); }
        }
#endif
        /// <summary>The xForwardedFor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XForwardedFor {
            get { return BackingStore?.Get<string?>("xForwardedFor"); }
            set { BackingStore?.Set("xForwardedFor", value); }
        }
#nullable restore
#else
        public string XForwardedFor {
            get { return BackingStore?.Get<string>("xForwardedFor"); }
            set { BackingStore?.Set("xForwardedFor", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new headers and sets the default values.
        /// </summary>
        public Headers() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Headers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Headers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
                {"referrer", n => { Referrer = n.GetStringValue(); } },
                {"xForwardedFor", n => { XForwardedFor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("referrer", Referrer);
            writer.WriteStringValue("xForwardedFor", XForwardedFor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CorsConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The allowedHeaders property</summary>
        public List<string> AllowedHeaders {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedHeaders)); }
            set { BackingStore?.Set(nameof(AllowedHeaders), value); }
        }
        /// <summary>The allowedMethods property</summary>
        public List<string> AllowedMethods {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedMethods)); }
            set { BackingStore?.Set(nameof(AllowedMethods), value); }
        }
        /// <summary>The allowedOrigins property</summary>
        public List<string> AllowedOrigins {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedOrigins)); }
            set { BackingStore?.Set(nameof(AllowedOrigins), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The maxAgeInSeconds property</summary>
        public int? MaxAgeInSeconds {
            get { return BackingStore?.Get<int?>(nameof(MaxAgeInSeconds)); }
            set { BackingStore?.Set(nameof(MaxAgeInSeconds), value); }
        }
        /// <summary>The resource property</summary>
        public string Resource {
            get { return BackingStore?.Get<string>(nameof(Resource)); }
            set { BackingStore?.Set(nameof(Resource), value); }
        }
        /// <summary>
        /// Instantiates a new corsConfiguration and sets the default values.
        /// </summary>
        public CorsConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CorsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CorsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedHeaders", n => { AllowedHeaders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedMethods", n => { AllowedMethods = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedOrigins", n => { AllowedOrigins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"maxAgeInSeconds", n => { MaxAgeInSeconds = n.GetIntValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedHeaders", AllowedHeaders);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedMethods", AllowedMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedOrigins", AllowedOrigins);
            writer.WriteIntValue("maxAgeInSeconds", MaxAgeInSeconds);
            writer.WriteStringValue("resource", Resource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

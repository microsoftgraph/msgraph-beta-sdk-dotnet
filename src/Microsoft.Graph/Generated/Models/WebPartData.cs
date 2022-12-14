using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WebPartData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Audience information of the web part. By using this property, specific content will be prioritized to specific audiences.</summary>
        public List<string> Audiences {
            get { return BackingStore?.Get<List<string>>("audiences"); }
            set { BackingStore?.Set("audiences", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data version of the web part. The value is defined by the web part developer. Different dataVersions usually refers to a different property structure.</summary>
        public string DataVersion {
            get { return BackingStore?.Get<string>("dataVersion"); }
            set { BackingStore?.Set("dataVersion", value); }
        }
        /// <summary>Description of the web part.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Properties bag of the web part.</summary>
        public Json Properties {
            get { return BackingStore?.Get<Json>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
        /// <summary>Contains collections of data that can be processed by server side services like search index and link fixup.</summary>
        public Microsoft.Graph.Beta.Models.ServerProcessedContent ServerProcessedContent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServerProcessedContent>("serverProcessedContent"); }
            set { BackingStore?.Set("serverProcessedContent", value); }
        }
        /// <summary>Title of the web part.</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>
        /// Instantiates a new webPartData and sets the default values.
        /// </summary>
        public WebPartData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebPartData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebPartData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"audiences", n => { Audiences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dataVersion", n => { DataVersion = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"properties", n => { Properties = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"serverProcessedContent", n => { ServerProcessedContent = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServerProcessedContent>(Microsoft.Graph.Beta.Models.ServerProcessedContent.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("audiences", Audiences);
            writer.WriteStringValue("dataVersion", DataVersion);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Json>("properties", Properties);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServerProcessedContent>("serverProcessedContent", ServerProcessedContent);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports {
    /// <summary>Provides operations to call the getTotalAggregatedRemoteConnectionReports method.</summary>
    public class GetTotalAggregatedRemoteConnectionReportsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The filter property</summary>
        public string Filter {
            get { return BackingStore?.Get<string>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
        /// <summary>The groupBy property</summary>
        public List<string> GroupBy {
            get { return BackingStore?.Get<List<string>>("groupBy"); }
            set { BackingStore?.Set("groupBy", value); }
        }
        /// <summary>The orderBy property</summary>
        public List<string> OrderBy {
            get { return BackingStore?.Get<List<string>>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
        /// <summary>The search property</summary>
        public string Search {
            get { return BackingStore?.Get<string>("search"); }
            set { BackingStore?.Set("search", value); }
        }
        /// <summary>The select property</summary>
        public List<string> Select {
            get { return BackingStore?.Get<List<string>>("select"); }
            set { BackingStore?.Set("select", value); }
        }
        /// <summary>The skip property</summary>
        public int? Skip {
            get { return BackingStore?.Get<int?>("skip"); }
            set { BackingStore?.Set("skip", value); }
        }
        /// <summary>The top property</summary>
        public int? Top {
            get { return BackingStore?.Get<int?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>
        /// Instantiates a new getTotalAggregatedRemoteConnectionReportsPostRequestBody and sets the default values.
        /// </summary>
        public GetTotalAggregatedRemoteConnectionReportsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetTotalAggregatedRemoteConnectionReportsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetTotalAggregatedRemoteConnectionReportsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"filter", n => { Filter = n.GetStringValue(); } },
                {"groupBy", n => { GroupBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"search", n => { Search = n.GetStringValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"skip", n => { Skip = n.GetIntValue(); } },
                {"top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("filter", Filter);
            writer.WriteCollectionOfPrimitiveValues<string>("groupBy", GroupBy);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

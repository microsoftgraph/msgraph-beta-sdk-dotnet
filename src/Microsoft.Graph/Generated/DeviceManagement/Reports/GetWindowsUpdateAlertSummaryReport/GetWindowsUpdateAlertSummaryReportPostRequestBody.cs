using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.Reports.GetWindowsUpdateAlertSummaryReport {
    /// <summary>Provides operations to call the getWindowsUpdateAlertSummaryReport method.</summary>
    public class GetWindowsUpdateAlertSummaryReportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The filter property</summary>
        public string Filter {
            get { return BackingStore?.Get<string>(nameof(Filter)); }
            set { BackingStore?.Set(nameof(Filter), value); }
        }
        /// <summary>The groupBy property</summary>
        public List<string> GroupBy {
            get { return BackingStore?.Get<List<string>>(nameof(GroupBy)); }
            set { BackingStore?.Set(nameof(GroupBy), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The orderBy property</summary>
        public List<string> OrderBy {
            get { return BackingStore?.Get<List<string>>(nameof(OrderBy)); }
            set { BackingStore?.Set(nameof(OrderBy), value); }
        }
        /// <summary>The search property</summary>
        public string Search {
            get { return BackingStore?.Get<string>(nameof(Search)); }
            set { BackingStore?.Set(nameof(Search), value); }
        }
        /// <summary>The select property</summary>
        public List<string> Select {
            get { return BackingStore?.Get<List<string>>(nameof(Select)); }
            set { BackingStore?.Set(nameof(Select), value); }
        }
        /// <summary>The sessionId property</summary>
        public string SessionId {
            get { return BackingStore?.Get<string>(nameof(SessionId)); }
            set { BackingStore?.Set(nameof(SessionId), value); }
        }
        /// <summary>The skip property</summary>
        public int? Skip {
            get { return BackingStore?.Get<int?>(nameof(Skip)); }
            set { BackingStore?.Set(nameof(Skip), value); }
        }
        /// <summary>The top property</summary>
        public int? Top {
            get { return BackingStore?.Get<int?>(nameof(Top)); }
            set { BackingStore?.Set(nameof(Top), value); }
        }
        /// <summary>
        /// Instantiates a new getWindowsUpdateAlertSummaryReportPostRequestBody and sets the default values.
        /// </summary>
        public GetWindowsUpdateAlertSummaryReportPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetWindowsUpdateAlertSummaryReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetWindowsUpdateAlertSummaryReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"filter", n => { Filter = n.GetStringValue(); } },
                {"groupBy", n => { GroupBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"search", n => { Search = n.GetStringValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sessionId", n => { SessionId = n.GetStringValue(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

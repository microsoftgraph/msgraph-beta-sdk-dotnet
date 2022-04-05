using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.Reports.GetAppStatusOverviewReport {
    /// <summary>Provides operations to call the getAppStatusOverviewReport method.</summary>
    public class GetAppStatusOverviewReportRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filter property</summary>
        public string Filter { get; set; }
        /// <summary>The groupBy property</summary>
        public List<string> GroupBy { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The orderBy property</summary>
        public List<string> OrderBy { get; set; }
        /// <summary>The search property</summary>
        public string Search { get; set; }
        /// <summary>The select property</summary>
        public List<string> Select { get; set; }
        /// <summary>The sessionId property</summary>
        public string SessionId { get; set; }
        /// <summary>The skip property</summary>
        public int? Skip { get; set; }
        /// <summary>The top property</summary>
        public int? Top { get; set; }
        /// <summary>
        /// Instantiates a new getAppStatusOverviewReportRequestBody and sets the default values.
        /// </summary>
        public GetAppStatusOverviewReportRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetAppStatusOverviewReportRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetAppStatusOverviewReportRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"filter", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Filter = n.GetStringValue(); } },
                {"groupBy", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).GroupBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Name = n.GetStringValue(); } },
                {"orderBy", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).OrderBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"search", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Search = n.GetStringValue(); } },
                {"select", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Select = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sessionId", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).SessionId = n.GetStringValue(); } },
                {"skip", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Skip = n.GetIntValue(); } },
                {"top", (o,n) => { (o as GetAppStatusOverviewReportRequestBody).Top = n.GetIntValue(); } },
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

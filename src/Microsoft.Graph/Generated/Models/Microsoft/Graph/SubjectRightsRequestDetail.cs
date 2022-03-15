using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the privacy singleton.</summary>
    public class SubjectRightsRequestDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of items that are excluded from the request.</summary>
        public int? ExcludedItemCount { get; set; }
        /// <summary>Count of items per insight.</summary>
        public List<KeyValuePair> InsightCounts { get; set; }
        /// <summary>Count of items found.</summary>
        public int? ItemCount { get; set; }
        /// <summary>Count of item that need review.</summary>
        public int? ItemNeedReview { get; set; }
        /// <summary>Count of items per product, such as Exchange, SharePoint, OneDrive, and Teams.</summary>
        public List<KeyValuePair> ProductItemCounts { get; set; }
        /// <summary>Count of items signed off by the administrator.</summary>
        public int? SignedOffItemCount { get; set; }
        /// <summary>Total item size in bytes.</summary>
        public int? TotalItemSize { get; set; }
        /// <summary>
        /// Instantiates a new subjectRightsRequestDetail and sets the default values.
        /// </summary>
        public SubjectRightsRequestDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubjectRightsRequestDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludedItemCount", (o,n) => { (o as SubjectRightsRequestDetail).ExcludedItemCount = n.GetIntValue(); } },
                {"insightCounts", (o,n) => { (o as SubjectRightsRequestDetail).InsightCounts = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"itemCount", (o,n) => { (o as SubjectRightsRequestDetail).ItemCount = n.GetIntValue(); } },
                {"itemNeedReview", (o,n) => { (o as SubjectRightsRequestDetail).ItemNeedReview = n.GetIntValue(); } },
                {"productItemCounts", (o,n) => { (o as SubjectRightsRequestDetail).ProductItemCounts = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"signedOffItemCount", (o,n) => { (o as SubjectRightsRequestDetail).SignedOffItemCount = n.GetIntValue(); } },
                {"totalItemSize", (o,n) => { (o as SubjectRightsRequestDetail).TotalItemSize = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("excludedItemCount", ExcludedItemCount);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("insightCounts", InsightCounts);
            writer.WriteIntValue("itemCount", ItemCount);
            writer.WriteIntValue("itemNeedReview", ItemNeedReview);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("productItemCounts", ProductItemCounts);
            writer.WriteIntValue("signedOffItemCount", SignedOffItemCount);
            writer.WriteIntValue("totalItemSize", TotalItemSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

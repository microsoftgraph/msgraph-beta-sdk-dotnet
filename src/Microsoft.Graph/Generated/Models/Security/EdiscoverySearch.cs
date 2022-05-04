using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoverySearch : Search, IParsable {
        /// <summary>The additionalSources property</summary>
        public List<DataSource> AdditionalSources { get; set; }
        /// <summary>The addToReviewSetOperation property</summary>
        public EdiscoveryAddToReviewSetOperation AddToReviewSetOperation { get; set; }
        /// <summary>The custodianSources property</summary>
        public List<DataSource> CustodianSources { get; set; }
        /// <summary>The dataSourceScopes property</summary>
        public Microsoft.Graph.Beta.Models.Security.DataSourceScopes? DataSourceScopes { get; set; }
        /// <summary>The lastEstimateStatisticsOperation property</summary>
        public EdiscoveryEstimateOperation LastEstimateStatisticsOperation { get; set; }
        /// <summary>The noncustodialSources property</summary>
        public List<EdiscoveryNoncustodialDataSource> NoncustodialSources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoverySearch CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoverySearch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalSources", n => { AdditionalSources = n.GetCollectionOfObjectValues<DataSource>(DataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"addToReviewSetOperation", n => { AddToReviewSetOperation = n.GetObjectValue<EdiscoveryAddToReviewSetOperation>(EdiscoveryAddToReviewSetOperation.CreateFromDiscriminatorValue); } },
                {"custodianSources", n => { CustodianSources = n.GetCollectionOfObjectValues<DataSource>(DataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"dataSourceScopes", n => { DataSourceScopes = n.GetEnumValue<DataSourceScopes>(); } },
                {"lastEstimateStatisticsOperation", n => { LastEstimateStatisticsOperation = n.GetObjectValue<EdiscoveryEstimateOperation>(EdiscoveryEstimateOperation.CreateFromDiscriminatorValue); } },
                {"noncustodialSources", n => { NoncustodialSources = n.GetCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>(EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteCollectionOfObjectValues<DataSource>("custodianSources", CustodianSources);
            writer.WriteEnumValue<DataSourceScopes>("dataSourceScopes", DataSourceScopes);
            writer.WriteObjectValue<EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation", LastEstimateStatisticsOperation);
            writer.WriteCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>("noncustodialSources", NoncustodialSources);
        }
    }
}

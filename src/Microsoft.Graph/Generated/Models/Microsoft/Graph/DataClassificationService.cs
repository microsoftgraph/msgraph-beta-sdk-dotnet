using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
    public class DataClassificationService : Entity, IParsable {
        public List<JobResponseBase> ClassifyFileJobs { get; set; }
        public List<JobResponseBase> ClassifyTextJobs { get; set; }
        public List<JobResponseBase> EvaluateDlpPoliciesJobs { get; set; }
        public List<JobResponseBase> EvaluateLabelJobs { get; set; }
        public List<ExactMatchDataStore> ExactMatchDataStores { get; set; }
        public List<ExactMatchUploadAgent> ExactMatchUploadAgents { get; set; }
        public List<JobResponseBase> Jobs { get; set; }
        public List<SensitiveType> SensitiveTypes { get; set; }
        public List<SensitivityLabel> SensitivityLabels { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataClassificationService CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataClassificationService();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classifyFileJobs", (o,n) => { (o as DataClassificationService).ClassifyFileJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"classifyTextJobs", (o,n) => { (o as DataClassificationService).ClassifyTextJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluateDlpPoliciesJobs", (o,n) => { (o as DataClassificationService).EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluateLabelJobs", (o,n) => { (o as DataClassificationService).EvaluateLabelJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"exactMatchDataStores", (o,n) => { (o as DataClassificationService).ExactMatchDataStores = n.GetCollectionOfObjectValues<ExactMatchDataStore>(ExactMatchDataStore.CreateFromDiscriminatorValue).ToList(); } },
                {"exactMatchUploadAgents", (o,n) => { (o as DataClassificationService).ExactMatchUploadAgents = n.GetCollectionOfObjectValues<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue).ToList(); } },
                {"jobs", (o,n) => { (o as DataClassificationService).Jobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitiveTypes", (o,n) => { (o as DataClassificationService).SensitiveTypes = n.GetCollectionOfObjectValues<SensitiveType>(SensitiveType.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitivityLabels", (o,n) => { (o as DataClassificationService).SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("classifyFileJobs", ClassifyFileJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("classifyTextJobs", ClassifyTextJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("evaluateDlpPoliciesJobs", EvaluateDlpPoliciesJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("evaluateLabelJobs", EvaluateLabelJobs);
            writer.WriteCollectionOfObjectValues<ExactMatchDataStore>("exactMatchDataStores", ExactMatchDataStores);
            writer.WriteCollectionOfObjectValues<ExactMatchUploadAgent>("exactMatchUploadAgents", ExactMatchUploadAgents);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<SensitiveType>("sensitiveTypes", SensitiveTypes);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}

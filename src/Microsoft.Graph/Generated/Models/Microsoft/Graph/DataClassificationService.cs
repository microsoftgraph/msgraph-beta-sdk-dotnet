using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classifyFileJobs", (o,n) => { (o as DataClassificationService).ClassifyFileJobs = n.GetCollectionOfObjectValues<JobResponseBase>().ToList(); } },
                {"classifyTextJobs", (o,n) => { (o as DataClassificationService).ClassifyTextJobs = n.GetCollectionOfObjectValues<JobResponseBase>().ToList(); } },
                {"evaluateDlpPoliciesJobs", (o,n) => { (o as DataClassificationService).EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<JobResponseBase>().ToList(); } },
                {"evaluateLabelJobs", (o,n) => { (o as DataClassificationService).EvaluateLabelJobs = n.GetCollectionOfObjectValues<JobResponseBase>().ToList(); } },
                {"exactMatchDataStores", (o,n) => { (o as DataClassificationService).ExactMatchDataStores = n.GetCollectionOfObjectValues<ExactMatchDataStore>().ToList(); } },
                {"exactMatchUploadAgents", (o,n) => { (o as DataClassificationService).ExactMatchUploadAgents = n.GetCollectionOfObjectValues<ExactMatchUploadAgent>().ToList(); } },
                {"jobs", (o,n) => { (o as DataClassificationService).Jobs = n.GetCollectionOfObjectValues<JobResponseBase>().ToList(); } },
                {"sensitiveTypes", (o,n) => { (o as DataClassificationService).SensitiveTypes = n.GetCollectionOfObjectValues<SensitiveType>().ToList(); } },
                {"sensitivityLabels", (o,n) => { (o as DataClassificationService).SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>().ToList(); } },
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

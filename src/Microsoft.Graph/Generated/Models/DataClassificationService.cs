using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
    public class DataClassificationService : Entity, IParsable {
        /// <summary>The classifyFileJobs property</summary>
        public List<JobResponseBase> ClassifyFileJobs { get; set; }
        /// <summary>The classifyTextJobs property</summary>
        public List<JobResponseBase> ClassifyTextJobs { get; set; }
        /// <summary>The evaluateDlpPoliciesJobs property</summary>
        public List<JobResponseBase> EvaluateDlpPoliciesJobs { get; set; }
        /// <summary>The evaluateLabelJobs property</summary>
        public List<JobResponseBase> EvaluateLabelJobs { get; set; }
        /// <summary>The exactMatchDataStores property</summary>
        public List<ExactMatchDataStore> ExactMatchDataStores { get; set; }
        /// <summary>The exactMatchUploadAgents property</summary>
        public List<ExactMatchUploadAgent> ExactMatchUploadAgents { get; set; }
        /// <summary>The jobs property</summary>
        public List<JobResponseBase> Jobs { get; set; }
        /// <summary>The sensitiveTypes property</summary>
        public List<SensitiveType> SensitiveTypes { get; set; }
        /// <summary>The sensitivityLabels property</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classifyFileJobs", n => { ClassifyFileJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"classifyTextJobs", n => { ClassifyTextJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluateDlpPoliciesJobs", n => { EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluateLabelJobs", n => { EvaluateLabelJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"exactMatchDataStores", n => { ExactMatchDataStores = n.GetCollectionOfObjectValues<ExactMatchDataStore>(ExactMatchDataStore.CreateFromDiscriminatorValue).ToList(); } },
                {"exactMatchUploadAgents", n => { ExactMatchUploadAgents = n.GetCollectionOfObjectValues<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue).ToList(); } },
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitiveTypes", n => { SensitiveTypes = n.GetCollectionOfObjectValues<SensitiveType>(SensitiveType.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
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

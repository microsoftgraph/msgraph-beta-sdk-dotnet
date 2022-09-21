using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DataClassificationService : Entity, IParsable {
        /// <summary>The classifyFileJobs property</summary>
        public List<JobResponseBase> ClassifyFileJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("classifyFileJobs"); }
            set { BackingStore?.Set("classifyFileJobs", value); }
        }
        /// <summary>The classifyTextJobs property</summary>
        public List<JobResponseBase> ClassifyTextJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("classifyTextJobs"); }
            set { BackingStore?.Set("classifyTextJobs", value); }
        }
        /// <summary>The evaluateDlpPoliciesJobs property</summary>
        public List<JobResponseBase> EvaluateDlpPoliciesJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("evaluateDlpPoliciesJobs"); }
            set { BackingStore?.Set("evaluateDlpPoliciesJobs", value); }
        }
        /// <summary>The evaluateLabelJobs property</summary>
        public List<JobResponseBase> EvaluateLabelJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("evaluateLabelJobs"); }
            set { BackingStore?.Set("evaluateLabelJobs", value); }
        }
        /// <summary>The exactMatchDataStores property</summary>
        public List<ExactMatchDataStore> ExactMatchDataStores {
            get { return BackingStore?.Get<List<ExactMatchDataStore>>("exactMatchDataStores"); }
            set { BackingStore?.Set("exactMatchDataStores", value); }
        }
        /// <summary>The exactMatchUploadAgents property</summary>
        public List<ExactMatchUploadAgent> ExactMatchUploadAgents {
            get { return BackingStore?.Get<List<ExactMatchUploadAgent>>("exactMatchUploadAgents"); }
            set { BackingStore?.Set("exactMatchUploadAgents", value); }
        }
        /// <summary>The jobs property</summary>
        public List<JobResponseBase> Jobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
        /// <summary>The sensitiveTypes property</summary>
        public List<SensitiveType> SensitiveTypes {
            get { return BackingStore?.Get<List<SensitiveType>>("sensitiveTypes"); }
            set { BackingStore?.Set("sensitiveTypes", value); }
        }
        /// <summary>The sensitivityLabels property</summary>
        public List<SensitivityLabel> SensitivityLabels {
            get { return BackingStore?.Get<List<SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
        /// <summary>
        /// Instantiates a new DataClassificationService and sets the default values.
        /// </summary>
        public DataClassificationService() : base() {
            OdataType = "#microsoft.graph.dataClassificationService";
        }
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
                {"classifyFileJobs", n => { ClassifyFileJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classifyTextJobs", n => { ClassifyTextJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"evaluateDlpPoliciesJobs", n => { EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"evaluateLabelJobs", n => { EvaluateLabelJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exactMatchDataStores", n => { ExactMatchDataStores = n.GetCollectionOfObjectValues<ExactMatchDataStore>(ExactMatchDataStore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exactMatchUploadAgents", n => { ExactMatchUploadAgents = n.GetCollectionOfObjectValues<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitiveTypes", n => { SensitiveTypes = n.GetCollectionOfObjectValues<SensitiveType>(SensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
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

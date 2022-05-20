using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MatchingDlpRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The actions property</summary>
        public List<DlpActionInfo> Actions {
            get { return BackingStore?.Get<List<DlpActionInfo>>(nameof(Actions)); }
            set { BackingStore?.Set(nameof(Actions), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isMostRestrictive property</summary>
        public bool? IsMostRestrictive {
            get { return BackingStore?.Get<bool?>(nameof(IsMostRestrictive)); }
            set { BackingStore?.Set(nameof(IsMostRestrictive), value); }
        }
        /// <summary>The policyId property</summary>
        public string PolicyId {
            get { return BackingStore?.Get<string>(nameof(PolicyId)); }
            set { BackingStore?.Set(nameof(PolicyId), value); }
        }
        /// <summary>The policyName property</summary>
        public string PolicyName {
            get { return BackingStore?.Get<string>(nameof(PolicyName)); }
            set { BackingStore?.Set(nameof(PolicyName), value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>The ruleId property</summary>
        public string RuleId {
            get { return BackingStore?.Get<string>(nameof(RuleId)); }
            set { BackingStore?.Set(nameof(RuleId), value); }
        }
        /// <summary>The ruleMode property</summary>
        public Microsoft.Graph.Beta.Models.RuleMode? RuleMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RuleMode?>(nameof(RuleMode)); }
            set { BackingStore?.Set(nameof(RuleMode), value); }
        }
        /// <summary>The ruleName property</summary>
        public string RuleName {
            get { return BackingStore?.Get<string>(nameof(RuleName)); }
            set { BackingStore?.Set(nameof(RuleName), value); }
        }
        /// <summary>
        /// Instantiates a new matchingDlpRule and sets the default values.
        /// </summary>
        public MatchingDlpRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MatchingDlpRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MatchingDlpRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<DlpActionInfo>(DlpActionInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"isMostRestrictive", n => { IsMostRestrictive = n.GetBoolValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"ruleId", n => { RuleId = n.GetStringValue(); } },
                {"ruleMode", n => { RuleMode = n.GetEnumValue<RuleMode>(); } },
                {"ruleName", n => { RuleName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DlpActionInfo>("actions", Actions);
            writer.WriteBoolValue("isMostRestrictive", IsMostRestrictive);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteEnumValue<RuleMode>("ruleMode", RuleMode);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

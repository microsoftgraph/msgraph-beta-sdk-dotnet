using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskRoleBasedRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default rule that applies when a property or action-specific rule is not provided. Possible values are: Allow, Block</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultRule {
            get { return BackingStore?.Get<string?>("defaultRule"); }
            set { BackingStore?.Set("defaultRule", value); }
        }
#nullable restore
#else
        public string DefaultRule {
            get { return BackingStore?.Get<string>("defaultRule"); }
            set { BackingStore?.Set("defaultRule", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Rules for specific properties and actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskPropertyRule? PropertyRule {
            get { return BackingStore?.Get<PlannerTaskPropertyRule?>("propertyRule"); }
            set { BackingStore?.Set("propertyRule", value); }
        }
#nullable restore
#else
        public PlannerTaskPropertyRule PropertyRule {
            get { return BackingStore?.Get<PlannerTaskPropertyRule>("propertyRule"); }
            set { BackingStore?.Set("propertyRule", value); }
        }
#endif
        /// <summary>The role these rules apply to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskConfigurationRoleBase? Role {
            get { return BackingStore?.Get<PlannerTaskConfigurationRoleBase?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public PlannerTaskConfigurationRoleBase Role {
            get { return BackingStore?.Get<PlannerTaskConfigurationRoleBase>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerTaskRoleBasedRule and sets the default values.
        /// </summary>
        public PlannerTaskRoleBasedRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerTaskRoleBasedRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskRoleBasedRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultRule", n => { DefaultRule = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyRule", n => { PropertyRule = n.GetObjectValue<PlannerTaskPropertyRule>(PlannerTaskPropertyRule.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetObjectValue<PlannerTaskConfigurationRoleBase>(PlannerTaskConfigurationRoleBase.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultRule", DefaultRule);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PlannerTaskPropertyRule>("propertyRule", PropertyRule);
            writer.WriteObjectValue<PlannerTaskConfigurationRoleBase>("role", Role);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

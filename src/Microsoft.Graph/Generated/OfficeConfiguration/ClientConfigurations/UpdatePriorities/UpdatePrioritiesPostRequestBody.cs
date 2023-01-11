using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.OfficeConfiguration.ClientConfigurations.UpdatePriorities {
    public class UpdatePrioritiesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The officeConfigurationPolicyIds property</summary>
        public List<string> OfficeConfigurationPolicyIds {
            get { return BackingStore?.Get<List<string>>("officeConfigurationPolicyIds"); }
            set { BackingStore?.Set("officeConfigurationPolicyIds", value); }
        }
        /// <summary>The officeConfigurationPriorities property</summary>
        public List<int?> OfficeConfigurationPriorities {
            get { return BackingStore?.Get<List<int?>>("officeConfigurationPriorities"); }
            set { BackingStore?.Set("officeConfigurationPriorities", value); }
        }
        /// <summary>
        /// Instantiates a new updatePrioritiesPostRequestBody and sets the default values.
        /// </summary>
        public UpdatePrioritiesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdatePrioritiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePrioritiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"officeConfigurationPolicyIds", n => { OfficeConfigurationPolicyIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"officeConfigurationPriorities", n => { OfficeConfigurationPriorities = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("officeConfigurationPolicyIds", OfficeConfigurationPolicyIds);
            writer.WriteCollectionOfPrimitiveValues<int?>("officeConfigurationPriorities", OfficeConfigurationPriorities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

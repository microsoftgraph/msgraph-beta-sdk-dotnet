using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TemplateParameter : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description for the template parameter. Optional. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name for the template parameter. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The allowed values for the template parameter represented by a serialized string of JSON. Optional. Read-only.</summary>
        public string JsonAllowedValues {
            get { return BackingStore?.Get<string>("jsonAllowedValues"); }
            set { BackingStore?.Set("jsonAllowedValues", value); }
        }
        /// <summary>The default value for the template parameter represented by a serialized string of JSON. Required. Read-only.</summary>
        public string JsonDefaultValue {
            get { return BackingStore?.Get<string>("jsonDefaultValue"); }
            set { BackingStore?.Set("jsonDefaultValue", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The valueType property</summary>
        public ManagementParameterValueType? ValueType {
            get { return BackingStore?.Get<ManagementParameterValueType?>("valueType"); }
            set { BackingStore?.Set("valueType", value); }
        }
        /// <summary>
        /// Instantiates a new templateParameter and sets the default values.
        /// </summary>
        public TemplateParameter() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.templateParameter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TemplateParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemplateParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"jsonAllowedValues", n => { JsonAllowedValues = n.GetStringValue(); } },
                {"jsonDefaultValue", n => { JsonDefaultValue = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<ManagementParameterValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("jsonAllowedValues", JsonAllowedValues);
            writer.WriteStringValue("jsonDefaultValue", JsonDefaultValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ManagementParameterValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

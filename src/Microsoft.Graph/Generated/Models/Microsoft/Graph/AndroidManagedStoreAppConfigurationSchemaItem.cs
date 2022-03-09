using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class AndroidManagedStoreAppConfigurationSchemaItem : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of value this item describes. Possible values are: bool, integer, string, choice, multiselect, bundle, bundleArray, hidden.</summary>
        public AndroidManagedStoreAppConfigurationSchemaItemDataType? DataType { get; set; }
        /// <summary>Default value for boolean type items, if specified by the app developer</summary>
        public bool? DefaultBoolValue { get; set; }
        /// <summary>Default value for integer type items, if specified by the app developer</summary>
        public int? DefaultIntValue { get; set; }
        /// <summary>Default value for string array type items, if specified by the app developer</summary>
        public List<string> DefaultStringArrayValue { get; set; }
        /// <summary>Default value for string type items, if specified by the app developer</summary>
        public string DefaultStringValue { get; set; }
        /// <summary>Description of what the item controls within the application</summary>
        public string Description { get; set; }
        /// <summary>Human readable name</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique index the application uses to maintain nested schema items</summary>
        public int? Index { get; set; }
        /// <summary>Index of parent schema item to track nested schema items</summary>
        public int? ParentIndex { get; set; }
        /// <summary>Unique key the application uses to identify the item</summary>
        public string SchemaItemKey { get; set; }
        /// <summary>List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)</summary>
        public List<KeyValuePair> Selections { get; set; }
        /// <summary>
        /// Instantiates a new androidManagedStoreAppConfigurationSchemaItem and sets the default values.
        /// </summary>
        public AndroidManagedStoreAppConfigurationSchemaItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AndroidManagedStoreAppConfigurationSchemaItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreAppConfigurationSchemaItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dataType", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DataType = n.GetEnumValue<AndroidManagedStoreAppConfigurationSchemaItemDataType>(); } },
                {"defaultBoolValue", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DefaultBoolValue = n.GetBoolValue(); } },
                {"defaultIntValue", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DefaultIntValue = n.GetIntValue(); } },
                {"defaultStringArrayValue", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DefaultStringArrayValue = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defaultStringValue", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DefaultStringValue = n.GetStringValue(); } },
                {"description", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).DisplayName = n.GetStringValue(); } },
                {"index", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).Index = n.GetIntValue(); } },
                {"parentIndex", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).ParentIndex = n.GetIntValue(); } },
                {"schemaItemKey", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).SchemaItemKey = n.GetStringValue(); } },
                {"selections", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchemaItem).Selections = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AndroidManagedStoreAppConfigurationSchemaItemDataType>("dataType", DataType);
            writer.WriteBoolValue("defaultBoolValue", DefaultBoolValue);
            writer.WriteIntValue("defaultIntValue", DefaultIntValue);
            writer.WriteCollectionOfPrimitiveValues<string>("defaultStringArrayValue", DefaultStringArrayValue);
            writer.WriteStringValue("defaultStringValue", DefaultStringValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("index", Index);
            writer.WriteIntValue("parentIndex", ParentIndex);
            writer.WriteStringValue("schemaItemKey", SchemaItemKey);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("selections", Selections);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

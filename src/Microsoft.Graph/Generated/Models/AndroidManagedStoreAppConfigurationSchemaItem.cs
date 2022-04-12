using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Single configuration item inside an Android application&apos;s custom configuration schema.</summary>
    public class AndroidManagedStoreAppConfigurationSchemaItem : IAdditionalDataHolder, IParsable {
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetEnumValue<AndroidManagedStoreAppConfigurationSchemaItemDataType>(); } },
                {"defaultBoolValue", n => { DefaultBoolValue = n.GetBoolValue(); } },
                {"defaultIntValue", n => { DefaultIntValue = n.GetIntValue(); } },
                {"defaultStringArrayValue", n => { DefaultStringArrayValue = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defaultStringValue", n => { DefaultStringValue = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"index", n => { Index = n.GetIntValue(); } },
                {"parentIndex", n => { ParentIndex = n.GetIntValue(); } },
                {"schemaItemKey", n => { SchemaItemKey = n.GetStringValue(); } },
                {"selections", n => { Selections = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
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

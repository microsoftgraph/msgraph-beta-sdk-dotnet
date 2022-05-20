using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Single configuration item inside an Android application&apos;s custom configuration schema.</summary>
    public class AndroidManagedStoreAppConfigurationSchemaItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of value this item describes. Possible values are: bool, integer, string, choice, multiselect, bundle, bundleArray, hidden.</summary>
        public AndroidManagedStoreAppConfigurationSchemaItemDataType? DataType {
            get { return BackingStore?.Get<AndroidManagedStoreAppConfigurationSchemaItemDataType?>(nameof(DataType)); }
            set { BackingStore?.Set(nameof(DataType), value); }
        }
        /// <summary>Default value for boolean type items, if specified by the app developer</summary>
        public bool? DefaultBoolValue {
            get { return BackingStore?.Get<bool?>(nameof(DefaultBoolValue)); }
            set { BackingStore?.Set(nameof(DefaultBoolValue), value); }
        }
        /// <summary>Default value for integer type items, if specified by the app developer</summary>
        public int? DefaultIntValue {
            get { return BackingStore?.Get<int?>(nameof(DefaultIntValue)); }
            set { BackingStore?.Set(nameof(DefaultIntValue), value); }
        }
        /// <summary>Default value for string array type items, if specified by the app developer</summary>
        public List<string> DefaultStringArrayValue {
            get { return BackingStore?.Get<List<string>>(nameof(DefaultStringArrayValue)); }
            set { BackingStore?.Set(nameof(DefaultStringArrayValue), value); }
        }
        /// <summary>Default value for string type items, if specified by the app developer</summary>
        public string DefaultStringValue {
            get { return BackingStore?.Get<string>(nameof(DefaultStringValue)); }
            set { BackingStore?.Set(nameof(DefaultStringValue), value); }
        }
        /// <summary>Description of what the item controls within the application</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Human readable name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Unique index the application uses to maintain nested schema items</summary>
        public int? Index {
            get { return BackingStore?.Get<int?>(nameof(Index)); }
            set { BackingStore?.Set(nameof(Index), value); }
        }
        /// <summary>Index of parent schema item to track nested schema items</summary>
        public int? ParentIndex {
            get { return BackingStore?.Get<int?>(nameof(ParentIndex)); }
            set { BackingStore?.Set(nameof(ParentIndex), value); }
        }
        /// <summary>Unique key the application uses to identify the item</summary>
        public string SchemaItemKey {
            get { return BackingStore?.Get<string>(nameof(SchemaItemKey)); }
            set { BackingStore?.Set(nameof(SchemaItemKey), value); }
        }
        /// <summary>List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)</summary>
        public List<KeyValuePair> Selections {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(Selections)); }
            set { BackingStore?.Set(nameof(Selections), value); }
        }
        /// <summary>
        /// Instantiates a new androidManagedStoreAppConfigurationSchemaItem and sets the default values.
        /// </summary>
        public AndroidManagedStoreAppConfigurationSchemaItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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

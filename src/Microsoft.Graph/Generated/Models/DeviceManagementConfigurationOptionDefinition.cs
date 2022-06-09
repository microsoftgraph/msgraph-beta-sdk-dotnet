using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationOptionDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of Settings that depends on this option</summary>
        public List<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>>(nameof(DependedOnBy)); }
            set { BackingStore?.Set(nameof(DependedOnBy), value); }
        }
        /// <summary>List of dependent settings for this option</summary>
        public List<DeviceManagementConfigurationDependentOn> DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>>(nameof(DependentOn)); }
            set { BackingStore?.Set(nameof(DependentOn), value); }
        }
        /// <summary>Description of the option</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Friendly name of the option</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Help text of the option</summary>
        public string HelpText {
            get { return BackingStore?.Get<string>(nameof(HelpText)); }
            set { BackingStore?.Set(nameof(HelpText), value); }
        }
        /// <summary>Identifier of option</summary>
        public string ItemId {
            get { return BackingStore?.Get<string>(nameof(ItemId)); }
            set { BackingStore?.Set(nameof(ItemId), value); }
        }
        /// <summary>Name of the option</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Value of the option</summary>
        public DeviceManagementConfigurationSettingValue OptionValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValue>(nameof(OptionValue)); }
            set { BackingStore?.Set(nameof(OptionValue), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationOptionDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationOptionDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationOptionDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationOptionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>(DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue).ToList(); } },
                {"dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>(DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"optionValue", n => { OptionValue = n.GetObjectValue<DeviceManagementConfigurationSettingValue>(DeviceManagementConfigurationSettingValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingValue>("optionValue", OptionValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

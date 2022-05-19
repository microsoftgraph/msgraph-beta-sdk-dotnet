using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesExtensionAttributes : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>First customizable extension attribute.</summary>
        public string ExtensionAttribute1 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute1)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute1), value); }
        }
        /// <summary>Tenth customizable extension attribute.</summary>
        public string ExtensionAttribute10 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute10)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute10), value); }
        }
        /// <summary>Eleventh customizable extension attribute.</summary>
        public string ExtensionAttribute11 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute11)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute11), value); }
        }
        /// <summary>Twelfth customizable extension attribute.</summary>
        public string ExtensionAttribute12 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute12)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute12), value); }
        }
        /// <summary>Thirteenth customizable extension attribute.</summary>
        public string ExtensionAttribute13 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute13)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute13), value); }
        }
        /// <summary>Fourteenth customizable extension attribute.</summary>
        public string ExtensionAttribute14 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute14)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute14), value); }
        }
        /// <summary>Fifteenth customizable extension attribute.</summary>
        public string ExtensionAttribute15 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute15)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute15), value); }
        }
        /// <summary>Second customizable extension attribute.</summary>
        public string ExtensionAttribute2 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute2)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute2), value); }
        }
        /// <summary>Third customizable extension attribute.</summary>
        public string ExtensionAttribute3 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute3)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute3), value); }
        }
        /// <summary>Fourth customizable extension attribute.</summary>
        public string ExtensionAttribute4 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute4)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute4), value); }
        }
        /// <summary>Fifth customizable extension attribute.</summary>
        public string ExtensionAttribute5 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute5)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute5), value); }
        }
        /// <summary>Sixth customizable extension attribute.</summary>
        public string ExtensionAttribute6 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute6)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute6), value); }
        }
        /// <summary>Seventh customizable extension attribute.</summary>
        public string ExtensionAttribute7 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute7)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute7), value); }
        }
        /// <summary>Eighth customizable extension attribute.</summary>
        public string ExtensionAttribute8 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute8)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute8), value); }
        }
        /// <summary>Ninth customizable extension attribute.</summary>
        public string ExtensionAttribute9 {
            get { return BackingStore?.Get<string>(nameof(ExtensionAttribute9)); }
            set { BackingStore?.Set(nameof(ExtensionAttribute9), value); }
        }
        /// <summary>
        /// Instantiates a new onPremisesExtensionAttributes and sets the default values.
        /// </summary>
        public OnPremisesExtensionAttributes() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OnPremisesExtensionAttributes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesExtensionAttributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"extensionAttribute1", n => { ExtensionAttribute1 = n.GetStringValue(); } },
                {"extensionAttribute10", n => { ExtensionAttribute10 = n.GetStringValue(); } },
                {"extensionAttribute11", n => { ExtensionAttribute11 = n.GetStringValue(); } },
                {"extensionAttribute12", n => { ExtensionAttribute12 = n.GetStringValue(); } },
                {"extensionAttribute13", n => { ExtensionAttribute13 = n.GetStringValue(); } },
                {"extensionAttribute14", n => { ExtensionAttribute14 = n.GetStringValue(); } },
                {"extensionAttribute15", n => { ExtensionAttribute15 = n.GetStringValue(); } },
                {"extensionAttribute2", n => { ExtensionAttribute2 = n.GetStringValue(); } },
                {"extensionAttribute3", n => { ExtensionAttribute3 = n.GetStringValue(); } },
                {"extensionAttribute4", n => { ExtensionAttribute4 = n.GetStringValue(); } },
                {"extensionAttribute5", n => { ExtensionAttribute5 = n.GetStringValue(); } },
                {"extensionAttribute6", n => { ExtensionAttribute6 = n.GetStringValue(); } },
                {"extensionAttribute7", n => { ExtensionAttribute7 = n.GetStringValue(); } },
                {"extensionAttribute8", n => { ExtensionAttribute8 = n.GetStringValue(); } },
                {"extensionAttribute9", n => { ExtensionAttribute9 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("extensionAttribute1", ExtensionAttribute1);
            writer.WriteStringValue("extensionAttribute10", ExtensionAttribute10);
            writer.WriteStringValue("extensionAttribute11", ExtensionAttribute11);
            writer.WriteStringValue("extensionAttribute12", ExtensionAttribute12);
            writer.WriteStringValue("extensionAttribute13", ExtensionAttribute13);
            writer.WriteStringValue("extensionAttribute14", ExtensionAttribute14);
            writer.WriteStringValue("extensionAttribute15", ExtensionAttribute15);
            writer.WriteStringValue("extensionAttribute2", ExtensionAttribute2);
            writer.WriteStringValue("extensionAttribute3", ExtensionAttribute3);
            writer.WriteStringValue("extensionAttribute4", ExtensionAttribute4);
            writer.WriteStringValue("extensionAttribute5", ExtensionAttribute5);
            writer.WriteStringValue("extensionAttribute6", ExtensionAttribute6);
            writer.WriteStringValue("extensionAttribute7", ExtensionAttribute7);
            writer.WriteStringValue("extensionAttribute8", ExtensionAttribute8);
            writer.WriteStringValue("extensionAttribute9", ExtensionAttribute9);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The minimum operating system required for a MacOS app.</summary>
    public class MacOSMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Mac OS 10.10 or later.</summary>
        public bool? V10_10 {
            get { return BackingStore?.Get<bool?>("v10_10"); }
            set { BackingStore?.Set("v10_10", value); }
        }
        /// <summary>Mac OS 10.11 or later.</summary>
        public bool? V10_11 {
            get { return BackingStore?.Get<bool?>("v10_11"); }
            set { BackingStore?.Set("v10_11", value); }
        }
        /// <summary>Mac OS 10.12 or later.</summary>
        public bool? V10_12 {
            get { return BackingStore?.Get<bool?>("v10_12"); }
            set { BackingStore?.Set("v10_12", value); }
        }
        /// <summary>Mac OS 10.13 or later.</summary>
        public bool? V10_13 {
            get { return BackingStore?.Get<bool?>("v10_13"); }
            set { BackingStore?.Set("v10_13", value); }
        }
        /// <summary>Mac OS 10.14 or later.</summary>
        public bool? V10_14 {
            get { return BackingStore?.Get<bool?>("v10_14"); }
            set { BackingStore?.Set("v10_14", value); }
        }
        /// <summary>Mac OS 10.15 or later.</summary>
        public bool? V10_15 {
            get { return BackingStore?.Get<bool?>("v10_15"); }
            set { BackingStore?.Set("v10_15", value); }
        }
        /// <summary>Mac OS 10.7 or later.</summary>
        public bool? V10_7 {
            get { return BackingStore?.Get<bool?>("v10_7"); }
            set { BackingStore?.Set("v10_7", value); }
        }
        /// <summary>Mac OS 10.8 or later.</summary>
        public bool? V10_8 {
            get { return BackingStore?.Get<bool?>("v10_8"); }
            set { BackingStore?.Set("v10_8", value); }
        }
        /// <summary>Mac OS 10.9 or later.</summary>
        public bool? V10_9 {
            get { return BackingStore?.Get<bool?>("v10_9"); }
            set { BackingStore?.Set("v10_9", value); }
        }
        /// <summary>Mac OS 11.0 or later.</summary>
        public bool? V11_0 {
            get { return BackingStore?.Get<bool?>("v11_0"); }
            set { BackingStore?.Set("v11_0", value); }
        }
        /// <summary>Mac OS 12.0 or later.</summary>
        public bool? V12_0 {
            get { return BackingStore?.Get<bool?>("v12_0"); }
            set { BackingStore?.Set("v12_0", value); }
        }
        /// <summary>
        /// Instantiates a new macOSMinimumOperatingSystem and sets the default values.
        /// </summary>
        public MacOSMinimumOperatingSystem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"v10_10", n => { V10_10 = n.GetBoolValue(); } },
                {"v10_11", n => { V10_11 = n.GetBoolValue(); } },
                {"v10_12", n => { V10_12 = n.GetBoolValue(); } },
                {"v10_13", n => { V10_13 = n.GetBoolValue(); } },
                {"v10_14", n => { V10_14 = n.GetBoolValue(); } },
                {"v10_15", n => { V10_15 = n.GetBoolValue(); } },
                {"v10_7", n => { V10_7 = n.GetBoolValue(); } },
                {"v10_8", n => { V10_8 = n.GetBoolValue(); } },
                {"v10_9", n => { V10_9 = n.GetBoolValue(); } },
                {"v11_0", n => { V11_0 = n.GetBoolValue(); } },
                {"v12_0", n => { V12_0 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("v10_10", V10_10);
            writer.WriteBoolValue("v10_11", V10_11);
            writer.WriteBoolValue("v10_12", V10_12);
            writer.WriteBoolValue("v10_13", V10_13);
            writer.WriteBoolValue("v10_14", V10_14);
            writer.WriteBoolValue("v10_15", V10_15);
            writer.WriteBoolValue("v10_7", V10_7);
            writer.WriteBoolValue("v10_8", V10_8);
            writer.WriteBoolValue("v10_9", V10_9);
            writer.WriteBoolValue("v11_0", V11_0);
            writer.WriteBoolValue("v12_0", V12_0);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

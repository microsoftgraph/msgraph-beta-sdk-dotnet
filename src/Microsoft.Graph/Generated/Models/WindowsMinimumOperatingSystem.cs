using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The minimum operating system required for a Windows mobile app.</summary>
    public class WindowsMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Windows version 10.0 or later.</summary>
        public bool? V10_0 {
            get { return BackingStore?.Get<bool?>("v10_0"); }
            set { BackingStore?.Set("v10_0", value); }
        }
        /// <summary>Windows 10 1607 or later.</summary>
        public bool? V10_1607 {
            get { return BackingStore?.Get<bool?>("v10_1607"); }
            set { BackingStore?.Set("v10_1607", value); }
        }
        /// <summary>Windows 10 1703 or later.</summary>
        public bool? V10_1703 {
            get { return BackingStore?.Get<bool?>("v10_1703"); }
            set { BackingStore?.Set("v10_1703", value); }
        }
        /// <summary>Windows 10 1709 or later.</summary>
        public bool? V10_1709 {
            get { return BackingStore?.Get<bool?>("v10_1709"); }
            set { BackingStore?.Set("v10_1709", value); }
        }
        /// <summary>Windows 10 1803 or later.</summary>
        public bool? V10_1803 {
            get { return BackingStore?.Get<bool?>("v10_1803"); }
            set { BackingStore?.Set("v10_1803", value); }
        }
        /// <summary>Windows 10 1809 or later.</summary>
        public bool? V10_1809 {
            get { return BackingStore?.Get<bool?>("v10_1809"); }
            set { BackingStore?.Set("v10_1809", value); }
        }
        /// <summary>Windows 10 1903 or later.</summary>
        public bool? V10_1903 {
            get { return BackingStore?.Get<bool?>("v10_1903"); }
            set { BackingStore?.Set("v10_1903", value); }
        }
        /// <summary>Windows 10 1909 or later.</summary>
        public bool? V10_1909 {
            get { return BackingStore?.Get<bool?>("v10_1909"); }
            set { BackingStore?.Set("v10_1909", value); }
        }
        /// <summary>Windows 10 2004 or later.</summary>
        public bool? V10_2004 {
            get { return BackingStore?.Get<bool?>("v10_2004"); }
            set { BackingStore?.Set("v10_2004", value); }
        }
        /// <summary>Windows 10 21H1 or later.</summary>
        public bool? V10_21H1 {
            get { return BackingStore?.Get<bool?>("v10_21H1"); }
            set { BackingStore?.Set("v10_21H1", value); }
        }
        /// <summary>Windows 10 2H20 or later.</summary>
        public bool? V10_2H20 {
            get { return BackingStore?.Get<bool?>("v10_2H20"); }
            set { BackingStore?.Set("v10_2H20", value); }
        }
        /// <summary>Windows version 8.0 or later.</summary>
        public bool? V8_0 {
            get { return BackingStore?.Get<bool?>("v8_0"); }
            set { BackingStore?.Set("v8_0", value); }
        }
        /// <summary>Windows version 8.1 or later.</summary>
        public bool? V8_1 {
            get { return BackingStore?.Get<bool?>("v8_1"); }
            set { BackingStore?.Set("v8_1", value); }
        }
        /// <summary>
        /// Instantiates a new windowsMinimumOperatingSystem and sets the default values.
        /// </summary>
        public WindowsMinimumOperatingSystem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"v10_0", n => { V10_0 = n.GetBoolValue(); } },
                {"v10_1607", n => { V10_1607 = n.GetBoolValue(); } },
                {"v10_1703", n => { V10_1703 = n.GetBoolValue(); } },
                {"v10_1709", n => { V10_1709 = n.GetBoolValue(); } },
                {"v10_1803", n => { V10_1803 = n.GetBoolValue(); } },
                {"v10_1809", n => { V10_1809 = n.GetBoolValue(); } },
                {"v10_1903", n => { V10_1903 = n.GetBoolValue(); } },
                {"v10_1909", n => { V10_1909 = n.GetBoolValue(); } },
                {"v10_2004", n => { V10_2004 = n.GetBoolValue(); } },
                {"v10_21H1", n => { V10_21H1 = n.GetBoolValue(); } },
                {"v10_2H20", n => { V10_2H20 = n.GetBoolValue(); } },
                {"v8_0", n => { V8_0 = n.GetBoolValue(); } },
                {"v8_1", n => { V8_1 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("v10_0", V10_0);
            writer.WriteBoolValue("v10_1607", V10_1607);
            writer.WriteBoolValue("v10_1703", V10_1703);
            writer.WriteBoolValue("v10_1709", V10_1709);
            writer.WriteBoolValue("v10_1803", V10_1803);
            writer.WriteBoolValue("v10_1809", V10_1809);
            writer.WriteBoolValue("v10_1903", V10_1903);
            writer.WriteBoolValue("v10_1909", V10_1909);
            writer.WriteBoolValue("v10_2004", V10_2004);
            writer.WriteBoolValue("v10_21H1", V10_21H1);
            writer.WriteBoolValue("v10_2H20", V10_2H20);
            writer.WriteBoolValue("v8_0", V8_0);
            writer.WriteBoolValue("v8_1", V8_1);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

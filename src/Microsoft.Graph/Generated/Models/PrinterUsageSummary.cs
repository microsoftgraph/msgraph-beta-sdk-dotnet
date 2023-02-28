using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterUsageSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The completedJobCount property</summary>
        public int? CompletedJobCount {
            get { return BackingStore?.Get<int?>("completedJobCount"); }
            set { BackingStore?.Set("completedJobCount", value); }
        }
        /// <summary>The incompleteJobCount property</summary>
        public int? IncompleteJobCount {
            get { return BackingStore?.Get<int?>("incompleteJobCount"); }
            set { BackingStore?.Set("incompleteJobCount", value); }
        }
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
        /// <summary>The printer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Printer {
            get { return BackingStore?.Get<DirectoryObject?>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#nullable restore
#else
        public DirectoryObject Printer {
            get { return BackingStore?.Get<DirectoryObject>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#endif
        /// <summary>The printerDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterDisplayName {
            get { return BackingStore?.Get<string?>("printerDisplayName"); }
            set { BackingStore?.Set("printerDisplayName", value); }
        }
#nullable restore
#else
        public string PrinterDisplayName {
            get { return BackingStore?.Get<string>("printerDisplayName"); }
            set { BackingStore?.Set("printerDisplayName", value); }
        }
#endif
        /// <summary>The printerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterId {
            get { return BackingStore?.Get<string?>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#nullable restore
#else
        public string PrinterId {
            get { return BackingStore?.Get<string>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#endif
        /// <summary>The printerManufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterManufacturer {
            get { return BackingStore?.Get<string?>("printerManufacturer"); }
            set { BackingStore?.Set("printerManufacturer", value); }
        }
#nullable restore
#else
        public string PrinterManufacturer {
            get { return BackingStore?.Get<string>("printerManufacturer"); }
            set { BackingStore?.Set("printerManufacturer", value); }
        }
#endif
        /// <summary>The printerModel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterModel {
            get { return BackingStore?.Get<string?>("printerModel"); }
            set { BackingStore?.Set("printerModel", value); }
        }
#nullable restore
#else
        public string PrinterModel {
            get { return BackingStore?.Get<string>("printerModel"); }
            set { BackingStore?.Set("printerModel", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new printerUsageSummary and sets the default values.
        /// </summary>
        public PrinterUsageSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrinterUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedJobCount", n => { CompletedJobCount = n.GetIntValue(); } },
                {"incompleteJobCount", n => { IncompleteJobCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"printer", n => { Printer = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"printerDisplayName", n => { PrinterDisplayName = n.GetStringValue(); } },
                {"printerId", n => { PrinterId = n.GetStringValue(); } },
                {"printerManufacturer", n => { PrinterManufacturer = n.GetStringValue(); } },
                {"printerModel", n => { PrinterModel = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("completedJobCount", CompletedJobCount);
            writer.WriteIntValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<DirectoryObject>("printer", Printer);
            writer.WriteStringValue("printerDisplayName", PrinterDisplayName);
            writer.WriteStringValue("printerId", PrinterId);
            writer.WriteStringValue("printerManufacturer", PrinterManufacturer);
            writer.WriteStringValue("printerModel", PrinterModel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

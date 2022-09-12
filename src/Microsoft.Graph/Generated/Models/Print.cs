using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Print : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of available print connectors.</summary>
        public List<PrintConnector> Connectors {
            get { return BackingStore?.Get<List<PrintConnector>>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The operations property</summary>
        public List<PrintOperation> Operations {
            get { return BackingStore?.Get<List<PrintOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>The list of printers registered in the tenant.</summary>
        public List<Printer> Printers {
            get { return BackingStore?.Get<List<Printer>>("printers"); }
            set { BackingStore?.Set("printers", value); }
        }
        /// <summary>The printerShares property</summary>
        public List<PrinterShare> PrinterShares {
            get { return BackingStore?.Get<List<PrinterShare>>("printerShares"); }
            set { BackingStore?.Set("printerShares", value); }
        }
        /// <summary>The reports property</summary>
        public ReportRoot Reports {
            get { return BackingStore?.Get<ReportRoot>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
        /// <summary>The list of available Universal Print service endpoints.</summary>
        public List<PrintService> Services {
            get { return BackingStore?.Get<List<PrintService>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
        /// <summary>Tenant-wide settings for the Universal Print service.</summary>
        public PrintSettings Settings {
            get { return BackingStore?.Get<PrintSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
        /// <summary>The list of printer shares registered in the tenant.</summary>
        public List<PrinterShare> Shares {
            get { return BackingStore?.Get<List<PrinterShare>>("shares"); }
            set { BackingStore?.Set("shares", value); }
        }
        /// <summary>The taskDefinitions property</summary>
        public List<PrintTaskDefinition> TaskDefinitions {
            get { return BackingStore?.Get<List<PrintTaskDefinition>>("taskDefinitions"); }
            set { BackingStore?.Set("taskDefinitions", value); }
        }
        /// <summary>
        /// Instantiates a new Print and sets the default values.
        /// </summary>
        public Print() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.print";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Print CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Print();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<PrintOperation>(PrintOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"printers", n => { Printers = n.GetCollectionOfObjectValues<Printer>(Printer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"printerShares", n => { PrinterShares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<ReportRoot>(ReportRoot.CreateFromDiscriminatorValue); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<PrintService>(PrintService.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<PrintSettings>(PrintSettings.CreateFromDiscriminatorValue); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PrintOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Printer>("printers", Printers);
            writer.WriteCollectionOfObjectValues<PrinterShare>("printerShares", PrinterShares);
            writer.WriteObjectValue<ReportRoot>("reports", Reports);
            writer.WriteCollectionOfObjectValues<PrintService>("services", Services);
            writer.WriteObjectValue<PrintSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

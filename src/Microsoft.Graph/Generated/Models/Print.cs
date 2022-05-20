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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of available print connectors.</summary>
        public List<PrintConnector> Connectors {
            get { return BackingStore?.Get<List<PrintConnector>>(nameof(Connectors)); }
            set { BackingStore?.Set(nameof(Connectors), value); }
        }
        /// <summary>The list of print long running operations.</summary>
        public List<PrintOperation> Operations {
            get { return BackingStore?.Get<List<PrintOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The list of printers registered in the tenant.</summary>
        public List<Printer> Printers {
            get { return BackingStore?.Get<List<Printer>>(nameof(Printers)); }
            set { BackingStore?.Set(nameof(Printers), value); }
        }
        /// <summary>The printerShares property</summary>
        public List<PrinterShare> PrinterShares {
            get { return BackingStore?.Get<List<PrinterShare>>(nameof(PrinterShares)); }
            set { BackingStore?.Set(nameof(PrinterShares), value); }
        }
        /// <summary>The reports property</summary>
        public ReportRoot Reports {
            get { return BackingStore?.Get<ReportRoot>(nameof(Reports)); }
            set { BackingStore?.Set(nameof(Reports), value); }
        }
        /// <summary>The list of available Universal Print service endpoints.</summary>
        public List<PrintService> Services {
            get { return BackingStore?.Get<List<PrintService>>(nameof(Services)); }
            set { BackingStore?.Set(nameof(Services), value); }
        }
        /// <summary>Tenant-wide settings for the Universal Print service.</summary>
        public PrintSettings Settings {
            get { return BackingStore?.Get<PrintSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>The list of printer shares registered in the tenant.</summary>
        public List<PrinterShare> Shares {
            get { return BackingStore?.Get<List<PrinterShare>>(nameof(Shares)); }
            set { BackingStore?.Set(nameof(Shares), value); }
        }
        /// <summary>List of abstract definition for a task that can be triggered when various events occur within Universal Print.</summary>
        public List<PrintTaskDefinition> TaskDefinitions {
            get { return BackingStore?.Get<List<PrintTaskDefinition>>(nameof(TaskDefinitions)); }
            set { BackingStore?.Set(nameof(TaskDefinitions), value); }
        }
        /// <summary>
        /// Instantiates a new Print and sets the default values.
        /// </summary>
        public Print() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
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
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<PrintOperation>(PrintOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"printers", n => { Printers = n.GetCollectionOfObjectValues<Printer>(Printer.CreateFromDiscriminatorValue).ToList(); } },
                {"printerShares", n => { PrinterShares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue).ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<ReportRoot>(ReportRoot.CreateFromDiscriminatorValue); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<PrintService>(PrintService.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<PrintSettings>(PrintSettings.CreateFromDiscriminatorValue); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue).ToList(); } },
                {"taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
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

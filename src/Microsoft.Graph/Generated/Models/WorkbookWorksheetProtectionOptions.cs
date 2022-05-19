using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookWorksheetProtectionOptions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing using auto filter feature.</summary>
        public bool? AllowAutoFilter {
            get { return BackingStore?.Get<bool?>(nameof(AllowAutoFilter)); }
            set { BackingStore?.Set(nameof(AllowAutoFilter), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing deleting columns.</summary>
        public bool? AllowDeleteColumns {
            get { return BackingStore?.Get<bool?>(nameof(AllowDeleteColumns)); }
            set { BackingStore?.Set(nameof(AllowDeleteColumns), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing deleting rows.</summary>
        public bool? AllowDeleteRows {
            get { return BackingStore?.Get<bool?>(nameof(AllowDeleteRows)); }
            set { BackingStore?.Set(nameof(AllowDeleteRows), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing formatting cells.</summary>
        public bool? AllowFormatCells {
            get { return BackingStore?.Get<bool?>(nameof(AllowFormatCells)); }
            set { BackingStore?.Set(nameof(AllowFormatCells), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing formatting columns.</summary>
        public bool? AllowFormatColumns {
            get { return BackingStore?.Get<bool?>(nameof(AllowFormatColumns)); }
            set { BackingStore?.Set(nameof(AllowFormatColumns), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing formatting rows.</summary>
        public bool? AllowFormatRows {
            get { return BackingStore?.Get<bool?>(nameof(AllowFormatRows)); }
            set { BackingStore?.Set(nameof(AllowFormatRows), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing inserting columns.</summary>
        public bool? AllowInsertColumns {
            get { return BackingStore?.Get<bool?>(nameof(AllowInsertColumns)); }
            set { BackingStore?.Set(nameof(AllowInsertColumns), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing inserting hyperlinks.</summary>
        public bool? AllowInsertHyperlinks {
            get { return BackingStore?.Get<bool?>(nameof(AllowInsertHyperlinks)); }
            set { BackingStore?.Set(nameof(AllowInsertHyperlinks), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing inserting rows.</summary>
        public bool? AllowInsertRows {
            get { return BackingStore?.Get<bool?>(nameof(AllowInsertRows)); }
            set { BackingStore?.Set(nameof(AllowInsertRows), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing using pivot table feature.</summary>
        public bool? AllowPivotTables {
            get { return BackingStore?.Get<bool?>(nameof(AllowPivotTables)); }
            set { BackingStore?.Set(nameof(AllowPivotTables), value); }
        }
        /// <summary>Represents the worksheet protection option of allowing using sort feature.</summary>
        public bool? AllowSort {
            get { return BackingStore?.Get<bool?>(nameof(AllowSort)); }
            set { BackingStore?.Set(nameof(AllowSort), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new workbookWorksheetProtectionOptions and sets the default values.
        /// </summary>
        public WorkbookWorksheetProtectionOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WorkbookWorksheetProtectionOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheetProtectionOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowAutoFilter", n => { AllowAutoFilter = n.GetBoolValue(); } },
                {"allowDeleteColumns", n => { AllowDeleteColumns = n.GetBoolValue(); } },
                {"allowDeleteRows", n => { AllowDeleteRows = n.GetBoolValue(); } },
                {"allowFormatCells", n => { AllowFormatCells = n.GetBoolValue(); } },
                {"allowFormatColumns", n => { AllowFormatColumns = n.GetBoolValue(); } },
                {"allowFormatRows", n => { AllowFormatRows = n.GetBoolValue(); } },
                {"allowInsertColumns", n => { AllowInsertColumns = n.GetBoolValue(); } },
                {"allowInsertHyperlinks", n => { AllowInsertHyperlinks = n.GetBoolValue(); } },
                {"allowInsertRows", n => { AllowInsertRows = n.GetBoolValue(); } },
                {"allowPivotTables", n => { AllowPivotTables = n.GetBoolValue(); } },
                {"allowSort", n => { AllowSort = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAutoFilter", AllowAutoFilter);
            writer.WriteBoolValue("allowDeleteColumns", AllowDeleteColumns);
            writer.WriteBoolValue("allowDeleteRows", AllowDeleteRows);
            writer.WriteBoolValue("allowFormatCells", AllowFormatCells);
            writer.WriteBoolValue("allowFormatColumns", AllowFormatColumns);
            writer.WriteBoolValue("allowFormatRows", AllowFormatRows);
            writer.WriteBoolValue("allowInsertColumns", AllowInsertColumns);
            writer.WriteBoolValue("allowInsertHyperlinks", AllowInsertHyperlinks);
            writer.WriteBoolValue("allowInsertRows", AllowInsertRows);
            writer.WriteBoolValue("allowPivotTables", AllowPivotTables);
            writer.WriteBoolValue("allowSort", AllowSort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

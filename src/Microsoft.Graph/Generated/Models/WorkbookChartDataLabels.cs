using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class WorkbookChartDataLabels : Entity, IParsable {
        /// <summary>Represents the format of chart data labels, which includes fill and font formatting. Read-only.</summary>
        public WorkbookChartDataLabelFormat Format {
            get { return BackingStore?.Get<WorkbookChartDataLabelFormat>(nameof(Format)); }
            set { BackingStore?.Set(nameof(Format), value); }
        }
        /// <summary>DataLabelPosition value that represents the position of the data label. The possible values are: None, Center, InsideEnd, InsideBase, OutsideEnd, Left, Right, Top, Bottom, BestFit, Callout.</summary>
        public string Position {
            get { return BackingStore?.Get<string>(nameof(Position)); }
            set { BackingStore?.Set(nameof(Position), value); }
        }
        /// <summary>String representing the separator used for the data labels on a chart.</summary>
        public string Separator {
            get { return BackingStore?.Get<string>(nameof(Separator)); }
            set { BackingStore?.Set(nameof(Separator), value); }
        }
        /// <summary>Boolean value representing if the data label bubble size is visible or not.</summary>
        public bool? ShowBubbleSize {
            get { return BackingStore?.Get<bool?>(nameof(ShowBubbleSize)); }
            set { BackingStore?.Set(nameof(ShowBubbleSize), value); }
        }
        /// <summary>Boolean value representing if the data label category name is visible or not.</summary>
        public bool? ShowCategoryName {
            get { return BackingStore?.Get<bool?>(nameof(ShowCategoryName)); }
            set { BackingStore?.Set(nameof(ShowCategoryName), value); }
        }
        /// <summary>Boolean value representing if the data label legend key is visible or not.</summary>
        public bool? ShowLegendKey {
            get { return BackingStore?.Get<bool?>(nameof(ShowLegendKey)); }
            set { BackingStore?.Set(nameof(ShowLegendKey), value); }
        }
        /// <summary>Boolean value representing if the data label percentage is visible or not.</summary>
        public bool? ShowPercentage {
            get { return BackingStore?.Get<bool?>(nameof(ShowPercentage)); }
            set { BackingStore?.Set(nameof(ShowPercentage), value); }
        }
        /// <summary>Boolean value representing if the data label series name is visible or not.</summary>
        public bool? ShowSeriesName {
            get { return BackingStore?.Get<bool?>(nameof(ShowSeriesName)); }
            set { BackingStore?.Set(nameof(ShowSeriesName), value); }
        }
        /// <summary>Boolean value representing if the data label value is visible or not.</summary>
        public bool? ShowValue {
            get { return BackingStore?.Get<bool?>(nameof(ShowValue)); }
            set { BackingStore?.Set(nameof(ShowValue), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChartDataLabels CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartDataLabels();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"format", n => { Format = n.GetObjectValue<WorkbookChartDataLabelFormat>(WorkbookChartDataLabelFormat.CreateFromDiscriminatorValue); } },
                {"position", n => { Position = n.GetStringValue(); } },
                {"separator", n => { Separator = n.GetStringValue(); } },
                {"showBubbleSize", n => { ShowBubbleSize = n.GetBoolValue(); } },
                {"showCategoryName", n => { ShowCategoryName = n.GetBoolValue(); } },
                {"showLegendKey", n => { ShowLegendKey = n.GetBoolValue(); } },
                {"showPercentage", n => { ShowPercentage = n.GetBoolValue(); } },
                {"showSeriesName", n => { ShowSeriesName = n.GetBoolValue(); } },
                {"showValue", n => { ShowValue = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartDataLabelFormat>("format", Format);
            writer.WriteStringValue("position", Position);
            writer.WriteStringValue("separator", Separator);
            writer.WriteBoolValue("showBubbleSize", ShowBubbleSize);
            writer.WriteBoolValue("showCategoryName", ShowCategoryName);
            writer.WriteBoolValue("showLegendKey", ShowLegendKey);
            writer.WriteBoolValue("showPercentage", ShowPercentage);
            writer.WriteBoolValue("showSeriesName", ShowSeriesName);
            writer.WriteBoolValue("showValue", ShowValue);
        }
    }
}

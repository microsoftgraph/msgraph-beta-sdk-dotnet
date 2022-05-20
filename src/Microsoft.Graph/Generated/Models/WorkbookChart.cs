using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class WorkbookChart : Entity, IParsable {
        /// <summary>Represents chart axes. Read-only.</summary>
        public WorkbookChartAxes Axes {
            get { return BackingStore?.Get<WorkbookChartAxes>(nameof(Axes)); }
            set { BackingStore?.Set(nameof(Axes), value); }
        }
        /// <summary>Represents the datalabels on the chart. Read-only.</summary>
        public WorkbookChartDataLabels DataLabels {
            get { return BackingStore?.Get<WorkbookChartDataLabels>(nameof(DataLabels)); }
            set { BackingStore?.Set(nameof(DataLabels), value); }
        }
        /// <summary>Encapsulates the format properties for the chart area. Read-only.</summary>
        public WorkbookChartAreaFormat Format {
            get { return BackingStore?.Get<WorkbookChartAreaFormat>(nameof(Format)); }
            set { BackingStore?.Set(nameof(Format), value); }
        }
        /// <summary>Represents the height, in points, of the chart object.</summary>
        public double? Height {
            get { return BackingStore?.Get<double?>(nameof(Height)); }
            set { BackingStore?.Set(nameof(Height), value); }
        }
        /// <summary>The distance, in points, from the left side of the chart to the worksheet origin.</summary>
        public double? Left {
            get { return BackingStore?.Get<double?>(nameof(Left)); }
            set { BackingStore?.Set(nameof(Left), value); }
        }
        /// <summary>Represents the legend for the chart. Read-only.</summary>
        public WorkbookChartLegend Legend {
            get { return BackingStore?.Get<WorkbookChartLegend>(nameof(Legend)); }
            set { BackingStore?.Set(nameof(Legend), value); }
        }
        /// <summary>Represents the name of a chart object.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Represents either a single series or collection of series in the chart. Read-only.</summary>
        public List<WorkbookChartSeries> Series {
            get { return BackingStore?.Get<List<WorkbookChartSeries>>(nameof(Series)); }
            set { BackingStore?.Set(nameof(Series), value); }
        }
        /// <summary>Represents the title of the specified chart, including the text, visibility, position and formating of the title. Read-only.</summary>
        public WorkbookChartTitle Title {
            get { return BackingStore?.Get<WorkbookChartTitle>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>Represents the distance, in points, from the top edge of the object to the top of row 1 (on a worksheet) or the top of the chart area (on a chart).</summary>
        public double? Top {
            get { return BackingStore?.Get<double?>(nameof(Top)); }
            set { BackingStore?.Set(nameof(Top), value); }
        }
        /// <summary>Represents the width, in points, of the chart object.</summary>
        public double? Width {
            get { return BackingStore?.Get<double?>(nameof(Width)); }
            set { BackingStore?.Set(nameof(Width), value); }
        }
        /// <summary>The worksheet containing the current chart. Read-only.</summary>
        public WorkbookWorksheet Worksheet {
            get { return BackingStore?.Get<WorkbookWorksheet>(nameof(Worksheet)); }
            set { BackingStore?.Set(nameof(Worksheet), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"axes", n => { Axes = n.GetObjectValue<WorkbookChartAxes>(WorkbookChartAxes.CreateFromDiscriminatorValue); } },
                {"dataLabels", n => { DataLabels = n.GetObjectValue<WorkbookChartDataLabels>(WorkbookChartDataLabels.CreateFromDiscriminatorValue); } },
                {"format", n => { Format = n.GetObjectValue<WorkbookChartAreaFormat>(WorkbookChartAreaFormat.CreateFromDiscriminatorValue); } },
                {"height", n => { Height = n.GetDoubleValue(); } },
                {"left", n => { Left = n.GetDoubleValue(); } },
                {"legend", n => { Legend = n.GetObjectValue<WorkbookChartLegend>(WorkbookChartLegend.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"series", n => { Series = n.GetCollectionOfObjectValues<WorkbookChartSeries>(WorkbookChartSeries.CreateFromDiscriminatorValue).ToList(); } },
                {"title", n => { Title = n.GetObjectValue<WorkbookChartTitle>(WorkbookChartTitle.CreateFromDiscriminatorValue); } },
                {"top", n => { Top = n.GetDoubleValue(); } },
                {"width", n => { Width = n.GetDoubleValue(); } },
                {"worksheet", n => { Worksheet = n.GetObjectValue<WorkbookWorksheet>(WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxes>("axes", Axes);
            writer.WriteObjectValue<WorkbookChartDataLabels>("dataLabels", DataLabels);
            writer.WriteObjectValue<WorkbookChartAreaFormat>("format", Format);
            writer.WriteDoubleValue("height", Height);
            writer.WriteDoubleValue("left", Left);
            writer.WriteObjectValue<WorkbookChartLegend>("legend", Legend);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookChartSeries>("series", Series);
            writer.WriteObjectValue<WorkbookChartTitle>("title", Title);
            writer.WriteDoubleValue("top", Top);
            writer.WriteDoubleValue("width", Width);
            writer.WriteObjectValue<WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}

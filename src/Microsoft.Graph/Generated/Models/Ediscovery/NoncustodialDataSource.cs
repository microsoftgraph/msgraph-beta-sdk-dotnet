using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>
    /// Provides operations to manage the compliance singleton.
    /// </summary>
    public class NoncustodialDataSource : DataSourceContainer, IParsable {
        /// <summary>Indicates if hold is applied to non-custodial data source (such as mailbox or site).</summary>
        public bool? ApplyHoldToSource {
            get { return BackingStore?.Get<bool?>("applyHoldToSource"); }
            set { BackingStore?.Set("applyHoldToSource", value); }
        }
        /// <summary>User source or SharePoint site data source as non-custodial data source.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.DataSource DataSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.DataSource>("dataSource"); }
            set { BackingStore?.Set("dataSource", value); }
        }
        /// <summary>
        /// Instantiates a new noncustodialDataSource and sets the default values.
        /// </summary>
        public NoncustodialDataSource() : base() {
            OdataType = "#microsoft.graph.ediscovery.noncustodialDataSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NoncustodialDataSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NoncustodialDataSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applyHoldToSource", n => { ApplyHoldToSource = n.GetBoolValue(); } },
                {"dataSource", n => { DataSource = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.DataSource>(Microsoft.Graph.Beta.Models.Ediscovery.DataSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applyHoldToSource", ApplyHoldToSource);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.DataSource>("dataSource", DataSource);
        }
    }
}

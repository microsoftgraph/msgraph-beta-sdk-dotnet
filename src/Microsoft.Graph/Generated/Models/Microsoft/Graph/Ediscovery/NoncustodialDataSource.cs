using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class NoncustodialDataSource : DataSourceContainer, IParsable {
        /// <summary>Indicates if hold is applied to non-custodial data source (such as mailbox or site).</summary>
        public bool? ApplyHoldToSource { get; set; }
        /// <summary>User source or SharePoint site data source as non-custodial data source.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.DataSource DataSource { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new NoncustodialDataSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NoncustodialDataSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applyHoldToSource", (o,n) => { (o as NoncustodialDataSource).ApplyHoldToSource = n.GetBoolValue(); } },
                {"dataSource", (o,n) => { (o as NoncustodialDataSource).DataSource = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.DataSource>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.DataSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applyHoldToSource", ApplyHoldToSource);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.DataSource>("dataSource", DataSource);
        }
    }
}

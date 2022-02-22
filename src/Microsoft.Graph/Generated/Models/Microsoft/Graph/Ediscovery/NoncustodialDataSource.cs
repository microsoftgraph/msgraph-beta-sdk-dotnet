using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Ediscovery {
    public class NoncustodialDataSource : DataSourceContainer, IParsable {
        /// <summary>Indicates if hold is applied to non-custodial data source (such as mailbox or site).</summary>
        public bool? ApplyHoldToSource { get; set; }
        /// <summary>User source or SharePoint site data source as non-custodial data source.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource DataSource { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applyHoldToSource", (o,n) => { (o as NoncustodialDataSource).ApplyHoldToSource = n.GetBoolValue(); } },
                {"dataSource", (o,n) => { (o as NoncustodialDataSource).DataSource = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>(); } },
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
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>("dataSource", DataSource);
        }
    }
}

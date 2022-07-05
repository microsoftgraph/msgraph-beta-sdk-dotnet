using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class EdiscoveryNoncustodialDataSource : DataSourceContainer, IParsable {
        /// <summary>User source or SharePoint site data source as non-custodial data source.</summary>
        public Microsoft.Graph.Beta.Models.Security.DataSource DataSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DataSource>(nameof(DataSource)); }
            set { BackingStore?.Set(nameof(DataSource), value); }
        }
        /// <summary>Operation entity that represents the latest indexing for the non-custodial data source.</summary>
        public EdiscoveryIndexOperation LastIndexOperation {
            get { return BackingStore?.Get<EdiscoveryIndexOperation>(nameof(LastIndexOperation)); }
            set { BackingStore?.Set(nameof(LastIndexOperation), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryNoncustodialDataSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryNoncustodialDataSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataSource", n => { DataSource = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DataSource>(Microsoft.Graph.Beta.Models.Security.DataSource.CreateFromDiscriminatorValue); } },
                {"lastIndexOperation", n => { LastIndexOperation = n.GetObjectValue<EdiscoveryIndexOperation>(EdiscoveryIndexOperation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DataSource>("dataSource", DataSource);
            writer.WriteObjectValue<EdiscoveryIndexOperation>("lastIndexOperation", LastIndexOperation);
        }
    }
}

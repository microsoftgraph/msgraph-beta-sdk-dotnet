using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Contract : DirectoryObject, IParsable {
        /// <summary>The contractType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractType {
            get { return BackingStore?.Get<string?>("contractType"); }
            set { BackingStore?.Set("contractType", value); }
        }
#nullable restore
#else
        public string ContractType {
            get { return BackingStore?.Get<string>("contractType"); }
            set { BackingStore?.Set("contractType", value); }
        }
#endif
        /// <summary>The customerId property</summary>
        public Guid? CustomerId {
            get { return BackingStore?.Get<Guid?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
        /// <summary>The defaultDomainName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDomainName {
            get { return BackingStore?.Get<string?>("defaultDomainName"); }
            set { BackingStore?.Set("defaultDomainName", value); }
        }
#nullable restore
#else
        public string DefaultDomainName {
            get { return BackingStore?.Get<string>("defaultDomainName"); }
            set { BackingStore?.Set("defaultDomainName", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Contract and sets the default values.
        /// </summary>
        public Contract() : base() {
            OdataType = "#microsoft.graph.contract";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Contract CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contract();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contractType", n => { ContractType = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetGuidValue(); } },
                {"defaultDomainName", n => { DefaultDomainName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contractType", ContractType);
            writer.WriteGuidValue("customerId", CustomerId);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}

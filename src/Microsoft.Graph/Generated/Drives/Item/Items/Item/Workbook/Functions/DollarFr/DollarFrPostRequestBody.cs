// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.DollarFr
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DollarFrPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The decimalDollar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DecimalDollar
        {
            get { return BackingStore?.Get<UntypedNode?>("decimalDollar"); }
            set { BackingStore?.Set("decimalDollar", value); }
        }
#nullable restore
#else
        public UntypedNode DecimalDollar
        {
            get { return BackingStore?.Get<UntypedNode>("decimalDollar"); }
            set { BackingStore?.Set("decimalDollar", value); }
        }
#endif
        /// <summary>The fraction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Fraction
        {
            get { return BackingStore?.Get<UntypedNode?>("fraction"); }
            set { BackingStore?.Set("fraction", value); }
        }
#nullable restore
#else
        public UntypedNode Fraction
        {
            get { return BackingStore?.Get<UntypedNode>("fraction"); }
            set { BackingStore?.Set("fraction", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.DollarFr.DollarFrPostRequestBody"/> and sets the default values.
        /// </summary>
        public DollarFrPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.DollarFr.DollarFrPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.DollarFr.DollarFrPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.DollarFr.DollarFrPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "decimalDollar", n => { DecimalDollar = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "fraction", n => { Fraction = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("decimalDollar", DecimalDollar);
            writer.WriteObjectValue<UntypedNode>("fraction", Fraction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

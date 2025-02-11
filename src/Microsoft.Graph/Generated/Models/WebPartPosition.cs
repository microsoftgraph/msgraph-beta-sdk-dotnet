// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WebPartPosition : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Indicates the identifier of the column where the web part is located.</summary>
        public double? ColumnId
        {
            get { return BackingStore?.Get<double?>("columnId"); }
            set { BackingStore?.Set("columnId", value); }
        }
        /// <summary>Indicates the horizontal section where the web part is located.</summary>
        public double? HorizontalSectionId
        {
            get { return BackingStore?.Get<double?>("horizontalSectionId"); }
            set { BackingStore?.Set("horizontalSectionId", value); }
        }
        /// <summary>Indicates whether the web part is located in the vertical section.</summary>
        public bool? IsInVerticalSection
        {
            get { return BackingStore?.Get<bool?>("isInVerticalSection"); }
            set { BackingStore?.Set("isInVerticalSection", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Index of the current web part. Represents the order of the web part in this column or section.</summary>
        public double? WebPartIndex
        {
            get { return BackingStore?.Get<double?>("webPartIndex"); }
            set { BackingStore?.Set("webPartIndex", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WebPartPosition"/> and sets the default values.
        /// </summary>
        public WebPartPosition()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WebPartPosition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WebPartPosition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WebPartPosition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "columnId", n => { ColumnId = n.GetDoubleValue(); } },
                { "horizontalSectionId", n => { HorizontalSectionId = n.GetDoubleValue(); } },
                { "isInVerticalSection", n => { IsInVerticalSection = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "webPartIndex", n => { WebPartIndex = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("columnId", ColumnId);
            writer.WriteDoubleValue("horizontalSectionId", HorizontalSectionId);
            writer.WriteBoolValue("isInVerticalSection", IsInVerticalSection);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("webPartIndex", WebPartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

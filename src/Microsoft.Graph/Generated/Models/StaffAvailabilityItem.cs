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
    public partial class StaffAvailabilityItem : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Each item in this collection indicates a slot and the status of the staff member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AvailabilityItem>? AvailabilityItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AvailabilityItem>?>("availabilityItems"); }
            set { BackingStore?.Set("availabilityItems", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AvailabilityItem> AvailabilityItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AvailabilityItem>>("availabilityItems"); }
            set { BackingStore?.Set("availabilityItems", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The ID of the staff member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StaffId
        {
            get { return BackingStore?.Get<string?>("staffId"); }
            set { BackingStore?.Set("staffId", value); }
        }
#nullable restore
#else
        public string StaffId
        {
            get { return BackingStore?.Get<string>("staffId"); }
            set { BackingStore?.Set("staffId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.StaffAvailabilityItem"/> and sets the default values.
        /// </summary>
        public StaffAvailabilityItem()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.StaffAvailabilityItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.StaffAvailabilityItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.StaffAvailabilityItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availabilityItems", n => { AvailabilityItems = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AvailabilityItem>(global::Microsoft.Graph.Beta.Models.AvailabilityItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "staffId", n => { StaffId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AvailabilityItem>("availabilityItems", AvailabilityItems);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("staffId", StaffId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

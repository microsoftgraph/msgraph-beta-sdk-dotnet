// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdateManagementEnrollment : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The driver property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation? Driver
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation?>("driver"); }
            set { BackingStore?.Set("driver", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation Driver
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("driver"); }
            set { BackingStore?.Set("driver", value); }
        }
#endif
        /// <summary>The feature property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation? Feature
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation?>("feature"); }
            set { BackingStore?.Set("feature", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation Feature
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("feature"); }
            set { BackingStore?.Set("feature", value); }
        }
#endif
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
        /// <summary>The quality property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation? Quality
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation?>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation Quality
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateManagementEnrollment"/> and sets the default values.
        /// </summary>
        public UpdateManagementEnrollment()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateManagementEnrollment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateManagementEnrollment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateManagementEnrollment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "driver", n => { Driver = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation.CreateFromDiscriminatorValue); } },
                { "feature", n => { Feature = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "quality", n => { Quality = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("driver", Driver);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("feature", Feature);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategoryEnrollmentInformation>("quality", Quality);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

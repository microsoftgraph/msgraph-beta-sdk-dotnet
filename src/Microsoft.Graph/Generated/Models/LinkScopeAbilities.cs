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
    public partial class LinkScopeAbilities : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The blockDownload link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? BlockDownloadLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("blockDownloadLinkAbilities"); }
            set { BackingStore?.Set("blockDownloadLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities BlockDownloadLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("blockDownloadLinkAbilities"); }
            set { BackingStore?.Set("blockDownloadLinkAbilities", value); }
        }
#endif
        /// <summary>The editLinkAbilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? EditLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("editLinkAbilities"); }
            set { BackingStore?.Set("editLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities EditLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("editLinkAbilities"); }
            set { BackingStore?.Set("editLinkAbilities", value); }
        }
#endif
        /// <summary>The manageList link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? ManageListLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("manageListLinkAbilities"); }
            set { BackingStore?.Set("manageListLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities ManageListLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("manageListLinkAbilities"); }
            set { BackingStore?.Set("manageListLinkAbilities", value); }
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
        /// <summary>The readLinkAbilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? ReadLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("readLinkAbilities"); }
            set { BackingStore?.Set("readLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities ReadLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("readLinkAbilities"); }
            set { BackingStore?.Set("readLinkAbilities", value); }
        }
#endif
        /// <summary>The review link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? ReviewLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("reviewLinkAbilities"); }
            set { BackingStore?.Set("reviewLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities ReviewLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("reviewLinkAbilities"); }
            set { BackingStore?.Set("reviewLinkAbilities", value); }
        }
#endif
        /// <summary>The submitOnly link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities? SubmitOnlyLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities?>("submitOnlyLinkAbilities"); }
            set { BackingStore?.Set("submitOnlyLinkAbilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LinkRoleAbilities SubmitOnlyLinkAbilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("submitOnlyLinkAbilities"); }
            set { BackingStore?.Set("submitOnlyLinkAbilities", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.LinkScopeAbilities"/> and sets the default values.
        /// </summary>
        public LinkScopeAbilities()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LinkScopeAbilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.LinkScopeAbilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.LinkScopeAbilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "blockDownloadLinkAbilities", n => { BlockDownloadLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "editLinkAbilities", n => { EditLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "manageListLinkAbilities", n => { ManageListLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "readLinkAbilities", n => { ReadLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "reviewLinkAbilities", n => { ReviewLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "submitOnlyLinkAbilities", n => { SubmitOnlyLinkAbilities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>(global::Microsoft.Graph.Beta.Models.LinkRoleAbilities.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("blockDownloadLinkAbilities", BlockDownloadLinkAbilities);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("editLinkAbilities", EditLinkAbilities);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("manageListLinkAbilities", ManageListLinkAbilities);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("readLinkAbilities", ReadLinkAbilities);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("reviewLinkAbilities", ReviewLinkAbilities);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LinkRoleAbilities>("submitOnlyLinkAbilities", SubmitOnlyLinkAbilities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

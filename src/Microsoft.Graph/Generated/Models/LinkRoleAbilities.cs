// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class LinkRoleAbilities : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates if the current user can add existing external user recipients to this sharing link.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? AddExistingExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("addExistingExternalUsers"); }
            set { BackingStore?.Set("addExistingExternalUsers", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus AddExistingExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("addExistingExternalUsers"); }
            set { BackingStore?.Set("addExistingExternalUsers", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Indicates if the current user can add new external user recipients to this sharing link.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? AddNewExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("addNewExternalUsers"); }
            set { BackingStore?.Set("addNewExternalUsers", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus AddNewExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("addNewExternalUsers"); }
            set { BackingStore?.Set("addNewExternalUsers", value); }
        }
#endif
        /// <summary>Indicates the status of the potential sharing link variants. If selected, it generates a separate sharing link from the sharing link that would otherwise be generated without the variant, yet with an identical role and scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingLinkVariants? ApplyVariants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingLinkVariants?>("applyVariants"); }
            set { BackingStore?.Set("applyVariants", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingLinkVariants ApplyVariants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingLinkVariants>("applyVariants"); }
            set { BackingStore?.Set("applyVariants", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates if links of this role can be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? CreateLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("createLink"); }
            set { BackingStore?.Set("createLink", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus CreateLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("createLink"); }
            set { BackingStore?.Set("createLink", value); }
        }
#endif
        /// <summary>Indicates if links of this role can be deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? DeleteLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("deleteLink"); }
            set { BackingStore?.Set("deleteLink", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus DeleteLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("deleteLink"); }
            set { BackingStore?.Set("deleteLink", value); }
        }
#endif
        /// <summary>Indicates if this link can include external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? LinkAllowsExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("linkAllowsExternalUsers"); }
            set { BackingStore?.Set("linkAllowsExternalUsers", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus LinkAllowsExternalUsers
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("linkAllowsExternalUsers"); }
            set { BackingStore?.Set("linkAllowsExternalUsers", value); }
        }
#endif
        /// <summary>Indicates if links must expire, meaning the link is no longer usable after a specified time. If link expiration is enabled, a default link expiration time is provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus? LinkExpiration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus?>("linkExpiration"); }
            set { BackingStore?.Set("linkExpiration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus LinkExpiration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus>("linkExpiration"); }
            set { BackingStore?.Set("linkExpiration", value); }
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
        /// <summary>Indicates if links of this role can be retrieved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? RetrieveLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("retrieveLink"); }
            set { BackingStore?.Set("retrieveLink", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus RetrieveLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("retrieveLink"); }
            set { BackingStore?.Set("retrieveLink", value); }
        }
#endif
        /// <summary>Indicates if links of this role can be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharingOperationStatus? UpdateLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus?>("updateLink"); }
            set { BackingStore?.Set("updateLink", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharingOperationStatus UpdateLink
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingOperationStatus>("updateLink"); }
            set { BackingStore?.Set("updateLink", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.LinkRoleAbilities"/> and sets the default values.
        /// </summary>
        public LinkRoleAbilities()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.LinkRoleAbilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.LinkRoleAbilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.LinkRoleAbilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addExistingExternalUsers", n => { AddExistingExternalUsers = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "addNewExternalUsers", n => { AddNewExternalUsers = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "applyVariants", n => { ApplyVariants = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingLinkVariants>(Microsoft.Graph.Beta.Models.SharingLinkVariants.CreateFromDiscriminatorValue); } },
                { "createLink", n => { CreateLink = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "deleteLink", n => { DeleteLink = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "linkAllowsExternalUsers", n => { LinkAllowsExternalUsers = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "linkExpiration", n => { LinkExpiration = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus>(Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "retrieveLink", n => { RetrieveLink = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "updateLink", n => { UpdateLink = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>(Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("addExistingExternalUsers", AddExistingExternalUsers);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("addNewExternalUsers", AddNewExternalUsers);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingLinkVariants>("applyVariants", ApplyVariants);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("createLink", CreateLink);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("deleteLink", DeleteLink);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("linkAllowsExternalUsers", LinkAllowsExternalUsers);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingLinkExpirationStatus>("linkExpiration", LinkExpiration);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("retrieveLink", RetrieveLink);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharingOperationStatus>("updateLink", UpdateLink);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

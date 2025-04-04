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
    public partial class CloudPcReviewStatus : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The blob access tier of the Azure Storage account in which the Cloud PC snapshot is saved with. Possible values are hot, cool, cold, and archive, default value is hot.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier? AccessTier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier?>("accessTier"); }
            set { BackingStore?.Set("accessTier", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The resource ID of the Azure Storage account in which the Cloud PC snapshot is being saved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageAccountId
        {
            get { return BackingStore?.Get<string?>("azureStorageAccountId"); }
            set { BackingStore?.Set("azureStorageAccountId", value); }
        }
#nullable restore
#else
        public string AzureStorageAccountId
        {
            get { return BackingStore?.Get<string>("azureStorageAccountId"); }
            set { BackingStore?.Set("azureStorageAccountId", value); }
        }
#endif
        /// <summary>The name of the Azure Storage account in which the Cloud PC snapshot is being saved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageAccountName
        {
            get { return BackingStore?.Get<string?>("azureStorageAccountName"); }
            set { BackingStore?.Set("azureStorageAccountName", value); }
        }
#nullable restore
#else
        public string AzureStorageAccountName
        {
            get { return BackingStore?.Get<string>("azureStorageAccountName"); }
            set { BackingStore?.Set("azureStorageAccountName", value); }
        }
#endif
        /// <summary>The name of the container in an Azure Storage account in which the Cloud PC snapshot is being saved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageContainerName
        {
            get { return BackingStore?.Get<string?>("azureStorageContainerName"); }
            set { BackingStore?.Set("azureStorageContainerName", value); }
        }
#nullable restore
#else
        public string AzureStorageContainerName
        {
            get { return BackingStore?.Get<string>("azureStorageContainerName"); }
            set { BackingStore?.Set("azureStorageContainerName", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>True if the Cloud PC is set to in review by the administrator.</summary>
        public bool? InReview
        {
            get { return BackingStore?.Get<bool?>("inReview"); }
            set { BackingStore?.Set("inReview", value); }
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
        /// <summary>The specific date and time of the Cloud PC snapshot that was taken and saved automatically, when the Cloud PC is set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RestorePointDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("restorePointDateTime"); }
            set { BackingStore?.Set("restorePointDateTime", value); }
        }
        /// <summary>The specific date and time when the Cloud PC was set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ReviewStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewStartDateTime"); }
            set { BackingStore?.Set("reviewStartDateTime", value); }
        }
        /// <summary>The ID of the Azure subscription in which the Cloud PC snapshot is being saved, in GUID format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId
        {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId
        {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The name of the Azure subscription in which the Cloud PC snapshot is being saved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionName
        {
            get { return BackingStore?.Get<string?>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#nullable restore
#else
        public string SubscriptionName
        {
            get { return BackingStore?.Get<string>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#endif
        /// <summary>The userAccessLevel property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcUserAccessLevel? UserAccessLevel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcUserAccessLevel?>("userAccessLevel"); }
            set { BackingStore?.Set("userAccessLevel", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CloudPcReviewStatus"/> and sets the default values.
        /// </summary>
        public CloudPcReviewStatus()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcReviewStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CloudPcReviewStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcReviewStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessTier", n => { AccessTier = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier>(); } },
                { "azureStorageAccountId", n => { AzureStorageAccountId = n.GetStringValue(); } },
                { "azureStorageAccountName", n => { AzureStorageAccountName = n.GetStringValue(); } },
                { "azureStorageContainerName", n => { AzureStorageContainerName = n.GetStringValue(); } },
                { "inReview", n => { InReview = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "restorePointDateTime", n => { RestorePointDateTime = n.GetDateTimeOffsetValue(); } },
                { "reviewStartDateTime", n => { ReviewStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                { "subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
                { "userAccessLevel", n => { UserAccessLevel = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcUserAccessLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier>("accessTier", AccessTier);
            writer.WriteStringValue("azureStorageAccountId", AzureStorageAccountId);
            writer.WriteStringValue("azureStorageAccountName", AzureStorageAccountName);
            writer.WriteStringValue("azureStorageContainerName", AzureStorageContainerName);
            writer.WriteBoolValue("inReview", InReview);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("restorePointDateTime", RestorePointDateTime);
            writer.WriteDateTimeOffsetValue("reviewStartDateTime", ReviewStartDateTime);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcUserAccessLevel>("userAccessLevel", UserAccessLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

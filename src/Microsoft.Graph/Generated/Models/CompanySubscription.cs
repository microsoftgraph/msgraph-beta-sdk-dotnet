using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CompanySubscription : Entity, IParsable {
        /// <summary>The commerceSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommerceSubscriptionId {
            get { return BackingStore?.Get<string?>("commerceSubscriptionId"); }
            set { BackingStore?.Set("commerceSubscriptionId", value); }
        }
#nullable restore
#else
        public string CommerceSubscriptionId {
            get { return BackingStore?.Get<string>("commerceSubscriptionId"); }
            set { BackingStore?.Set("commerceSubscriptionId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The isTrial property</summary>
        public bool? IsTrial {
            get { return BackingStore?.Get<bool?>("isTrial"); }
            set { BackingStore?.Set("isTrial", value); }
        }
        /// <summary>The nextLifecycleDateTime property</summary>
        public DateTimeOffset? NextLifecycleDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("nextLifecycleDateTime"); }
            set { BackingStore?.Set("nextLifecycleDateTime", value); }
        }
        /// <summary>The ocpSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OcpSubscriptionId {
            get { return BackingStore?.Get<string?>("ocpSubscriptionId"); }
            set { BackingStore?.Set("ocpSubscriptionId", value); }
        }
#nullable restore
#else
        public string OcpSubscriptionId {
            get { return BackingStore?.Get<string>("ocpSubscriptionId"); }
            set { BackingStore?.Set("ocpSubscriptionId", value); }
        }
#endif
        /// <summary>The ownerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId {
            get { return BackingStore?.Get<string?>("ownerId"); }
            set { BackingStore?.Set("ownerId", value); }
        }
#nullable restore
#else
        public string OwnerId {
            get { return BackingStore?.Get<string>("ownerId"); }
            set { BackingStore?.Set("ownerId", value); }
        }
#endif
        /// <summary>The ownerTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerTenantId {
            get { return BackingStore?.Get<string?>("ownerTenantId"); }
            set { BackingStore?.Set("ownerTenantId", value); }
        }
#nullable restore
#else
        public string OwnerTenantId {
            get { return BackingStore?.Get<string>("ownerTenantId"); }
            set { BackingStore?.Set("ownerTenantId", value); }
        }
#endif
        /// <summary>The ownerType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerType {
            get { return BackingStore?.Get<string?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#nullable restore
#else
        public string OwnerType {
            get { return BackingStore?.Get<string>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#endif
        /// <summary>The serviceStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePlanInfo>? ServiceStatus {
            get { return BackingStore?.Get<List<ServicePlanInfo>?>("serviceStatus"); }
            set { BackingStore?.Set("serviceStatus", value); }
        }
#nullable restore
#else
        public List<ServicePlanInfo> ServiceStatus {
            get { return BackingStore?.Get<List<ServicePlanInfo>>("serviceStatus"); }
            set { BackingStore?.Set("serviceStatus", value); }
        }
#endif
        /// <summary>The skuId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuId {
            get { return BackingStore?.Get<string?>("skuId"); }
            set { BackingStore?.Set("skuId", value); }
        }
#nullable restore
#else
        public string SkuId {
            get { return BackingStore?.Get<string>("skuId"); }
            set { BackingStore?.Set("skuId", value); }
        }
#endif
        /// <summary>The skuPartNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuPartNumber {
            get { return BackingStore?.Get<string?>("skuPartNumber"); }
            set { BackingStore?.Set("skuPartNumber", value); }
        }
#nullable restore
#else
        public string SkuPartNumber {
            get { return BackingStore?.Get<string>("skuPartNumber"); }
            set { BackingStore?.Set("skuPartNumber", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The totalLicenses property</summary>
        public int? TotalLicenses {
            get { return BackingStore?.Get<int?>("totalLicenses"); }
            set { BackingStore?.Set("totalLicenses", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CompanySubscription CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanySubscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"commerceSubscriptionId", n => { CommerceSubscriptionId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isTrial", n => { IsTrial = n.GetBoolValue(); } },
                {"nextLifecycleDateTime", n => { NextLifecycleDateTime = n.GetDateTimeOffsetValue(); } },
                {"ocpSubscriptionId", n => { OcpSubscriptionId = n.GetStringValue(); } },
                {"ownerId", n => { OwnerId = n.GetStringValue(); } },
                {"ownerTenantId", n => { OwnerTenantId = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetStringValue(); } },
                {"serviceStatus", n => { ServiceStatus = n.GetCollectionOfObjectValues<ServicePlanInfo>(ServicePlanInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"skuId", n => { SkuId = n.GetStringValue(); } },
                {"skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalLicenses", n => { TotalLicenses = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("commerceSubscriptionId", CommerceSubscriptionId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isTrial", IsTrial);
            writer.WriteDateTimeOffsetValue("nextLifecycleDateTime", NextLifecycleDateTime);
            writer.WriteStringValue("ocpSubscriptionId", OcpSubscriptionId);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteStringValue("ownerTenantId", OwnerTenantId);
            writer.WriteStringValue("ownerType", OwnerType);
            writer.WriteCollectionOfObjectValues<ServicePlanInfo>("serviceStatus", ServiceStatus);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
            writer.WriteStringValue("status", Status);
            writer.WriteIntValue("totalLicenses", TotalLicenses);
        }
    }
}

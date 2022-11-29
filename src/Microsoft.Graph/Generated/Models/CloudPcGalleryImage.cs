using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class CloudPcGalleryImage : Entity, IParsable {
        /// <summary>The official display name of the gallery image. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The date in which this image is no longer within long-term support. The Cloud PC will continue to provide short-term support. Read-only.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
        /// <summary>The date when the image is no longer available. Read-only.</summary>
        public Date? ExpirationDate {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>The offer name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Offer {
            get { return BackingStore?.Get<string>("offer"); }
            set { BackingStore?.Set("offer", value); }
        }
        /// <summary>The official display offer name of the gallery image. For example, Windows 10 Enterprise + OS Optimizations. Read-only.</summary>
        public string OfferDisplayName {
            get { return BackingStore?.Get<string>("offerDisplayName"); }
            set { BackingStore?.Set("offerDisplayName", value); }
        }
        /// <summary>The publisher name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
        /// <summary>Recommended Cloud PC SKU for this gallery image. Read-only.</summary>
        public string RecommendedSku {
            get { return BackingStore?.Get<string>("recommendedSku"); }
            set { BackingStore?.Set("recommendedSku", value); }
        }
        /// <summary>The size of this image in gigabytes. Read-only.</summary>
        public int? SizeInGB {
            get { return BackingStore?.Get<int?>("sizeInGB"); }
            set { BackingStore?.Set("sizeInGB", value); }
        }
        /// <summary>The SKU name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Sku {
            get { return BackingStore?.Get<string>("sku"); }
            set { BackingStore?.Set("sku", value); }
        }
        /// <summary>The official display stock keeping unit (SKU) name of this gallery image. For example, 2004. Read-only.</summary>
        public string SkuDisplayName {
            get { return BackingStore?.Get<string>("skuDisplayName"); }
            set { BackingStore?.Set("skuDisplayName", value); }
        }
        /// <summary>The date when the image becomes available. Read-only.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>The status of the gallery image on the Cloud PC. Possible values are: supported, supportedWithWarning, notSupported, unknownFutureValue. Read-only.</summary>
        public CloudPcGalleryImageStatus? Status {
            get { return BackingStore?.Get<CloudPcGalleryImageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcGalleryImage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcGalleryImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"offer", n => { Offer = n.GetStringValue(); } },
                {"offerDisplayName", n => { OfferDisplayName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"recommendedSku", n => { RecommendedSku = n.GetStringValue(); } },
                {"sizeInGB", n => { SizeInGB = n.GetIntValue(); } },
                {"sku", n => { Sku = n.GetStringValue(); } },
                {"skuDisplayName", n => { SkuDisplayName = n.GetStringValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcGalleryImageStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteStringValue("offer", Offer);
            writer.WriteStringValue("offerDisplayName", OfferDisplayName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteStringValue("recommendedSku", RecommendedSku);
            writer.WriteIntValue("sizeInGB", SizeInGB);
            writer.WriteStringValue("sku", Sku);
            writer.WriteStringValue("skuDisplayName", SkuDisplayName);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteEnumValue<CloudPcGalleryImageStatus>("status", Status);
        }
    }
}

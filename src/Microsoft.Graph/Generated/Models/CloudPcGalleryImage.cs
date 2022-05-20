using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class CloudPcGalleryImage : Entity, IParsable {
        /// <summary>The official display name of the gallery image. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date in which this image is no longer within long-term support. The Cloud PC will continue to provide short-term support. Read-only.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>(nameof(EndDate)); }
            set { BackingStore?.Set(nameof(EndDate), value); }
        }
        /// <summary>The date when the image is no longer available. Read-only.</summary>
        public Date? ExpirationDate {
            get { return BackingStore?.Get<Date?>(nameof(ExpirationDate)); }
            set { BackingStore?.Set(nameof(ExpirationDate), value); }
        }
        /// <summary>The offer name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Offer {
            get { return BackingStore?.Get<string>(nameof(Offer)); }
            set { BackingStore?.Set(nameof(Offer), value); }
        }
        /// <summary>The official display offer name of the gallery image. For example, Windows 10 Enterprise + OS Optimizations. Read-only.</summary>
        public string OfferDisplayName {
            get { return BackingStore?.Get<string>(nameof(OfferDisplayName)); }
            set { BackingStore?.Set(nameof(OfferDisplayName), value); }
        }
        /// <summary>The publisher name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>Recommended Cloud PC SKU for this gallery image. Read-only.</summary>
        public string RecommendedSku {
            get { return BackingStore?.Get<string>(nameof(RecommendedSku)); }
            set { BackingStore?.Set(nameof(RecommendedSku), value); }
        }
        /// <summary>The size of this image in gigabytes. Read-only.</summary>
        public int? SizeInGB {
            get { return BackingStore?.Get<int?>(nameof(SizeInGB)); }
            set { BackingStore?.Set(nameof(SizeInGB), value); }
        }
        /// <summary>The SKU name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Sku {
            get { return BackingStore?.Get<string>(nameof(Sku)); }
            set { BackingStore?.Set(nameof(Sku), value); }
        }
        /// <summary>The official display stock keeping unit (SKU) name of this gallery image. For example, 2004. Read-only.</summary>
        public string SkuDisplayName {
            get { return BackingStore?.Get<string>(nameof(SkuDisplayName)); }
            set { BackingStore?.Set(nameof(SkuDisplayName), value); }
        }
        /// <summary>The date when the image becomes available. Read-only.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>(nameof(StartDate)); }
            set { BackingStore?.Set(nameof(StartDate), value); }
        }
        /// <summary>The status of the gallery image on the Cloud PC. Possible values are: supported, supportedWithWarning, notSupported, unknownFutureValue. Read-only.</summary>
        public CloudPcGalleryImageStatus? Status {
            get { return BackingStore?.Get<CloudPcGalleryImageStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

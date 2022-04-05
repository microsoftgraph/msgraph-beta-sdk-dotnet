using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcGalleryImage : Entity, IParsable {
        /// <summary>The official display name of the gallery image. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date in which this image is no longer within long-term support. The Cloud PC will continue to provide short-term support. Read-only.</summary>
        public Date? EndDate { get; set; }
        /// <summary>The date when the image is no longer available. Read-only.</summary>
        public Date? ExpirationDate { get; set; }
        /// <summary>The offer name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Offer { get; set; }
        /// <summary>The official display offer name of the gallery image. For example, Windows 10 Enterprise + OS Optimizations. Read-only.</summary>
        public string OfferDisplayName { get; set; }
        /// <summary>The publisher name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Publisher { get; set; }
        /// <summary>Recommended Cloud PC SKU for this gallery image. Read-only.</summary>
        public string RecommendedSku { get; set; }
        /// <summary>The size of this image in gigabytes. Read-only.</summary>
        public int? SizeInGB { get; set; }
        /// <summary>The SKU name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.</summary>
        public string Sku { get; set; }
        /// <summary>The official display stock keeping unit (SKU) name of this gallery image. For example, 2004. Read-only.</summary>
        public string SkuDisplayName { get; set; }
        /// <summary>The date when the image becomes available. Read-only.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The status of the gallery image on the Cloud PC. Possible values are: supported, supportedWithWarning, notSupported, unknownFutureValue. Read-only.</summary>
        public CloudPcGalleryImageStatus? Status { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as CloudPcGalleryImage).DisplayName = n.GetStringValue(); } },
                {"endDate", (o,n) => { (o as CloudPcGalleryImage).EndDate = n.GetDateValue(); } },
                {"expirationDate", (o,n) => { (o as CloudPcGalleryImage).ExpirationDate = n.GetDateValue(); } },
                {"offer", (o,n) => { (o as CloudPcGalleryImage).Offer = n.GetStringValue(); } },
                {"offerDisplayName", (o,n) => { (o as CloudPcGalleryImage).OfferDisplayName = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as CloudPcGalleryImage).Publisher = n.GetStringValue(); } },
                {"recommendedSku", (o,n) => { (o as CloudPcGalleryImage).RecommendedSku = n.GetStringValue(); } },
                {"sizeInGB", (o,n) => { (o as CloudPcGalleryImage).SizeInGB = n.GetIntValue(); } },
                {"sku", (o,n) => { (o as CloudPcGalleryImage).Sku = n.GetStringValue(); } },
                {"skuDisplayName", (o,n) => { (o as CloudPcGalleryImage).SkuDisplayName = n.GetStringValue(); } },
                {"startDate", (o,n) => { (o as CloudPcGalleryImage).StartDate = n.GetDateValue(); } },
                {"status", (o,n) => { (o as CloudPcGalleryImage).Status = n.GetEnumValue<CloudPcGalleryImageStatus>(); } },
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

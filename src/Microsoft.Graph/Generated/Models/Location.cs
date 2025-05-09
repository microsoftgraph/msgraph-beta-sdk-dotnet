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
    public partial class Location : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The street address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PhysicalAddress? Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PhysicalAddress Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The geographic coordinates and elevation of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates? Coordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates?>("coordinates"); }
            set { BackingStore?.Set("coordinates", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates Coordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates>("coordinates"); }
            set { BackingStore?.Set("coordinates", value); }
        }
#endif
        /// <summary>The name associated with the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Optional email address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationEmailAddress
        {
            get { return BackingStore?.Get<string?>("locationEmailAddress"); }
            set { BackingStore?.Set("locationEmailAddress", value); }
        }
#nullable restore
#else
        public string LocationEmailAddress
        {
            get { return BackingStore?.Get<string>("locationEmailAddress"); }
            set { BackingStore?.Set("locationEmailAddress", value); }
        }
#endif
        /// <summary>The type of location. Possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public global::Microsoft.Graph.Beta.Models.LocationType? LocationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LocationType?>("locationType"); }
            set { BackingStore?.Set("locationType", value); }
        }
        /// <summary>Optional URI representing the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationUri
        {
            get { return BackingStore?.Get<string?>("locationUri"); }
            set { BackingStore?.Set("locationUri", value); }
        }
#nullable restore
#else
        public string LocationUri
        {
            get { return BackingStore?.Get<string>("locationUri"); }
            set { BackingStore?.Set("locationUri", value); }
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
        /// <summary>For internal use only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueId
        {
            get { return BackingStore?.Get<string?>("uniqueId"); }
            set { BackingStore?.Set("uniqueId", value); }
        }
#nullable restore
#else
        public string UniqueId
        {
            get { return BackingStore?.Get<string>("uniqueId"); }
            set { BackingStore?.Set("uniqueId", value); }
        }
#endif
        /// <summary>For internal use only.</summary>
        public global::Microsoft.Graph.Beta.Models.LocationUniqueIdType? UniqueIdType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LocationUniqueIdType?>("uniqueIdType"); }
            set { BackingStore?.Set("uniqueIdType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Location"/> and sets the default values.
        /// </summary>
        public Location()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Location"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Location CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.locationConstraintItem" => new global::Microsoft.Graph.Beta.Models.LocationConstraintItem(),
                _ => new global::Microsoft.Graph.Beta.Models.Location(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PhysicalAddress>(global::Microsoft.Graph.Beta.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "coordinates", n => { Coordinates = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates>(global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "locationEmailAddress", n => { LocationEmailAddress = n.GetStringValue(); } },
                { "locationType", n => { LocationType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.LocationType>(); } },
                { "locationUri", n => { LocationUri = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "uniqueId", n => { UniqueId = n.GetStringValue(); } },
                { "uniqueIdType", n => { UniqueIdType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.LocationUniqueIdType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PhysicalAddress>("address", Address);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.OutlookGeoCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("locationEmailAddress", LocationEmailAddress);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.LocationType>("locationType", LocationType);
            writer.WriteStringValue("locationUri", LocationUri);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.LocationUniqueIdType>("uniqueIdType", UniqueIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

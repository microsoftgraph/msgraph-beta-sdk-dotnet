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
    public partial class SignInLocation : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City
        {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City
        {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>Provides the country code info (two letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion
        {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion
        {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
        /// <summary>Provides the latitude, longitude and altitude where the sign-in originated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GeoCoordinates? GeoCoordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GeoCoordinates?>("geoCoordinates"); }
            set { BackingStore?.Set("geoCoordinates", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GeoCoordinates GeoCoordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GeoCoordinates>("geoCoordinates"); }
            set { BackingStore?.Set("geoCoordinates", value); }
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
        /// <summary>Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State
        {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State
        {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.SignInLocation"/> and sets the default values.
        /// </summary>
        public SignInLocation()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SignInLocation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.SignInLocation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SignInLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "city", n => { City = n.GetStringValue(); } },
                { "countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                { "geoCoordinates", n => { GeoCoordinates = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GeoCoordinates>(global::Microsoft.Graph.Beta.Models.GeoCoordinates.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GeoCoordinates>("geoCoordinates", GeoCoordinates);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

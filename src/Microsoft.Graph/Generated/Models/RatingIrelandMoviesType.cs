// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Movies rating labels in Ireland</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum RatingIrelandMoviesType
    {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>Suitable for children of school going age</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG classification advises parental guidance</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The 12A classification is suitable for viewers of 12 or older</summary>
        [EnumMember(Value = "agesAbove12")]
        AgesAbove12,
        /// <summary>The 15A classification is suitable for viewers of 15 or older</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>The 16 classification is suitable for viewers of 16 or older</summary>
        [EnumMember(Value = "agesAbove16")]
        AgesAbove16,
        /// <summary>The 18 classification, suitable only for adults</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}

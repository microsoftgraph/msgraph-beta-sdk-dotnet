// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>TV content rating labels in Canada</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum RatingCanadaTelevisionType
    {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The C classification is suitable for children ages of 2 to 7 years</summary>
        [EnumMember(Value = "children")]
        Children,
        /// <summary>The C8 classification is suitable for children ages 8+</summary>
        [EnumMember(Value = "childrenAbove8")]
        ChildrenAbove8,
        /// <summary>The G classification is suitable for general audience</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>PG, Parental Guidance</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The 14+ classification is intended for viewers ages 14 and older</summary>
        [EnumMember(Value = "agesAbove14")]
        AgesAbove14,
        /// <summary>The 18+ classification is intended for viewers ages 18 and older</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
    }
}

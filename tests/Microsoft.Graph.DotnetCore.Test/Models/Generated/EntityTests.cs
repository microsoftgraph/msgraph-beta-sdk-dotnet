// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Models.Generated
{
    using System.Linq;
    using System.Reflection;
    using Xunit;
    using Microsoft.Graph.Beta.Models;
    
    public class EntityTests
    {
        [Fact]
        public void AbstractEntity_DefaultConstructorGeneration()
        {
            var entityType = typeof(Entity);
            var constructors = entityType.GetConstructors(
                BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.Single(constructors);

            var defaultConstructor = constructors.First();
            Assert.False(defaultConstructor.IsPrivate);
            Assert.True(defaultConstructor.IsPublic);
            Assert.False(defaultConstructor.IsStatic);
            Assert.False(defaultConstructor.GetParameters().Any());
        }
    }
}

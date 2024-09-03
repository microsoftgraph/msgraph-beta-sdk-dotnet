using Microsoft.Graph.Beta.Models;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Extensions;

public class UploadSessionTests
{
    [Fact]
    public void AddPublicEncryptionCertificate()
    {
        // arrange 
        var uploadSession = new UploadSession();

        // act
        Assert.IsAssignableFrom<IUploadSession>(uploadSession);
    }
}

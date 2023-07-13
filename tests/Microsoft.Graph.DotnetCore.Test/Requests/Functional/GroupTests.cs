
namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Graph.Beta.Models.ODataErrors;
    using System.Threading.Tasks;
    using Xunit;

    public class GroupTests : GraphTestBase
    {
        /// <summary>
        /// Create a team on a group.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task GroupCreateTeam()
        {
            try
            {
                // Get a groups collection. We'll use the first entry to add the team. Results in a call to the service.
                var groupPage = await graphClient.Groups.GetAsync();

                // Create a team with settings.
                Team team = new Team()
                {
                    MemberSettings = new TeamMemberSettings()
                    {
                        AllowCreateUpdateChannels = true
                    }
                };

                // Add a team to the group.  Results in a call to the service.
                await graphClient.Groups[groupPage.Value[8].Id].Team.PutAsync(team);
            }
            catch (ODataError e)
            {
                Assert.Fail(e.Error.ToString());
            }
        }
    }
}

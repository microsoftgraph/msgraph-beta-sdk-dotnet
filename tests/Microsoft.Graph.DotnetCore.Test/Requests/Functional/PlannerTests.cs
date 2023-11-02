namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Kiota.Abstractions;

    public class PlannerTests : GraphTestBase
    {
        private Group testGroup = new ();

        private async void TestCleanUp()
        {
            Group toDelete = testGroup;
            await graphClient.Groups[toDelete.Id].DeleteAsync();
        }

        public async Task<Group> CreateGroup()
        {
            // Create a group. There can only be a single planner plan per group.
            var clientOnlyGroup = new Group();
            clientOnlyGroup.Description = "A temporary group to that contains a planner plan that we'll test.";
            clientOnlyGroup.DisplayName = "Test group";
            clientOnlyGroup.GroupTypes = new List<string>() { "Unified" };
            clientOnlyGroup.MailEnabled = true;
            clientOnlyGroup.MailNickname = "BobTestGroup" + Guid.NewGuid();
            clientOnlyGroup.SecurityEnabled = false;

            // Call Graph service API to create the new group.
            var syncdGroup = await graphClient.Groups.PostAsync(clientOnlyGroup);

            var thisUser = await graphClient.Me.GetAsync();

            var reference = new ReferenceCreate
            {
                OdataId = thisUser.Id
            };
            // add the current user as member.
            await graphClient.Groups[syncdGroup.Id].Members.Ref.PostAsync(reference);

            // The group may take a few seconds to be available in Planner.
            await Task.Delay(20000);

            return syncdGroup;
        }

        private Task DeleteGroup(Group group)
        {
            return graphClient.Groups[group.Id].DeleteAsync();
        }

        public async Task<PlannerPlan> CreatePlan(Group owner)
        {
            PlannerPlan forCreate = new PlannerPlan();

            forCreate.Title = "Test Plan" + Guid.NewGuid();
            forCreate.Owner = owner.Id;

            return await graphClient.Planner.Plans.PostAsync(forCreate);
        }

        // Working as expected.
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task PlannerGetPlannerPlan()
        {
            try
            {
                var plannerPlan = await GetPlannerPlan();

                Assert.NotNull(plannerPlan);
                Assert.IsType<PlannerPlan>(plannerPlan);
            }
            catch (ApiException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: " + e.Message);
            }
        }

        public async Task<PlannerPlan> GetPlannerPlan(string planId = "")
        {
            if (planId == "")
            {
                planId = "X64sGtz57EO5q2KVrqEfVmUAEAYw"; // OnlineMarketingGroup PlanId in test tenant.
            }

            try
            {
                return await graphClient.Planner.Plans[planId].GetAsync();
            }
            catch (ApiException e)
            {
                Assert.Fail($"Tried to get a PlannerPlan and failed. Error: {e.Message}");
            }
            return null;
        }

        // Successful 4/27/2017 - Gets planner tasks
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task PlannerGetPlannerTasks()
        {
            try
            {
                // Get a default plan
                var plannerPlan = await GetPlannerPlan();

                var plannerPlanTasksCollectionPage = await graphClient.Planner.Plans[plannerPlan.Id].Tasks.GetAsync();

                Assert.NotNull(plannerPlanTasksCollectionPage);
                Assert.IsType<PlannerTaskCollectionResponse>(plannerPlanTasksCollectionPage);
            }
            catch (ApiException e)
            {
                Assert.Fail($"Something happened, check out a trace. Error: {e.Message}");
            }
        }
        // Successful 4/27/2017 - Creates a task without a bucket.
        [Fact(Skip = "No CI set up for functional tests")]
        //https://developer.microsoft.com/en-us/graph/docs/api-reference/beta/api/planner_post_tasks
        public async Task PlannerTaskCreate()
        {
            // Get a default plan
            var group = await CreateGroup();
            this.testGroup = group;
            await Task.Delay(5000);
            var plannerPlan = await CreatePlan(group);

            PlannerTask taskToCreate = new PlannerTask();
            taskToCreate.PlanId = plannerPlan.Id;
            taskToCreate.Title = "New task title";
            taskToCreate.Assignments = new PlannerAssignments();
            taskToCreate.Assignments.AdditionalData["me"] = new PlannerAssignment
            {
                OrderHint = " !"
            };
            taskToCreate.AppliedCategories = new PlannerAppliedCategories();
            taskToCreate.AppliedCategories.AdditionalData["category3"] = true;
            taskToCreate.DueDateTime = DateTimeOffset.UtcNow.AddDays(3);

            PlannerTask createdTask = await graphClient.Planner.Tasks.PostAsync(taskToCreate);

            Assert.NotNull(createdTask);
            Assert.NotNull(createdTask.Assignments);
            Assert.Equal(taskToCreate.Title, createdTask.Title);
            Assert.Single(createdTask.Assignments.AdditionalData);
            Assert.Equal(true, createdTask.AppliedCategories.AdditionalData["category3"]);
            Assert.Equal(taskToCreate.DueDateTime, createdTask.DueDateTime);
        }

        [Fact(Skip = "No CI set up for functional tests")]
        public async Task PlannerTaskDetailsUpdate()
        {
            var group = await CreateGroup();
            this.testGroup = group;
            var plannerPlan = await CreatePlan(group); // You may need to add a Delay in this since there is some latency.

            PlannerTask taskToCreate = new PlannerTask();
            taskToCreate.PlanId = plannerPlan.Id;
            taskToCreate.Title = "New task title";

            PlannerTask createdTask = await graphClient.Planner.Tasks.PostAsync(taskToCreate);
            PlannerTaskDetails taskDetails = await graphClient.Planner.Tasks[createdTask.Id].Details.GetAsync();

            PlannerTaskDetails taskDetailsToUpdate = new PlannerTaskDetails();
            taskDetailsToUpdate.Checklist = new PlannerChecklistItems();
            string checklistItemId1 = Guid.NewGuid().ToString();
            taskDetailsToUpdate.Checklist.AdditionalData[checklistItemId1] = new PlannerChecklistItem()
            {
                Title = "Do Something"
            };
            string checklistItemId2 = Guid.NewGuid().ToString();
            taskDetailsToUpdate.Checklist.AdditionalData[checklistItemId1] = new PlannerChecklistItem()
            {
                Title = "Do Something else"
            };
            taskDetailsToUpdate.References = new PlannerExternalReferences();
            taskDetailsToUpdate.References.AdditionalData["http://developer.microsoft.com"]= new PlannerExternalReference()
            {
                Alias = "Developer resources"
            };

            taskDetailsToUpdate.PreviewType = PlannerPreviewType.Checklist;
            taskDetailsToUpdate.Description = "Description of the task";

            string etag = taskDetails.AdditionalData["@odata.etag"].ToString();
            PlannerTaskDetails updatedTaskDetails = await graphClient.Planner.Tasks[createdTask.Id].Details
                .PatchAsync(taskDetailsToUpdate, requestConfiguration =>
                {
                    requestConfiguration.Headers.Add("If-Match", etag);
                    requestConfiguration.Headers.Add("Prefer", "return=representation");
                });

            Assert.Equal("Description of the task", updatedTaskDetails.Description);
            Assert.Equal(PlannerPreviewType.Checklist, updatedTaskDetails.PreviewType);
            Assert.Equal(2, updatedTaskDetails.Checklist.AdditionalData.Count());
            Assert.Equal("Do something", ((PlannerChecklistItem)updatedTaskDetails.Checklist.AdditionalData[checklistItemId1])?.Title);
            Assert.Equal("Do something else", ((PlannerChecklistItem)updatedTaskDetails.Checklist.AdditionalData[checklistItemId2])?.Title);
            Assert.Single(updatedTaskDetails.References.AdditionalData);
            Assert.Equal("Developer resources", ((PlannerExternalReference)updatedTaskDetails.References.AdditionalData["http://developer.microsoft.com"])?.Alias);
        }

        [Fact(Skip = "No CI set up for functional tests")]
        public async Task PlannerPlanDetailsUpdate()
        {
            var group = await CreateGroup();
            this.testGroup = group;
            await Task.Delay(3000); // sometimes we need to delay, the group information needs to be set before we can create a plan.
            var plannerPlan = await CreatePlan(group);

            PlannerPlanDetails planDetails = await graphClient.Planner.Plans[plannerPlan.Id].Details.GetAsync();

            string etag = planDetails.AdditionalData["@odata.etag"].ToString();
            PlannerPlanDetails planDetailsToUpdate = new PlannerPlanDetails();
            planDetailsToUpdate.CategoryDescriptions = new PlannerCategoryDescriptions();
            planDetailsToUpdate.CategoryDescriptions.Category1 = "First category";
            planDetailsToUpdate.CategoryDescriptions.Category4 = "Category 4";
            planDetailsToUpdate.SharedWith = new PlannerUserIds();
            planDetailsToUpdate.SharedWith.AdditionalData["me"]=true;

            PlannerPlanDetails updatedPlanDetails = await graphClient.Planner.Plans[plannerPlan.Id].Details.PatchAsync(planDetailsToUpdate, requestConfiguration =>
            {
                requestConfiguration.Headers.Add("If-Match", etag);
                requestConfiguration.Headers.Add("Prefer", "return=representation");
            });

            Assert.Equal("First category", updatedPlanDetails.CategoryDescriptions.Category1);
            Assert.Equal("Category 4", updatedPlanDetails.CategoryDescriptions.Category4);

            // plan creator is the current user as well, we can get the id from there.
            Assert.True(updatedPlanDetails.SharedWith.AdditionalData.ContainsKey(plannerPlan.CreatedBy.User.Id));
        }

        [Fact(Skip = "No CI set up for functional tests")]
        public async Task PlannerTaskAssignedToTaskBoardFormatUpdate()
        {
            var group = await CreateGroup();
            this.testGroup = group;
            var plannerPlan = await CreatePlan(group);

            PlannerTask taskToCreate = new PlannerTask();
            taskToCreate.PlanId = plannerPlan.Id;
            taskToCreate.Title = "Top";
            taskToCreate.Assignments = new PlannerAssignments();
            taskToCreate.Assignments.AdditionalData["me"] = new PlannerAssignment()
            {
                OrderHint = " !"
            };

            PlannerTask topTask = await graphClient.Planner.Tasks.PostAsync(taskToCreate);

            taskToCreate = new PlannerTask();
            taskToCreate.PlanId = plannerPlan.Id;
            taskToCreate.Title = "Bottom";
            taskToCreate.Assignments = new PlannerAssignments();
            taskToCreate.Assignments.AdditionalData["me"] = new PlannerAssignment()
            {
                OrderHint = " !"
            };

            PlannerTask bottomTask = await graphClient.Planner.Tasks.PostAsync(taskToCreate);

            taskToCreate = new PlannerTask();
            taskToCreate.PlanId = plannerPlan.Id;
            taskToCreate.Title = "Middle";
            taskToCreate.Assignments = new PlannerAssignments();
            taskToCreate.Assignments.AdditionalData["me"] = new PlannerAssignment()
            {
                OrderHint = " !"
            };

            PlannerTask middleTask = await graphClient.Planner.Tasks.PostAsync(taskToCreate);

            // give it two second to ensure asynchronous processing is completed.
            await Task.Delay(10000);

            var myUserId = plannerPlan.CreatedBy.User.Id;

            // get assigned to task board formats of the tasks in plan.
            var taskIdsWithTaskBoardFormats = await graphClient.Planner.Plans[plannerPlan.Id].Tasks.GetAsync( requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Select = new[] { "id" };
                requestConfiguration.QueryParameters.Expand = new[] { "assignedToTaskBoardFormat" };
            });
            IDictionary<string, PlannerAssignedToTaskBoardTaskFormat> formatsByTasks = taskIdsWithTaskBoardFormats.Value.ToDictionary(item => item.Id, item => item.AssignedToTaskBoardFormat);

            var bottomTaskFormatUpdate = new PlannerAssignedToTaskBoardTaskFormat();
            bottomTaskFormatUpdate.OrderHintsByAssignee = new PlannerOrderHintsByAssignee();
            bottomTaskFormatUpdate.OrderHintsByAssignee.AdditionalData[myUserId] = $"{formatsByTasks[topTask.Id].OrderHintsByAssignee.AdditionalData[myUserId]} !"; // after top task.

            var middleTaskFormatUpdate = new PlannerAssignedToTaskBoardTaskFormat();
            middleTaskFormatUpdate.OrderHintsByAssignee = new PlannerOrderHintsByAssignee();
            middleTaskFormatUpdate.OrderHintsByAssignee.AdditionalData[myUserId] = $"{formatsByTasks[topTask.Id].OrderHintsByAssignee.AdditionalData[myUserId]} {bottomTaskFormatUpdate.OrderHintsByAssignee.AdditionalData[myUserId]}!"; // after top task, before bottom task's client side new value.

            string etag = formatsByTasks[bottomTask.Id].AdditionalData["@odata.etag"].ToString();
            formatsByTasks[bottomTask.Id] = await graphClient
                .Planner
                .Tasks[bottomTask.Id]
                .AssignedToTaskBoardFormat
                .PatchAsync(bottomTaskFormatUpdate, requestConfiguration =>
                {
                    requestConfiguration.Headers.Add("If-Match", etag);
                    requestConfiguration.Headers.Add("Prefer", "return=representation");
                });

            etag = formatsByTasks[middleTask.Id].AdditionalData["@odata.etag"].ToString();
            formatsByTasks[middleTask.Id] = await graphClient
                .Planner
                .Tasks[middleTask.Id]
                .AssignedToTaskBoardFormat
                .PatchAsync(middleTaskFormatUpdate, requestConfiguration =>
                {
                    requestConfiguration.Headers.Add("If-Match", etag);
                    requestConfiguration.Headers.Add("Prefer", "return=representation");
                });

            // verify final order
            var orderedTaskFormats = formatsByTasks.OrderBy(kvp => kvp.Value.OrderHintsByAssignee.AdditionalData[myUserId].ToString(), StringComparer.Ordinal).ToList();
            Assert.Equal(topTask.Id, orderedTaskFormats[0].Key);
            Assert.Equal(middleTask.Id, orderedTaskFormats[1].Key);
            Assert.Equal(bottomTask.Id, orderedTaskFormats[2].Key);
        }

    }
}

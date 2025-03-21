---
title: "Create workflow (lifecycle workflow)"
description: "Create a new workflow object. You can create up to 50 workflows in a tenant."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Create workflow (lifecycle workflow)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [workflow](../resources/identitygovernance-workflow.md) object. You can create up to 50 workflows in a tenant.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|LifecycleWorkflows.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|LifecycleWorkflows.ReadWrite.All|

For delegated scenarios, the admin needs one of the following [Azure AD roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

- Global administrator
- Lifecycle workflows administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /identityGovernance/lifecycleWorkflows/workflows
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [workflow](../resources/identitygovernance-workflow.md) object.

You can specify the following properties when creating a **workflow**.

|Property|Type|Description|
|:---|:---|:---|
|category|[microsoft.graph.identityGovernance.lifecycleWorkflowCategory](../resources/identitygovernance-workflow.md)|The category of the workflow. The possible values are: `joiner`, `leaver`, `unknownFutureValue`. Can be only one value. Required.|
|description|String|A string that describes the purpose of the workflow for administrative use.|
|displayName|String|A unique string that identifies the workflow. Required.|
|executionConditions|[microsoft.graph.identityGovernance.workflowExecutionConditions](../resources/identitygovernance-workflowexecutionconditions.md)|Defines for who and when a workflow will run. Required. |
|id|String|Identifier used for individually addressing a specific workflow.|
|isEnabled|Boolean|A Boolean value that denotes whether the workflow is set to run or not.|
|isSchedulingEnabled|Boolean|A Boolean value that denotes whether scheduling is enabled or not. |
|tasks|[microsoft.graph.identityGovernance.task](../resources/identitygovernance-task.md) collection| Represents the configured tasks to execute and their execution sequence within the workflow. Required. |

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.identityGovernance.workflow](../resources/identitygovernance-workflow.md) object in the response body.

## Examples

### Request

The following is an example of a request that creates a workflow with the following configuration:
+ It's a "leaver" workflow that's enabled and schedule to run.
+ It runs for new users that are based in Australia, on their employeeHireDate.
+ Two tasks are carried out when the workflow runs: the user's account is enabled and a "Welcome" email is sent to the user.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_create_workflow_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows
Content-Type: application/json

{
    "category": "joiner",
    "description": "Configure new hire tasks for onboarding employees on their first day",
    "displayName": "Australia Onboard new hire employee",
    "isEnabled": true,
    "isSchedulingEnabled": false,
    "executionConditions": {
        "@odata.type": "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions",
        "scope": {
            "@odata.type": "#microsoft.graph.identityGovernance.ruleBasedSubjectSet",
            "rule": "(country eq 'Australia')"
        },
        "trigger": {
            "@odata.type": "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger",
            "timeBasedAttribute": "employeeHireDate",
            "offsetInDays": 0
        }
    },
    "tasks": [
        {
            "continueOnError": false,
            "description": "Enable user account in the directory",
            "displayName": "Enable User Account",
            "isEnabled": true,
            "taskDefinitionId": "6fc52c9d-398b-4305-9763-15f42c1676fc",
            "arguments": []
        },
        {
            "continueOnError": false,
            "description": "Send welcome email to new hire",
            "displayName": "Send Welcome Email",
            "isEnabled": true,
            "taskDefinitionId": "70b29d51-b59a-4773-9280-8841dfd3f2ea",
            "arguments": []
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var workflow = new Microsoft.Graph.IdentityGovernance.Workflow
{
	Category = Microsoft.Graph.IdentityGovernance.LifecycleWorkflowCategory.Joiner,
	Description = "Configure new hire tasks for onboarding employees on their first day",
	DisplayName = "Australia Onboard new hire employee",
	IsEnabled = true,
	IsSchedulingEnabled = false,
	ExecutionConditions = new Microsoft.Graph.IdentityGovernance.TriggerAndScopeBasedConditions
	{
		Scope = new Microsoft.Graph.IdentityGovernance.RuleBasedSubjectSet
		{
			Rule = "(country eq 'Australia')"
		},
		Trigger = new Microsoft.Graph.IdentityGovernance.TimeBasedAttributeTrigger
		{
			TimeBasedAttribute = Microsoft.Graph.IdentityGovernance.WorkflowTriggerTimeBasedAttribute.EmployeeHireDate,
			OffsetInDays = 0
		}
	},
	Tasks = new Microsoft.Graph.IdentityGovernance.WorkflowTasksCollectionPage()
	{
		new Microsoft.Graph.IdentityGovernance.Task
		{
			ContinueOnError = false,
			Description = "Enable user account in the directory",
			DisplayName = "Enable User Account",
			IsEnabled = true,
			TaskDefinitionId = "6fc52c9d-398b-4305-9763-15f42c1676fc",
			Arguments = new List<KeyValuePair>()
			{
			}
		},
		new Microsoft.Graph.IdentityGovernance.Task
		{
			ContinueOnError = false,
			Description = "Send welcome email to new hire",
			DisplayName = "Send Welcome Email",
			IsEnabled = true,
			TaskDefinitionId = "70b29d51-b59a-4773-9280-8841dfd3f2ea",
			Arguments = new List<KeyValuePair>()
			{
			}
		}
	}
};

await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows
	.Request()
	.AddAsync(workflow);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityGovernance.workflow"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/workflows/$entity",
    "category": "joiner",
    "description": "Configure new hire tasks for onboarding employees on their first day",
    "displayName": "New Zealand new hire",
    "lastModifiedDateTime": "2022-08-26T04:51:27.521792Z",
    "createdDateTime": "2022-08-26T04:51:27.5217824Z",
    "deletedDateTime": null,
    "id": "818cd47f-138c-4a83-b3f5-afa92bfcf391",
    "isEnabled": true,
    "isSchedulingEnabled": false,
    "nextScheduleRunDateTime": null,
    "version": 1,
    "executionConditions": {
        "@odata.type": "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions",
        "scope": {
            "@odata.type": "#microsoft.graph.identityGovernance.ruleBasedSubjectSet",
            "rule": "(country eq 'New Zealand')"
        },
        "trigger": {
            "@odata.type": "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger",
            "timeBasedAttribute": "employeeHireDate",
            "offsetInDays": 0
        }
    }
}
```

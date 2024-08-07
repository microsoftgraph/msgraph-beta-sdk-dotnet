---
title: "Update task (within a workflow)"
description: "Update the properties of a task object within a workflow object."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update task (within a workflow)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [task](../resources/identitygovernance-task.md) object.

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
PATCH /identityGovernance/lifecycleWorkflows/workflows/{workflowId}/tasks/{taskId}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|description|String|Describes the purpose of the task for administrative use.|
|displayName|String|A unique string that identifies the task within the workflow.|

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_update_task"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/identitygovernance/lifecycleWorkflows/workflows/8696088c-1aef-4f65-afe9-acd55343e327/tasks/eb0b8bc2-7756-4429-8ce8-b9f09063cf54
Content-Type: application/json
Content-length: 454

{
    "description": "Add user to selected groups",
    "displayName": "Update marketing day 1 add users to Group set up",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var task = new Microsoft.Graph.IdentityGovernance.Task
{
	Description = "Add user to selected groups",
	DisplayName = "Update marketing day 1 add users to Group set up"
};

await graphClient.Identitygovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Tasks["{identityGovernance.task-id}"]
	.Request()
	.UpdateAsync(task);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,

}
-->
``` http
HTTP/1.1 204 No Content
```

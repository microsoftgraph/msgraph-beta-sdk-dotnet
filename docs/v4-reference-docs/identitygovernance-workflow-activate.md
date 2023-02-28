---
title: "workflow: activate (run a workflow on-demand)"
description: "Run a workflow on-demand for time critical execution and testing."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# workflow: activate (run a workflow on-demand)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Run a [workflow](../resources/identitygovernance-workflow.md) object on-demand. You can run any workflow on-demand, including scheduled workflows. Workflows created from the "Real-time employee termination" template are run on-demand only. When you run a workflow on demand, the tasks are executed regardless of whether the user state matches the scope and trigger execution conditions.

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
POST /identityGovernance/lifecycleWorkflows/workflows/{workflowId}/activate
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that are required with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|subjects|[microsoft.graph.user](../resources/user.md) collection|The subjects for whom the workflow is activated.|

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_workflowthis.activate"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows/14879e66-9ea9-48d0-804d-8fea672d0341/activate
Content-Type: application/json

{
    "subjects": [ 
        { "id": "8cdf25a8-c9d2-423e-a03d-3f39f03c3e97"},
        { "id": "ea09ac2e-77e3-4134-85f2-25ccf3c33387"}
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var subjects = new List<User>()
{
	new User
	{
		Id = "8cdf25a8-c9d2-423e-a03d-3f39f03c3e97"
	},
	new User
	{
		Id = "ea09ac2e-77e3-4134-85f2-25ccf3c33387"
	}
};

await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"]
	.Activate(subjects)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

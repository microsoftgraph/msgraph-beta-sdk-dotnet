---
title: "Get run (for a lifecycle workflow)"
description: "Read the properties and relationships of a run object."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Get run (for a lifecycle workflow)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [run](../resources/identitygovernance-run.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|LifecycleWorkflows.Read.All, LifecycleWorkflows.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|LifecycleWorkflows.Read.All, LifecycleWorkflows.ReadWrite.All|

For delegated scenarios, the admin needs one of the following [Azure AD roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

- Global administrator
- Global reader
- Lifecycle workflows administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identityGovernance/lifecycleWorkflows/workflows/{workflowId}/runs/{runId}
```

## Optional query parameters

This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [microsoft.graph.identityGovernance.run](../resources/identitygovernance-run.md) object in the response body.

## Examples

### Example 1: Get a run report for a workflow

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_get_workflow_run"
}
-->
``` http
GET https://graph.microsoft.com/beta/IdentityGovernance/lifecycleWorkflows/workflows/14879e66-9ea9-48d0-804d-8fea672d0341/runs/dad77a47-6eda-4de7-bc37-fe8eb5aaf17d
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var run = await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Runs["{identityGovernance.run-id}"]
	.Request()
	.Select("id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityGovernance.run"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/workflows('14879e66-9ea9-48d0-804d-8fea672d0341')/runs/$entity",
    "id": "dad77a47-6eda-4de7-bc37-fe8eb5aaf17d",
    "completedDateTime": "2022-08-24T23:28:11.1348863Z",
    "failedTasksCount": 0,
    "failedUsersCount": 0,
    "lastUpdatedDateTime": "2022-08-24T23:33:09.186588Z",
    "processingStatus": "completed",
    "scheduledDateTime": "2022-08-24T23:28:01.6476554Z",
    "startedDateTime": "2022-08-24T23:28:04.5688752Z",
    "successfulUsersCount": 2,
    "totalTasksCount": 4,
    "totalUsersCount": 2,
    "totalUnprocessedTasksCount": 0,
    "workflowExecutionType": "onDemand"
}
```

### Example 2: Get specific properties of a run report for a workflow

#### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_get_workflow_run"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows/15239232-66ed-445b-8292-2f5bbb2eb833/runs/e65e08a0-d68d-41dc-915b-8c4019af5cc2?$select=id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var run = await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Runs["{identityGovernance.run-id}"]
	.Request()
	.Select("id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response


The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityGovernance.run"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/workflows('15239232-66ed-445b-8292-2f5bbb2eb833')/runs(id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount)/$entity",
    "id": "e65e08a0-d68d-41dc-915b-8c4019af5cc2",
    "failedTasksCount": 0,
    "failedUsersCount": 0,
    "processingStatus": "completed",
    "totalTasksCount": 3,
    "totalUsersCount": 1,
    "totalUnprocessedTasksCount": 0
}
```

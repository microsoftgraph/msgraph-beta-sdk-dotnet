---
title: "run: summary (of a lifecycle workflow)"
description: "A summary of runs for a specified time period. Since the amount of runs returned by the List API call can be overwhelming, this summary allows the administrator to get a quick overview based on counts."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# run: summary (of a lifecycle workflow)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

A summary of runs for a specified time period. Since the amount of runs returned by the List API call can be overwhelming, this summary allows the administrator to get a quick overview based on counts.

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
GET /identityGovernance/lifecycleWorkflows/workflows/{workflowId}/runs/summary(startDateTime={timestamp},endDateTime={timestamp})
```

## Function parameters

In the request URL, provide the following query parameters with values.
The following table shows the parameters that are required with this function.

|Parameter|Type|Description|
|:---|:---|:---|
|startDateTime|DateTimeOffset|The start date and time of the workflow run|
|endDateTime|DateTimeOffset|The end date and time of the workflow run|

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [microsoft.graph.identityGovernance.runSummary](../resources/identitygovernance-runsummary.md) in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_runthis.summary"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows/14879e66-9ea9-48d0-804d-8fea672d0341/runs/summary(startDateTime=2022-08-01T00:00:00Z,endDateTime=2022-08-31T00:00:00Z)
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var runSummary = await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Runs
	.Summary(2022-08-01T00:00:00Z,2022-08-31T00:00:00Z)
	.Request()
	.GetAsync();

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
  "@odata.type": "microsoft.graph.identityGovernance.runSummary"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.identityGovernance.runSummary",
    "failedRuns": 0,
    "failedTasks": 0,
    "successfulRuns": 1,
    "totalRuns": 2,
    "totalTasks": 4,
    "totalUsers": 2
}
```

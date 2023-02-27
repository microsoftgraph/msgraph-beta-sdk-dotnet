---
title: "List workflowVersions"
description: "Get a list of the workflowVersion objects and their properties."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# List versions (of a lifecycle workflow)

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [workflowVersion](../resources/identitygovernance-workflowversion.md) objects and their properties.

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
GET /identityGovernance/lifecycleWorkflows/workflows/{workflowId}/versions
```

## Optional query parameters

This method supports the `$select`, `$count`, `$search`, `$orderBy`, `$expand`, and `$filter` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.identityGovernance.workflowVersion](../resources/identitygovernance-workflowversion.md) objects in the response body.

## Examples

### Example 1: Retrieve the versions of a workflow

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_list_workflowversion"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows/156ce798-1eb6-4e0a-8515-e79f54d04390/versions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var versions = await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Versions
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.identityGovernance.workflowVersion)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/workflows('156ce798-1eb6-4e0a-8515-e79f54d04390')/versions",
    "value": [
        {
            "category": "joiner",
            "description": "Configure new hire tasks for onboarding employees on their first day",
            "displayName": "Global onboard new hire employee",
            "isEnabled": true,
            "isSchedulingEnabled": true,
            "lastModifiedDateTime": "2022-08-24T19:33:03.8664941Z",
            "versionNumber": 3,
            "createdDateTime": "2022-08-24T19:31:33.5534766Z"
        },
        {
            "category": "joiner",
            "description": "Configure new hire tasks for onboarding employees on their first day",
            "displayName": "Onboard new hire employee",
            "isEnabled": true,
            "isSchedulingEnabled": false,
            "lastModifiedDateTime": "2022-08-24T19:31:33.4303233Z",
            "versionNumber": 2,
            "createdDateTime": "2022-08-24T19:18:18.6841471Z"
        },
        {
            "category": "joiner",
            "description": "Configure new hire tasks for onboarding employees on their first day",
            "displayName": "Onboard new hire employee",
            "isEnabled": true,
            "isSchedulingEnabled": false,
            "lastModifiedDateTime": "2022-08-24T19:18:18.5633638Z",
            "versionNumber": 1,
            "createdDateTime": "2022-08-24T15:39:17.6496784Z"
        }
    ]
}
```

### Example 2: Retrieve specific properties of all versions of a workflow

#### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_list_workflowversion_select"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/workflows/15239232-66ed-445b-8292-2f5bbb2eb833/versions?$select=category,displayName,versionNumber
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var versions = await graphClient.IdentityGovernance.LifecycleWorkflows.Workflows["{identityGovernance.workflow-id}"].Versions
	.Request()
	.Select("category,displayName,versionNumber")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.identityGovernance.workflowVersion)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/workflows('15239232-66ed-445b-8292-2f5bbb2eb833')/versions(category,displayName,versionNumber)",
    "value": [
        {
            "category": "leaver",
            "displayName": "Post-Offboarding of an employee",
            "versionNumber": 2
        },
        {
            "category": "leaver",
            "displayName": "Post-Offboarding of an employee",
            "versionNumber": 1
        }
    ]
}
```

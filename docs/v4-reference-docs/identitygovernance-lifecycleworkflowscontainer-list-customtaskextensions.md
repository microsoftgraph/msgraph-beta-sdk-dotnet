---
title: "List customTaskExtensions"
description: "Get a list of the customTaskExtension objects and their properties."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# List customTaskExtensions

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [customTaskExtension](../resources/identitygovernance-customtaskextension.md) objects and their properties.

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
GET /identityGovernance/lifecycleWorkflows/customTaskExtensions
```

## Optional query parameters

This method supports the `$select` `$search`, `$orderBy`, and `$filter` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.identityGovernance.customTaskExtension](../resources/identitygovernance-customtaskextension.md) objects in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_list_customtaskextension"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/customTaskExtensions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customTaskExtensions = await graphClient.IdentityGovernance.LifecycleWorkflows.CustomTaskExtensions
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.identityGovernance.customTaskExtension)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/customTaskExtensions",
    "@odata.count": 2,
    "value": [
        {
            "id": "c0c5b05b-6b5b-4c8d-8060-2ae8df425f4b",
            "displayName": "Query and assign Teams phone number",
            "description": "Query and assign Teams phone number",
            "createdDateTime": "2022-08-24T20:34:52.3028938Z",
            "lastModifiedDateTime": "2022-08-24T20:35:07.716353Z",
            "callbackConfiguration": null,
            "endpointConfiguration": {
                "@odata.type": "#microsoft.graph.logicAppTriggerEndpointConfiguration",
                "subscriptionId": "c500b67c-e9b7-4ad2-a90d-77d41385ae55",
                "resourceGroupName": "RG-LCM",
                "logicAppWorkflowName": "TeamsPhoneNumber"
            },
            "authenticationConfiguration": {
                "@odata.type": "#microsoft.graph.azureAdTokenAuthentication",
                "resourceId": "b9c29c27-b116-47a9-925b-ff3b19bafa3b"
            },
            "clientConfiguration": {
                "@odata.type": "#microsoft.graph.customExtensionClientConfiguration",
                "maximumRetries": 1,
                "timeoutInMilliseconds": 1000
            }
        },
        {
            "id": "ffcc4c85-5a14-448e-a390-77abf2700369",
            "displayName": "Grant manager access to mailbox and OneDrive",
            "description": "Grant manager access to mailbox and OneDrive",
            "createdDateTime": "2022-08-24T20:36:14.7006029Z",
            "lastModifiedDateTime": "2022-08-24T20:42:07.9885265Z",
            "endpointConfiguration": {
                "@odata.type": "#microsoft.graph.logicAppTriggerEndpointConfiguration",
                "subscriptionId": "c500b67c-e9b7-4ad2-a90d-77d41385ae55",
                "resourceGroupName": "RG-LCM",
                "logicAppWorkflowName": "ManagerAccess"
            },
            "authenticationConfiguration": {
                "@odata.type": "#microsoft.graph.azureAdTokenAuthentication",
                "resourceId": "542dc01a-0b5d-4edc-b3f9-5cfe6393f557"
            },
            "clientConfiguration": {
                "@odata.type": "#microsoft.graph.customExtensionClientConfiguration",
                "maximumRetries": 1,
                "timeoutInMilliseconds": 1000
            },
            "callbackConfiguration": {
                "@odata.type": "#microsoft.graph.identityGovernance.customTaskExtensionCallbackConfiguration",
                "timeoutDuration": "PT5M"
            }
        }
    ]
}
```

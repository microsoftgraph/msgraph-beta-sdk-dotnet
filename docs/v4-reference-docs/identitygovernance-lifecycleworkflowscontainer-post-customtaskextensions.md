---
title: "Create Custom Task Extension"
description: "Create a new customTaskExtension object."
author: "AlexFilipin"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Create customTaskExtensions

Namespace: microsoft.graph.identityGovernance

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [customTaskExtension](../resources/identitygovernance-customtaskextension.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|LifecycleWorkflows.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|Not supported|

> [!IMPORTANT]
> The calling user also requires one of the following Azure Resource Manager roles for the specified Azure Logic App: **Logic App contributor**, **Contributor**, or **Owner**.

For delegated scenarios, the admin needs one of the following [Azure AD roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

- Global administrator
- Lifecycle workflows administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /identityGovernance/lifecycleWorkflows/customTaskExtensions
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [customTaskExtension](../resources/identitygovernance-customtaskextension.md) object.

You can specify the following properties when creating a **customTaskExtension**.

|Property|Type|Description|
|:---|:---|:---|
|authenticationConfiguration|[microsoft.graph.customExtensionAuthenticationConfiguration](../resources/customextensionauthenticationconfiguration.md)|The authentication configuration for the `customTaskExtension`.|
|clientConfiguration|[microsoft.graph.customExtensionClientConfiguration](../resources/customextensionclientconfiguration.md)|The client configuration for a custom extension.|
|description|String|The description of the `customTaskExtension`.|
|displayName|String|A unique string that identifies the `customTaskExtension`.|
|endpointConfiguration|[microsoft.graph.customExtensionEndpointConfiguration](../resources/customextensionendpointconfiguration.md)|The endpoint configuration for a custom extension. Optional.|
|callbackConfiguration|[microsoft.graph.identityGovernance.customTaskExtensionCallbackConfiguration](../resources/identitygovernance-customtaskextensioncallbackconfiguration.md)|The callback configuration for a custom extension.  Optional.|

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.identityGovernance.customTaskExtension](../resources/identitygovernance-customtaskextension.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "lifecycleworkflows_create_customtaskextension_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/lifecycleWorkflows/customTaskExtensions
Content-Type: application/json
Content-length: 588

{
    "displayName": "Grant manager access to mailbox and OneDrive",
    "description": "Grant manager access to mailbox and OneDrive",
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
```

### Response

The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityGovernance.customTaskExtension"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/customTaskExtensions/$entity",
    "id": "ee2590e4-4572-4820-a397-969ecd7bd6a9",
    "displayName": "Grant manager access to mailbox and OneDrive",
    "description": "Grant manager access to mailbox and OneDrive",
    "createdDateTime": "2022-08-24T22:37:46.1790566Z",
    "lastModifiedDateTime": "2022-08-24T22:37:46.179062Z",
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
```

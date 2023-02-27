---
title: "Update customAccessPackageWorkflowExtension"
description: "Update the properties of a customAccessPackageWorkflowExtension object."
author: "currenmehta-zz"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update customAccessPackageWorkflowExtension
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an existing [customAccessPackageWorkflowExtension](../resources/customaccesspackageworkflowextension.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|EntitlementManagement.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|EntitlementManagement.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PUT /identityGovernance/entitlementManagement/accessPackageCatalogs/{catalogId}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtensionId}
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
|description|String|Description for the customAccessPackageWorkflowExtension object.|
|displayName|String|Display name for the customAccessPackageWorkflowExtension.|
|endpointConfiguration|[customExtensionEndpointConfiguration](../resources/customextensionendpointconfiguration.md)|The type and details for configuring the endpoint to call the logic app's workflow.|  
|authenticationConfiguration|[customExtensionAuthenticationConfiguration](../resources/customextensionauthenticationconfiguration.md)|Configuration for securing the API call to the logic app. For example, using OAuth client credentials flow.|


## Response

If successful, this method returns a `200 OK` response code and an updated [customAccessPackageWorkflowExtension](../resources/customaccesspackageworkflowextension.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_customaccesspackageworkflowextension"
}
-->
``` http
PUT https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageCatalogs/32efb28c-9a7a-446c-986b-ca6528c6669d/customAccessPackageWorkflowExtensions/98ffaec5-ae8e-4902-a434-5ffc5d3d3cd0
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.customAccessPackageWorkflowExtension",
  "displayName": "test_action_0124_email",
  "description": "this is for graph testing only"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customAccessPackageWorkflowExtension = new CustomAccessPackageWorkflowExtension
{
	DisplayName = "test_action_0124_email",
	Description = "this is for graph testing only"
};

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs["{accessPackageCatalog-id}"].CustomAccessPackageWorkflowExtensions["{customAccessPackageWorkflowExtension-id}"]
	.Request()
	.PutAsync(customAccessPackageWorkflowExtension);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.customAccessPackageWorkflowExtension"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{ 
    "displayName": "test_action_0124_email", 
    "description": "this is for graph testing only", 
    "endpointConfiguration": { 
        "@odata.type": "#microsoft.graph.logicAppTriggerEndpointConfiguration", 
        "subscriptionId": "38ab2ccc-3747-4567-b36b-9478f5602f0d", 
        "resourceGroupName": "EMLogicApp", 
        "logicAppWorkflowName": "elm-extension-email" 
    }, 
    "authenticationConfiguration": { 
        "@odata.type": "#microsoft.graph.azureAdTokenAuthentication", 
        "resourceId": "eed6dee9-7ff7-44a5-8980-c11e8886cea2" 
    } 
} 
```


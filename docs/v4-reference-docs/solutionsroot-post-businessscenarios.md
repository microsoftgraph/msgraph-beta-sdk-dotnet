---
title: "Create businessScenario"
description: "Create a new businessScenario object."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Create businessScenario
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [businessScenario](../resources/businessscenario.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioConfig.ReadWrite.OwnedBy, BusinessScenarioConfig.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application| BusinessScenarioConfig.ReadWrite.OwnedBy |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /solutions/businessScenarios
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [businessScenario](../resources/businessscenario.md) object.

You can specify the following properties when you create a **businessScenario**.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Display name of the scenario. Required.|
|uniqueName|String|Unique name of the scenario. To avoid conflicts, the recommended value for the unique name is a reverse domain name format, owned by the author of the scenario. For example, a scenario authored by *Contoso.com* would have a unique name that starts with `com.contoso`. Required.|
|ownerAppIds|String collection|Identifiers of applications that are authorized to work with this scenario. The application that creates the scenario will be automatically added to the list. Optional.|

## Response

If successful, this method returns a `201 Created` response code and a [businessScenario](../resources/businessscenario.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_businessscenario_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/solutions/businessScenarios
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.businessScenario",
  "displayName": "Contoso Order Tracking",
  "uniqueName": "com.contoso.apps.ordertracking"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var businessScenario = new BusinessScenario
{
	DisplayName = "Contoso Order Tracking",
	UniqueName = "com.contoso.apps.ordertracking"
};

await graphClient.Solutions.BusinessScenarios
	.Request()
	.AddAsync(businessScenario);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.businessScenario"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.businessScenario",
  "id": "c5d514e6c6864911ac46c720affb6e4d",
  "displayName": "Contoso Order Tracking",
  "uniqueName": "com.contoso.apps.ordertracking",
  "ownerAppIds": [
      "44109254-4b2b-7a33-76ee-c890a167b295"
  ]
}
```

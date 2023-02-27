---
title: "Create operationalInsightsConnection"
description: "Create a new operationalInsightsConnection object."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# Create operationalInsightsConnection
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [operationalInsightsConnection](../resources/windowsupdates-operationalinsightsconnection.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|WindowsUpdates.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|WindowsUpdates.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /admin/windows/updates/resourceConnections
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [operationalInsightsConnection](../resources/windowsupdates-operationalinsightsconnection.md) object.

You must specify the following properties when you create an **operationalInsightsConnection**.

|Property|Type|Description|
|:---|:---|:---|
|azureResourceGroupName|String|The name of the Azure resource group that contains the Log Analytics workspace.|
|azureSubscriptionId|String|The Azure subscription ID that contains the Log Analytics workspace.|
|workspaceName|String|The name of the Log Analytics workspace.|

## Response

If successful, this method returns a `201 Created` response code and an [operationalInsightsConnection](../resources/windowsupdates-operationalinsightsconnection.md) object in the response body.

The following errors are possible:

|Response Code|Message|
|:---|:---|
|`400 Bad Request`|The specified workspace was not able to be linked. Verify that the key properties are correct.|
|`403 Forbidden`|The specified workspace was not able to be linked. Verify that the Azure subscription is active.|
|`409 Conflict`|The specified resource already exists.|

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_operationalInsightsConnection_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/windows/updates/resourceConnections
Content-Type: application/json
Content-length: 97

{
  "@odata.type": "#microsoft.graph.windowsUpdates.operationalInsightsConnection",
  "azureSubscriptionId": "322ec614-e9c2-4cd5-a55c-5711fdecf02e",
  "azureResourceGroupName": "target-resource-group",
  "workspaceName": "my-workspace"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var resourceConnection = new Microsoft.Graph.WindowsUpdates.OperationalInsightsConnection
{
	AzureSubscriptionId = "322ec614-e9c2-4cd5-a55c-5711fdecf02e",
	AzureResourceGroupName = "target-resource-group",
	WorkspaceName = "my-workspace"
};

await graphClient.Admin.Windows.Updates.ResourceConnections
	.Request()
	.AddAsync(resourceConnection);

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
  "@odata.type": "microsoft.graph.windowsUpdates.operationalInsightsConnection"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.operationalInsightsConnection",
  "id": "85fbecb2-e407-34e9-9298-4d587857795d",
  "azureSubscriptionId": "322ec614-e9c2-4cd5-a55c-5711fdecf02e",
  "azureResourceGroupName": "target-resource-group",
  "workspaceName": "my-workspace",
  "state": "connected"
}
```

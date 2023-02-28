---
title: "Update simulation"
description: "Update an attack simulation campaign for a tenant."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Update simulation

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update an attack simulation campaign for a tenant.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | AttackSimulation.ReadWrite.All              |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | AttackSimulation.ReadWrite.All              |

## HTTP request
<!-- {
  "blockType": "ignored"
}
-->
```http
PATCH /security/attackSimulation/simulations/{simulationId}
```

## Request headers

|Header         |Value                    |
|---------------|-------------------------|
|Authorization  |Bearer {token}. Required.|
|Content-Type   |application/json         |

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|attackTechnique|[simulationAttackTechnique](../resources/simulation.md#simulationattacktechnique-values)|The social engineering technique used in the attack simulation and training campaign. Supports `$filter` and `$orderby`. Possible values are: `unknown`, `credentialHarvesting`, `attachmentMalware`, `driveByUrl`, `linkInAttachment`, `linkToMalwareFile`, `unknownFutureValue`. For more information on the types of social engineering attack techniques, see [simulations](/microsoft-365/security/office-365-security/attack-simulation-training-get-started?view=o365-worldwide&preserve-view=true#simulations).|
|attackType|[simulationAttackType](../resources/simulation.md#simulationattacktype-values)|Attack type of the attack simulation and training campaign. Supports `$filter` and `$orderby`. Possible values are: `unknown`, `social`, `cloud`, `endpoint`, `unknownFutureValue`.|
|completionDateTime|DateTimeOffset|Date and time of completion of the attack simulation and training campaign. Supports `$filter` and `$orderby`.|
|description|String|Description of the attack simulation and training campaign.|
|displayName|String|Display name of the attack simulation and training campaign. Supports `$filter` and `$orderby`.|
|durationInDays|Int32|Simulation duration in days.|
|excludedAccountTarget|[accountTargetContent](../resources/accounttargetcontent.md)|Users excluded from the simulation.|
|includedAccountTarget|[accountTargetContent](../resources/accounttargetcontent.md)|Users targeted in the simulation.|
|lastModifiedBy|[emailIdentity](../resources/emailidentity.md)|Identity of the user who most recently modified the attack simulation and training campaign.|
|lastModifiedDateTime|DateTimeOffset|Date and time of the most recent modification of the attack simulation and training campaign.|
|launchDateTime|DateTimeOffset|Date and time of the launch/start of the attack simulation and training campaign. Supports `$filter` and `$orderby`.|
|payloadDeliveryPlatform|payloadDeliveryPlatform|Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: `unknown`, `sms`, `email`, `teams`, `unknownFutureValue`.|
|status|[simulationStatus](../resources/simulation.md#simulationstatus-values)|Status of the attack simulation and training campaign. Supports `$filter` and `$orderby`. Possible values are: `unknown`, `draft`, `running`, `scheduled`, `succeeded`, `failed`, `cancelled`, `excluded`, `unknownFutureValue`.|

## Response

If successful, this method returns a `202 Accepted` response code and a tracking header named `location` in the response.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_simulation",
  "sampleKeys": ["2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc"]
}
-->
```http
PATCH https://graph.microsoft.com/beta/security/attackSimulation/simulations/2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc
Content-type: application/json

{
  "id": "2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc",
  "displayName": "Graph Simulation",
  "description": "Test simulation created using postman",
  "payloadDeliveryPlatform": "email",
  "payload@odata.bind":"https://graph.microsoft.com/beta/security/attacksimulation/payloads/12345678-9abc-def0-123456789a",
  "durationInDays": 7,
  "attackTechnique": "credentialHarvesting",
  "attackType": "social",
  "status": "scheduled",
  "completionDateTime": "2022-09-16T06:13:08.4297612Z",
  "launchDateTime": "2022-09-05T06:13:08.4297612Z",
  "includedAccountTarget": {
    "@odata.type": "#microsoft.graph.addressBookAccountTargetContent",
    "type" : "addressBook",
    "accountTargetEmails" : [
        "faiza@contoso.com"
    ]
  },
  "excludedAccountTarget": {
    "@odata.type": "#microsoft.graph.addressBookAccountTargetContent",
    "type" : "addressBook",
    "accountTargetEmails" : [
        "sam@contoso.com"
    ]
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var simulation = new Simulation
{
	Id = "2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc",
	DisplayName = "Graph Simulation",
	Description = "Test simulation created using postman",
	PayloadDeliveryPlatform = PayloadDeliveryPlatform.Email,
	DurationInDays = 7,
	AttackTechnique = SimulationAttackTechnique.CredentialHarvesting,
	AttackType = SimulationAttackType.Social,
	Status = SimulationStatus.Scheduled,
	CompletionDateTime = DateTimeOffset.Parse("2022-09-16T06:13:08.4297612Z"),
	LaunchDateTime = DateTimeOffset.Parse("2022-09-05T06:13:08.4297612Z"),
	IncludedAccountTarget = new AddressBookAccountTargetContent
	{
		Type = AccountTargetContentType.AddressBook,
		AccountTargetEmails = new List<String>()
		{
			"faiza@contoso.com"
		}
	},
	ExcludedAccountTarget = new AddressBookAccountTargetContent
	{
		Type = AccountTargetContentType.AddressBook,
		AccountTargetEmails = new List<String>()
		{
			"sam@contoso.com"
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"payload@odata.bind", "https://graph.microsoft.com/beta/security/attacksimulation/payloads/12345678-9abc-def0-123456789a"}
	}
};

await graphClient.Security.AttackSimulation.Simulations["{simulation-id}"]
	.Request()
	.UpdateAsync(simulation);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note**: The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

```http
HTTP/1.1 202 Accepted
```

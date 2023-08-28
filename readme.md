### Basic Parameters

- Running locally
- Active Instance of Azurite 
- Connected to Azure WebPuSub

### Content of my local.settings.json

- IsEncrypted: false
- Values
-- AzureWebjobsStorge: UseDevelopmentStorage=true
-- Functions-Worker-Runtime: dotnet-isolated
-- WebPubSubConnectionString: "secret"
--  FUNCTIONS_EXTENSION_VERSION: "~4"
-- WEBSITE_CONTENTAZUREFILECONNECTIONSTRING: "secret"
-- WEBSITE_CONTENTSHARE: "secret"
-- WEBSITE_RUN_FROM_PACKAGE
- Host
-- CORS: localhost.. 
- ConnectionStrings: Empty Array

### Get the issue
- Calling: http://localhost:7071/api/notification with Get
- Calling http://localhost:7071/api/negotiate?userid=YOURUSERNAME

### Expectations
- Terminal shows the request to the specific function but no response is emitted. (Timeout)
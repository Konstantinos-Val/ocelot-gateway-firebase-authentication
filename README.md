# ocelot-gateway-firebase-authentication

Basic sample of Aspnet Core 3.1 Ocelot gateway with Firebase Authentication

### Setup a Firebase project

- Create a Firebase project. https://console.firebase.google.com/

In appsettings.json **FirebaseAuthentication:Issuer** will be _https://securetoken.google.com/YOURPROJECTNAME_ and **FirebaseAuthentication:Audience** will be _YOURPROJECTNAME_

Enable authentication provider (Google, Facebook, Anonymous, ...) on your project.

### Configure DownstreamHostAndPorts ports

Open **ocelot.json** and change the DownstreamHostAndPorts values based on your visual studio iisExpress assignments. See the _launchSettings.json_ file in every project.

### Work in Progress

For the time being in order to make authorized calls to the protected endpoints through the gateway you need to create a simple Firebase client to authenticate and get an access_token.

This client is not provided in this demo but will be added in the near future...

## License

[MIT](https://choosealicense.com/licenses/mit/)

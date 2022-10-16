# Sample Twitter Stream Services Application.
A Web API Test Application for Accessing Twitter Endpoints

## Table of Contents
1. Requirements
2. Project Setup
2. Implementation Details

### Requirements
1. .Net Core 3.1
2. Visual studio 2019

### Project Setup
1. Git Clone https://github.com/ratnakarp/JHRPTwitterTestApp.git
2. Open JHRPTwitterTestApp.sln
3. Update "BearerToken" value in appsetting.config file on registered twitter profile.
4. Build the solution.
5. Run the web project.
6. Expand the /api/twitteraccess/getsamplestream 
7. Click Tryout
8. Click Execute

![image](https://user-images.githubusercontent.com/3654363/196064240-f5e46470-3fef-43ca-9843-2872090d756e.png)

### Implementation Details
1. Implemented Dependency Injection.
2. Used In memory cache for to store the results from twitter endpoint.
3. Used NLog logging to capture Info, Debug, Error details. 
4. Logging has been setup for strugged logging which is configurable in appsettings.config.
5. Implemented Unit test(s) for the service class.
6. Added swagger to test the Restful API endpoint.


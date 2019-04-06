# DEVOPS C# - Web App On and Azure SQL Database demo

This demo contains simple one page web app with REST API backend and Azure SQL Database for data persistence.

### Demonstrated DEVOPS scenario:
* automatically create infrastructure environment (Web App and Azure SQL Database).
* configure Web App with Azure SQL Database connection string and GitHub repository with application source codes for automated deployment.
* When developer changes application code and pushed changes to `cs` branch Web App collect changes from GitHub and deploy (and build) new version of application.

### Web App:
* exposes REST APIs for listing ToDoes, creating and editing ToDo records.



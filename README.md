# Mission Board

This is an interactive application that lets churches show members information about the missionaries they support. There are a few different views.  The initial view shows a map with markers visualizing where the missionaries are in the world.  If you click on the marker, you will be taken to a different screen that will have details about the missionary and show any recent letters from the missionary.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
Windows OS
Dot Net Framework
```


### Running Locally

A few things need to be done before you can run the project locally.  First off, you'll likely need to download/update any nuget packages you may be missing or are out of date.  Once that's done, you'll need to create a CSV file that the program will read to get the missionary info. The CSV file needs to be in the following format:

```
[0]           [1]             [2]           [3]         [4]       [5]         [6]     [7]               [8]
Display_Name  Mission_Field   First_Name    Last_Name   Latitude  Longitude   Email   Profile_Picture   Letter_Alias

```

Then, you'll want to create a config file that will contain your secrets.  For obvious reasons, this file is not in source control.  This file will be call AppSettingsSecrets.config.  You will want to add this file to the project.  The gitignore file is setup to ignore this file so as to not save your secrets in a publicly available source control.  The file needs to have the following tags:

```
<appSettings>
  <add key="BingApiKey" value="" />
  <add key="EmailUsername" value=""/>
  <add key="EmailPassword" value=""/>
</appSettings>
```

Finally, you will want to fill out the values for the settings in both the regular app.config file (under the applicationSettings node) and in the secrets file you just created.  Once done, you should be able to run the project.

## Deployment

There are two ways to deploy the application.  The first is to build the setup project and use that to distribute and install the application.  The second is to publish as a runonce application using Visual Studio.

## Built With

* [Microsoft .Net Framework](https://dotnet.microsoft.com/apps/desktop) - The desktop framework used.
* [Microsoft Bing Maps WCF Control](https://docs.microsoft.com/en-us/previous-versions/bing/wpf-control/hh750210(v=msdn.10)) - The API for the map.
* [PDFium Viewer](https://github.com/pvginkel/PdfiumViewer) - Used to convert PDF pages into JPGs.

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. <!--For the versions available, see the [tags on this repository](https://github.com/your/project/tags). -->

## Authors

* **tbehman** - *Initial work* - [tbehman](https://github.com/tbehman/)
* **Tyler Piscaglia** - *New features and support* - [tpiscaglia](https://github.com/tpiscaglia/)

<!-- See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.-->

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

<!--## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc-->

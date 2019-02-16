
# Human Motion Visualiser

[![Build status](https://ci.appveyor.com/api/projects/status/fvsbknfnumvavx4o?svg=true)](https://ci.appveyor.com/project/BayesTech/humanmotionvisualiser)

This project is for visualising human motion data captured with Kinect V2. Currently the project is in developing stage and will release the alpha version soon.

## Getting Started

Currently we don't have release binary version. If you would like to try the application, please download and compile the source code. Please follow the Installation section for detail.

### Branching Model

This project uses [Git Flow](https://datasift.github.io/gitflow/IntroducingGitFlow.html) as the branching model wit some minor adjustment. Basically there are three long-running branches:

 - release
 This branch ONLY contains released code, including major, minor and patch releases. Each merge to this branch will be tagged agaist a release version. Developers are not allowed to commit or create pull request against this branch. Only merges from master branch are allowed.
 
 - master
This branch contains working code, which passes all the automated and manual testing. Developers are not allowed to commit or create pull request against this branch. Only merges from develop branch are allowed.
 
 - develop
 This branch accepts pull request from developers.

Some other temporarily branches includes feature, bug and hotfix branches. They should be deleted immediately after being merged to develop branch.

### Code Analyser and Coding Style

This project uses the [Code Analyser](https://docs.microsoft.com/en-us/visualstudio/code-quality/code-analysis-for-managed-code-overview?view=vs-2017) with all rules for static code analysis. Additionally, [StyleCop](https://marketplace.visualstudio.com/items?itemName=ChrisDahlberg.StyleCop) is used to check make sure the coding style is consistent. So before making pull request, please check if there is any **Warnings** relating to code you just added.

### Installation

This project is developed with .Net Framework 4.7.2 and Visual Studio 2017. Other packages are managed by Nuget.

## Running the tests

### Break down into end to end tests

### And coding style tests

## Deployment

## Built With

## Contributors

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

## License

This project is licensed under the GPL V3 License

## Acknowledgments


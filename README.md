# NPFTestApi
[![Build Status](https://api.travis-ci.org/caiomarruda/NPFTestApi.svg?branch=master)](https://travis-ci.org/caiomarruda/NPFTestApi)

NPF Challenge Test Api (ex. 3)


## Instalation
You need to install latest version of .Net Core Runtime (3.1) to run this project.

You can download from https://dotnet.microsoft.com/download, and check out
installation instructions.
```url
https://dotnet.microsoft.com/download/dotnet-core
```

### To build and run this project (port 5000 for http or 5001 for https):
```bash
dotnet restore
dotnet build
dotnet run --project src\NPFTestApi\NPFTestApi.csproj
dotnet publish -c Release
```

###To build and run this project via docker:
```bash
docker build -t npftestapi:latest .
docker run -p 80:80 npftestapi:latest
```

## Usage

Use the ports 80 or 443(SSL) to run this project. All API documentation are available in Swagger UI.

You can also run this project using [Play With Docker](https://labs.play-with-docker.com/) for free.

## License
[MIT](https://choosealicense.com/licenses/mit/)

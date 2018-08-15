# IO.Swagger - ASP.NET Core 2.0 Server

This is the test of the SDC REST API   [SDC REST API Doc](https://goo.gl/YLo7Fq) and more on SDC at  [http://wiki.ihe.net/index.php/Structured_Data_Capture](http://wiki.ihe.net/index.php/Structured_Data_Capture). 

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```

FROM microsoft/aspnet:1.0.0-beta5

MAINTAINER Dan Fernandez dan.fernandez@microsoft.com 

RUN apt-get install -y jp2a

ADD . /app

WORKDIR /app

ENTRYPOINT ["./ConsoleAscii"]
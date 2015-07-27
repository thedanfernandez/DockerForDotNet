FROM bindu/aspnet:1.0.0-beta4

ADD . /app

WORKDIR /app/approot/src/{{ProjectName}}

ENTRYPOINT ["dnx", ".", "Kestrel", "--server.urls", "http://localhost:{{DockerPublishContainerPort}}"]
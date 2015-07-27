FROM bindu/aspnet:1.0.0-beta4

ADD . /app
RUN apt-get install -y jp2a

WORKDIR /app/approot/src/{{ProjectName}}

ENTRYPOINT ["dnx", ".", "run"]
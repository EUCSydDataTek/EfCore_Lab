FROM ubuntu:plucky

RUN mkdir /Environment

WORKDIR /Environment

COPY . /Environment

RUN ls

RUN bash Environment/install-dotnet-interactive.sh

CMD ["sleep","infinity"]
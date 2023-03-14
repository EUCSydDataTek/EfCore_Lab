FROM ubuntu:lunar

RUN mkdir /Environment

WORKDIR /Environment

COPY . /Environment

RUN ls

RUN bash .devcontainer/install-dotnet-interactive.sh

CMD ["sleep","infinity"]
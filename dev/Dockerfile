FROM microsoft/dotnet:2.2-sdk
RUN apt-get update && apt-get install -y vim
RUN dotnet tool install -g dotnet-aspnet-codegenerator
RUN dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
ENV PATH="${PATH}:/root/.dotnet/tools"
CMD ["/bin/bash"]

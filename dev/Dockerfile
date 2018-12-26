FROM microsoft/dotnet:2.2-sdk
RUN apt-get update && apt-get install -y vim

# TODO - doesn't quite work yet
CMD ["dotnet", "tool install -g dotnet-aspnet-codegenerator"]
CMD ["dotnet", "add package Microsoft.VisualStudio.Web.CodeGeneration.Design"]
ENV PATH="${PATH}:/root/.dotnet/tools"
# ------------------------------

CMD ["/bin/bash"]

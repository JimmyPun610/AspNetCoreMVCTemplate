pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Settings') {
      steps {
        sh 'ls'
        sh 'export DOTNET_CLI_HOME="/tmp/DOTNET_CLI_HOME"'
      }
    }

    stage('Publish') {
      steps {
        sh 'dotnet publish "~/AspNetCoreMVCTemplate.csproj" -o /publish'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
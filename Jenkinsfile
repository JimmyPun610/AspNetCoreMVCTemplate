pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Publish') {
      steps {
        sh 'ls'
        sh 'dotnet publish "~/AspNetCoreMVCTemplate.csproj"'
      }
    }

  }
}
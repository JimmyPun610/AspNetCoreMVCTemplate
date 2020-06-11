pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Publish') {
      steps {
        sh 'dotnet publish "~/AspNetCoreMVCTemplate/AspNetCoreMVCTemplate.csproj" -o /publish'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
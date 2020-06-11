pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build "/AspNetCoreMVCTemplate/AspNetCoreMVCTemplate.csproj" -c Release -o /publish'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
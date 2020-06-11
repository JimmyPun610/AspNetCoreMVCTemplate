pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Restore Package') {
      steps {
        sh 'nuget restore "/AspNetCoreMVCTemplate.sln"'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
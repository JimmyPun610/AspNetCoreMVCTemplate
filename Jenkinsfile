pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Restore') {
      steps {
        sh 'dotnet restore'
      }
    }

    stage('Clean') {
      steps {
        sh 'dotnet build --configuration Release'
      }
    }

    stage('Build') {
      steps {
        sh 'dotnet build --configuration Release'
      }
    }

    stage('Check') {
      steps {
        sh 'ls'
        sh 'cd AspNetCoreMVCTemplate'
        sh 'ls'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
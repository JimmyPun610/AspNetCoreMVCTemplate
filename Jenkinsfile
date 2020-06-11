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
        sh 'dotnet clean'
      }
    }

    stage('Build') {
      steps {
        sh 'dotnet build --configuration Release'
      }
    }

    stage('Publish') {
      steps {
        sh 'dotnet publish -c Release'
      }
    }

    stage('Check') {
      steps {
        sh 'ls AspNetCoreMVCTemplate/bin/publish'
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
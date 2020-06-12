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

    stage('Archive') {
      steps {
        sh 'ls AspNetCoreMVCTemplate/bin/Release/netcoreapp3.1/publish/'
        archiveArtifacts(artifacts: 'AspNetCoreMVCTemplate/bin/Release/netcoreapp3.1/publish/', onlyIfSuccessful: true)
      }
    }

  }
  environment {
    Home = '/tmp'
  }
}
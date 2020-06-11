pipeline {
  agent {
    docker {
      image 'microsoft/dotnet:latest'
    }

  }
  stages {
    stage('Checkout') {
      steps {
        sh 'dotnet --version'
      }
    }

  }
}
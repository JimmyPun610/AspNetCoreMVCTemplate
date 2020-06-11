pipeline {
  agent {
    docker {
      image 'node:7-alpine'
    }

  }
  stages {
    stage('Checkout') {
      steps {
        sh 'node --version'
      }
    }

  }
}
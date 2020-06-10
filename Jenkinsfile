pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('Checkout') {
      steps {
        sh 'git clone https://github.com/JimmyPun610/AspNetCoreMVCTemplate.git'
        echo 'Clone source complete'
      }
    }

  }
}
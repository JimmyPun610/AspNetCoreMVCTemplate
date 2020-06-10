pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('Checkout') {
      steps {
        sh 'git clone "git@https://github.com/JimmyPun610/AspNetCoreMVCTemplate.git"'
        echo 'Clone source complete'
      }
    }

  }
}
pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('Create Docker') {
      steps {
        sh 'sudo -u opc'
        sh 'sudo docker run --name microsoft/aspnetcore -d -p 8810:8810 aspnetcore:latest'
      }
    }

  }
}
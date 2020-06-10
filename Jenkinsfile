pipeline {
  agent none
  stages {
    stage('Create Docker') {
      steps {
        sh 'sudo docker run --name microsoft/aspnetcore -d -p 8810:8810 aspnetcore:latest'
      }
    }

  }
}
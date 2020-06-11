pipeline {
  agent {
    docker {
      image 'microsoft/aspnetcore:latest'
    }

  }
  stages {
    stage('Checkout') {
      steps {
        git(url: 'https://github.com/JimmyPun610/AspNetCoreMVCTemplate.git', branch: 'master', changelog: true, poll: true)
        sh 'dotnet --version'
      }
    }

  }
}
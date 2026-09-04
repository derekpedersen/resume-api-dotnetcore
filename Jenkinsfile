pipeline {
    agent {
        label 'build-dotnetcore-stable'
    }

    options {
        skipDefaultCheckout true
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                sh 'make build'
            }
        }

        stage('Test') {
            steps {
                sh 'make test'
            }
        }

        stage('Docker') {
            steps {
                sh 'make docker'
            }
        }

        stage('Publish') {
            when {
                branch 'main'
            }
            steps {
                withDockerRegistry([credentialsId: 'docker-jenkins-pat', url: "https://index.docker.io/v1/"]) {
                    sh 'make publish-docker'
                }
            }
        }

        stage('Deploy') {
            when {
                branch 'main'
            }
            steps {
                sh '''
                    make set-version
                    make deploy
                '''
            }
        }
    }
}
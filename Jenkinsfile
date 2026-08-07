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
                branch 'master'
            }
            steps {
                withCredentials([
                    string(credentialsId: 'GCLOUD_PROJECT_ID', variable: 'GCLOUD_PROJECT_ID')
                ]) {
                    sh 'make publish'
                }
            }
        }

        stage('Deploy') {
            when {
                branch 'master'
            }
            steps {
                withCredentials([
                    string(credentialsId: 'GCLOUD_PROJECT_ID', variable: 'GCLOUD_PROJECT_ID')
                ]) {
                    sh '''
                        make set-version
                        make deploy
                    '''
                }
            }
        }
    }
}
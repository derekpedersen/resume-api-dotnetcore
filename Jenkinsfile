pipeline {
    agent {
        label 'build-dotnetcore-stable'
    }
    options {
        skipDefaultCheckout true
    }
    stages {
        stage('Checkout') {
            steps{
                dir('/root/workspace/resume-api-dotnetcore') {
                    checkout scm
                }
            }
        }
        stage('Build') {
            steps{
                dir('/root/workspace/resume-api-dotnetcore') {
                    sh 'make build'
                }
            }
        }
        stage('Test') {
            steps{
                dir('/root/workspace/resume-api-dotnetcore') {
                    sh 'make test'
                }
            }
        }
        stage('Docker') {
            steps {
                dir('/root/workspace/resume-api-dotnetcore') {
                    sh 'make docker'
                }
            }
        }
        stage('Publish') {
            when {
                expression { env.BRANCH_NAME == 'master' }
            }
            steps {
                withCredentials([[$class: 'StringBinding', credentialsId: 'GCLOUD_PROJECT_ID', variable: 'GCLOUD_PROJECT_ID']]) {
                    dir('/root/workspace/resume-api-dotnetcore') {
                        sh 'make publish'
                    }
                }
            }
        }
        stage('Deploy') {
            when {
                expression { env.BRANCH_NAME == 'master' }
            }
            steps {
                withCredentials([[$class: 'StringBinding', credentialsId: 'GCLOUD_PROJECT_ID', variable: 'GCLOUD_PROJECT_ID']]) {
                    dir('/root/workspace/resume-api-dotnetcore') {
                        sh 'make set-version'
                        sh 'make deploy'
                    }
                }
            }
        }
    }
}
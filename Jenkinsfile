pipeline {
    agent {
        label 'build-dotnet-core-stable'
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
                        sh 'make deploy'
                    }
                }
            }
        }
    }
    post {
        always {
            withCredentials([[$class: 'StringBinding', credentialsId: 'RESUME_API_COVERALLS_TOKEN', variable: 'COVERALLS_REPO_TOKEN']]) {
                dir('/root/workspace/resume-api-dotnetcore') {
                    step([$class: 'CoberturaPublisher', autoUpdateHealth: false, autoUpdateStability: false, coberturaReportFile: '**/coverage.opencover.xml', failUnhealthy: false, failUnstable: false, maxNumberOfBuilds: 0, onlyStable: false, sourceEncoding: 'ASCII', zoomCoverageChart: false]) 
                    sh '[ -f ./tools/csmacnz.Coveralls ] || dotnet tool install coveralls.net --version 1.0.0 --tool-path tools'
                    sh './tools/csmacnz.Coveralls --opencover -i tests/coverage.opencover.xml --commitBranch $GIT_BRANCH --commitId $GIT_COMMIT --serviceName jenkins'
                }
            }
        }
    }
}
pipeline {
    agent none
    stages {
        stage('Getting nugets') {
            environment {
                HOME = '/tmp'
            }
            agent {
                docker {
                    image 'mono:latest'
                    reuseNode true
                }
            }
            steps {
                sh 'nuget restore Automation.sln'
                sh 'msbuild Automation.sln'
                sh 'mono packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe Automation/bin/Debug/Automation.dll'
                nunit testResultsPattern: 'TestResult.xml'
            }
        }
    }
}

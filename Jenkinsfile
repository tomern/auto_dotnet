pipeline {
    agent none
    stages {
        stage('Getting nugets') {
            environment {
                HOME = '/tmp'
            } 
            agent {
                docker {
                    image 'tomernoy1/mono:3.1'
                    reuseNode true
                }
            }
            steps {
                sh 'nuget restore tomerdotnet.sln'
                sh 'msbuild tomerdotnet.sln'
                sh 'mono packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe tomerdotnet/bin/Debug/tomerdotnet.dll'
            }
        }
        stage('Test') {
            agent {
                docker {
                    image 'tomernoy1/mono:3.1'
                    reuseNode true
                }
            }
            steps {
                sh 'ls tomerdotnet'
                // sh 'ls /var/jenkins_home/workspace/automation_dotnet_master/tomerdotnet'
                // sh 'mono /nunit/nunit3-console.exe /var/jenkins_home/workspace/automation_dotnet_master/bin/Debug/tomerdotnet.dll'
            }  
        }
    }
}
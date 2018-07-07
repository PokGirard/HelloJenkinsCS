// @Library("myLib") _
pipeline {
    agent any
    stages {
        stage('Example Build perso') {
            steps {
                echo 'Hello, build'
                bat 'dir'
                library 'myLib'
                int ui =  globalVars.a;
               
            }
        }
        stage('Example Test perso') {
          
            steps {
                echo 'Hello, session de test'
               
            }
        }
    }


}


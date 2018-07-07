 @Library("myLib") _
pipeline {
    agent any
    stages {
        stage('Example Build perso') {
            steps {
                echo 'Hello, build'
                bat 'dir'
             //   library 'myLib'
               globalVars.display();
               
            }
        }
        stage('Example Test perso') {
          
            steps {
                echo 'Hello, session de test'
               
            }
        }
    }


}


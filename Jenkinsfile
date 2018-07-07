 @Library("myLib") _
pipeline {
    agent any
    stages {
        stage('Example Build perso') {
            steps {
                echo 'Hello, build'
                bat 'dir'
             script {
              def huitre = 4;
              println('test');
             //  globalVars.display();
             }
            }
        }
        stage('Example Test perso') {
          
            steps {
                echo 'Hello, session de test'
               
            }
        }
    }


}


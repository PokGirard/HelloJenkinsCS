def traitement(String s) {
    echo s;
}


def bonjour() {
// @Library("libPerso") _
    traitement();
}

pipeline {
    agent any
    stages {
        stage('Example Build perso') {
            steps {
                echo 'Hello, build'
                bat 'dir'
               
            }
        }
        stage('Example Test perso') {
          
            steps {
                echo 'Hello, session de test'
                bonjour();
            }
        }
    }


}


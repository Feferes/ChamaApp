# Tarefa: Sistema de cadastro de cursos

## Testes
Foi criado um arquivo que deve ser importado no Postman, com ele é possivel fazer um post pra cadastro de aluno. 
É necessário que baixe a solução e rode no visual studio.

## Desenvolvimento
Eu utilizei o código base disponivel visando não perder muito tempo, porém, o processo de aprendizado sobre o pattern Mediator tomou um tempo. 
Procurei focar na separação do código (organização) e implementação do pattern. Eu não terminei todas implementações justamente pelo tempo.

### Distribuição
Na pasta Infra se encontra os repositórios, ali podemos implementar qualquer lógica para armazenamento das informações, visando somente rodar, é adicionadod numa lista em memória mesmo.

### Service worker
Eu também investi um tempo para estudar sobre service worker. A idéia era implementar dentro do CoursesHandle. Alí eu faria o envio pro worker pra ele "garantir"
que o cadastro do aluno só seria feito se houvesse vagas disponíveis.

### Pendencias
Eu não cheguei a pensar em alguma solução para a tarefa de relatorio para resolver a analise das idades dos alunos.
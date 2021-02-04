# Assignment: Course Sign-up System

## Evaluation

A tarefa foi projetada para verificar suas habilidades de codificação e resolução de problemas. É intencionalmente grande demais. Sugerimos que você gaste no máximo 4 horas nele, portanto, você precisa decidir quais componentes do sistema codificará e quais simulará. Por exemplo, estamos mais interessados no projeto de modelo de Arquitetura e Domínio do que na configuração do Swagger ou na implementação do repositório Mongo.

Você pode usar o esqueleto da solução deste repositório.

Envie-nos um link para o seu repositório git. Caso você tenha um repositório privado, compartilhe-o com os e-mails enviados a você junto com esta tarefa. O repositório deve conter código e arquivo README.md no diretório raiz.

O que avaliamos no código:
- Projeto de modelo de domínio (uso de conceitos DDD: agregados, objetos de valor, serviços de domínio, etc)
- Mensagens (Comandos e Eventos)
- Organização do código (modularidade, dependências entre módulos, etc)
- Tratamento e registro de exceções
- Redação e organização de testes
- Programação assíncrona baseada em tarefas

O que esperamos ver no README:
- Visão geral da arquitetura (conhecimento de serviços distribuídos, plataformas em nuvem)
- Explicação de soluções para ambas as partes
- Estratégia de teste para esta solução (o que testar)
- Quais ferramentas e tecnologias você usou (bibliotecas, estrutura, ferramentas, tipos de armazenamento, recursos da plataforma em nuvem)
- O que você acha que pode ser melhorado e como
- Qualquer coisa que você achar útil colocar aqui

## Case description

Você começa a trabalhar na Chama Online University, que oferece cursos online.
Para cada um dos cursos, há um professor, e para cada um dos cursos há um número máximo de alunos que podem participar.
Para se inscrever, os alunos precisam fornecer seu e-mail, nome e data de nascimento.

### Part 1: Massive growth

São muitos cursos e milhões de inscrições.

Crie uma lógica que inscreverá alunos em um curso.
Se um curso estiver cheio, não será mais possível se inscrever (mesmo com solicitações simultâneas).

Crie uma instalação bombástica que difira o processamento real para um
processo de trabalho: a inscrição é processada de forma assíncrona por meio de um barramento de mensagem. O trabalhador tenta inscrever o aluno e notifica-o se a inscrição foi bem-sucedida ou não.

### Part 2: Aggregating & Querying data

Para efeito de análise, a empresa precisa saber a idade mínima, máxima e média dos alunos de todos os cursos.
Considere que isso precisa continuar funcionando de forma eficiente quando há milhões
de inscrições por dia. Calcular essa estatística a cada solicitação não é viável.

## FAQ

Tenho que completar a tarefa em 4 horas?
- Não, preferimos que você use 4 horas para propor uma implementação aproximada e descrever como continuar. Se você quiser gastar mais tempo, tudo bem, mas esteja ciente de que seremos mais rígidos ao avaliar sua tarefa. Tente equilibrar os dois mundos.

Devo usar a estrutura de código fornecida?
- Não, configuramos assim porque alguns candidatos preferem, mas não é obrigatório.

Eu tenho que implementar tudo de cima para baixo?
- Não necessariamente, conforme mencionado neste arquivo, você precisa descobrir o que implementar e o que simular (bons candidatos para simular são o serviço de e-mail e o barramento de mensagens).## Tips n' Tricks:

### At Chama we like the following:
- Micro Services
- DDD
- High skills evaluating concurrency
- Mediator

### At Chama, we use the following:
- Azure (try to show some skills there)
- CosmosDb, SQL Server and some Table Storage
- Docker
- Kubernetes
- Service Fabric
- Lots of Asynchronous Messaging
- Serverless (Azure Functions)

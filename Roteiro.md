# Slide 1

**Título: Conhecendo o Projeto do Curso**

- **Contexto**: Vamos conhecer o projeto do curso?
- **Problema**: Como ele está organizado/estruturado?
- **Solução**: Desenhar na tela mostrando as várias partes do projeto: HTML, controladores, acesso ao banco de dados, conceitos e regras do domínio.
- **Teoria**: Essa apresentação sucinta sobre o projeto foi uma descrição de sua arquitetura de software. O que é? Uma arquitetura de software tem por objetivo indicar as partes do código, como elas se comunicam e que princípios devemos seguir para que estas partes se mantenham coesas e coerentes.

---

# Slide 2

**Título: Implementando Restrições de Idade para Clientes**

- **Contexto**: Agora que você assumiu a evolução deste projeto, vamos supor que precisa implementar uma mudança, que é garantir que somente clientes acima de 18 anos sejam registrados.
- **Problema**: Que partes do código você precisará alterar/incluir?
- **Solução**: Como estamos trabalhando em uma estrutura MVC, o código onde acontece o registro de clientes fica aqui neste método no controlador RegistroController e é ali que colocaríamos a restrição de idade. Mas pra saber a idade das pessoas, falta incluir um campo com o nascimento ou a própria idade no tipo que representa o corpo da requisição de entrada. Mostrar o oposto: criar código em outra classe com outras orientações e refletir como isso pode confundir novos membros e novas demandas.
- **Teoria**: Saber onde, como e o que fazer é um dos benefícios de uma arquitetura bem definida. Sua evolução é mais fluída, mais harmônica. Além da facilidade para desenvolver, outros benefícios são facilidade para manter, testar, publicar/deployar. O principal objetivo de uma arquitetura é garantir o sucesso do projeto!

---

# Slide 3

**Título: Elaborando uma API para Exposição de Dados**

- **Contexto**: Queremos criar outro projeto, o de uma API que irá expor dados referentes ao projeto do curso.
- **Problema**: Como você organizaria o projeto? Quais seriam suas partes? Como elas se comunicariam?
- **Solução**: Se formos utilizar os modelos padrões do .NET, temos algumas opções. Contudo, é importante estabelecer algumas diretrizes para projetos que você vai manter; escolher tópicos como segurança, persistência, qualidade, legibilidade, dentre outros.
- **Teoria**: Acabamos de elaborar uma proposta de arquitetura de software. Mas porque estou falando disso? Porque o assunto do curso é uma proposta de arquitetura, que se tornou popular. Ela se chama Clean Architecture e tem partes e princípios bem claros, que vão ajudar na construção de seus futuros projetos e também diminuir a curva de aprendizado em projetos existentes.

---



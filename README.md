💻 Linguagem de Programação (LPR)

Curso Técnico em Desenvolvimento de Sistemas — Games
ETE FMC · Rede Jesuíta de Educação

📚 Sobre o repositório

Este repositório reúne as resoluções dos exercícios de cada aula da disciplina de Linguagem de Programação, ministrada pelo Prof. José Andery. Os códigos são escritos em C# e C++, alternando entre as duas linguagens para
praticar a mesma lógica em ambientes diferentes.

A disciplina segue uma progressão didática: primeiro entendemos como o computador funciona, depois aprendemos a pensar e escrever algoritmos, em seguida dominamos o controle de fluxo (decisões e repetições), organizamos 
o código em funções, guardamos dados em estruturas cada vez mais completas e, por fim, modelamos o sistema inteiro com objetos.

🗺️ Visão geral das aulas

- Aula 01: 🖥️ Revisão de conceitos básicos da computação (Como o computador, os algoritmos e as linguagens funcionam)
- Aula 02: 🧠 Introdução à lógica de programação (Tipos, variáveis, operadores, entrada e saída)
- Aula 03: 🐙 GitHub e controle de versionamento (Git, repositórios, commits, branches)
- Aula 04: 🔀 Estruturas de seleção (`if / else` e `switch`)
- Aula 05: 🔁 Estruturas de repetição (`while`, `do while` e `for`)
- Aula 06: 🧩 Funções (Modularização, escopo, retorno e parâmetros)
- Aula 07: 📦 Vetores e matrizes (Variáveis compostas homogêneas)
- Aula 08: 🗂️ Registros (Structs) (Variáveis compostas heterogêneas)
- Aula 09: 📋 Listas e dicionários (Estruturas de dados dinâmicas)
- Aula 10: 🏗️ Programação Orientada a Objetos (Classes, objetos, construtores, get/set e relacionamentos)


📖 Conteúdo detalhado de cada aula

🖥️ Aula 01 — Revisão de conceitos básicos da computação
Objetivo: nivelar a turma em relação aos termos e conceitos essenciais da computação.

O que foi apresentado

A aula começou pelo computador: um sistema com entrada (mouse, teclado, microfone), processamento (CPU) e saída (monitor, som, impressora). Foram diferenciadas as memórias: a principal (RAM), rápida e volátil, que funciona como memória de trabalho, e a auxiliar (HD, SSD, pen drive), maior e não volátil. A CPU foi dividida em Unidade de Controle (interpreta as instruções), Registradores (guardam instruções e valores intermediários) e Unidade Lógico-Aritmética (executa as operações).

Em seguida, a ideia central: um programa transforma uma informação A em uma informação B, e a lógica está no programador, não no computador. Daí vieram os conceitos de:

- Lógica: a arte de organizar o pensamento para tomar decisões racionais.
- Algoritmo: sequência finita de passos para atingir um objetivo (como uma receita de bolo).
- Pseudocódigo: forma de escrever o algoritmo em linguagem simples e estruturada (SE, ENQUANTO, FAÇA).
- Linguagem de programação: o meio de traduzir o algoritmo para algo que o computador entende. Esse processo é a codificação, e o resultado é o programa.
- Sintaxe × semântica: a sintaxe é a forma de escrever (regras da linguagem), a semântica é o significado (o objetivo do sistema).
- Alto × baixo nível: quanto mais próxima da linguagem humana, mais "alto nível" é a linguagem.

Foram apresentadas as três linguagens do contexto do curso: C (1972, sistemas operacionais), C++ (1979, multiparadigma, versátil e usada em sistemas embarcados) e C# (2000, Microsoft, muito usada no desenvolvimento de jogos).

O que foi abordado

- Paradigmas de programação (a maneira de resolver um problema) e sua evolução: linguagem de máquina → programação estruturada → modular/funcional → orientada a objetos.
- Compilador × interpretador: o compilador traduz tudo antes de executar (execução mais rápida, erros detectados antes); o interpretador executa linha a linha (começa na hora, mas é mais lento).
- IDE: ambiente que reúne editor, compilador/interpretador e depurador.

Na prática: configuração do VS Code e o primeiro "Hello World" em C++ e em C#, além de exercícios de nivelamento no BeeCrowd.


🧠 Aula 02 — Introdução à lógica de programação

Objetivo: revisar tipos de dados, constantes e variáveis, expressões aritméticas e lógicas, e comandos de atribuição, entrada e saída.

O que foi apresentado

Para manipular informação, o programa precisa guardá-la. A aula usou a analogia de um armário (a memória) com caixas etiquetadas (as variáveis), cada uma guardando um tipo de coisa. Um tipo de dado define quais valores uma variável aceita, quais operações são possíveis e quanto de memória ocupa.

- Tipos primitivos: `int` (inteiros), `float` e `double` (números com parte fracionária, com precisões diferentes), `bool` (verdadeiro/falso), `char` (um caractere) e `string` (sequência de caracteres).
- Tipos compostos: vetores, listas, matrizes, dicionários, registros etc. (assunto das próximas aulas).
- Tipagem estática (forte) × dinâmica (fraca). C# e C++ são estaticamente tipadas.
- Diferença entre ASCII (8 bits, só inglês) e Unicode (milhões de caracteres, usado no `char` do C#).

Constantes e variáveis: constante não muda durante a execução (`const`), variável pode mudar. Foram apresentadas as regras de nomeação (não começar com número, sem acentos nem espaços) e a boa prática de usar nomes autoexplicativos (`idadeJose` em vez de `x`).

O que foi abordado

- Expressões aritméticas: `+ - * / %`, a prioridade dos operadores (`* / %` antes de `+ -`) e os operadores de atribuição (`++`, `--`, `+=`, `-=`, `*=`, `/=`).
- Expressões lógicas: relacionais (`> < >= <= == !=`) e lógicos (`&&`, `||`, `!`), com prioridade `!` → `&&` → `||`.
- Saída de dados: `Console.WriteLine`/`Write` (C#) e `cout` (C++), controle de casas decimais (`ToString("F2")` e `setprecision`) e formas de juntar texto e variáveis (placeholder, interpolação, concatenação).
- Entrada de dados: em C# toda entrada é `string`, então é preciso converter com `Parse` (e `Split` para várias entradas na mesma linha); em C++ o `cin` reconhece o tipo automaticamente, e o `getline` lê frases com espaços.

Exercícios: área de um círculo, diferença de produtos, cálculo de salário e valor de peças a pagar.


🐙 Aula 03 — GitHub e controle de versionamento

Objetivo: entender o controle de versionamento, o sistema Git e a plataforma GitHub, e criar repositórios locais e remotos.

O que foi apresentado

Controle de versionamento é o gerenciamento das alterações feitas nos arquivos ao longo do tempo, mantendo um histórico detalhado. Suas vantagens: rastrear alterações e bugs, recuperar versões anteriores, trabalhar em equipe sem conflitos e testar novidades em ramificações sem afetar o projeto principal.

Um ponto-chave: Git ≠ GitHub. O Git é o software que controla as versões; o GitHub é a plataforma que hospeda repositórios Git.

Conceitos abordados

- Repositório: diretório com todos os arquivos do projeto (código, imagens, documentação e o README).
- Branch: linha de desenvolvimento independente, uma cópia que permite criar funcionalidades sem mexer na principal. Tipos comuns: `main`, `develop`, `feature`, `release` e `hotfix`.
- Commit: registro das mudanças, com um identificador único (hash) e uma mensagem descritiva.
- Merge: união das alterações de duas branches (podendo gerar conflitos).
- Repositório local × remoto: o local está no computador do desenvolvedor; o remoto fica no servidor (GitHub) e funciona também como backup.
- Comandos principais: `clone`, `add`, `commit`, `push` e `pull`.
- Recursos do GitHub: repositórios, *Issues*, *Pull Requests* e README escrito em Markdown.

Na prática: instalar o Git, criar a conta no GitHub, configurar usuário e e-mail (`git config`), criar um projeto "Hello GitHub", inicializar o repositório pelo VS Code, fazer o primeiro commit e publicar o repositório no GitHub.

Desafios: (1) clonar o repositório de exemplo, alterá-lo e publicá-lo na própria conta; (2) em dupla, clonar o repositório do colega, alterar o código, dar `commit` e `push` e abrir um Pull Request, que o colega aceita pelo navegador.

🔀 Aula 04 — Estruturas de seleção

Objetivo: exercitar as lógicas de `if` e `switch`.

O que foi apresentado

Estruturas de seleção permitem escolher quais ações executar conforme uma condição seja ou não satisfeita. A condição é sempre uma expressão lógica, que resulta em verdadeiro ou falso. É assim que o programa toma decisões e se adapta a situações diferentes.

O que foi abordado

- Seleção simples (`if`): executa um bloco se a condição for verdadeira; se for falsa, nada acontece.
- Seleção composta (`if / else`): um bloco para o verdadeiro e outro para o falso. Apenas um dos dois é executado.
- Seleção encadeada: várias condições verificadas em sequência; o primeiro bloco com condição verdadeira é executado e as demais são ignoradas.
  - Homogênea contínua: `if / else if / else`, usada para faixas de valores (ex.: temperatura > 10, > 5, > 2).
  - Homogênea discreta: `switch / case / default`, usada para valores específicos (ex.: dia da semana 1, 2, 3).
  - Heterogênea: cada condição avalia variáveis de tipos diferentes (ex.: um número e depois um texto).
- Bloco padrão (`else` / `default`): executado quando nenhuma condição é atingida.

Exemplo trabalhado: ler o preço e o código de origem de um produto e exibir a região de procedência com `switch`, tratando códigos desconhecidos como "importado".

Exercícios:
1. (C#) Dizer se um número inteiro é par ou ímpar.
2. (C++) Verificar se dois números são múltiplos entre si, em qualquer ordem.
3. (C#) Mini-sistema de RPG: o jogador escolhe uma classe (Guerreira, Mago, Arqueira) e o programa exibe suas habilidades especiais.

🔁 Aula 05 — Estruturas de repetição

Objetivo: exercitar `while`, `do while` e `for`.

O que foi apresentado

Repetições são usadas quando o mesmo trecho de código precisa ser executado várias vezes enquanto uma condição for verdadeira (ex.: calcular a média de vários alunos). O trecho repetido é o loop (ou laço), e cada repetição é uma iteração.

O que foi abordado

- `while` (enquanto): testa a condição antes de executar (pré-condição). Pode executar zero vezes se a condição já começar falsa.
- `do while` (repita): testa a condição depois (pós-condição). Executa pelo menos uma vez, sempre.
- `for` (para): repetição contada, com inicialização, condição de continuação e atualização em uma única linha. O contador é interno. Características: a variável de controle nem sempre atinge o valor final (depende do passo) e o passo pode ser positivo ou negativo.
- Comparativo: o `while` verifica no início, executa no mínimo 0 vezes e usa contador externo; o `do while` verifica no fim, executa no mínimo 1 vez e usa contador externo; o `for` tem condição interna e contador interno.
- Contador × acumulador: o contador conta quantas iterações ocorreram (sempre +1); o acumulador soma valores que podem variar a cada volta.

Exemplo trabalhado: ler valores inteiros positivos até o usuário digitar `-1`, descobrindo o menor, o maior e a média.

Exercícios: média de números pares informados (while), jogo de adivinhação de número aleatório de 1 a 100 com contagem de tentativas (do while), soma dos ímpares múltiplos de 3 entre 50 e 500 (for), soma dos dígitos do quadrado de um número e a simulação do treinamento de um Jedi (nestes dois, escolher a melhor estrutura).


🧩 Aula 06 — Funções

Objetivo: apresentar o paradigma funcional como forma de programar de maneira mais eficiente.

O que foi apresentado

A aula retomou a evolução dos paradigmas: da programação estruturada (uma sequência de comandos) para a modular/funcional, que percebe que algumas etapas se repetem e podem ser reutilizadas. Uma função é um trecho de código independente, que executa uma única tarefa bem definida e só roda quando é chamado. Ao chamá-la, o fluxo de execução desvia para a função e, ao terminar, volta ao ponto seguinte à chamada.

O que foi abordado

- Decomposição de problemas (top-down): quebrar um problema complexo em vários problemas simples, cada um resolvido por uma função.
- Vantagens: modularização, reutilização de código e facilidade de teste e depuração.
- Função `main`: ponto de entrada do programa, que chama as demais. Em C++, a função precisa ser declarada antes de ser chamada.
- Escopo de variáveis: locais (existem só dentro do bloco onde foram declaradas) e globais (acessíveis em toda a aplicação; em C# precisam de `static`).
- Retorno: funções de ação (`void`, não devolvem nada) e de resultado (`return`, devolvem um valor compatível com a variável que o recebe).
- Parâmetros:
  - Passagem por valor: a função recebe uma cópia.
  - Passagem por referência: a função recebe o endereço e altera a variável original (`ref` em C#, `&` em C++).
  - Funções genéricas: quanto mais parametrizada, mais reutilizável (ex.: uma função de potência com base e expoente).
  - Parâmetros opcionais: com valor padrão, sempre ao final da lista.
  - Parâmetros nomeados: chamar os argumentos fora de ordem pelo nome (apenas em C#).

Exercícios: função que devolve o reverso de um número (C++); menu que agrupa exercícios de repetição antigos, cada um em sua função (C++); sistema de seleção de heróis da Marvel com funções de cadastro, seleção de equipe, pontuação e menu (C#).


📦 Aula 07 — Variáveis compostas homogêneas: vetores e matrizes

Objetivo: apresentar vetores e matrizes como forma de organizar e representar dados.

O que foi apresentado

Os tipos primitivos não bastam para representar informações como uma lista de nomes ou uma tabela. Por isso existem os tipos construídos, formados pela composição de tipos primitivos: as estruturas de dados. As variáveis compostas homogêneas guardam vários valores do mesmo tipo.

O que foi abordado

Vetores (unidimensionais)
- Analogia do prédio: cada andar é um elemento, acessado pelo índice (que começa em 0).
- Características: homogêneo, ordenado, de tamanho fixo. Vantagem: acesso imediato pelo índice. Desvantagens: tamanho predeterminado e dificuldade de inserir e remover.
- C#: `int[]`, `Length`, laços `for` e `foreach`, e métodos como `Array.Sort`, `Reverse`, `IndexOf`, `Resize` e `Find`.
- C++: vetores simples e `vector<T>` (`size()`), além das funções `sort`, `reverse`, `find`, `binary_search` e `accumulate`.

Matrizes (multidimensionais)
- Estrutura em linhas e colunas, acessada por dois índices (o número de índices é igual ao número de dimensões).
- Mesmas características e limitações do vetor.
- C#: `int[,]` e `GetLength(dimensão)` para percorrer com `for` aninhado.

Exemplo trabalhado: média aritmética de 3 alturas lidas do usuário.

Exercícios: maior valor de um vetor e sua posição, separar números pares e ímpares, pesquisar um número e contar ocorrências, análise de notas de uma turma com classificação (aprovado, recuperação, reprovado), soma de uma matriz 3x3, consulta de distância entre cidades em uma matriz e operações entre matrizes.


🗂️ Aula 08 — Variáveis compostas heterogêneas: registros (Structs)

Objetivo: compreender e utilizar registros (*structs*) para representar entidades compostas por diferentes tipos de dados.

O que foi apresentado

Enquanto vetores e matrizes guardam dados do mesmo tipo, as variáveis compostas heterogêneas (structs, listas e dicionários) reúnem tipos diferentes. Uma struct agrupa vários tipos de variável sob um mesmo nome; essas variáveis são os membros ou campos. Ela é útil para representar um único conceito com várias características. O exemplo da aula foi uma passagem de ônibus: o registro "passagem" tem origem (`string`), poltrona (`int`) e total (`double`).

Vantagens das structs
- Organização dos dados: em vez de várias variáveis soltas, tudo fica sob uma única entidade.
- Facilidade de acesso: os campos são acessados com o operador ponto (`.`).
- Modularidade: a struct é definida uma vez e reutilizada em todo o programa.

O que foi abordado
- C#: `public struct Aluno { public string Nome; public int Idade; ... }`, declarada fora do `Main`. Instanciação com `Aluno a1;` e também com `new Aluno { Nome = "...", ... }`.
- C++: `struct Aluno { ... };`, declarada fora do `main`, com a inicialização direta `Aluno a1 = {"Mosca", 99, "34DS"};`.
- Vetor de structs: como combinar com a aula anterior para guardar vários registros.

Exemplo trabalhado: guardar os dados de 5 alunos da turma 34DS e calcular a média das idades (em C# com `foreach`, em C++ com `array` e `for`).

Exercícios: `Filme` (3 filmes e o mais antigo), `Produto` (valor total em estoque), `Livro` (preço total e média de páginas), sistema de heróis da Marvel com structs e menu (C#) e controle de chamados de uma empresa com status, prioridade e estatísticas.

📋 Aula 09 — Estruturas de dados avançadas: listas e dicionários

Objetivo: explorar os tipos de dados lista e dicionário, seus métodos e funcionalidades.

O que foi apresentado

A aula partiu de uma pergunta: e se o vetor tem tamanho fixo e é difícil inserir e remover elementos? A resposta é a lista, que resolve essas desvantagens sem perder a vantagem do acesso por posição.

Listas
- Uma lista é um vetor dinâmico. Analogia da caça ao tesouro: cada elemento indica onde está o próximo, então mudar a disposição não quebra o encadeamento lógico.
- Pode começar vazia e crescer sob demanda; guarda elementos do mesmo tipo (que podem ser `int`, `string`, struct, vetor ou até outra lista).
- Vantagens: tamanho variável, fácil inserir e remover, vários métodos prontos.
- Manipulação em C# (`List<T>`): `Add`, `AddRange`, `Insert`, `Remove`, `RemoveAt`, acesso por índice, `foreach`/`for`, `Contains`, `IndexOf`, `Count` (propriedade), `Sort` e `Reverse`.
- Em C++: a mesma ideia com a biblioteca de listas e iteradores para inserir e buscar.

Dicionários
- Estrutura de pares chave-valor: em vez de acessar por índice numérico, usa chaves únicas (ex.: `"Canetas" → 50`).
- Vantagens: organização semântica (chaves descritivas deixam o código mais legível) e flexibilidade para adicionar, alterar e remover. Desvantagem: consome mais memória, pois guarda também as chaves.
- C#: `Dictionary<string, int>`, adição com `Add` ou pelo indexador.

Tipos `var` e `auto`
- `var` (C#) e `auto` (C++) fazem o compilador deduzir o tipo da variável a partir do valor inicial. O uso mais comum é em laços `foreach`/`for`.

Exercícios (8): notas em lista (maior, menor e média); nomes organizados em linhas por tamanho; 100 números aleatórios ordenados, sem os pares e com os repetidos; campeonato de pilotos com struct e lista (ranking, média e melhor equipe); jogos e gêneros em dicionário; idades e populações em dicionário (acima da média, maior, menor e remoção); e um acervo de livros usando dicionário com struct.


🏗️ Aula 10 — Programação Orientada a Objetos (POO)

Objetivo: apresentar a introdução e a implementação inicial da Programação Orientada a Objetos.

O que foi apresentado

O desenvolvimento de software começou com a programação procedural, mas, com o tempo, os sistemas ficaram muito complexos. A POO surge como paradigma que organiza o programa em objetos, reunindo dados e comportamentos. A diferença em relação ao procedural está na organização: o procedural foca nos processos (criar conta, retirar dinheiro); a POO foca em mapear os agentes e seus relacionamentos (cliente, banco, produto). Essa junção de dados e comportamento é o encapsulamento.

Vantagens da POO: reuso de código, coesão das responsabilidades (cada classe é especialista), acoplamento (colaboração entre classes) e manutenção, substituição e extensão mais fáceis.

O que foi abordado

- Objeto: uma instância que representa algo do mundo real, com atributos (características que definem o estado) e métodos (ações). Ex.: a calculadora do José tem cor, teclas e visor, e sabe somar e multiplicar.
- Classe: o tipo que serve de molde. O objeto é uma instância da classe, com seus próprios valores. Pode representar entidades, serviços, controladores, utilitários etc. Uma analogia usada foi "structs com funções", mas com muito mais recursos (encapsulamento, abstração, herança e polimorfismo, que virão adiante).
- Classes em C#: declaração, atributos, métodos e instanciação com `new`.
- Exemplo trabalhado: comparar a área de dois triângulos sem POO (cálculo repetido) e com POO (a classe `Triangulo` sabe calcular a própria área), mostrando o reaproveitamento de código e a delegação de responsabilidades.
- Modificadores da classe: `public`, `internal`, `static`, e adiantados `abstract` e `sealed`.
- Especificadores de acesso: `public`, `private`, `protected` e `static` (membros acessados direto pela classe, como `Math.Sqrt`).
- Método construtor: inicializa o objeto na criação, com o mesmo nome da classe.
- Get e Set: atributos passam a ser privados; o *getter* permite a leitura controlada e o *setter* permite a modificação com validações, garantindo a consistência do estado.
- Relacionamento entre classes: associação, agregação, composição e herança, além das cardinalidades (1x1, 1xN e NxN) implementadas com referências e listas.

Exercícios (8): `Retangulo` (área e perímetro); `Funcionario` com imposto e aumento salarial; `Aluno` com média e prova final; diagrama de classes do jogo favorito com 3 classes implementadas; `Produto` e `Pedido`; `Cliente` e `Reserva` (1xN); `Livro` e `Biblioteca`; e `Aluno`, `Turma` e `Matricula` (NxN).


📁 Estrutura do repositório

📦 LPR
 ┣ 📂 Aula2   ← Lógica de programação
 ┣ 📂 Aula3   ← Git e GitHub
 ┣ 📂 Aula4   ← Estruturas de seleção
 ┣ 📂 Aula5   ← Estruturas de repetição
 ┣ 📂 Aula6   ← Funções
 ┣ 📂 Aula7   ← Vetores e matrizes
 ┣ 📂 Aula8   ← Structs
 ┣ 📂 Aula9   ← Listas e dicionários
 ┣ 📂 Aula10  ← POO
 ┗ 📄 README.md

🎯 Resumo do que foi aprendido

- ✅ Como o computador, os algoritmos e as linguagens funcionam
- ✅ Variáveis, tipos de dados, operadores, entrada e saída
- ✅ Versionamento de código com Git e GitHub
- ✅ Tomada de decisão com `if / else` e `switch`
- ✅ Repetição com `while`, `do while` e `for`
- ✅ Modularização com funções, escopo e parâmetros
- ✅ Armazenamento de dados com vetores, matrizes, structs, listas e dicionários
- ✅ Modelagem de sistemas com classes, objetos e relacionamentos (POO)


👨‍🏫 Professor
José Andery · 📧 jose.andery@etefmc.com.br

🙋 Autor
Luiz Henrique Schmidt Silva · Turma 34DS

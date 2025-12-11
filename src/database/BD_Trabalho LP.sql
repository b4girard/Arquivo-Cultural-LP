CREATE DATABASE IF NOT EXISTS REGISTRADOR_FILMES_LIVROS_LP;
USE REGISTRADOR_FILMES_LIVROS_LP;

-- Tabela de usuários
CREATE TABLE usuario (
  ID_usuario INT NOT NULL AUTO_INCREMENT,
  Usuario VARCHAR(100) NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  E_mail VARCHAR(100) NOT NULL UNIQUE,
  Senha VARCHAR(255) NOT NULL,
  Tipo_usuario ENUM('usuario', 'administrador') NOT NULL DEFAULT 'usuario',
  PRIMARY KEY (ID_usuario)
);

-- Tabela de livros
CREATE TABLE livro (
  ID_Livro INT NOT NULL AUTO_INCREMENT,
  ISBN VARCHAR(20) NOT NULL,
  Titulo VARCHAR(150) NOT NULL,
  Autor VARCHAR(100) NOT NULL,
  Descricao VARCHAR(9999) NOT NULL,
  Idioma VARCHAR(50) NOT NULL,
  Editora VARCHAR(100),
  N_Paginas INT,
  Capa VARCHAR(255),
  PRIMARY KEY (ID_Livro)
);

-- Tabela de sugestões de livros
CREATE TABLE sugestaolivro (
  ID_Livro INT NOT NULL AUTO_INCREMENT,
  ISBN VARCHAR(20) NOT NULL,
  Titulo VARCHAR(150) NOT NULL,
  Autor VARCHAR(100) NOT NULL,
  Descricao VARCHAR(9999) NOT NULL,
  Idioma VARCHAR(50) NOT NULL,
  Editora VARCHAR(100),
  N_Paginas INT,
  Capa VARCHAR(255),
  Status ENUM('validado', 'não validado') NOT NULL DEFAULT 'não validado',
  ID_usuario INT NOT NULL,
  PRIMARY KEY (ID_Livro)
);
ALTER TABLE sugestaolivro
ADD CONSTRAINT fk_usuario_livro
FOREIGN KEY (ID_usuario) REFERENCES usuario(ID_usuario)
ON DELETE CASCADE ON UPDATE CASCADE;

-- Tabela de filmes
CREATE TABLE filme (
  ID_filme INT NOT NULL AUTO_INCREMENT,
  IMDb_ID VARCHAR(20) NOT NULL,
  Titulo VARCHAR(150) NOT NULL,
  Diretor VARCHAR(100) NOT NULL,
  Descricao VARCHAR(9999) NOT NULL,
  Idioma_original VARCHAR(50) NOT NULL,
  Ano_de_lancamento INT,
  Poster VARCHAR(255),
  PRIMARY KEY (ID_filme)
);

-- Tabela de sugestões de filmes
CREATE TABLE sugestaofilme (
  ID_filme INT NOT NULL AUTO_INCREMENT,
  IMDb_ID VARCHAR(20) NOT NULL,
  Titulo VARCHAR(150) NOT NULL,
  Diretor VARCHAR(100) NOT NULL,
  Descricao VARCHAR(9999) NOT NULL,
  Idioma_original VARCHAR(50) NOT NULL,
  Ano_de_lancamento INT,
  Poster VARCHAR(255),
  Status ENUM('validado', 'não validado') NOT NULL DEFAULT 'não validado',
  ID_usuario INT NOT NULL,
  PRIMARY KEY (ID_filme)
);
ALTER TABLE sugestaofilme
ADD CONSTRAINT fk_usuario_filme
FOREIGN KEY (ID_usuario) REFERENCES usuario(ID_usuario)
ON DELETE CASCADE ON UPDATE CASCADE;

-- Tabela de listas
CREATE TABLE lista (
  ID_lista INT NOT NULL AUTO_INCREMENT,
  ID_usuario INT NOT NULL,
  Nome_lista VARCHAR(100) NOT NULL,
  Descricao TEXT NULL,
  Data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (ID_lista),
  FOREIGN KEY (ID_usuario) REFERENCES usuario(ID_usuario)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- Tabela de relacionamento lista x mídia (livros e filmes)
CREATE TABLE lista_midia (
  ID_lista_midia INT NOT NULL AUTO_INCREMENT,
  ID_lista INT NOT NULL,
  ID_livro INT NULL,
  ID_filme INT NULL,
  PRIMARY KEY (ID_lista_midia),
  FOREIGN KEY (ID_lista) REFERENCES lista(ID_lista)
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (ID_livro) REFERENCES livro(ID_Livro)
    ON DELETE SET NULL ON UPDATE CASCADE,
  FOREIGN KEY (ID_filme) REFERENCES filme(ID_filme)
    ON DELETE SET NULL ON UPDATE CASCADE
);

-- Tabela de avaliações
CREATE TABLE avaliacao (
  ID_avaliacao INT AUTO_INCREMENT PRIMARY KEY,
  ID_usuario INT NOT NULL,
  ID_livro INT NULL,
  ID_filme INT NULL,
  Nota TINYINT NOT NULL,         -- 1 a 5
  Comentario TEXT,
  Data_avaliacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (ID_usuario) REFERENCES usuario(ID_usuario),
  FOREIGN KEY (ID_livro) REFERENCES livro(ID_livro),
  FOREIGN KEY (ID_filme) REFERENCES filme(ID_filme)
);

UPDATE usuario SET Tipo_usuario = "administrador" WHERE ID_usuario = 1;
UPDATE usuario SET Tipo_usuario = "administrador" WHERE ID_usuario = 2;
UPDATE usuario SET Tipo_usuario = "administrador" WHERE ID_usuario = 3;

insert into livro (ISBN, Titulo, Autor, Descricao, Idioma, Editora, N_Paginas, Capa) values
("978-6555323283", "Amêndoas", " Won-pyung Sohn",
"Livro recomendado pelo BTS!
 Eu tenho amêndoas em mim.
 Assim como você.
 Assim como quem você ama e quem odeia.
 Mas ninguém consegue senti-las.
 Você só sabe que elas existem.
 Esta história é, em resumo, sobre um monstro encontrando outro monstro. Um dos monstros sou eu.
 Yunjae nasceu com uma condição neurológica chamada alexitimia, ou a incapacidade de identificar e expressar sentimentos, como medo, 
 tristeza, desejo ou raiva. Ele não tem amigos ― as duas estruturas em forma de amêndoas localizadas no fundo de seu cérebro causaram 
 isso ―, mas a mãe e a avó lhe proporcionam uma vida segura e tranquila. O pequeno apartamento em que moram, acima do sebo da mãe, 
 é decorado com cartazes coloridos com lembretes de quando sorrir, quando agradecer e quando demonstrar preocupação.
 Então, no seu décimo sexto aniversário, véspera de Natal, tudo muda. Um ato chocante de violência destrói tudo que Yunjae conhece, deixando-o sozinho. Lutando para lidar com a perda, o garoto se isola no silêncio, até a chegada do problemático colega de escola Gon.
 Conforme começa a se abrir para novas pessoas, algo se modifica lentamente dentro dele. Quando suas novas amizades passam a apresentar níveis de complexidade, Yunjae precisará aprender a lidar com um mundo que não compreende e até se colocar em risco para sair de sua zona de conforto.
 Livro vencedor do Prêmio Changbi de Ficção para Jovens Adultos e Prêmio Jeju 4.3 Peace Literary.
 'Uma obra de ficção ousada e original que mergulha nas profundezas da condição humana com muito humor.' ― Entertainment Weekly",
 "Português", "Rocco", 288, "imagens_livro/692f8a0d832d3_amendoas.jpg");

insert into livro (ISBN, Titulo, Autor, Descricao, Idioma, Editora, N_Paginas, Capa) values
("978-8535928358",	"Jantar Secreto", "Raphael Montes", 
" Romance com mais de 100 mil exemplares vendidos, Jantar secreto conta a história de um grupo de amigos que se muda para o Rio de Janeiro
 e passa a organizar jantares misteriosos. Do autor da novela “Beleza Fatal”, da Max e criador da série original Netflix Bom dia, Verônica.
 Um grupo de jovens deixa uma pequena cidade no Paraná para viver no Rio de Janeiro. Eles alugam um apartamento em Copacabana e fazem o 
 possível para pagar a faculdade e manter vivos seus sonhos de sucesso na capital fluminense. Mas o dinheiro está curto e o aluguel 
 está vencido. Para sair do buraco e manter o apartamento, os amigos adotam uma estratégia heterodoxa: arrecadar fundos por meio de 
 jantares secretos, divulgados pela internet para uma clientela exclusiva da elite carioca. A partir daí, eles se envolvem em uma espiral 
 de crimes, descobrem uma rede de contrabando de corpos, matadouros clandestinos e grã-finos excêntricos, e levam ao limite uma índole 
 perversa que jamais imaginaram existir em cada um deles.",	"Português", "Companhia das Letras", 368, 
 "imagens_livro/692b7bc6a845e_jantar_secreto.jpg");
select * from livro;

insert into filme (IMDb_ID, Titulo, Diretor, Descricao, Idioma_original, Ano_de_lancamento, Poster) values
 ("tt19847976", "Wicked: For Good", "Jon M. Chu",
 "Acompanha Elphaba, a futura Bruxa Má do Oeste, e seu relacionamento com Glinda, a Bruxa Boa do Norte. O segundo de uma adaptação cinematográfica em
 duas partes do musical da Broadway.",
 "Inglês", 2025, "imagens_filme/693055c050206_692f96f3d21eb_wicked2");
 
 
 insert into filme (IMDb_ID, Titulo, Diretor, Descricao, Idioma_original, Ano_de_lancamento, Poster) values
 ("tt0068646" ,"The Godfather", "Francis Ford Coppola", 
 "O patriarca idoso de uma dinastia do crime organizado transfere o controle de seu império clandestino para seu filho relutante.",
 "Inglês", 1972, "imagens_filme/693055b21cded_692f95314498f_o_poderoso_cgefao");

select * from filme;
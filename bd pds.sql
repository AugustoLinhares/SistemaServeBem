create database bd_pds;
use bd_pds;

create table cliente(
id_cli int primary key auto_increment not null,
nome_cli VARCHAR(45) NULL,
cpf_cli VARCHAR(45),
numero_cli VARCHAR(45) ,
email_cli VARCHAR(45) ,
cidade_cli VARCHAR(45) ,
endereco_cli VARCHAR(45)
);

  CREATE TABLE Produto(
  id_pro int primary key auto_increment not null,
  nome_pro VARCHAR(45),
  valor_venda_pro DOUBLE,
  valor_custo_pro double,
  marca_pro VARCHAR(45),
  tipo_pro VARCHAR(45) # = categoria
);
CREATE TABLE Funcionario(
  id_fun int primary key auto_increment not null,
  nome_fun VARCHAR(45),
  cpf_fun VARCHAR(45),
  funcao_fun VARCHAR(45),
  cidade_fun VARCHAR(45),
  uf_fun VARCHAR(45)
);
CREATE TABLE Mesa(
  id_mes int primary key auto_increment not null,
  status_mes VARCHAR(45),
  cadeiras_mes VARCHAR(45),
  numero_mes INT
 );
CREATE TABLE Pedido(
  id_ped int primary key auto_increment not null,
  valor_ped DOUBLE,
  data_ped DATE,
  id_fun_fk INT,
  id_mes_fk INT,
  FOREIGN KEY (id_fun_fk) REFERENCES Funcionario (id_fun),
  FOREIGN KEY (id_mes_fk) REFERENCES Mesa (id_mes)
  );
CREATE TABLE Fornecedor(
  id_for int primary key auto_increment not null,
  cnpj_for VARCHAR(45),
  nome_fantasia_for VARCHAR(45),
  razao_social_for VARCHAR(45),
  endereco_for VARCHAR(45),
  contato_for VARCHAR(45)
  );
CREATE TABLE Despesa(
  id_desp int primary key auto_increment not null,
  valor_desp DOUBLE,
  nome_desp VARCHAR(45),
  data_desp DATE,
  forma_pag_desp VARCHAR(45)
);
CREATE TABLE Compra(
  id_com int primary key auto_increment not null,
  data_com DATE ,
  valor_com DOUBLE ,
  parcelas_com INT ,
  id_fun_fk INT,
  id_for_fk INT,
  id_desp_fk INT,
 FOREIGN KEY (id_fun_fk) REFERENCES Funcionario (id_fun),
 FOREIGN KEY (id_for_fk) REFERENCES Fornecedor (id_for),
 FOREIGN KEY (id_desp_fk) REFERENCES Despesa (id_desp)
);
CREATE TABLE Venda(
  id_ven int primary key auto_increment not null,
  data_ven DATE,
  valor_ven DOUBLE,
  id_cli_fk INT,
  id_ped_fk INT,
  id_fun_fk INT,
    FOREIGN KEY (id_cli_fk) REFERENCES Cliente (id_cli),
    FOREIGN KEY (id_ped_fk) REFERENCES Pedido (id_ped),
    FOREIGN KEY (id_fun_fk) REFERENCES Funcionario (id_fun)
);
CREATE TABLE Caixa(
  id_cai int primary key auto_increment not null,
  saldo_inicial_cai DOUBLE,
  saldo_final_cai DOUBLE,
  numero_cai INT,
  total_pagamentos_cai DOUBLE,
  total_recebimentos_cai DOUBLE
  );
  CREATE TABLE Recebimento(
  id_rec int primary key auto_increment not null,
  data_rec DATE,
  valor_rec DOUBLE,
  data_venc_rec DATE,
  status_rec VARCHAR(45),
  forma_rec VARCHAR(45),
  id_ven_fk INT,
  id_cai_fk INT,
    FOREIGN KEY (id_ven_fk) REFERENCES Venda (id_ven),
    FOREIGN KEY (id_cai_fk) REFERENCES Caixa (id_cai)
);
CREATE TABLE Prato(
  id_prat int primary key auto_increment not null,
  valor_prat DOUBLE,
  peso_prat VARCHAR(45),
  self_service_prat VARCHAR(45),
  nome_prat VARCHAR(45),
  id_ven_fk INT,
  id_ped_fk INT,
    FOREIGN KEY (id_ven_fk) REFERENCES Venda (id_ven),
    FOREIGN KEY (id_ped_fk) REFERENCES Pedido (id_ped)
);
CREATE TABLE Pedido_Produto(
  id_ped_Pro int primary key auto_increment not null,
  id_ped_fk int,
  id_pro_fk INT,
    FOREIGN KEY (id_ped_fk) REFERENCES Pedido (id_ped),
    FOREIGN KEY (id_pro_fk) REFERENCES Produto (id_pro)
);
CREATE TABLE Venda_Produto(
  id_ven_pro int primary key auto_increment not null,
  id_ven_fk INT,
  id_pro_fk INT,
  qtd_ven_pro INT,
    FOREIGN KEY (id_ven_fk) REFERENCES Venda (id_ven),
    FOREIGN KEY (id_pro_fk) REFERENCES Produto (id_pro)
);
CREATE TABLE Produto_Compra(
  id_pro_Com int primary key auto_increment not null,
  id_pro_fk INT,
  id_com_fk INT,
    FOREIGN KEY (id_pro_fk) REFERENCES Produto (id_pro),
    FOREIGN KEY (id_com_fk) REFERENCES Compra (id_com)
);
CREATE TABLE Despesa_Caixa(
  id_desp_cai int primary key auto_increment not null,
  id_desp_fk INT,
  id_cai_fk INT,
    FOREIGN KEY (id_desp_fk) REFERENCES Despesa (id_desp),
    FOREIGN KEY (id_cai_fk) REFERENCES Caixa (id_cai)
);

INSERT INTO cliente VALUES 
(null,'Maria Oliveira', '111.222.333-44', '(96) 3592-4458', 'maria@email.com', 'São Paulo', 'Rua da Imprensa'),
(null,'Pedro Santos', '555.666.777-88', '(63) 2895-1255', 'pedro@email.com', 'Rio de Janeiro', 'Rua das Fiandeiras'),
(null,'Ana Silva', '999.888.777-66', '(75) 3634-4909', 'ana@email.com', 'Belo Horizonte', 'Rua Carlos Augusto Cornelsen'),
(null,'Lucas Souza', '444.555.666-77', '(96) 3742-1595', 'lucas@email.com', 'Porto Alegre', 'Rua Paracatu'),
(null,'Carolina Pereira', '222.333.444-55', '(82) 3944-2836', 'carolina@email.com', 'Salvador', 'Rua Arlindo Nogueira'),
(null,'Rafael Almeida', '777.888.999-00', '(99) 2876-8205', 'rafael@email.com', 'Curitiba', 'Avenida Governador José Malcher'),
(null,'Mariana Costa', '666.777.888-99', '(61) 3078-1196', 'mariana@email.com', 'Fortaleza', 'Rua Carlos Augusto Cornelsen'),
(null,'Gustavo Lima', '333.444.555-66', '(93) 2649-2273', 'gustavo@email.com', 'Recife', 'Avenida Rio Branco'),
(null,'Beatriz Rodrigues', '888.999.000-11', '(83) 3610-7306', 'beatriz@email.com', 'Porto Alegre', 'Avenida Desembargador Moreira'),
(null,'Thiago Nunes', '444.333.222-11', '(62) 2191-8836', 'thiago@email.com', 'São Paulo', 'Avenida São João');

INSERT INTO Produto VALUES 
(null, 'Produto A', 10.99, '9.99', 'Marca A', 'Tipo A'),
(null, 'Produto B', 19.99, '15.99', 'Marca B', 'Tipo B'),
(null, 'Produto C', 5.99, '3.99', 'Marca C', 'Tipo A'),
(null, 'Produto D', 15.99, '11.99', 'Marca A', 'Tipo C'),
(null, 'Produto E', 12.49, '10.99', 'Marca B', 'Tipo A'),
(null, 'Produto F', 8.99, '4.99', 'Marca C', 'Tipo B'),
(null, 'Produto G', 14.99, '10.99', 'Marca A', 'Tipo B'),
(null, 'Produto H', 9.99, '6.99', 'Marca B', 'Tipo C'),
(null, 'Produto I', 7.49, '5.99', 'Marca C', 'Tipo A'),
(null, 'Produto J', 11.99, '10.99', 'Marca A', 'Tipo C');

INSERT INTO Funcionario VALUES 
(null, 'João Silva', '111.222.333-44', 'Vendedor', 'São Paulo', 'SP'),
(null, 'Maria Oliveira', '555.666.777-88', 'Gerente', 'Rio de Janeiro', 'RJ'),
(null, 'Pedro Santos', '999.888.777-66', 'Assistente Administrativo', 'Belo Horizonte', 'MG'),
(null, 'Lucas Souza', '444.555.666-77', 'Estoquista', 'Porto Alegre', 'RS'),
(null, 'Carolina Pereira', '222.333.444-55', 'Caixa', 'Salvador', 'BA'),
(null, 'Rafael Almeida', '777.888.999-00', 'Atendente', 'Curitiba', 'PR'),
(null, 'Mariana Costa', '666.777.888-99', 'Auxiliar de Limpeza', 'Fortaleza', 'CE'),
(null, 'Gustavo Lima', '333.444.555-66', 'Recepcionista', 'Recife', 'PE'),
(null, 'Beatriz Rodrigues', '888.999.000-11', 'Analista de Recursos Humanos', 'Porto Alegre', 'RS'),
(null, 'Thiago Nunes', '444.333.222-11', 'Assistente de Marketing', 'São Paulo', 'SP');

INSERT INTO Mesa VALUES
(null, 'Disponível', '4', 1),
(null, 'Ocupada', '2', 2),
(null, 'Disponível', '6', 3),
(null, 'Ocupada', '4', 4),
(null, 'Disponível', '2', 5),
(null, 'Disponível', '4', 6),
(null, 'Ocupada', '6', 7),
(null, 'Disponível', '2', 8),
(null, 'Disponível', '4', 9),
(null, 'Disponível', '2', 10);

INSERT INTO Pedido VALUES 
(null, 50.99, '2023-06-01', 1, 1),
(null, 35.49, '2023-06-02', 2, 2),
(null, 27.99, '2023-06-03', 3, 3),
(null, 42.75, '2023-06-04', 4, 4),
(null, 18.99, '2023-06-05', 5, 5),
(null, 62.50, '2023-06-06', 6, 6),
(null, 23.99, '2023-06-07', 7, 7),
(null, 38.25, '2023-06-08', 8, 8),
(null, 15.99, '2023-06-09', 9, 9),
(null, 29.75, '2023-06-10', 10, 10);

INSERT INTO Fornecedor VALUES 
(null, '11.222.333/0001-01', 'Fornecedor A', 'Razão Social A', 'Rua A, 123', 'contato@a.com'),
(null, '22.333.444/0001-02', 'Fornecedor B', 'Razão Social B', 'Rua B, 456', 'contato@b.com'),
(null, '33.444.555/0001-03', 'Fornecedor C', 'Razão Social C', 'Rua C, 789', 'contato@c.com'),
(null, '44.555.666/0001-04', 'Fornecedor D', 'Razão Social D', 'Rua D, 012', 'contato@d.com'),
(null, '55.666.777/0001-05', 'Fornecedor E', 'Razão Social E', 'Rua E, 345', 'contato@e.com'),
(null, '66.777.888/0001-06', 'Fornecedor F', 'Razão Social F', 'Rua F, 678', 'contato@f.com'),
(null, '77.888.999/0001-07', 'Fornecedor G', 'Razão Social G', 'Rua G, 901', 'contato@g.com'),
(null, '88.999.000/0001-08', 'Fornecedor H', 'Razão Social H', 'Rua H, 234', 'contato@h.com'),
(null, '99.000.111/0001-09', 'Fornecedor I', 'Razão Social I', 'Rua I, 567', 'contato@i.com'),
(null, '00.111.222/0001-10', 'Fornecedor J', 'Razão Social J', 'Rua J, 890', 'contato@j.com');

INSERT INTO Despesa VALUES 
(null, 100.00, 'Conta de Luz', '2023-06-01', 'Boleto'),
(null, 50.00, 'Aluguel', '2023-06-02', 'Transferência'),
(null, 30.00, 'Telefone', '2023-06-03', 'Cartão de Crédito'),
(null, 80.00, 'Internet', '2023-06-04', 'Boleto'),
(null, 20.00, 'Material de Limpeza', '2023-06-05', 'Transferência'),
(null, 50.00, 'Manutenção', '2023-06-06', 'Cartão de Crédito'),
(null, 40.00, 'Impostos', '2023-06-07', 'Boleto'),
(null, 60.00, 'Marketing', '2023-06-08', 'Transferência'),
(null, 25.00, 'Seguro', '2023-06-09', 'Cartão de Crédito'),
(null, 35.00, 'Manutenção Equipamentos', '2023-06-10', 'Boleto');

INSERT INTO Compra VALUES 
(null, '2023-06-01', 250.00, 1, 1, 1, 1),
(null, '2023-06-02', 180.50, 1, 2, 2, 2),
(null, '2023-06-03', 120.25, 1, 3, 3, 3),
(null, '2023-06-04', 300.00, 1, 4, 4, 4),
(null, '2023-06-05', 90.75, 1, 5, 5, 5),
(null, '2023-06-06', 150.00, 1, 6, 6, 6),
(null, '2023-06-07', 200.50, 1, 7, 7, 7),
(null, '2023-06-08', 80.25, 1, 8, 8, 8),
(null, '2023-06-09', 175.00, 1, 9, 9, 9),
(null, '2023-06-10', 130.75, 1, 10, 10, 10);
select*from produto;
INSERT INTO Venda VALUES 
(null, '2023-06-01', 80.00, 1, 1, 1),
(null, '2023-06-02', 65.50, 2, 2, 2),
(null, '2023-06-03', 50.25, 3, 3, 3),
(null, '2023-06-04', 95.00, 4, 4, 4),
(null, '2023-06-05', 35.75, 5, 5, 5),
(null, '2023-06-06', 120.00, 6, 6, 6),
(null, '2023-06-07', 45.50, 7, 7, 7),
(null, '2023-06-08', 80.25, 8, 8, 8),
(null, '2023-06-09', 30.00, 9, 9, 9),
(null, '2023-06-10', 60.75, 10, 10, 10);

INSERT INTO Caixa VALUES 
(null, 500.00, 600.00, 1, 200.00, 300.00),
(null, 700.00, 900.00, 2, 300.00, 600.00),
(null, 800.00, 1000.00, 3, 400.00, 600.00),
(null, 600.00, 800.00, 4, 200.00, 400.00),
(null, 900.00, 1100.00, 5, 400.00, 700.00),
(null, 1000.00, 1200.00, 6, 500.00, 700.00),
(null, 1100.00, 1300.00, 7, 600.00, 700.00),
(null, 1200.00, 1400.00, 8, 700.00, 700.00),
(null, 1300.00, 1500.00, 9, 800.00, 700.00),
(null, 1400.00, 1600.00, 10, 900.00, 700.00);

INSERT INTO Recebimento VALUES 
(null, '2023-06-01', 80.00, '2023-06-10', 'Pago', 'Dinheiro', 1, 1),
(null, '2023-06-02', 65.50, '2023-06-11', 'Pendente', 'Cartão de Crédito', 2, 2),
(null, '2023-06-03', 50.25, '2023-06-12', 'Pendente', 'Transferência', 3, 3),
(null, '2023-06-04', 95.00, '2023-06-13', 'Pendente', 'Boleto', 4, 4),
(null, '2023-06-05', 35.75, '2023-06-14', 'Pendente', 'Transferência', 5, 5),
(null, '2023-06-06', 120.00, '2023-06-15', 'Pendente', 'Dinheiro', 6, 6),
(null, '2023-06-07', 45.50, '2023-06-16', 'Pendente', 'Cartão de Crédito', 7, 7),
(null, '2023-06-08', 80.25, '2023-06-17', 'Pendente', 'Transferência', 8, 8),
(null, '2023-06-09', 30.00, '2023-06-18', 'Pendente', 'Boleto', 9, 9),
(null, '2023-06-10', 60.75, '2023-06-19', 'Pendente', 'Dinheiro', 10, 10);

INSERT INTO Prato VALUES 
(null, 15.00, '300g', 'Sim', 'Prato 1', 1, 1),
(null, 12.50, '250g', 'Sim', 'Prato 2', 2, 2),
(null, 10.25, '200g', 'Sim', 'Prato 3', 3, 3),
(null, 18.00, '350g', 'Sim', 'Prato 4', 4, 4),
(null, 8.75, '180g', 'Sim', 'Prato 5', 5, 5),
(null, 25.00, '400g', 'Sim', 'Prato 6', 6, 6),
(null, 10.50, '220g', 'Sim', 'Prato 7', 7, 7),
(null, 15.25, '300g', 'Sim', 'Prato 8', 8, 8),
(null, 5.00, '150g', 'Sim', 'Prato 9', 9, 9),
(null, 12.75, '250g', 'Sim', 'Prato 10', 10, 10);

INSERT INTO Pedido_Produto VALUES
(null, 1, 1),
(null, 2, 2),
(null, 3, 3),
(null, 4, 4),
(null, 5, 5),
(null, 6, 6),
(null, 7, 7),
(null, 8, 8),
(null, 9, 9),
(null, 10, 10);

INSERT INTO Venda_Produto VALUES 
(null, 1, 1, 2),
(null, 2, 2, 1),
(null, 3, 3, 3),
(null, 4, 4, 2),
(null, 5, 5, 1),
(null, 6, 6, 4),
(null, 7, 7, 3),
(null, 8, 8, 2),
(null, 9, 9, 1),
(null, 10, 10, 3);

INSERT INTO Produto_Compra VALUES 
(null, 1, 1),
(null, 2, 2),
(null, 3, 3),
(null, 4, 4),
(null, 5, 5),
(null, 6, 6),
(null, 7, 7),
(null, 8, 8),
(null, 9, 9),
(null, 10, 10);

INSERT INTO Despesa_Caixa VALUES 
(null, 1, 1),
(null, 2, 2),
(null, 3, 3),
(null, 4, 4),
(null, 5, 5),
(null, 6, 6),
(null, 7, 7),
(null, 8, 8),
(null, 9, 9),
(null, 10, 10);
CREATE DATABASE Fazenda

USE Fazenda


CREATE TABLE Usuario
(
codUsuario INT PRIMARY KEY IDENTITY,
nomeUsuario VARCHAR (60) NOT NULL,
nivelAcesso INT NOT NULL,
usuario VARCHAR (50) NOT NULL,
senha CHAR (40) NOT NULL
);



CREATE TABLE Cliente
(
codCliente INT PRIMARY KEY IDENTITY,
nomeCliente VARCHAR (60) NOT NULL,
emailCliente VARCHAR (80) NOT NULL,
ufCliente CHAR (2) NOT NULL,
cidadeCliente VARCHAR (50) NOT NULL,
telefoneCliente VARCHAR (25) NOT NULL,
cepCliente VARCHAR (10) NOT NULL,
logradouroCliente VARCHAR (50) NOT NULL,
numeroEnderecoCliente INT NOT NULL,

);

CREATE TABLE ClienteFisico 
(
codClienteFisico INT PRIMARY KEY IDENTITY,
cpfCliente VARCHAR (25),
codClienteF INT,
CONSTRAINT FkClienteF FOREIGN KEY (codClienteF) REFERENCES Cliente (codCliente) 
);

CREATE TABLE ClienteJuridico
(
codClienteJuridico INT PRIMARY KEY IDENTITY,
cnpjCliente VARCHAR (30) NOT NULL,
razaoSocialCliente VARCHAR (60) NOT NULL,
codClienteJ INT NOT NULL,
CONSTRAINT FkClienteJ FOREIGN KEY (codClienteJ) REFERENCES Cliente (codCliente) 
);


CREATE TABLE Fornecedor 
(
codFornecedor INT PRIMARY KEY IDENTITY,
nomeFornecedor VARCHAR (60) NOT NULL,
emailFornecedor VARCHAR (100) NOT NULL,
ufFornecedor CHAR (2) NOT NULL,
cidadeFornecedor VARCHAR (50) NOT NULL,
telefoneFornecedor VARCHAR (25) NOT NULL,
cepFornecedor VARCHAR (10) NOT NULL,
logradouroFornecedor VARCHAR (50) NOT NULL,
numeroEnderecoFornecedor INT NOT NULL,
cnpjFornecedor VARCHAR (30) NOT NULL,
razaoSocialFornecedor VARCHAR (60) NOT NULL
);

CREATE TABLE Insumo
(
codInsumo INT PRIMARY KEY IDENTITY,
nomeInsumo VARCHAR (60) not null,
estoqueInsumo INT NOT NULL,
dataValidadeInsumo DATE NOT NULL,
precoInsumo MONEY NOT NULL
);



CREATE TABLE Compra
(
codCompra INT PRIMARY KEY IDENTITY,
dataHorarioCompra DATETIME NOT NULL,
formaPagamentoCompra VARCHAR (40) NOT NULL,
codFornecedorC INT,
codUsuarioC INT,
CONSTRAINT FkFornecedor FOREIGN KEY (codFornecedorC) REFERENCES Fornecedor (CodFornecedor),
CONSTRAINT FkUsuarioC FOREIGN KEY (codUsuarioC) REFERENCES Usuario (CodUsuario)
);



CREATE TABLE ItensCompra (
codItensCompra INT PRIMARY KEY IDENTITY,
quantidadeItensCompra INT NOT NULL,
valorTotalItensCompra MONEY NOT NULL,
codCompraIC INT,
codInsumoIC INT,
CONSTRAINT FkCompraIC FOREIGN KEY (codCompraIC) REFERENCES Compra (codCompra),
CONSTRAINT FkInsumoIC FOREIGN KEY (codInsumoIC) REFERENCES Insumo (codInsumo)
);


CREATE TABLE Produto (
codProduto INT PRIMARY KEY IDENTITY,
nomeProduto VARCHAR (60) NOT NULL,
precoProduto MONEY NOT NULL,
estoqueProduto INT NOT NULL,
dataValidadeProduto DATE NOT NULL
);


CREATE TABLE Venda (
codVenda INT PRIMARY KEY IDENTITY,
dataHorarioVenda DATETIME NOT NULL,
formaPagamentoVenda VARCHAR (40) NOT NULL,
codUsuarioV INT,
codClienteV INT,
CONSTRAINT FkUsuarioV FOREIGN KEY (codUsuarioV) REFERENCES Usuario (codUsuario),
CONSTRAINT FkClienteV FOREIGN KEY (codClienteV) REFERENCES Cliente (codCliente)
);



CREATE TABLE ItensVenda
(
codItensVenda INT PRIMARY KEY IDENTITY,
quantidadeItensVenda INT NOT NULL,
valorTotalItensVenda MONEY NOT NULL,
codProdutoIV INT,
codVendaIV INT,
CONSTRAINT FkProdutoIv FOREIGN KEY (codProdutoIV) REFERENCES Produto (codProduto),
CONSTRAINT FkVendaIV FOREIGN KEY (codVendaIV) REFERENCES Venda (codVenda)

);

CREATE TABLE Colheita (
codColheita INT PRIMARY KEY IDENTITY,
dataColheita DATE NOT NULL,
horarioColheita TIME NOT NULL,
quantidadeColheita INT NOT NULL,
codProdutoC INT,
CONSTRAINT FkProdutoC FOREIGN KEY (codProdutoC) REFERENCES Produto (codProduto)


);

CREATE TABLE Plantacao
(
codPlantacao INT PRIMARY KEY IDENTITY,
dataPlantacao DATE NOT NULL,
horarioPlantacao TIME NOT NULL,
quantidadePlantacao INT NOT NULL,
codInsumoP INT,
CONSTRAINT FkInsumoP FOREIGN KEY (codInsumoP) REFERENCES Insumo (codInsumo)


);



CREATE TABLE Entrega (
codEntrega INT PRIMARY KEY IDENTITY,
quantidadeEntrega INT NOT NULL,
codVendaE INT,
codClienteE INT,
CONSTRAINT VendaE FOREIGN KEY (codVendaE) REFERENCES Venda (codVenda),
CONSTRAINT ClienteV FOREIGN KEY (codClienteE) REFERENCES Cliente (codCliente)

);


GO



                                              -- Procedimento Usuarios 

--Login
	CREATE PROCEDURE spLogin

		@Usuario VARCHAR (60),
		@Senha VARCHAR (20)

	AS 

	SELECT * FROM Usuario WHERE usuario = @Usuario AND senha = @Senha 

	GO

	--Cadastrar Usuario
	CREATE PROCEDURE spCadastrarUsuario

		@NomeUsuario VARCHAR (50),
		@NivelAcesso INT,
		@Usuario VARCHAR (50),
		@Senha VARCHAR (40)

	AS 

	INSERT INTO Usuario VALUES (@NomeUsuario, @NivelAcesso, @Usuario, @Senha)

	GO


	--Consultar Todos Usuarios

		CREATE PROCEDURE spConsultarTodosUsuarios

		AS

		SELECT codUsuario AS 'Código', nomeUsuario AS 'Nome', nivelAcesso AS 'Nível Acesso', usuario AS 'Usuário', senha AS 'Senha' FROM Usuario

		GO


	
	--Excluir Usuario
		CREATE PROCEDURE spExcluirUsuario
			@CodUsuario INT

		AS

		DELETE FROM Usuario WHERE codUsuario = @CodUsuario
	
		GO

	--Alterar Usuario
	CREATE PROCEDURE spAlterarUsuario
		@CodUsuario INT,
		@NomeUsuario VARCHAR (50),
		@NivelAcesso INT,
		@Usuario VARCHAR (50),
		@Senha VARCHAR (40)

	AS

	UPDATE Usuario SET nomeUsuario = @NomeUsuario, nivelAcesso = @NivelAcesso, usuario = @Usuario, senha = @Senha WHERE codUsuario = @CodUsuario

	GO

	


                                                 --Procedimentos Clientes

--Cadastrar Cliente
	CREATE PROCEDURE spCadastrarCliente
		@NomeCliente   VARCHAR(50),
		@EmailCliente  VARCHAR(100),
		@UfCliente   CHAR(2),
		@CidadeCliente VARCHAR (50),
		@TelefoneCliente VARCHAR (20),
		@CepCliente CHAR (8),
		@LogradouroCliente VARCHAR (50),
		@NumEnderecoCliente INT

	AS 

	INSERT INTO Cliente VALUES (@NomeCliente, @EmailCliente, @UfCliente, @CidadeCliente, @TelefoneCliente, @CepCliente, @LogradouroCliente, @NumEnderecoCliente)

GO



--Procedimento de Excluir Cliente (Exclui da tabela cliente juridico ou fisico)

	CREATE PROCEDURE spExcluirCliente

		@CodCliente INT = codCliente

	AS


	DELETE FROM ClienteFisico WHERE codClienteF = @CodCliente

	DELETE FROM ClienteJuridico WHERE codClienteJ = @CodCliente

	DELETE FROM Cliente WHERE codCliente = @CodCliente

	GO

	--Procedimento Alterar Cliente

	CREATE PROCEDURE spAlterarCliente 
	    @NomeCliente   VARCHAR(50),
		@EmailCliente  VARCHAR(100),
		@UfCliente   CHAR(2),
		@CidadeCliente VARCHAR (50),
		@TelefoneCliente VARCHAR (20),
		@CepCliente CHAR (8),
		@LogradouroCliente VARCHAR (50),
		@NumEnderecoCliente INT,
		@CodCliente INT


     AS

	 UPDATE Cliente SET nomeCliente = @NomeCliente, emailCliente = @EmailCliente, ufCliente = @UfCliente, cidadeCliente = @CidadeCliente,
	 telefoneCliente = @TelefoneCliente, cepCliente = @CepCliente, logradouroCliente = @LogradouroCliente, numeroEnderecoCliente = @NumEnderecoCliente
	 WHERE codCliente = @CodCliente

	 GO



	
	                                  --PROCEDIMENTOS CLIENTES JURIDICOS
	--Cadastrar Cliente Juridico

	CREATE PROCEDURE spCadastrarClienteJuridico
		@CnpjCliente VARCHAR (30),
		@RazaoSocialCliente VARCHAR (60),
		@CodClienteJ INT
	AS
	INSERT INTO ClienteJuridico VALUES (@CnpjCliente, @RazaoSocialCliente, @CodClienteJ)

GO

	--Excluir Cliente Juridico
	CREATE PROCEDURE spExcluirClienteJuridico
		@CodClienteJuridico INT 
	AS
	DELETE FROM ClienteJuridico WHERE codClienteJuridico = @CodClienteJuridico

	

GO

	--Alterar Cliente Juridico
	CREATE PROCEDURE spAlterarClienteJuridico
		@CodClienteJuridico INT,
		@CnpjCliente VARCHAR (30),
		@RazaoSocialCliente VARCHAR (60),
		@CodClienteJ INT
	AS
	UPDATE ClienteJuridico SET cnpjCliente = @CnpjCliente, razaoSocialCliente = @RazaoSocialCliente, codClienteJ = @CodClienteJ WHERE codClienteJuridico = @CodClienteJuridico

GO

	--Consultar Todos Clientes Juridicos
	CREATE PROCEDURE spConsultarTodosClientesJ	
	AS
	SELECT codClienteJuridico AS 'Código', cnpjCliente AS 'CNPJ', razaoSocialCliente AS 'Razão Social', codClienteJ AS 'Cliente' FROM  ClienteJuridico

GO
	                                     --PROCEDIMENTOS Cliente Fisico
	

--Cadastrar Cliente Fisico

	CREATE PROCEDURE spCadastrarClienteFisico
		@CpfCliente VARCHAR (25),
		@CodClienteF INT
	AS
	INSERT INTO ClienteFisico VALUES (@CpfCliente, @CodClienteF)

	GO

	--Excluir cliente fisico
	CREATE PROCEDURE spExcluirClienteFisico
		@CodClienteFisico INT 
	AS 
	DELETE FROM ClienteFisico WHERE codClienteFisico = @CodClienteFisico

	GO

	--Alterar Cliente Fisico
	CREATE PROCEDURE spAlterarClienteFisico
		@CodClienteFisico INT,
		@CpfCliente VARCHAR (25),
		@CodClienteF INT
	AS
	UPDATE ClienteFisico SET cpfCliente = @CpfCliente, codClienteF = @CodClienteF WHERE codClienteFisico = @CodClienteFisico

	GO

	--Consultar Todos Clientes Fisicos
	CREATE PROCEDURE spConsultarTodosClientesF
	AS
	SELECT codClienteFisico AS 'Código', cpfCliente AS 'CPF', codClienteF AS 'Cliente' FROM ClienteFisico

	GO



	                                          --PROCEDIMENTOS FORNECEDOR

	--Cadastrar Fornecedor
		CREATE PROCEDURE spCadastrarFornecedor

			@NomeFornecedor VARCHAR (50),
			@EmailFornecedor VARCHAR (100),
			@UfFornecedor CHAR (2),
			@CidadeFornecedor VARCHAR (50),
			@TelefoneFornecedor VARCHAR (25),
			@CepFornecedor VARCHAR (10),
			@LogradouroFornecedor VARCHAR (50),
			@NumeroEnderecoFornecedor INT,
			@CnpjFornecedor VARCHAR (30),
			@RazaoSocialFornecedor VARCHAR (60)

		AS

		INSERT INTO Fornecedor VALUES (@NomeFornecedor, @EmailFornecedor, @UfFornecedor, @CidadeFornecedor, @TelefoneFornecedor, @CepFornecedor,
		@LogradouroFornecedor, @NumeroEnderecoFornecedor, @CnpjFornecedor, @RazaoSocialFornecedor )

		GO

		--Alterar Fornecedor
	CREATE PROCEDURE spAlterarFornecedor
		@CodFornecedor INT,
		@NomeFornecedor VARCHAR (50),
		@EmailFornecedor VARCHAR (100),
		@UfFornecedor CHAR (2),
		@CidadeFornecedor VARCHAR (50),
		@TelefoneFornecedor VARCHAR (25),
		@CepFornecedor VARCHAR (10),
		@LogradouroFornecedor VARCHAR (50),
		@NumeroEnderecoFornecedor INT,
		@CnpjFornecedor VARCHAR (30),
		@RazaoSocialFornecedor VARCHAR (60)

	AS

	UPDATE Fornecedor SET nomeFornecedor = @NomeFornecedor, emailFornecedor = @EmailFornecedor, ufFornecedor = @UfFornecedor, cidadeFornecedor = @CidadeFornecedor, telefoneFornecedor = @TelefoneFornecedor, logradouroFornecedor = @LogradouroFornecedor, numeroEnderecoFornecedor = @NumeroEnderecoFornecedor, cnpjFornecedor = @CnpjFornecedor, razaoSocialFornecedor = @RazaoSocialFornecedor WHERE codFornecedor = @CodFornecedor

	GO

	--Excluir Fornecedor
	CREATE PROCEDURE spExcluirFornecedor
		@CodFornecedor INT

	AS

	DELETE FROM Fornecedor WHERE codFornecedor = @CodFornecedor
	
	GO


	                                            --PROCEDIMENTOS INSUMO

	--PROCEDIMENTO CADASTRAR INSUMO

	CREATE PROCEDURE spCadastrarInsumo

		@NomeInsumo VARCHAR (50),
		@EstoqueInsumo INT,
		@DataValidadeInsumo DATE,
		@PrecoInsumo MONEY

		AS

		INSERT INTO Insumo VALUES (@NomeInsumo, @EstoqueInsumo, @DataValidadeInsumo, @PrecoInsumo)
GO

--PROCEDIMENTO EXCLUIR INSUMO
   CREATE PROCEDURE spExcluirInsumo

		@CodInsumo INT

		AS

		DELETE FROM Insumo WHERE codInsumo = @CodInsumo

GO

--PROCEDIMENTO ALTERAR INSUMO
  CREATE PROCEDURE spAlterarInsumo
	
	    @NomeInsumo VARCHAR (50),
		@EstoqueInsumo INT,
		@DataValidadeInsumo DATE,
		@PrecoInsumo MONEY,
		@CodInsumo INT

	AS

	UPDATE Insumo SET nomeInsumo = @NomeInsumo, estoqueInsumo = @EstoqueInsumo, dataValidadeInsumo = @DataValidadeInsumo, precoInsumo = @PrecoInsumo WHERE codInsumo = @CodInsumo

GO

--PROCEDIMENTO CONSULTAR TODOS INSUMOS

	CREATE PROCEDURE spConsultarTodosInsumo

	AS

	SELECT codInsumo AS 'Código', nomeInsumo AS 'Nome', estoqueInsumo AS 'Estoque', dataValidadeInsumo AS 'Data de Validade', precoInsumo AS 'Preço' FROM Insumo

GO




--Procedimentos Plantacao

-- PROCEDIMENTO CADASTRAR PLANTACAO
	
	CREATE PROCEDURE spCadastrarPlantacao
	@DataPlantacao DATE,
	@HorarioPlantacao TIME,
	@QuantidadePlantacao INT,
	@CodInsumoP INT

	AS

	INSERT INTO Plantacao VALUES (@DataPlantacao, @HorarioPlantacao, @QuantidadePlantacao, @CodInsumoP)

GO

--PROCEDIMENTO EXCLUIR PLANTACAO

	CREATE PROCEDURE spExcluirPlantacao

	@CodPlantacao INT

	AS

	DELETE FROM Plantacao WHERE codPlantacao = @CodPlantacao


GO

--PROCEDIMENTO ALTERAR PLANTACAO

CREATE PROCEDURE spAlterarPlantacao

	@DataPlantacao DATE,
	@HorarioPlantacao TIME,
	@QuantidadePlantacao INT,
	@CodInsumoP INT,
	@CodPlantacao INT

	AS

	UPDATE Plantacao SET dataPlantacao = @DataPlantacao, horarioPlantacao = @HorarioPlantacao, quantidadePlantacao = @QuantidadePlantacao, codInsumoP = @CodInsumoP WHERE codPlantacao = @CodPlantacao


	GO
	
	

                                        --PROCEDIMENTO PRODUTO

--PROCEDIMENTO CADASTRAR PRODUTO

	CREATE PROCEDURE spCadastrarProduto
	@NomeProduto VARCHAR (60),
	@PrecoProduto MONEY,
	@EstoqueProduto INT,
	@DataValidadeProduto DATE

	AS

		INSERT INTO Produto VALUES (@NomeProduto, @PrecoProduto, @EstoqueProduto, @DataValidadeProduto)
	
GO		


--PROCEDIMENTO EXCLUIR PRODUTO

	CREATE PROCEDURE spExcluirProduto
	@CodProduto INT

	AS

		DELETE FROM Produto WHERE codProduto = @CodProduto

	GO


--PROCEDIMENTO ALTERAR PRODUTO

	CREATE PROCEDURE spAlterarProduto
	@NomeProduto VARCHAR (60),
	@PrecoProduto MONEY,
	@EstoqueProduto INT,
	@DataValidadeProduto DATE,
	@CodProduto INT

	AS

		UPDATE Produto SET nomeProduto = @NomeProduto, precoProduto = @PrecoProduto, estoqueProduto = @EstoqueProduto, dataValidadeProduto = @DataValidadeProduto 
		WHERE codProduto = @CodProduto


	GO


--Procedimentos Colheita

-- PROCEDIMENTO CADASTRAR COLHEITA
	
	CREATE PROCEDURE spCadastrarColheita
	@DataColheita DATE,
	@HorarioColheita TIME,
	@QuantidadeColheita INT,
	@CodProdutoC INT

	AS

	INSERT INTO Colheita VALUES (@DataColheita, @HorarioColheita, @QuantidadeColheita, @CodProdutoC)

GO

--PROCEDIMENTO EXCLUIR COLHEITA

	CREATE PROCEDURE spExcluirColheita

	@CodColheita INT

	AS

	DELETE FROM Colheita WHERE codColheita = @CodColheita

	
GO

--PROCEDIMENTO ALTERAR COLHEITA

CREATE PROCEDURE spAlterarColheita

	@DataColheita DATE,
	@HorarioColheita TIME,
	@QuantidadeColheita INT,
	@CodProdutoC INT,
	@CodColheita INT


	AS

	UPDATE Colheita SET dataColheita = @DataColheita, horarioColheita = @HorarioColheita, quantidadeColheita = @QuantidadeColheita, codProdutoC = @CodProdutoC WHERE codColheita = @CodColheita


	GO



--PROCEDIMENTOS VENDA

--Cadastrar Venda

	CREATE PROCEDURE spCadastrarVenda 
	@DataHorarioVenda DATETIME,
	@FormaPagamentoVento VARCHAR (40),
	@CodUsuarioV INT,
	@CodClienteV INT

	AS 

	INSERT INTO Venda VALUES (@DataHorarioVenda, @FormaPagamentoVento, @CodUsuarioV, @CodClienteV)
	

	GO


	--Excluir Venda

	CREATE PROCEDURE spExcluirVenda

	@CodVenda INT

	AS 
	
	DELETE FROM Venda WHERE codVenda = @CodVenda
	

	GO
	

	--PROCEDIMENTOS ITENS VENDA

	CREATE PROCEDURE spCadastrarItensVenda
	@QuantidadeItensVenda INT,
	@ValorTotalItensVenda MONEY,
	@CodProdutoIV INT,
	@CodVendaIV INT

	AS

	INSERT INTO ItensVenda VALUES (@QuantidadeItensVenda, @ValorTotalItensVenda, @CodProdutoIV, @CodVendaIV)

	GO
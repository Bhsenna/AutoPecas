# Manual do Usuário - Sistema AutoPeças

---

## Sumário

1. [Introdução](#introdução)
2. [Requisitos do Sistema](#requisitos-do-sistema)
3. [Primeiro Acesso](#primeiro-acesso)
4. [Tela de Login](#tela-de-login)
5. [Tela Principal](#tela-principal)
6. [Dashboard](#dashboard)
7. [Cadastros](#cadastros)
   - 7.1 [Produtos](#71-produtos)
   - 7.2 [Clientes](#72-clientes)
   - 7.3 [Categorias](#73-categorias)
   - 7.4 [Fornecedores](#74-fornecedores)
   - 7.5 [Serviços](#75-serviços)
8. [Gestão de Estoque](#8-gestão-de-estoque)
   - 8.1 [Movimento de Estoque](#81-movimento-de-estoque)
   - 8.2 [Saldo de Estoque](#82-saldo-de-estoque)
9. [Atendimentos](#9-atendimentos)
10. [Calendário](#10-calendário)
11. [Relatórios](#11-relatórios)
12. [Dicas e Boas Práticas](#12-dicas-e-boas-práticas)
13. [Solução de Problemas](#13-solução-de-problemas)

---

## Introdução

O **Sistema AutoPeças** é uma solução completa para gestão de autopeças e serviços automotivos. O sistema oferece controle de estoque, cadastro de clientes, agendamento de serviços, controle financeiro e geração de relatórios.

### Principais Funcionalidades:

✅ Dashboard com indicadores em tempo real
✅ Gestão completa de produtos e estoque
✅ Cadastro de clientes e veículos
✅ Controle de fornecedores
✅ Gestão de serviços e atendimentos
✅ Calendário de agendamentos
✅ Relatórios gerenciais em Excel
✅ Interface moderna e intuitiva

---

## Requisitos do Sistema

### Requisitos Mínimos:

| Componente | Especificação |
|---|---|
| **Sistema Operacional** | Windows 10 ou superior |
| **Resolução de Tela** | 1280x720 (HD 720p) ou superior |
| **Memória RAM** | 4 GB |
| **Espaço em Disco** | 500 MB livres |
| **.NET Framework** | .NET 8.0 ou superior |

### Requisitos Recomendados:

| Componente | Especificação |
|---|---|
| **Sistema Operacional** | Windows 11 |
| **Resolução de Tela** | 1920x1080 (Full HD) ou superior |
| **Memória RAM** | 8 GB ou mais |
| **Espaço em Disco** | 2 GB livres |

---

## Primeiro Acesso

### 3.1. Instalação

1. Baixe o instalador acessando o link: https://drive.google.com/file/d/1OTuAP_XpYdU8e8_cLAOnXCJak3Y83se2/view?usp=sharing
2. Execute o instalador do sistema
3. Siga as instruções na tela
4. Aguarde a conclusão da instalação

### 3.2. Configuração Inicial

- O sistema cria automaticamente o banco de dados SQLite
- Usuário administrador padrão é criado automaticamente
- Na primeira execução, será solicitado o cadastro completo do usuário

### 3.3. Credenciais Padrão

- **Usuário:** admin
- **Senha:** admin123

> ⚠️ **IMPORTANTE:** Altere a senha padrão no primeiro acesso!

---

## Tela de Login

### 4.1. Acessando o Sistema

1. **Digite seu usuário** no campo "Usuário"
2. **Digite sua senha** no campo "Senha"
3. Clique no botão **"ENTRAR"** ou pressione **Enter**

### 4.2. Funcionalidades da Tela de Login

- **Minimizar janela:** Botão no canto superior direito
- **Fechar sistema:** Botão X no canto superior direito
- **Validação automática:** O sistema valida os campos antes de processar

### 4.3. Mensagens de Erro Comuns

- **"Por favor, preencha usuário e senha":** Campos obrigatórios vazios
- **"Usuário ou senha inválidos":** Credenciais incorretas
- **"Usuário bloqueado":** Conta desativada, contate o administrador

### 4.4. Recuperação de Senha

Caso tenha esquecido sua senha, entre em contato com o administrador do sistema.

---

## Tela Principal

### 5.1. Layout da Interface

A tela principal é dividida em três áreas principais:

```
┌─────────────────────────────────────────────────────┐
│ BARRA DE TÍTULO          [_ □ X]                    │
├─────────────┬───────────────────────────────────────┤
│             │                                       │
│   MENU      │        ÁREA DE TRABALHO               │
│  LATERAL    │       (Conteúdo das Telas)            │
│             │                                       │
└─────────────┴───────────────────────────────────────┘
```

### 5.2. Barra de Título

- **Botão Home:** Retorna ao Dashboard
- **Título da Tela:** Indica a tela ativa atual
- **Minimizar:** Minimiza a janela
- **Maximizar/Restaurar:** Alterna entre tela cheia e janela
- **Fechar:** Fecha o sistema

### 5.3. Menu Lateral

O menu lateral contém todos os módulos do sistema:

#### 📦 **Cadastros**
- **Produtos** - Gerenciar produtos e peças
- **Clientes** - Cadastro de clientes
- **Categorias** - Organizar produtos por categoria
- **Fornecedores** - Gestão de fornecedores
- **Serviços** - Cadastro de serviços oferecidos

#### 📊 **Gestão**
- **Atendimentos** - Registro de vendas e serviços
- **Mov. Estoque** - Movimentações de entrada/saída
- **Saldo Estoque** - Consulta de saldo atual

#### 📅 **Agendamento**
- **Calendário** - Agendamentos e compromissos

#### ⚙️ **Sistema**
- **Configurações** - Ajustes do sistema
- **Log Out** - Sair do sistema

### 5.4. Menu Lateral Retrátil

O menu lateral pode ser recolhido para ganhar mais espaço na tela:

**Para recolher/expandir o menu:**
1. Localize o botão **◀** ou **▶** na borda do menu
2. Clique no botão para alternar entre os modos:
   - **Expandido:** Mostra ícones e textos
   - **Recolhido:** Mostra apenas ícones

> 💡 **Dica:** Use o menu recolhido em telas menores ou quando precisar de mais espaço para visualizar dados.

---

## Dashboard

O Dashboard é a tela inicial que exibe indicadores importantes do negócio.

### 6.1. Cards de Indicadores

**Faturamento do Mês**
- 💰 Mostra o total faturado no mês atual
- Cor: Azul
- Atualizado automaticamente

**Lucro do Mês**
- 📈 Exibe o lucro líquido do mês
- Cor: Verde
- Calculado: Faturamento - Custos

**Atendimentos do Mês**
- 🤝 Contador de atendimentos realizados
- Cor: Laranja
- Inclui serviços e vendas

**Clientes Ativos**
- 👥 Número total de clientes cadastrados
- Cor: Roxo
- Apenas clientes ativos

### 6.2. Gráficos

**Faturamento e Lucro (Últimos 6 Meses)**
- Gráfico de linhas comparativo
- Mostra evolução mensal
- Permite identificar tendências

**Serviços Mais Realizados**
- Gráfico de pizza
- Top 5 serviços mais executados
- Percentual de cada serviço

**Produtos com Menor Estoque**
- Gráfico de barras horizontal
- Produtos com estoque crítico
- Alerta para necessidade de reposição

### 6.3. Próximos Agendamentos

Tabela com os próximos compromissos:
- **Data:** Data e hora do agendamento
- **Cliente:** Nome do cliente
- **Veículo:** Placa do veículo
- **Valor:** Valor estimado
- **Observações:** Detalhes do agendamento

### 6.4. Botões de Ação

**Atualizar** 🔄
- Atualiza todos os dados do dashboard
- Busca informações mais recentes
- Atalho: F5

**Gerar Relatório** 📊
- Exporta relatório completo em Excel (.ods)
- Inclui: Faturamento, Serviços e Produtos
- Salvo automaticamente na Área de Trabalho

---

## Cadastros

### 7.1. Produtos

Gerenciamento completo do catálogo de produtos e peças.

#### 7.1.1. Cadastrar Novo Produto

1. Clique em **"Produtos"** no menu lateral
2. Clique no botão **"+ Adicionar"**
3. Preencha os campos obrigatórios:
   - **Código:** Código único do produto (alfanumérico)
   - **Nome:** Nome/descrição do produto
   - **Categoria:** Selecione uma categoria
   - **Fornecedor:** Selecione o fornecedor
   - **Estoque Mínimo:** Quantidade mínima em estoque
   - **Estoque Máximo:** Quantidade máxima em estoque
   - **Preço de Custo:** Valor de compra
   - **Preço de Venda:** Valor de venda ao cliente
   - **Margem de Lucro:** Calculada automaticamente
4. Campos opcionais:
   - **Localização:** Posição no estoque
   - **Observações:** Informações adicionais
5. Clique em **"Salvar"**

#### 7.1.2. Pesquisar Produtos

- **Barra de Pesquisa:** Digite nome, código ou categoria
- **Filtros:** Use os filtros para refinar a busca
- **Ordenação:** Clique nos cabeçalhos das colunas

#### 7.1.3. Editar Produto

1. Localize o produto na lista
2. Clique no botão **"✏️ Editar"**
3. Modifique os campos desejados
4. Clique em **"Salvar"**

#### 7.1.4. Excluir Produto

1. Selecione o produto
2. Clique no botão **"🗑️ Excluir"**
3. Confirme a exclusão

> ⚠️ **ATENÇÃO:** Produtos com movimentações não podem ser excluídos, apenas desativados.

#### 7.1.5. Dicas - Produtos

✅ Use códigos padronizados (ex: BR-001, FIL-050)
✅ Mantenha categorias organizadas
✅ Configure estoque mínimo para receber alertas
✅ Atualize preços regularmente
✅ Use o campo Observações para características especiais

---

### 7.2. Clientes

Cadastro e gestão de clientes e seus veículos.

#### 7.2.1. Cadastrar Novo Cliente

1. Clique em **"Clientes"** no menu lateral
2. Clique em **"+ Adicionar Cliente"**
3. **Dados Pessoais:**
   - **Nome Completo:** Nome do cliente (obrigatório)
   - **CPF/CNPJ:** Documento do cliente
   - **Telefone:** Telefone principal (obrigatório)
   - **E-mail:** E-mail para contato
   - **Data de Nascimento:** Data de nascimento
4. **Endereço:**
   - **CEP:** Código postal
   - **Logradouro:** Rua/Avenida
   - **Número:** Número do endereço
   - **Complemento:** Apto, sala, etc.
   - **Bairro:** Bairro
   - **Cidade:** Cidade
   - **Estado:** UF
5. **Observações:**
   - Campo livre para anotações
6. Clique em **"Salvar"**

#### 7.2.2. Cadastrar Veículo do Cliente

1. Abra o cadastro do cliente
2. Na aba **"Veículos"**, clique em **"+ Adicionar Veículo"**
3. Preencha os dados:
   - **Placa:** Placa do veículo (obrigatório)
   - **Marca:** Fabricante do veículo
   - **Modelo:** Modelo do veículo
   - **Ano:** Ano de fabricação
   - **Cor:** Cor do veículo
   - **Observações:** Características especiais
4. Clique em **"Salvar"**

#### 7.2.3. Pesquisar Clientes

- **Por Nome:** Digite o nome na barra de pesquisa
- **Por CPF/CNPJ:** Digite o documento
- **Por Telefone:** Digite o telefone
- **Por Veículo:** Pesquise pela placa

#### 7.2.4. Editar Cliente

1. Localize o cliente na lista
2. Clique em **"✏️ Editar"**
3. Modifique os dados necessários
4. Clique em **"Salvar"**

#### 7.2.5. Histórico do Cliente

Visualize todo o histórico de atendimentos:
- Lista de todos os serviços realizados
- Datas de atendimento
- Valores pagos
- Veículos atendidos
- Observações de cada atendimento

#### 7.2.6. Dicas - Clientes

✅ Sempre solicite um telefone de contato
✅ Mantenha os dados atualizados
✅ Use o campo Observações para preferências
✅ Cadastre todos os veículos do cliente
✅ Consulte o histórico antes de atender

---

### 7.3. Categorias

Organização de produtos por categorias.

#### 7.3.1. Cadastrar Nova Categoria

1. Clique em **"Categorias"** no menu lateral
2. Clique em **"+ Adicionar"**
3. Preencha:
   - **Nome da Categoria:** Nome descritivo (obrigatório)
   - **Descrição:** Detalhes sobre a categoria
4. Clique em **"Salvar"**

#### 7.3.2. Exemplos de Categorias

- 🔧 Filtros (óleo, ar, combustível)
- 🔩 Peças de Motor
- 🛞 Pneus e Rodas
- ⚡ Sistema Elétrico
- 🔧 Ferramentas
- 💡 Iluminação
- 🚗 Acessórios

#### 7.3.3. Editar/Excluir Categoria

- **Editar:** Clique no botão "✏️" ao lado da categoria
- **Excluir:** Clique no botão "🗑️" (apenas se não houver produtos vinculados)

---

### 7.4. Fornecedores

Cadastro de fornecedores de produtos.

#### 7.4.1. Cadastrar Novo Fornecedor

1. Clique em **"Fornecedores"** no menu lateral
2. Clique em **"+ Adicionar"**
3. **Dados da Empresa:**
   - **Nome/Razão Social:** Nome do fornecedor (obrigatório)
   - **Nome Fantasia:** Nome comercial
   - **CNPJ:** CNPJ do fornecedor
   - **Inscrição Estadual:** IE do fornecedor
4. **Contato:**
   - **Telefone:** Telefone principal (obrigatório)
   - **E-mail:** E-mail para contato
   - **Site:** Website do fornecedor
   - **Contato Principal:** Nome do responsável
5. **Endereço:**
   - CEP, Logradouro, Número, Complemento
   - Bairro, Cidade, Estado
6. **Dados Bancários:**
   - **Banco:** Nome do banco
   - **Agência:** Número da agência
   - **Conta:** Número da conta
7. **Observações:**
   - Condições de pagamento
   - Prazos de entrega
   - Informações relevantes
8. Clique em **"Salvar"**

#### 7.4.2. Pesquisar Fornecedores

- Digite nome, CNPJ ou cidade na busca
- Ordene por nome ou cidade

#### 7.4.3. Dicas - Fornecedores

✅ Cadastre fornecedores alternativos
✅ Registre condições de pagamento nas observações
✅ Mantenha os contatos atualizados
✅ Anote prazos de entrega médios

---

### 7.5. Serviços

Cadastro dos serviços oferecidos pela oficina.

#### 7.5.1. Cadastrar Novo Serviço

1. Clique em **"Serviços"** no menu lateral
2. Clique em **"+ Adicionar"**
3. **Dados do Serviço:**
   - **Nome do Serviço:** Nome descritivo (obrigatório)
   - **Descrição:** Detalhes sobre o serviço
   - **Preço:** Valor cobrado pelo serviço
   - **Tempo Estimado:** Duração em minutos
   - **Categoria:** Categoria do serviço
4. **Produtos Utilizados:**
   - Clique em **"+ Adicionar Produto"**
   - Selecione o produto
   - Informe a quantidade necessária
   - Adicione mais produtos se necessário
5. **Observações:**
   - Instruções especiais
   - Requisitos técnicos
6. Clique em **"Salvar"**

#### 7.5.2. Exemplos de Serviços

**Troca de Óleo Completa**
- Descrição: Troca de óleo do motor + filtro
- Produtos: Óleo 5W40 (4L), Filtro de óleo
- Tempo: 30 minutos

**Alinhamento e Balanceamento**
- Descrição: Alinhamento + balanceamento das 4 rodas
- Produtos: Chumbinho de balanceamento
- Tempo: 60 minutos

**Revisão Geral**
- Descrição: Check-up completo do veículo
- Produtos: Vários filtros, fluidos
- Tempo: 120 minutos

#### 7.5.3. Vincular Produtos ao Serviço

Quando você vincula produtos ao serviço:
- O sistema calcula automaticamente o custo
- No atendimento, os produtos são baixados do estoque
- O valor total do serviço considera mão de obra + produtos

#### 7.5.4. Dicas - Serviços

✅ Cadastre serviços padronizados
✅ Vincule todos os produtos necessários
✅ Defina tempo estimado realista
✅ Atualize preços regularmente
✅ Use descrições claras

---

## 8. Gestão de Estoque

### 8.1. Movimento de Estoque

Controle de entradas e saídas de produtos.

#### 8.1.1. Registrar Entrada de Produtos

**Compra de Fornecedor:**

1. Clique em **"Mov. Estoque"** no menu lateral
2. Clique em **"+ Nova Entrada"**
3. Selecione **"Tipo: ENTRADA"**
4. Preencha:
   - **Data:** Data da entrada
   - **Fornecedor:** Selecione o fornecedor
   - **Nota Fiscal:** Número da NF (opcional)
   - **Produto:** Selecione o produto
   - **Quantidade:** Quantidade recebida
   - **Valor Unitário:** Preço de compra
   - **Valor Total:** Calculado automaticamente
   - **Observações:** Informações adicionais
5. Para adicionar mais produtos:
   - Clique em **"+ Adicionar Produto"**
   - Repita o processo
6. Clique em **"Salvar"**

> 💡 **Dica:** O sistema atualiza automaticamente o estoque e o preço médio de compra.

#### 8.1.2. Registrar Saída de Produtos

**Saídas Manuais (Uso interno, perda, devolução):**

1. Clique em **"+ Nova Saída"**
2. Selecione **"Tipo: SAÍDA"**
3. Preencha:
   - **Data:** Data da saída
   - **Motivo:** Selecione o motivo:
     - Venda avulsa
     - Uso interno
     - Perda/Dano
     - Devolução
     - Transferência
   - **Produto:** Selecione o produto
   - **Quantidade:** Quantidade de saída
   - **Observações:** Justificativa da saída
4. Clique em **"Salvar"**

> ⚠️ **IMPORTANTE:** Saídas por atendimento são registradas automaticamente ao finalizar um atendimento.

#### 8.1.3. Ajuste de Estoque

Para corrigir divergências de inventário:

1. Clique em **"+ Ajuste de Estoque"**
2. Selecione **"Tipo: AJUSTE"**
3. Preencha:
   - **Produto:** Produto a ajustar
   - **Saldo Atual:** Mostra o estoque no sistema
   - **Saldo Real:** Informe a quantidade física real
   - **Diferença:** Calculada automaticamente
   - **Motivo:** Explique a diferença
4. Clique em **"Salvar"**

#### 8.1.4. Consultar Movimentações

**Filtros Disponíveis:**
- **Por Período:** Data inicial e final
- **Por Tipo:** Entrada, Saída, Ajuste
- **Por Produto:** Específico ou todos
- **Por Fornecedor:** Em caso de entradas

**Visualização:**
- Lista todas as movimentações
- Mostra tipo, data, produto, quantidade e valor
- Permite editar ou excluir (se permitido)

---

### 8.2. Saldo de Estoque

Consulta rápida do estoque atual.

#### 8.2.1. Visualizar Saldo

A tela mostra uma tabela com:
- **Código:** Código do produto
- **Produto:** Nome do produto
- **Categoria:** Categoria do produto
- **Estoque Atual:** Quantidade em estoque
- **Estoque Mínimo:** Ponto de reposição
- **Estoque Máximo:** Capacidade máxima
- **Status:** Indicador visual:
  - 🟢 Verde: Estoque normal
  - 🟡 Amarelo: Próximo do mínimo
  - 🔴 Vermelho: Abaixo do mínimo

#### 8.2.2. Filtros e Busca

- **Por Nome:** Digite o nome do produto
- **Por Categoria:** Filtre por categoria
- **Por Status:** Filtro de criticidade:
  - Todos
  - Normal
  - Atenção (próximo do mínimo)
  - Crítico (abaixo do mínimo)

#### 8.2.3. Alertas de Estoque

O sistema gera alertas automáticos quando:
- ⚠️ Produto atinge estoque mínimo
- 🚨 Produto fica sem estoque
- 📊 Produto está acima do estoque máximo

#### 8.2.4. Inventário Físico

Para realizar inventário:

1. Clique em **"Iniciar Inventário"**
2. O sistema gera lista de todos produtos
3. Imprima a lista (opcional)
4. Conte fisicamente cada item
5. Informe as quantidades reais
6. O sistema calcula diferenças
7. Confirme os ajustes necessários
8. Clique em **"Finalizar Inventário"**

> 💡 **Dica:** Realize inventário mensalmente para manter o controle.

---

## 9. Atendimentos

Registro de vendas e serviços prestados.

### 9.1. Novo Atendimento

#### 9.1.1. Iniciando um Atendimento

1. Clique em **"Atendimentos"** no menu lateral
2. Clique em **"+ Novo Atendimento"**
3. **Dados Básicos:**
   - **Data:** Data do atendimento (padrão: hoje)
   - **Cliente:** Selecione ou cadastre novo
   - **Veículo:** Selecione um veículo do cliente
   - **Status:** Selecione o status:
     - Orçamento
     - Em andamento
     - Concluído
     - Cancelado

#### 9.1.2. Adicionar Serviços

1. Na seção **"Serviços"**, clique em **"+ Adicionar Serviço"**
2. Selecione o serviço da lista
3. Informe a **Quantidade** (padrão: 1)
4. O sistema preenche automaticamente:
   - Valor unitário do serviço
   - Produtos necessários
   - Valor total
5. Você pode alterar o valor se necessário
6. Repita para adicionar mais serviços

#### 9.1.3. Adicionar Produtos Avulsos

Para venda de produtos sem serviço:

1. Na seção **"Produtos"**, clique em **"+ Adicionar Produto"**
2. Selecione o produto
3. Informe a quantidade
4. O sistema mostra:
   - Valor unitário
   - Estoque disponível
   - Valor total
5. Confirme a adição

> ⚠️ **ATENÇÃO:** Verifique se há estoque disponível antes de adicionar.

#### 9.1.4. Valores do Atendimento

O sistema calcula automaticamente:

**Custos:**
- Custo dos produtos (baseado no preço médio de compra)
- Custo total dos produtos

**Valores de Venda:**
- Valor dos serviços (mão de obra)
- Valor dos produtos
- **Valor Total:** Soma de serviços + produtos

**Resultado:**
- **Lucro Bruto:** Valor Total - Custos
- **Margem:** Percentual de lucro

#### 9.1.5. Observações e Anotações

Use o campo **"Observações"** para registrar:
- Reclamações do cliente
- Problemas encontrados
- Recomendações de serviços futuros
- Garantias aplicadas
- Condições de pagamento especiais

#### 9.1.6. Finalizar Atendimento

1. Revise todos os itens
2. Confira os valores
3. Marque o status como **"Concluído"**
4. Clique em **"Salvar"**
5. O sistema:
   - Baixa os produtos do estoque
   - Registra o faturamento
   - Atualiza o histórico do cliente
6. Opções após salvar:
   - **Imprimir OS:** Ordem de Serviço
   - **Enviar por E-mail:** Envia OS para o cliente
   - **Novo Atendimento:** Inicia outro atendimento

### 9.2. Orçamentos

#### 9.2.1. Criar Orçamento

1. Siga os mesmos passos de um atendimento
2. Marque o status como **"Orçamento"**
3. Salve normalmente
4. O orçamento NÃO:
   - Baixa estoque
   - Registra faturamento
   - Afeta indicadores

#### 9.2.2. Aprovar Orçamento

1. Localize o orçamento na lista
2. Clique em **"✏️ Editar"**
3. Altere o status para **"Em andamento"**
4. Salve
5. Ao concluir o serviço, mude para **"Concluído"**

#### 9.2.3. Cancelar Orçamento

1. Abra o orçamento
2. Altere status para **"Cancelado"**
3. Informe o motivo nas observações
4. Salve

### 9.3. Consultar Atendimentos

#### 9.3.1. Filtros de Pesquisa

- **Por Período:** Data inicial e final
- **Por Cliente:** Nome ou CPF
- **Por Veículo:** Placa
- **Por Status:** Todos, Orçamento, Em andamento, Concluído, Cancelado
- **Por Valor:** Faixa de valores

#### 9.3.2. Visualização

A lista mostra:
- Data do atendimento
- Cliente e veículo
- Status (com cor indicativa)
- Valor total
- Botões de ação

#### 9.3.3. Ações Rápidas

- **👁️ Visualizar:** Ver detalhes completos
- **✏️ Editar:** Modificar o atendimento
- **🖨️ Imprimir:** Imprimir OS
- **📧 E-mail:** Enviar por e-mail
- **🗑️ Excluir:** Remover (apenas orçamentos)

---

## 10. Calendário

Gestão de agendamentos e compromissos.

### 10.1. Visualizar Calendário

1. Clique em **"Calendário"** no menu lateral
2. Visualizações disponíveis:
   - **Mês:** Visão mensal completa
   - **Semana:** Detalhes semanais
   - **Dia:** Agenda diária
   - **Lista:** Lista de agendamentos

### 10.2. Criar Novo Agendamento

#### 10.2.1. Passo a Passo

1. Clique na data/hora desejada no calendário
   - OU clique no botão **"+ Novo Agendamento"**
2. Preencha os dados:
   - **Cliente:** Selecione o cliente
   - **Veículo:** Selecione o veículo (opcional)
   - **Data:** Data do agendamento
   - **Hora Início:** Hora de início
   - **Hora Fim:** Hora de término (calculada automaticamente)
   - **Serviço:** Selecione o serviço agendado
   - **Valor Estimado:** Valor previsto
   - **Status:** 
     - Agendado
     - Confirmado
     - Em atendimento
     - Concluído
     - Cancelado
   - **Observações:** Detalhes importantes
3. Clique em **"Salvar"**

#### 10.2.2. Cores dos Status

- 🔵 **Azul:** Agendado (aguardando confirmação)
- 🟢 **Verde:** Confirmado
- 🟡 **Amarelo:** Em atendimento
- ⚫ **Cinza:** Concluído
- 🔴 **Vermelho:** Cancelado

### 10.3. Gerenciar Agendamentos

#### 10.3.1. Confirmar Agendamento

1. Clique no agendamento
2. Altere status para **"Confirmado"**
3. Salve

> 💡 **Dica:** Confirme com o cliente por telefone antes.

#### 10.3.2. Reagendar

1. Clique no agendamento
2. Altere a data e/ou horário
3. Atualize as observações (motivo do reagendamento)
4. Salve

#### 10.3.3. Cancelar Agendamento

1. Abra o agendamento
2. Mude status para **"Cancelado"**
3. Informe o motivo nas observações
4. Salve

#### 10.3.4. Converter em Atendimento

Quando o cliente chegar:

1. Clique no agendamento
2. Clique em **"Criar Atendimento"**
3. O sistema abre a tela de atendimento
4. Os dados do agendamento são preenchidos automaticamente
5. Continue o atendimento normalmente

### 10.4. Lembretes e Notificações

O sistema pode enviar lembretes:
- 24 horas antes do agendamento
- 2 horas antes do agendamento
- No horário do agendamento

> ⚙️ Configure nas **Configurações do Sistema**

### 10.5. Dicas - Calendário

✅ Sempre confirme agendamentos por telefone
✅ Deixe intervalos entre agendamentos
✅ Respeite o tempo estimado dos serviços
✅ Mantenha observações detalhadas
✅ Atualize status em tempo real

---

## 11. Relatórios

### 11.1. Gerar Relatório do Dashboard

1. Na tela **Dashboard**, clique em **"Gerar Relatório"**
2. O sistema gera um arquivo Excel (.ods) com 3 planilhas:

#### 11.1.1. Planilha 1: Faturamento
- Data dos atendimentos
- Cliente e veículo
- Valor praticado
- Lucro obtido
- Observações
- **Totalizadores** no final

#### 11.1.2. Planilha 2: Serviços
- Serviço realizado
- Descrição completa
- Quantidade executada
- Valor unitário
- Data, cliente e veículo

#### 11.1.3. Planilha 3: Produtos
- Produtos utilizados
- Quantidade por serviço
- Data, cliente e veículo
- Serviço relacionado

### 11.2. Localizar Relatórios

- Os relatórios são salvos na **Área de Trabalho**
- Nome do arquivo: `Relatorio_Faturamento_AAAA_MM.ods`
- Exemplo: `Relatorio_Faturamento_2024_03.ods`

### 11.3. Abrir Relatórios

Os arquivos podem ser abertos com:
- **Microsoft Excel** (2010 ou superior)
- **LibreOffice Calc** (gratuito)
- **Google Sheets** (online)

### 11.4. Personalizar Relatórios

Você pode editar o arquivo gerado:
- Adicionar gráficos
- Criar tabelas dinâmicas
- Aplicar filtros avançados
- Adicionar fórmulas
- Formatar células

---

## 12. Dicas e Boas Práticas

### 12.1. Organização

✅ **Mantenha Cadastros Atualizados**
- Revise dados de clientes regularmente
- Atualize preços de produtos mensalmente
- Verifique dados de fornecedores

✅ **Use Categorias Consistentes**
- Crie padrão de nomenclatura
- Agrupe produtos relacionados
- Facilita buscas e relatórios

✅ **Registre Observações**
- Anote informações relevantes
- Documente problemas encontrados
- Registre acordos especiais

### 12.2. Controle de Estoque

✅ **Realize Inventários Periódicos**
- Mensal ou trimestral
- Compare físico vs. sistema
- Ajuste divergências imediatamente

✅ **Configure Estoques Mínimos**
- Baseie-se no consumo médio
- Considere prazo de entrega do fornecedor
- Ajuste sazonalmente se necessário

✅ **Monitore Produtos Críticos**
- Use o Dashboard para visualizar
- Configure alertas de estoque baixo
- Tenha fornecedores alternativos

### 12.3. Atendimento ao Cliente

✅ **Consulte Histórico**
- Veja atendimentos anteriores
- Identifique padrões de problemas
- Ofereça soluções preventivas

✅ **Faça Orçamentos Detalhados**
- Liste todos os serviços necessários
- Inclua produtos que serão trocados
- Explique cada item ao cliente

✅ **Mantenha Comunicação**
- Confirme agendamentos
- Informe sobre andamento do serviço
- Avise se houver necessidade de serviços adicionais

### 12.4. Financeiro

✅ **Acompanhe Indicadores**
- Verifique Dashboard diariamente
- Compare faturamento mensal
- Analise margem de lucro

✅ **Controle Custos**
- Registre valores de compra corretamente
- Compare fornecedores
- Negocie melhores preços

✅ **Gere Relatórios Regulares**
- Mensal para análise de desempenho
- Trimestral para planejamento
- Anual para declarações

### 12.5. Segurança

✅ **Faça Backup Regularmente**
- Diário de preferência
- Guarde em local seguro
- Teste a restauração periodicamente

✅ **Controle de Acesso**
- Use senhas fortes
- Não compartilhe credenciais
- Altere senhas periodicamente

✅ **Proteção de Dados**
- Respeite LGPD
- Não divulgue dados de clientes
- Mantenha informações confidenciais seguras

---

## 13. Solução de Problemas

### 13.1. Problemas de Login

**Não consigo fazer login**
- ✅ Verifique se CAPS LOCK está desativado
- ✅ Confirme usuário e senha
- ✅ Tente recuperar senha com administrador
- ✅ Verifique se usuário não foi desativado

**Sistema não abre**
- ✅ Verifique se .NET 8.0 está instalado
- ✅ Execute como administrador
- ✅ Verifique antivírus
- ✅ Reinstale o sistema

### 13.2. Problemas de Cadastro

**Não consigo salvar dados**
- ✅ Verifique campos obrigatórios
- ✅ Confira formatos (CPF, CNPJ, telefone)
- ✅ Verifique se há duplicação de código
- ✅ Confirme conexão com banco de dados

**Cadastro não aparece na lista**
- ✅ Limpe filtros de pesquisa
- ✅ Verifique se cadastro foi salvo
- ✅ Atualize a tela (F5)
- ✅ Verifique se não está inativo

### 13.3. Problemas de Estoque

**Estoque negativo**
- ✅ Verifique movimentações incorretas
- ✅ Faça ajuste de estoque
- ✅ Corrija lançamentos errados
- ✅ Registre entrada de produtos

**Estoque não atualiza**
- ✅ Confirme se atendimento foi finalizado
- ✅ Verifique se produtos estão vinculados ao serviço
- ✅ Recarregue a tela de saldo
- ✅ Verifique permissões do usuário

### 13.4. Problemas de Relatórios

**Relatório não é gerado**
- ✅ Verifique se há dados no período
- ✅ Confirme permissões de escrita na pasta
- ✅ Libere espaço em disco
- ✅ Feche arquivos Excel abertos

**Relatório vazio**
- ✅ Ajuste período de datas
- ✅ Verifique filtros aplicados
- ✅ Confirme se há atendimentos cadastrados
- ✅ Recarregue dados do Dashboard

### 13.5. Problemas de Performance

**Sistema lento**
- ✅ Feche programas desnecessários
- ✅ Limpe arquivos temporários
- ✅ Verifique espaço em disco
- ✅ Atualize o sistema
- ✅ Faça manutenção do banco de dados

**Tela congela**
- ✅ Aguarde conclusão de operação
- ✅ Verifique conexão de rede (se houver)
- ✅ Reinicie o sistema
- ✅ Contate suporte técnico

### 13.6. Contato com Suporte

Se o problema persistir:

📧 **E-mail:** suporte@autopecas.com.br
📞 **Telefone:** (11) 1234-5678
💬 **WhatsApp:** (11) 91234-5678
🕐 **Horário:** Segunda a Sexta, 8h às 18h

**Ao contatar o suporte, tenha em mãos:**
- Descrição detalhada do problema
- Mensagem de erro (se houver)
- Passos para reproduzir o problema
- Versão do sistema
- Sistema operacional

---

## Apêndices

### A. Atalhos de Teclado

| Tecla | Ação |
|-------|------|
| F5 | Atualizar tela |
| Ctrl + N | Novo cadastro |
| Ctrl + S | Salvar |
| Ctrl + F | Buscar |
| Ctrl + P | Imprimir |
| Esc | Cancelar/Fechar |
| Enter | Confirmar/Próximo campo |

### B. Glossário

- **Atendimento:** Registro de venda ou serviço prestado a um cliente
- **Dashboard:** Painel de indicadores e gráficos gerenciais
- **Estoque Mínimo:** Quantidade mínima que deve ser mantida em estoque
- **Lucro Bruto:** Diferença entre valor de venda e custo
- **Margem de Lucro:** Percentual de lucro sobre o valor de venda
- **OS (Ordem de Serviço):** Documento que registra serviços e produtos
- **Saldo de Estoque:** Quantidade disponível de produtos em estoque

---

## Conclusão

Este manual cobre as principais funcionalidades do **Sistema AutoPeças**. Para melhor aproveitamento:

1. ✅ Explore cada módulo gradualmente
2. ✅ Pratique com dados de teste inicialmente
3. ✅ Mantenha cadastros organizados desde o início
4. ✅ Realize backups regularmente
5. ✅ Consulte este manual sempre que necessário

**Versão do Manual:** 1.0
**Data:** Dezembro 2025
**Sistema:** AutoPeças v1.0

---

**© 2025 Sistema AutoPeças - Todos os direitos reservados**
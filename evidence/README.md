# Evidence Log

Use este arquivo como índice das evidências das trilhas SSE e LeetCode.

## Template de registro

### ID da task
Ex.: `LC-001` ou `SSE-01B`

**Tema:**

**Objetivo:**

**Hipótese / problema:**

**Implementação / experimento:**

**Como reproduzir:**
```bash
# comandos necessários
```

**Evidência gerada:**
- código:
- teste:
- trace/log:
- benchmark/query/diagrama/ADR:

**Resultado observado:**

**Complexidade / trade-offs:**

**Edge cases / falhas testadas:**

**Aprendizado em uma frase:**

**Próxima revisão:**

---

## Regras específicas — LeetCode

Antes de fechar uma task LC, registrar explicitamente:
- brute force;
- Big O antes da solução alvo;
- gargalo;
- solução otimizada;
- edge cases;
- frase para reconhecer o padrão no futuro.

## Regras específicas — SSE

Antes de fechar um laboratório SSE, anexar pelo menos uma evidência verificável: código, teste, trace, query, benchmark, diagrama ou ADR, conforme o tema.

## Validação inicial do repositório

Data: 2026-09-08

Status: VALIDADO LOCALMENTE.

Primeira tentativa:
- `dotnet --info`: SDK reconhecido.
- `dotnet restore`: falhou com `MSB1011` porque a pasta contém mais de um arquivo de projeto/solução.
- causa: coexistem `MyLeet.sln` e `Questions.csproj` na raiz.
- correção: informar explicitamente o projeto/solução.

Comandos validados:
```bash
dotnet restore Questions.csproj
dotnet run --project Questions.csproj
```

Alternativa para restaurar a solução:
```bash
dotnet restore MyLeet.sln
```

Resultado final:
- `dotnet restore Questions.csproj`: OK
- `dotnet run --project Questions.csproj`: OK
- repositório executa localmente: SIM
- README de evidências existe: SIM

SET-024: critério de conclusão atendido.

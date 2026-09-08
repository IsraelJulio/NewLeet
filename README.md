# Engineering Lab — SSE + LeetCode

Este repositório é o laboratório executável das trilhas **SSE (Roadmap Sênior)** e **LC (LeetCode)** do plano de estudos.

O objetivo não é acumular arquivos, mas guardar **evidência verificável de aprendizado**: código, testes, medições, traces, queries, diagramas, ADRs e decisões técnicas.

## Estrutura de uso

- `leetcode/` — exercícios e padrões de algoritmos em C#.
- `sse/` — laboratórios do Roadmap Sênior.
- `evidence/` — registro das evidências produzidas.
- Arquivos C# já existentes na raiz são exercícios antigos e podem ser reorganizados gradualmente, sem necessidade de refatoração artificial.

## Regra para LeetCode

Para cada exercício, registrar:

1. solução brute force;
2. complexidade de tempo e espaço;
3. gargalo encontrado;
4. solução otimizada;
5. edge cases testados;
6. frase de reconhecimento do padrão.

## Regra para SSE

Cada laboratório deve produzir pelo menos uma evidência executável ou verificável, como:

- código;
- teste;
- trace/log;
- query/EXPLAIN;
- benchmark;
- diagrama;
- ADR;
- reprodução de falha + correção.

## Executar localmente

Pré-requisito: SDK do .NET instalado.

```bash
dotnet --info
dotnet restore
dotnet run
```

O projeto atual está definido em `Questions.csproj`.

## Evidências

O padrão oficial de registro está em [`evidence/README.md`](evidence/README.md).

## Critério de qualidade

Uma atividade só deve ser tratada como evidência quando outra pessoa conseguir entender:

- qual era o problema/objetivo;
- o que foi implementado ou testado;
- como reproduzir;
- qual foi o resultado observado;
- qual trade-off ou aprendizado ficou.

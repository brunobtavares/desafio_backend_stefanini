import { Cidade } from "./Cidade";

export type Pessoa = {
  id: string,
  nome: string,
  cpf: string,
  cidadeId: string,
  cidade: Cidade
};

export type PessoaIncluir = {
  nome: string,
  cpf: string,
  cidadeId: string
};

export type PessoaAlterar = {
  id: string,
  nome: string,
  cpf: string,
  cidadeId: string
}

import { Component, OnInit } from '@angular/core';
import { PessoaService } from '../../../services/PessoaService';
import { Pessoa } from '../../../types/Pessoa';

@Component({
  selector: 'app-pessoas-listar',
  templateUrl: './pessoas-listar.component.html',
  styleUrls: ['./pessoas-listar.component.css']
})
export class PessoasListarComponent implements OnInit {

  pessoas: Pessoa[] = [];

  constructor(
    private _pessoaService: PessoaService
  ) { }

  ngOnInit(): void {
    this.getAllWithCitiesAsync();
  }

  getAllWithCitiesAsync() {
    this._pessoaService.getAllWithCitiesAsync().then(((r) => this.pessoas = r!));
  }

  remover(pessoa: Pessoa) {

    let remover = confirm(`Deseja realmente remover ${pessoa.nome} ?`)

    if (remover) {
      this._pessoaService.removerAsync(pessoa.id).then(r => {
        this.getAllWithCitiesAsync();
        alert(`${r?.nome} removido com sucesso!`);
      });
    }
  }
}

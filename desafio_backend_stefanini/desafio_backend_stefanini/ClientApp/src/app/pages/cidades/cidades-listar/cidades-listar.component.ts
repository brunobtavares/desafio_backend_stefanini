import { Component, OnInit } from '@angular/core';
import { CidadeService } from '../../../services/CidadeService';
import { Cidade } from '../../../types/Cidade';

@Component({
  selector: 'app-cidades-listar',
  templateUrl: './cidades-listar.component.html',
  styleUrls: ['./cidades-listar.component.css']
})
export class CidadesListarComponent implements OnInit {

  cidades: Cidade[] = [];

  constructor(
    private _cidadeService: CidadeService
  ) { }

  ngOnInit(): void {
    this.getAllAsync();
  }

  getAllAsync() {
    this._cidadeService.getAllAsync().then(((r) => this.cidades = r!));
  }

  remover(cidade: Cidade) {

    let remover = confirm(`Deseja realmente remover ${cidade.nome} ?`)

    if (remover) {
      this._cidadeService.removerAsync(cidade.id).then(r => {
        this.getAllAsync();
        alert(`${r?.nome} removido com sucesso!`)
      });
    }
  }
}

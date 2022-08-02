import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CidadeService } from '../../../services/CidadeService';
import { PessoaService } from '../../../services/PessoaService';
import { Cidade } from '../../../types/Cidade';

@Component({
  selector: 'app-pessoas-incluir',
  templateUrl: './pessoas-incluir.component.html',
  styleUrls: ['./pessoas-incluir.component.css']
})
export class PessoasIncluirComponent implements OnInit {

  cidades: Cidade[] = [];
  pessoaForm!: FormGroup;

  constructor(
    private _pessoaService: PessoaService,
    private _cidadeService: CidadeService,
    private _router: Router
  ) { }

  ngOnInit(): void {
    this.pessoaForm = new FormGroup({
      nome: new FormControl('', [Validators.required]),
      cpf: new FormControl('', [Validators.required]),
      cidadeId: new FormControl('', [Validators.required]),
    });

    this.getCidadesAsync();
  }

  getCidadesAsync() {
    this._cidadeService.getAllAsync().then(((r) => this.cidades = r!));
  }

  submit() {
    if (this.pessoaForm.valid) {
      this._pessoaService.incluirAsync({
        nome: this.pessoaForm.get('nome')?.value,
        cpf: this.pessoaForm.get('cpf')?.value,
        cidadeId: this.pessoaForm.get('cidadeId')?.value,
      }).then(() => this._router.navigate(['/pessoas/listar']));
    }
  }  
}

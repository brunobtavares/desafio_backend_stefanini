import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CidadeService } from '../../../services/CidadeService';
import { PessoaService } from '../../../services/PessoaService';
import { Cidade } from '../../../types/Cidade';

@Component({
  selector: 'app-pessoas-alterar',
  templateUrl: './pessoas-alterar.component.html',
  styleUrls: ['./pessoas-alterar.component.css']
})
export class PessoasAlterarComponent implements OnInit {

  cidades: Cidade[] = [];
  pessoaForm!: FormGroup;

  constructor(
    private _pessoaService: PessoaService,
    private _cidadeService: CidadeService,
    private _activatedroute: ActivatedRoute,
    private _router: Router
  ) { }

  ngOnInit(): void {
    let pessoaId = this._activatedroute.snapshot.paramMap.get("id");
    this.getPessoa(pessoaId!);

    this.pessoaForm = new FormGroup({
      id: new FormControl('', [Validators.required]),
      nome: new FormControl('', [Validators.required]),
      cpf: new FormControl('', [Validators.required]),
      cidadeId: new FormControl('', [Validators.required]),
    });

    this.getCidadesAsync();
  }

  getCidadesAsync() {
    this._cidadeService.getAllAsync().then(((r) => this.cidades = r!));
  }

  getPessoa(id: string) {
    this._pessoaService.getByIdAsync(id).then(r => {
      this.pessoaForm.get('id')?.setValue(r?.id);
      this.pessoaForm.get('nome')?.setValue(r?.nome);
      this.pessoaForm.get('cpf')?.setValue(r?.cpf);
      this.pessoaForm.get('cidadeId')?.setValue(r?.cidadeId);
    });
  }

  getAsync() {
    this._cidadeService.getAllAsync().then(((r) => this.cidades = r!));
  }

  submit() {
    if (this.pessoaForm.valid) {
      this._pessoaService.alterarAsync({
        id: this.pessoaForm.get('id')?.value,
        nome: this.pessoaForm.get('nome')?.value,
        cpf: this.pessoaForm.get('cpf')?.value,
        cidadeId: this.pessoaForm.get('cidadeId')?.value,
      }).then(() => this._router.navigate(['/pessoas/listar']));
    }
  }
}

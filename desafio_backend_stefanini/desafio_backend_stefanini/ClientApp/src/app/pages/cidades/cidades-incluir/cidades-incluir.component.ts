import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CidadeService } from '../../../services/CidadeService';

@Component({
  selector: 'app-cidades-incluir',
  templateUrl: './cidades-incluir.component.html',
  styleUrls: ['./cidades-incluir.component.css']
})
export class CidadesIncluirComponent implements OnInit {

  ufs: any[] = [
    { "nome": "Acre", "value": "AC" },
    { "nome": "Alagoas", "value": "AL" },
    { "nome": "Amapá", "value": "AP" },
    { "nome": "Amazonas", "value": "AM" },
    { "nome": "Bahia", "value": "BA" },
    { "nome": "Ceará", "value": "CE" },
    { "nome": "Espírito Santo", "value": "ES" },
    { "nome": "Goiás", "value": "GO" },
    { "nome": "Maranhão", "value": "MA" },
    { "nome": "Mato Grosso", "value": "MT" },
    { "nome": "Mato Grosso do Sul", "value": "MS" },
    { "nome": "Minas Gerais", "value": "MG" },
    { "nome": "Pará", "value": "PA" },
    { "nome": "Paraíba", "value": "PB" },
    { "nome": "Paraná", "value": "PR" },
    { "nome": "Pernambuco", "value": "PE" },
    { "nome": "Piauí", "value": "PI" },
    { "nome": "Rio de Janeiro", "value": "RJ" },
    { "nome": "Rio Grande do Norte", "value": "RN" },
    { "nome": "Rio Grande do Sul", "value": "RS" },
    { "nome": "Rondônia", "value": "RO" },
    { "nome": "Roraima", "value": "RR" },
    { "nome": "Santa Catarina", "value": "SC" },
    { "nome": "São Paulo", "value": "SP" },
    { "nome": "Sergipe", "value": "SE" },
    { "nome": "Tocantins", "value": "TO" },
    { "nome": "Distrito Federal", "value": "DF" }
  ];

  cidadeForm!: FormGroup;

  constructor(
    private _cidadeService: CidadeService,
    private _router: Router
  ) { }

  ngOnInit(): void {
    this.cidadeForm = new FormGroup({
      nome: new FormControl('', [Validators.required]),
      uf: new FormControl('', [Validators.required])
    });
  }

  submit() {
    if (this.cidadeForm.valid) {
      this._cidadeService.incluirAsync({
        nome: this.cidadeForm.get('nome')?.value,
        uf: this.cidadeForm.get('uf')?.value,
      }).then(() => this._router.navigate(['/cidades/listar']));
    }
  }
}

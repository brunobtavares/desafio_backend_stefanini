import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { apiUrl } from '../../main';
import { Pessoa, PessoaAlterar, PessoaIncluir } from '../types/Pessoa';

@Injectable({
  providedIn: 'root',
})
export class PessoaService {

  constructor(
    private _httpClient: HttpClient,
  ) { }

  getAllWithCitiesAsync() {
    return this._httpClient.get<Pessoa[]>(`${apiUrl}api/pessoa/getallwithcities`).toPromise();    
  }

  getAllAsync() {
    return this._httpClient.get<Pessoa[]>(`${apiUrl}api/pessoa/getall`).toPromise();
  }

  getByIdAsync(id: string) {
    return this._httpClient.get<Pessoa>(`${apiUrl}api/pessoa/${id}`).toPromise();
  }

  incluirAsync(pessoa: PessoaIncluir) {
    return this._httpClient.post<Pessoa>(`${apiUrl}api/pessoa/incluir`, pessoa).toPromise();
  }

  alterarAsync(pessoa: PessoaAlterar) {
    return this._httpClient.put<Pessoa>(`${apiUrl}api/pessoa/alterar`, pessoa).toPromise();
  }

  removerAsync(id: string) {
    return this._httpClient.delete<Pessoa>(`${apiUrl}api/pessoa/${id}`).toPromise();
  }
}

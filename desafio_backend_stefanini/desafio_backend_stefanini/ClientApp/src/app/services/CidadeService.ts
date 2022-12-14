import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { apiUrl } from '../../main';
import { Cidade, CidadeAlterar, CidadeIncluir } from '../types/Cidade';

@Injectable({
  providedIn: 'root',
})
export class CidadeService {
  constructor(
    private _httpClient: HttpClient
  ) { }

  getAllAsync() {
    return this._httpClient.get<Cidade[]>(`${apiUrl}api/cidade/getAll`).toPromise();
  }

  getByIdAsync(id: string) {
    return this._httpClient.get<Cidade>(`${apiUrl}api/cidade/${id}`).toPromise();
  }

  incluirAsync(cidade: CidadeIncluir) {
    return this._httpClient.post<Cidade>(`${apiUrl}api/cidade/incluir`, cidade).toPromise();
  }

  alterarAsync(cidade: CidadeAlterar) {
    return this._httpClient.put<Cidade>(`${apiUrl}api/cidade/alterar`, cidade).toPromise();
  }

  removerAsync(id: string) {
    return this._httpClient.delete<Cidade>(`${apiUrl}api/cidade/${id}`).toPromise();
  }
}

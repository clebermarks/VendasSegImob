import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class VendaService {

    vendasUrl = 'http://localhost:55123/api/Vendas/';

    constructor(private http: HttpClient) { }

    listar() {
        return this.http.get<any[]>(`${this.vendasUrl}`);
    }
}
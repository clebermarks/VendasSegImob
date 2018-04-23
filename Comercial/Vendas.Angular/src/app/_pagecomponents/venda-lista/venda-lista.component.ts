import { VendaService } from './../../venda.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-venda-lista',
  templateUrl: './venda-lista.component.html'
})
export class VendaListaComponent implements OnInit {

  vendas: Array<any>;

  constructor(private vendaService: VendaService) { }

  ngOnInit() {
    this.listar();
  }

  listar() {
    this.vendaService.listar().subscribe(dados => this.vendas == dados);
  }

}

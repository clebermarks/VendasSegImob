import { ProdutoService } from './../../produto.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-produto-lista',
  templateUrl: './produto-lista.component.html'
})
export class ProdutoListaComponent implements OnInit {

  produtos: Array<any>;

  constructor(private produtoService: ProdutoService) { }

  ngOnInit() {
    this.listar();
  }

  listar() {
    this.produtoService.listar().subscribe(dados => this.produtos == dados);
  }

}

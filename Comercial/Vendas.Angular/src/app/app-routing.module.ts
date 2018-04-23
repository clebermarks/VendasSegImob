import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

import { VendaComponent } from './venda/venda.component';
import { ProdutoComponent } from './produto/produto.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'produto', component: ProdutoComponent },
  {path: 'venda', component: VendaComponent },
  {path: 'about', component: AboutComponent }
];

@NgModule({
  imports: [
    //CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [ RouterModule ],
  declarations: []
})
export class AppRoutingModule { }

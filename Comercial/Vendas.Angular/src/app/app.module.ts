import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { ProdutoComponent } from './produto/produto.component';
import { VendaComponent } from './venda/venda.component';
import { ProdutoService } from './produto.service';
import { VendaService } from './venda.service';
import { ProdutoListaComponent } from './_pagecomponents/produto-lista/produto-lista.component';
import { VendaListaComponent } from './_pagecomponents/venda-lista/venda-lista.component';


@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    FooterComponent,
    HeaderComponent,
    HomeComponent,
    ProdutoComponent,
    VendaComponent,
    ProdutoListaComponent,
    VendaListaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [ ProdutoService, VendaService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }

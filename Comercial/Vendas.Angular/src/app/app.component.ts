import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  content = 'Bem-Vindo à Vendas!'

  constructor() { }

  ngOnInit() {
  }
}

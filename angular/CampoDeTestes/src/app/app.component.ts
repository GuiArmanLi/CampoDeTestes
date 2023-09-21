import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CampoDeTestes';

  pessoa!: {nome: string, idade: number, sexo: string};

  pessoas = [
    this.pessoa = {
      nome: "Dulcinea",
      idade: 53,
      sexo: "Feminino",
    },
    this.pessoa = {
      nome: "Lucas",
      idade: 23,
      sexo: "Masculino",
    },
    this.pessoa = {
      nome: "Gabriel",
      idade: 22,
      sexo: "Masculino",
    },
    this.pessoa = {
      nome: "Guilherme",
      idade: 20,
      sexo: "Masculino",
    }
  ]
}

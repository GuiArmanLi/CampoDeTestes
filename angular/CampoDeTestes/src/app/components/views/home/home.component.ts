import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  @Input() pessoas!: [];

  color: string = "green";
  backgroundColor: string = "gainsboro";
  border: string = "1px solid black";
  padding: string = "10px";

  contentPessoa = "contentPessoa";
  contentCard = "contentCard"
}

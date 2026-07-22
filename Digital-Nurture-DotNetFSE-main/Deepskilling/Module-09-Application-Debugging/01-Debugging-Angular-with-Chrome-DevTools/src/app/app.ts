import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  title = 'Angular Debugging Demo';

  showMessage(): void {
    debugger;
    console.log("Button clicked successfully!");
    alert("Debugging Successful!");
  }

}

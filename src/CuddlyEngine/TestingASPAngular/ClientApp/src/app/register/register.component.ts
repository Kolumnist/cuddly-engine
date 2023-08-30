import { Component } from '@angular/core';

import { User } from '../model/usermodel';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent {

  user = new User(0, "", "");

  submitted = false;

  onClickSubmit(data: any) {
    alert("Submitted data: " + data);
    this.submitted = true;
  }

}

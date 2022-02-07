import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthentificationService } from '../authentification.service';
import { Login } from '../ModelsDTO/login';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {


  loginForm = this.fb.group({
    email: ['', [Validators.required, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")]],
    password: ['', Validators.required],
  });

  constructor(private fb: FormBuilder, private auth: AuthentificationService) { }

  ngOnInit(): void {
    if(this.auth.isLoggedin())
      this.auth.logout();
  }

  onLogin(){
    var loginData = new Login(this.loginForm.value);
    this.auth.login(loginData).subscribe();
  }

}

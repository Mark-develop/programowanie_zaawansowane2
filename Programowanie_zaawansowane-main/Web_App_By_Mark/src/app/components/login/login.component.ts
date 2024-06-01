import { Component } from "@angular/core";
import { Router } from '@angular/router'; 
import { AuthService } from "../../auth.service";
@Component({
    selector: 'app-login',
    templateUrl:'login.component.html',
    styleUrls: ['login.component.scss']
})

export class LoginComponent {
    formData = {
      username: '',
      password: ''
    };

    constructor(private authService: AuthService, private router: Router) { }
  
    login() {
        if (this.formData.username === 'Mark' && this.formData.password === '123') {
          this.authService.login();
          this.router.navigate(['/dashboard'])
          console.log('User logged in');
        } else {
          this.authService.logout();
          console.log('Invalid credentials');
        }
    
        console.log(this.authService.isLoggedIn);
      }
    }
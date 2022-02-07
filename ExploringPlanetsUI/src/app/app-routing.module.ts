import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CaptainGuard } from './captain.guard';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { RegisterPageComponent } from './register-page/register-page.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full'},
  { path: 'login', component: LoginPageComponent },
  { path: 'register', component: RegisterPageComponent},
  { path: 'home/:userId', component: HomePageComponent, canActivate: [CaptainGuard]},
  { path: 'home', component: HomePageComponent, canActivate: [CaptainGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './component/pages/home/home.component';
import { ContactComponent } from './component/pages/contact/contact.component';
import { LoginComponent } from './user/login/login.component';
import { RegisterComponent } from './user/register/register.component';
import { ProfileComponent } from './user/profile/profile.component';
import {PlayerComponent} from './player/player.component'

const routes: Routes= [
    {path: '' , redirectTo: '/home', pathMatch:'full'},
    {path: 'home', component: HomeComponent},
    {path: 'play', component: PlayerComponent},
    {path: 'auth/login', component:LoginComponent},
    {path: 'auth/register', component: RegisterComponent},
    {path: 'auth/user/profile', component: ProfileComponent},
    {path: 'contact', component: ContactComponent}
]

@NgModule({
    imports: [RouterModule.forRoot(routes)],
exports: [RouterModule]
  })

export class AppRoutingModule { }
  
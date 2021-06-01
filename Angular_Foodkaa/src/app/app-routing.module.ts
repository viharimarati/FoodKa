import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OrdersComponent } from './orders/orders.component';
import { OrderComponent } from './orders/order/order.component';
import { HomeComponent } from './home/home.component';
import { MenuComponent } from './menu/menu.component';
import { AboutComponent } from './about/about.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  {path:'',redirectTo:'order',pathMatch:'full'},
  {path:'orders',component:OrdersComponent},
  {
    path:'home',component:HomeComponent
  },
  {
    path:'menu',component:MenuComponent
  },
  {
    path:'about',component:AboutComponent
  },
  {
path:'login',component:LoginComponent
  },
  {path:'order',children:[
    {path:'',component:OrderComponent},  
    {path:'edit/:id',component:OrderComponent},
  
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

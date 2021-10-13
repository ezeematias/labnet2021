import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import {MatCardModule} from '@angular/material/card';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon';

import { FormShippersComponent } from './shippers/form-shippers/form-shippers.component';
import { HomeComponent } from './home/home.component';
import { ShippersComponent } from './shippers/shippers.component';
import { CategoriesComponent } from './categories/categories.component';
import { ShippersService } from './shippers/services/shippers.service';

const appRoutes: Routes=[
{path:'', component:HomeComponent},
{path:'shippers', component:ShippersComponent},
{path:'categories', component:CategoriesComponent},
{path:'form-shippers', component:FormShippersComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    FormShippersComponent,
    HomeComponent,
    ShippersComponent,
    CategoriesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatCardModule,
    MatProgressBarModule,
    MatButtonModule,
    MatTableModule,
    MatListModule,
    MatIconModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [ShippersService],
  bootstrap: [AppComponent]
})
export class AppModule { }

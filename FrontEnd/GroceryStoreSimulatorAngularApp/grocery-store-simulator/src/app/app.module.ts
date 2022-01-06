import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { HttpClientModule } from '@angular/common/http';
import { AppConfig } from './config/AppConfig';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { OrderList } from './orders/order-list.component';
import { MatTableModule } from "@angular/material/table"
import {MatProgressSpinnerModule, MatSpinner} from '@angular/material/progress-spinner';
import { MatButton } from '@angular/material/button';



@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    HomeComponent,
    OrderList
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DashboardModule,
    HttpClientModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatTableModule,
    MatProgressSpinnerModule,
    MatButtonModule

  ],
  providers: [AppConfig],
  bootstrap: [AppComponent],
  exports: [
  ]
})
export class AppModule { }

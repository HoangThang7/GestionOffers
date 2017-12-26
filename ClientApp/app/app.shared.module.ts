import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/Admin/navmenu/navmenu.component';
import { ProfilComponent } from './components/Admin/profil/profil.component';
import { FetchDataComponent } from './components/Admin/fetchdata/fetchdata.component';
import { CounterComponent } from './components/Admin/counter/counter.component';
import { UserService } from './components/Services/UserService';
import { Configuration } from './components/Services/Configuration';
import { BrowserModule } from '@angular/platform-browser';
import { HomeComponent } from './components/home/home.component';
import { CookieModule } from 'ngx-cookie';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        ProfilComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        CookieModule.forRoot(),
        RouterModule.forRoot([
            { path: '', component: HomeComponent },
            { path: 'profil', component: ProfilComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: '/profil' }
        ])
    ],
    providers: [
        UserService,
        Configuration,

    ]
})
export class AppModuleShared {
}

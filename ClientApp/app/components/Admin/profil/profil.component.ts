import { Component, OnInit} from '@angular/core';
import { CookieService } from 'ngx-cookie';



@Component({
    selector: 'profil',
    templateUrl: './profil.component.html'
})
export class ProfilComponent implements OnInit {

    CurrentUser: any;

    constructor(private cookiService: CookieService) {
        
    }


    ngOnInit() {
        this.CurrentUser = this.cookiService.getObject('CurrentUser');
        console.log(this.CurrentUser.lastName);
    }

   
}

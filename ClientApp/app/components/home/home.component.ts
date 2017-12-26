import { Component, Input } from '@angular/core';
import { UserService } from '../Services/UserService';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',           
    styleUrls: ['./home.component.css']
})
export class HomeComponent {

    user: any;
    email: string;
    pwd: string;
    errorPassword: string;
    errorEmail: string;


    constructor(private loginService: UserService, private router: Router, private cookieService: CookieService) {

    }

    public getLogin() {
        return this.loginService.getUser(this.email)
            .subscribe(
            (resp: Response) => {
                this.user = resp.json();
                this.cookieService.putObject('CurrentUser', this.user);
                console.log(this.cookieService.get('CurrentUser'));

                if (this.user) {
                    if (this.pwd == this.user.password) {
                        this.router.navigate(['/profil']);
                    } else {
                        this.errorPassword = 'wrong password';
                    }
                } else {
                    this.errorEmail = 'wrong user';
                }

            },
            (Error) => console.log(Error));

    }
}
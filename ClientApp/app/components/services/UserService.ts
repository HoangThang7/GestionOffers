import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { Configuration } from './Configuration';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';


@Injectable()
export class UserService {

    public actionurl: string;
    public header = new Headers({ 'Content-type': 'application/json' });
   
    constructor(private http: Http, private _configuration: Configuration) {
        this.actionurl = this._configuration.ServerWithApiUrl + '/User';
    }

    public handleError(error: Response | any) {
        console.error('ApiService::handleError', error);
        return Observable.throw(error);
    }

    public getUser(email: string) {
        return this.http.get(this.actionurl + '/' + email)          
            .catch(this.handleError);
    }

    public addUser(itemName: any) {
        const toAdd = JSON.stringify({ ItemName: itemName });

        return this.http.post(this.actionurl, toAdd);
    }


}


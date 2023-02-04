import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { client, Client } from './Client';

const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'aplication/json'
  })
};



@Injectable({
  providedIn: 'root'
})
export class ClientService {

  url = "http://localhost:5001/api/clients";

  constructor(private http: HttpClient) { }

  GetAll(): Observable<Client[]>{
    return this.http.get<Client[]>(this.url);
  }

  GetById(id: number): Observable<Client>{
    const apiUrl =`${this.url}/${id}`;
    return this.http.get<Client>(apiUrl);
  }


  AddClient(client: Client): Observable<any>{
    return this.http.post<Client>(this.url, client, httpOptions);

  }

  Put(client: Client): Observable<any>{
    return this.http.put<Client>(this.url, client, httpOptions);
  }

  Delete(id: number): Observable<any>{
    const apiUrl = `${this.url}/${id}`;
    return this.http.delete<number>(apiUrl, httpOptions);
  }

}

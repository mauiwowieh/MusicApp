import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Song } from '../_models/song';

@Injectable({
  providedIn: 'root'
})
export class SongsService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getSongs(){
    return this.http.get<Song[]>(this.baseUrl + 'song');
  }
}

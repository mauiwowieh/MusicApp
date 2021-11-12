import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Song } from '../_models/song';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class SongsService {
  baseUrl = 'https://localhost:5001/api/';
  song: Song[] = [];

  constructor(private http: HttpClient) { }

  getSongs(){
    return this.http.get<Song[]>(this.baseUrl + 'song');
  }

  getSong(songName: string){
    return this.http.get<Song>(this.baseUrl+'song/'+songName);
  }
  searchMusic(songname: string, type='songName'){
    return this.http.get<Song>(this.baseUrl+'song/?query='+songname+'&offset=0&limit=20&type='+type);
    //.map(resp => res.json())
  }
  updateSong(song: Song){
    return this.http.put(this.baseUrl+'song', song);
  }

  deleteSong(songId: number){
    return this.http.delete(this.baseUrl+'song/delete-song/' + songId);
  }
}

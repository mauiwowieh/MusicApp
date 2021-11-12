import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Song } from '../_models/song';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedResult } from '../_models/pagination';


@Injectable({
  providedIn: 'root'
})
export class SongsService {
  baseUrl = 'https://localhost:5001/api/';
  song: Song[] = [];
  paginatedResult: PaginatedResult<Song[]>=new PaginatedResult<Song[]>();

  constructor(private http: HttpClient) { }

  getSongs(){
    return this.http.get<Song[]>(this.baseUrl + 'song');
  }

  // getSongs(page?:number, itemsPerPage?:number){
  //   let params=new HttpParams();

  //   if(page!==null && itemsPerPage!==null){
  //     params=params.append('pageNumber', page.toString() );
  //     params=params.append('pageSize', itemsPerPage.toString() );

  //   }
  //   return this.http.get<Song[]>(this.baseUrl + 'song', {observe:'response', params}).pipe(
  //     map(response =>{
  //       this.paginatedResult.result=response.body;
  //       if(response.headers.get('Pagination') !==null){
  //         this.paginatedResult.pagination=JSON.parse(response.headers.get('Pagination'));

  //       }
  //       return this.paginatedResult;
  //     })
  //   );
  // }

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

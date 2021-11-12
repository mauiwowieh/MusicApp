import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { Song } from 'src/app/_models/song';
import { SongsService } from 'src/app/_services/songs.service';

@Component({
  selector: 'app-song-card',
  templateUrl: './song-card.component.html',
  styleUrls: ['./song-card.component.css']
})
export class SongCardComponent implements OnInit {

  @Input() song: Song;
  baseUrl = 'https://localhost:5001/api/';

  songs: Song[];

  constructor(private http: HttpClient, private songService: SongsService) { }

  ngOnInit(): void {
    this.loadSongs();

  }

  loadSongs(){
    this.songService.getSongs().subscribe(songs =>{
      this.songs=songs;
    }
      )
  }

  deleteSong(songId:number){
    return this.http.delete(this.baseUrl + 'song/delete-photo/' + songId);
  }


}

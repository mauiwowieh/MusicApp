import { Component, OnInit } from '@angular/core';
import { Song } from '../_models/song';
import { SongsService } from '../_services/songs.service';

@Component({
  selector: 'app-songs',
  templateUrl: './songs.component.html',
  styleUrls: ['./songs.component.css']
})
export class SongsComponent implements OnInit {

  songs: Song[];

  constructor(private songService: SongsService) { }

  ngOnInit(): void {
    this.loadSongs();
  }

  loadSongs(){
    this.songService.getSongs().subscribe(songs =>{
      this.songs=songs;
    }
      )
  }

}

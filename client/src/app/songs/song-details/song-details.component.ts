import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Song } from 'src/app/_models/song';
import { SongsService } from 'src/app/_services/songs.service';

@Component({
  selector: 'app-song-details',
  templateUrl: './song-details.component.html',
  styleUrls: ['./song-details.component.css']
})
export class SongDetailsComponent implements OnInit {

  //@Input() songsFromSongComponent: any;
  song: Song;

  constructor(private songsService: SongsService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadSong();
  }

  loadSong(){
    this.songsService.getSong(this.route.snapshot.paramMap.get('songName')).subscribe(song =>
      {
        this.song=song;

      })
  }

}

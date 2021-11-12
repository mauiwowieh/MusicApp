import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Song } from 'src/app/_models/song';
import { SongsService } from 'src/app/_services/songs.service';

@Component({
  selector: 'app-song-edit',
  templateUrl: './song-edit.component.html',
  styleUrls: ['./song-edit.component.css']
})
export class SongEditComponent implements OnInit {

  song: Song;

  constructor(private songService: SongsService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.loadSong();
  }

  loadSong(){
    this.songService.getSong(this.song.songName).subscribe(song =>{
      this.song=song;
    })
  }

  updateSong(){
    this.songService.updateSong(this.song).subscribe(()=>{
      this.toastr.success('Song updated successfully');
      
    })
    }

}

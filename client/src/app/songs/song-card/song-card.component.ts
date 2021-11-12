import { Component, Input, OnInit } from '@angular/core';
import { Song } from 'src/app/_models/song';

@Component({
  selector: 'app-song-card',
  templateUrl: './song-card.component.html',
  styleUrls: ['./song-card.component.css']
})
export class SongCardComponent implements OnInit {

  @Input() song: Song;
  constructor() { }

  ngOnInit(): void {
  }

}

import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { SongsService } from '../_services/songs.service';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  searchStr:string;

  constructor(private songService: SongsService) { }

  ngOnInit(): void {
    this.searchMusic();
  }

  searchMusic(){
    //console.log(this.searchStr);
    // console.log('Test');
    this.songService.searchMusic(this.searchStr).subscribe(res =>{
      console.log(res.songName);
    });
  }

}

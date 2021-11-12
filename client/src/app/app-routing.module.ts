import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { SongAddComponent } from './songs/song-add/song-add.component';
import { SongDetailsComponent } from './songs/song-details/song-details.component';
import { SongEditComponent } from './songs/song-edit/song-edit.component';
import { SongsComponent } from './songs/songs.component';

const routes: Routes = [
  {path:'', component: HomeComponent},
  
  {path:'songs', component: SongsComponent},
  {path:'songs/:songName', component: SongDetailsComponent},
  {path:'songs/add', component: SongAddComponent},

  
  {path:'song/edit', component: SongEditComponent},

  {path:'about', component: AboutComponent},
  {path:'**', component: HomeComponent, pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

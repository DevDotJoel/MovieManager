import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieListPageComponent } from '../movie-list/movie-list.page.component';
import { MovieDetailPageComponent } from '../movie-detail/movie-detail.page.component';
import {  HttpClientModule } from '@angular/common/http';
import { MovieService } from '../../data-acess/movie.service';
const routes: Routes = [
  {
    path:'',component:MovieListPageComponent
  },
  {
    path:':id',component:MovieDetailPageComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
    HttpClientModule,
  ],
  exports: [RouterModule],
  providers: [
    MovieService

  ]
})
export class MovieShellRoutingModule { }

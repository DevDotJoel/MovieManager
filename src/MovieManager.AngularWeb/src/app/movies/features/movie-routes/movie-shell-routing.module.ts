import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieListPageComponent } from '../movie-list/movie-list.page.component';
import { MovieDetailPageComponent } from '../movie-detail/movie-detail.page.component';

const routes: Routes = [
  {
    path:'',component:MovieListPageComponent
  },
  {
    path:':id',component:MovieDetailPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MovieShellRoutingModule { }

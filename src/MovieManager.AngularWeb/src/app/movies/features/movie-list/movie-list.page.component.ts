import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieService } from '../../data-acess/movie.service';
import { Observable, map } from 'rxjs';
import { MovieModel } from 'src/app/shared/ui/models/movie/movie.model';

@Component({
  selector: 'app-movie-list.page',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './movie-list.page.component.html'
})
export class MovieListPageComponent {

  movies$:Observable<MovieModel[]>
  searchTerm:string="";
  constructor(private movieService:MovieService)
  {
    this.movies$=this.movieService.getAll()
  }

  filter() {
    this.movies$ =this.movies$.pipe(
    map(data => data.filter(m => m.name===this.  searchTerm || m.description===this.  searchTerm )), );

}
}

import { ChangeDetectionStrategy, Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieService } from '../../data-acess/movie.service';
import { Observable, map } from 'rxjs';
import { MovieModel } from 'src/app/shared/ui/models/movie/movie.model';
import { MovieTableComponent } from '../../ui/movie-table/movie-table.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
@Component({
  selector: 'app-movie-list.page',
  standalone: true,
  imports: [CommonModule,MovieTableComponent,MatFormFieldModule, MatInputModule,FormsModule,MatButtonModule],
  templateUrl: './movie-list.page.component.html',

})
export class MovieListPageComponent  {

  movies$:Observable<MovieModel[]>
  searchTerm:string="";
  constructor(private movieService:MovieService)
  {
    this.movies$=this.movieService.getAll()
  }

  filter() {
    this.movies$ =this.movies$.pipe(
    map(data => data.filter(m => m.name===this.  searchTerm || m.description===this.  searchTerm )),);
}
}
